/****************************************************************************
* Copyright (C), 2010 ���������� www.armfly.com
*
* ���������ڰ�����STM32F103ZE-EK�������ϵ���ͨ��             ��
* ��QQ: 1295744630, ������armfly, Email: armfly@qq.com       ��
*
* �ļ���: main.c
* ���ݼ���:
*		��������ֲuIP-1.0Э��ջ����ʾ�������PC���TCPͨ�š��Զ�����һ���򵥵�Ӧ�ò�
*	ͨ��Э�顣������ʵ�ֵĹ����У�
*		��1��ͨ��PC�����ư����ϵ�LED��
*		��2������TCP�ϴ��ٶȺ�TCP�´��ٶȡ�
*		��3���ڲ�Ӱ��ͨ�ŵ�������ʵ���˰����ļ��ʹ�ӡ��ֵ���ܡ�
*
*	    ������STM32F103ZE-EK������ѡ�õ�����оƬDM9000AE����оƬ������Ӧ10M/100M
*	���ӣ��Զ�ʶ��ֱ�����ߺͽ������ߡ�
*		���������õ�ȱʡIP��ַ�� 192.168.1.10��Ĭ�ϵ�TCP�����˿���1000��
*		�����幤����TCP������ģʽ��PC��������TCP�ͻ���ģʽ��
*	 	PC������Ҫ����TcpTest�����C++ Builder 6.0(sp4)�������ṩԴ�롣
*	�û����������²��ԣ�
*	��1��ping ����
*		���windows ��ʼ-���У�ִ��cmd���Ȼ����dos�������� ping 192.168.1.10
*		Ӧ�ÿ������½����
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*
*	��2��PC�����ƿ������ϵ�LED����
*		����TcpTest��������������봰���������LED�������ַ�����Ȼ�������ͣ�������
*	�϶�Ӧ��LED�ƻᷢ���仯��TcpTest�����8����ť����������ֱ�ӷ���Led�Ŀ���
*	���
*		����������£� (ĩβ��0x00�ͻس��ַ�)
*		ledon 1     ----- ����LED1
*		ledoff 1    ----- �ر�LED1
*		ledon 2     ----- ����LED2
*		ledoff 2    ----- �ر�LED2
*		ledon 3     ----- ����LED3
*		ledoff 3    ----- �ر�LED3
*		ledon 4     ----- ����LED4
*		ledoff 4    ----- �ر�LED4
*		txtest      ----- ֪ͨĿ�������ϴ�����״̬��
*		rxtest      ----- ֪ͨĿ�����봫����״̬��
*		stop		----- �˳��ϴ����´�����״̬����������״̬
*
*	��3������Ŀ��������ϴ����ݰ���ͨ���ٶ�
*		���� txtest ������ߵ�����ϴ����ԡ���ť��Ŀ�����յ��������������������ݰ���
*	ÿ�����Ĵ�СΪ1400�ֽڡ�TcpTest�������ʾͨ���ٶȡ�
*		ע������ȱʡʱwindows��TCP�����ӳ�200ms��ȷ�ϣ�����ÿ��ֻ���ϴ�5����ʵ���ϴ��ٶ�
*	Ϊ7000�ֽ�/�롣
*		�����ѡ�ˡ��յ����ݺ�����Ӧ�𡱣���TcpTest�յ����ݺ�ᷢ��1���ַ���A'�������Ϳ���ʵ��
*	��ʱӦ��ʵ���ϴ��ٶ�Ϊ 1.2M�ֽ�/�롣

*	��4������Ŀ��������ϴ����ݰ���ͨ���ٶ�
*		���� extest ������ߵ�����´����ԡ���ť�� PC���������������ݰ���Ŀ��壬
*	ÿ�����Ĵ�СΪ1400�ֽڡ�TcpTest�������ʾͨ���ٶȡ�ʵ���´��ٶ�Ϊ 1.4M�ֽ�/�롣
*
*	��5��ͨ���а�������
*		��ʱ�����������ϵ�3����ť��ҡ�ˣ�����1���ӡ����ֵ����Ҫ���ϴ����ߣ��򿪴��ڹ��߽��й۲졣
*
* �ļ���ʷ:
* �汾��  ����       ����    ˵��
* v0.1    2010-02-01 armfly  �������ļ�
*
*/

#include "stm32f10x.h"
#include <stdio.h>
#include "usart_printf.h"
#include "systick.h"
#include "button.h"

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
	��������GPIO_Configuration
	��  ��:
	��  ��:
	����˵��������4��LEDΪ�������

	LED���߷��䣺
	LED1 : PF6  (���0����)
	LED2 : PF7  (���0����)
	LED3 : PF8  (���0����)
	LED4 : PF9  (���0����)

*/
void GPIO_Configuration(void)
{
	GPIO_InitTypeDef GPIO_InitStructure;

	/* ��1������GPIOA GPIOC GPIOD GPIOF GPIOG��ʱ��
	   ע�⣺����ط�����һ����ȫ��
	*/
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA | RCC_APB2Periph_GPIOC
			| RCC_APB2Periph_GPIOD | RCC_APB2Periph_GPIOF | RCC_APB2Periph_GPIOG,
				ENABLE);

	/* ��2�����������еİ���GPIOΪ��������ģʽ(ʵ����CPUf��λ���������״̬) */
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_IN_FLOATING;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOA, &GPIO_InitStructure);	/* PA0 */

	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_13;
	GPIO_Init(GPIOC, &GPIO_InitStructure);	/* PC13 */

	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_3;
	GPIO_Init(GPIOD, &GPIO_InitStructure);	/* PD3 */

	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_13
					  | GPIO_Pin_14 | GPIO_Pin_15;
	GPIO_Init(GPIOG, &GPIO_InitStructure);	/* PG7,8,13,14,15 */

	/* ��3�����������е�LEDָʾ��GPIOΪ�������ģʽ */
	/* ���ڽ�GPIO����Ϊ���ʱ��GPIO����Ĵ�����ֵȱʡ��0����˻�����LED����
		�����Ҳ�ϣ���ģ�����ڸı�GPIOΪ���ǰ�����޸�����Ĵ�����ֵΪ1 */
	GPIO_SetBits(GPIOF,  GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9);
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOF, &GPIO_InitStructure);
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

	/* ���ð���GPIO��LED GPIO */
	GPIO_Configuration();

	/* ���ô��� */
	USART_Configuration();

	/* �� SysTick_Config()ǰ�������ȵ��� */
	InitButtonVar();

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

/**
  * @}
  */

/**
  * @}
  */

/******************* (C) COPYRIGHT 2009 STMicroelectronics *****END OF FILE****/

