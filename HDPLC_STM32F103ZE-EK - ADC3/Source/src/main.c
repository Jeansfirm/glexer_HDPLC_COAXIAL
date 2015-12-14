/****************************************************************************  
*
* �ڰ�����STM32F103ZE-EK�������ϵ���ͨ�� 
*
* �ļ���: main.c
* ���ݼ���:
*		��ֲuIP-1.0Э��ջ
*	    ������STM32F103ZE-EK������ѡ�õ�����оƬDM9000AE	
*
*/

#include "stm32f10x.h"
#include <stdio.h>
#include "usart_printf.h"
#include "systick.h"


/* ʵ��uip��Ҫ������h�ļ� */
#include "uip.h"
#include "uip_arp.h"
#include "tapdev.h"
#include "timer.h"
#include "dm9k_uip.h"
#include "hello-world.h"
#include "udp_demo.h"
#include "hdplc_struct.h"

#define BUF ((struct uip_eth_hdr *)&uip_buf[0])

/*����*/

#define EXAMPLE_NAME	"hdplc_testProgram"
#define EXAMPLE_DATE	"2015-10-14"


/*ADC ���*/
#define SAMP_COUNT	5		/* ��������*/
static uint16_t g_usAdcValue=0;	/* ADC ����ֵ��ƽ��ֵ */
static uint16_t sum_Adc=0;

static void ADC_Configuration(void);
static void Get_Adc(uint8_t ch);

/*����*/

static void InitBoard(void);
static void DispLogo(void);
void InitNet(void);
void UserPro(void);
void UipPro(void);
void SetIP1(void);
void SetIP2(void);

unsigned char inStr[100];
char c_choice;
int send_flag=0;
int rec_flag=0;
int circle_flag=0;
int circle_state=0;
int i_ip=0;



/*******************************************************************************
*	��������main
*	��  ��:
*	��  ��:
*	����˵�����û��������
*/

int main(void)
{  

	InitBoard();	/* Ϊ����main���������������Щ�����ǽ���ʼ���Ĵ����װ��������� */
	DispLogo();		/* ��ʾ����Logo */

	InitNet();		/* ��ʼ�������豸�Լ�UIPЭ��ջ������IP��ַ */

	/* ����һ��TCP�����˿ڣ��˿ں�Ϊ1000 */
	//uip_listen(HTONS(1000));

	printf("\n\rBuilding UDP connectiong to 192.168.20.156...\n\n\r");

	while(1)
	{
		 //InitNet();
		 if(i_ip==0)
		 {
		 	SetIP1();
			i_ip=1;
		 }
		 else
		 {
		 	SetIP2();
			i_ip=0;
		 }

		uip_udp_init();

		if(circle_flag==0)
		{
		//display main menu
		printf("\t\t<--Main Menu-->\t\t\n\n\r");
		printf(" 1.	Get Status\n\r");
		printf(" 2.	Start SpeedTest\n\r");
		printf(" 3.	Get SpeedTestStatus\n\r");
		printf(" 4.	Get PhyRate\n\r");
		printf(" 5.	System Command\n\r");
		printf(" 6.	System GetPhyRate\n\r");
		printf(" 7.	Get All Messages\n\r");
		printf(" 8.	Set Mac Address\n\r");
		printf(" 9.	Start ChannelEstimate\n\r");
		printf(" a.	Get CINR Map\n\r");
		printf(" 0.	Exit\n\r");
		printf("\n\r	Input-->");

		//c_choice=getc(stdin);
		scanf("%s",inStr); 
		c_choice=(unsigned char)inStr[0];	 		

		if(c_choice=='7'||c_choice=='8')
		{
			circle_flag=1;
			circle_state=0;
		}

		send_flag=1;
		rec_flag=0;
		uip_len=0; 
		printf(" %c\n\n\r",c_choice);

		}

		while (1)
		{
			UipPro();		/* ����uip�¼���������뵽�û������ѭ������ */

			//uip_udp_init();	

			if(rec_flag)break;		 
			
		}	


	}
}



/*******************************************************************************
*	��������UipPro
*	��  ��:
*	��  ��:
*	����˵����uipЭ��ջ��ʵ����ڣ����뱻��ѯ����δ���ж�ģʽ
*/
void UipPro(void)
{
	uint8_t i;
	static struct timer periodic_timer, arp_timer;
	static char timer_ok = 0;	/* armfly */

	/* ����2����ʱ����ֻ��ִ��1�� */
	if (timer_ok == 0)
	{
		timer_ok = 1;
		timer_set(&periodic_timer, CLOCK_SECOND / 2);  /* ����1��0.5��Ķ�ʱ�� */
		timer_set(&arp_timer, CLOCK_SECOND * 10);	   /* ����1��10��Ķ�ʱ�� */
	}

	/*
		�������豸��ȡһ��IP��,�������ݳ��� (������)
		����ط�û��ʹ��DM9000AEP���жϹ��ܣ����õ��ǲ�ѯ��ʽ
	*/
	uip_len = tapdev_read();	/* uip_len ����uip�ж����ȫ�ֱ��� */
	if(uip_len > 0)
	{
		/* ����IP���ݰ�(ֻ��У��ͨ����IP���Żᱻ����) */
		if(BUF->type == htons(UIP_ETHTYPE_IP))
		{
			uip_arp_ipin();
			uip_input();
			/*
				������ĺ���ִ�к������Ҫ�������ݣ���ȫ�ֱ��� uip_len > 0
				��Ҫ���͵�������uip_buf, ������uip_len  (����2��ȫ�ֱ���)
			*/
			if (uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}
		/* ����arp���� */
		else if (BUF->type == htons(UIP_ETHTYPE_ARP))
		{
			uip_arp_arpin();
			/*
				������ĺ���ִ�к������Ҫ�������ݣ���ȫ�ֱ��� uip_len > 0
				��Ҫ���͵�������uip_buf, ������uip_len  (����2��ȫ�ֱ���)
			*/
			if (uip_len > 0)
			{
				tapdev_send();
			}
		}
	}
	else if(timer_expired(&periodic_timer))	/* 0.5�붨ʱ����ʱ */
	{
		timer_reset(&periodic_timer);	/* ��λ0.5�붨ʱ�� */

		/* ��������ÿ��TCP����, UIP_CONNSȱʡ��10�� */
		for(i = 0; i < UIP_CONNS; i++)
		{
			uip_periodic(i);	/* ����TCPͨ���¼� */
			/*
				������ĺ���ִ�к������Ҫ�������ݣ���ȫ�ֱ��� uip_len > 0
				��Ҫ���͵�������uip_buf, ������uip_len  (����2��ȫ�ֱ���)
			*/
			if(uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}

	#if UIP_UDP
		/* ��������ÿ��UDP����, UIP_UDP_CONNSȱʡ��10�� */
		for(i = 0; i < UIP_UDP_CONNS; i++)
		{
			uip_udp_periodic(i);	/*����UDPͨ���¼� */
			/* If the above function invocation resulted in data that
			should be sent out on the network, the global variable
			uip_len is set to a value > 0. */
			if(uip_len > 0)
			{
			uip_arp_out();
			tapdev_send();
			}
		}
	#endif /* UIP_UDP */

		/* ÿ��10�����1��ARP��ʱ������ */
		if (timer_expired(&arp_timer))
		{
			timer_reset(&arp_timer);
			uip_arp_timer();
		}
	}
}




/*******************************************************************************
*	��������InitNet
*	��  ��:
*	��  ��:
*	����˵������ʼ������Ӳ����UIPЭ��ջ�����ñ���IP��ַ
*/
void InitNet(void)
{
	uip_ipaddr_t ipaddr;

	/* �������оƬ */
	{
		uint32_t vid;

		vid = dm9k_ReadID();
		if (vid == DM9000A_ID_OK)
		{
			//printf("DM9000AE Detect Ok, vid&pid = %08X\n\r", vid);
		}
		else
		{
			//printf("DM9000AE Detect Failed, vid&pid = %08X, Expected = %08X\n\r", vid, DM9000A_ID_OK);
		}
	}

	tapdev_init();

	//printf("uip_init\n\r");
	uip_init();

	//printf("uip ip address : 192,168,20,11\n\r");
	uip_ipaddr(ipaddr, 192,168,20,11);
	uip_sethostaddr(ipaddr);

	//printf("uip route address : 192,168,20,1\n\r");
	uip_ipaddr(ipaddr, 192,168,20,1);
	uip_setdraddr(ipaddr);

	//printf("uip net mask : 255,255,255,0\n\r");
	uip_ipaddr(ipaddr, 255,255,255,0);
	uip_setnetmask(ipaddr);
}


void SetIP1(void)
{
	uip_ipaddr_t ipaddr;

	tapdev_init();
	uip_init();

	//printf("uip ip address : 192,168,20,11\n\r");
	uip_ipaddr(ipaddr, 192,168,20,11);
	uip_sethostaddr(ipaddr);

	//printf("uip route address : 192,168,20,1\n\r");
	uip_ipaddr(ipaddr, 192,168,20,1);
	uip_setdraddr(ipaddr);

	//printf("uip net mask : 255,255,255,0\n\r");
	uip_ipaddr(ipaddr, 255,255,255,0);
	uip_setnetmask(ipaddr);
}

void SetIP2(void)
{
	uip_ipaddr_t ipaddr;

	tapdev_init();
	uip_init();

	//printf("uip ip address : 192,168,20,11\n\r");
	uip_ipaddr(ipaddr, 192,168,20,12);
	uip_sethostaddr(ipaddr);

	//printf("uip route address : 192,168,20,1\n\r");
	uip_ipaddr(ipaddr, 192,168,20,1);
	uip_setdraddr(ipaddr);

	//printf("uip net mask : 255,255,255,0\n\r");
	uip_ipaddr(ipaddr, 255,255,255,0);
	uip_setnetmask(ipaddr);
}




/*******************************************************************************
	��������InitBoard
	��  ��:
	��  ��:
	����˵������ʼ��Ӳ���豸
*/
static void InitBoard(void)
{
	/*
		���������ST���еĺ���������ʵ����
		Libraries\CMSIS\Core\CM3\system_stm32f10x.c

		�����ڲ�Flash�ӿڣ���ʼ��PLL������ϵͳƵ��
		ϵͳʱ��ȱʡ����Ϊ72MHz���������Ҫ���ģ�����Ҫȥ�޸���ص�ͷ�ļ��еĺ궨��
	 */
	SystemInit();

	/* ���ô��� */
	USART_Configuration();

	/* ����systic��Ϊ1ms�ж�,���������
	\Libraries\CMSIS\Core\CM3\core_cm3.h */
	SysTick_Config(SystemFrequency / 1000);

}



/*******************************************************************************
	������: DispLogo
	��  ��:
	��  ��:
	����˵������ʾ����Logo (ͨ�����ڴ�ӡ��PC���ĳ����ն���ʾ)
*/
static void DispLogo(void)
{
	/* ͨ����������������͸������� */
	PrintfLogo(EXAMPLE_NAME, EXAMPLE_DATE);
}


/*ADC ���*/

static void ADC_Configuration(void)
{
	GPIO_InitTypeDef GPIO_InitStructure;
	ADC_InitTypeDef ADC_InitStructure;
	__IO uint16_t ADCConvertedValue;

    /* ʹ�� ADC1 and GPIOC clock */
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_ADC1 | RCC_APB2Periph_GPIOC, ENABLE);

	/* 
	����PC4Ϊģ������(ADC Channel14)
	PC4 ADC123_IN14
	 */
	//GPIO_InitStructure.GPIO_Pin = GPIO_Pin_4;

	/*
	PC0 ADC123_IN10
	PC1 ADC123_IN11
	PC2 ADC123_IN12
	*/
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0 | GPIO_Pin_1 | GPIO_Pin_2;

	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AIN;
	GPIO_Init(GPIOC, &GPIO_InitStructure);		  

	/* ����ADC1, ����DMA, ��������� */

	/*����ADC�����ڶ���ģʽ*/
	ADC_InitStructure.ADC_Mode = ADC_Mode_Independent;

	/*�涨ADת�������ڵ���ģʽ������һ��ͨ������*/
	ADC_InitStructure.ADC_ScanConvMode = DISABLE;

	/*�涨ADת��������ɨ��ģʽ�����Զ��ͨ������*/
	//ADC_InitStructure.ADC_ScanConvMode = ENABLE;
	/*�趨ADת��������ģʽ*/
	ADC_InitStructure.ADC_ContinuousConvMode = ENABLE;
	/*��ʹ���ⲿ�ٷ�ת��*/ 
	ADC_InitStructure.ADC_ExternalTrigConv = ADC_ExternalTrigConv_None;
	/*�ɼ��������ڼĴ��������Ҷ���ķ�ʽ���*/ 
	ADC_InitStructure.ADC_DataAlign = ADC_DataAlign_Right;

	/*�趨Ҫת����ADͨ����Ŀ*/
	ADC_InitStructure.ADC_NbrOfChannel = 1;
	//ADC_InitStructure.ADC_NbrOfChannel = 3;

	ADC_Init(ADC1, &ADC_InitStructure);

	/* ����ADC1 ����ͨ��14 channel14 configuration */
	//ADC_RegularChannelConfig(ADC1, ADC_Channel_14, 1, ADC_SampleTime_55Cycles5);

	/*����ADC1��ͨ��10��11��12��ת���Ⱥ�˳���Լ�����ʱ��ΪΪ55.5���������� */   
	//ADC_RegularChannelConfig(ADC1, ADC_Channel_10, 1, ADC_SampleTime_55Cycles5);   
	//ADC_RegularChannelConfig(ADC1, ADC_Channel_11, 2, ADC_SampleTime_55Cycles5); 
	//ADC_RegularChannelConfig(ADC1, ADC_Channel_12, 3, ADC_SampleTime_55Cycles5); 

	/* ʹ��ADC1 DMA���� */
	ADC_DMACmd(ADC1, ENABLE);

	/* ʹ�� ADC1 */
	ADC_Cmd(ADC1, ENABLE);

	/* ʹ��ADC1 ��λУ׼�Ĵ��� */
	ADC_ResetCalibration(ADC1);
	/* ���ADC1�ĸ�λ�Ĵ��� */
	while(ADC_GetResetCalibrationStatus(ADC1));

	/* ����ADC1У׼ */
	ADC_StartCalibration(ADC1);
	/* ���У׼�Ƿ���� */
	while(ADC_GetCalibrationStatus(ADC1));

	/* ����û�в����ⲿ����������ʹ���������ADCת�� */
	//ADC_SoftwareStartConvCmd(ADC1, ENABLE);
}

void Get_Adc(uint8_t ch)
{
	//������һ��ADCת���Ľ��
	ADC_RegularChannelConfig(ADC1, ch, 1, ADC_SampleTime_55Cycles5);
	ADC_SoftwareStartConvCmd(ADC1, ENABLE);
	while(!ADC_GetFlagStatus(ADC1, ADC_FLAG_EOC ));//�ȴ�ת������
	g_usAdcValue = ADC_GetConversionValue(ADC1);
	sum_Adc=sum_Adc+g_usAdcValue;
	g_usAdcValue=0;
}

/*����*/


#ifdef  USE_FULL_ASSERT

 /**
  * @brief  Reports the name of the source file and the source line number
  *   where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t* file, uint32_t line)
{
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */

  /* Infinite loop */
  while (1)
  {
  }
}

#endif





