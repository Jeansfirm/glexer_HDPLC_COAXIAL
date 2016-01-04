/**
  ******************************************************************************
  * @file    main.c
  * @author  MCD Application Team
  * @version V1.0.0
  * @date    11/20/2009
  * @brief   Main program body
  ******************************************************************************
  * @copy
  *
  * THE PRESENT FIRMWARE WHICH IS FOR GUIDANCE ONLY AIMS AT PROVIDING CUSTOMERS
  * WITH CODING INFORMATION REGARDING THEIR PRODUCTS IN ORDER FOR THEM TO SAVE
  * TIME. AS A RESULT, STMICROELECTRONICS SHALL NOT BE HELD LIABLE FOR ANY
  * DIRECT, INDIRECT OR CONSEQUENTIAL DAMAGES WITH RESPECT TO ANY CLAIMS ARISING
  * FROM THE CONTENT OF SUCH FIRMWARE AND/OR THE USE MADE BY CUSTOMERS OF THE
  * CODING INFORMATION CONTAINED HEREIN IN CONNECTION WITH THEIR PRODUCTS.
  *
  * <h2><center>&copy; COPYRIGHT 2009 STMicroelectronics</center></h2>
  */

/* Includes ------------------------------------------------------------------*/
#include "stm32_eth.h"
#include "netconf.h"
#include "main.h"

#include "stm32f10x.h"
#include <stdio.h>

#include "usart_printf.h"		/* printf函数定向输出到串口，所以必须包含这个文件 */
#include "hdplc_struct.h"

/* Private typedef -----------------------------------------------------------*/
/* Private define ------------------------------------------------------------*/
#define SYSTEMTICK_PERIOD_MS  10

uint32_t begin_time;
static uint8_t exe_count=0;


/* Private macro -------------------------------------------------------------*/
/* Private variables ---------------------------------------------------------*/
__IO uint32_t LocalTime = 0; /* this variable is used to create a time reference incremented by 10ms */
uint32_t timingdelay;
unsigned char inStr[100];


/* Private function prototypes -----------------------------------------------*/
void System_Periodic_Handle(void);
void Get_Adc(uint8_t ch);
extern void menu_handle();

unsigned char inStr[100];
char c_choice;
int send_flag=0;
int rec_flag=0;
int circle_flag=0;
int circle_state=0;
int ini_flag=1;
int i,j;

/*ADC 相关*/
#define SAMP_COUNT	10		/* 样本个数*/
static uint16_t g_usAdcValue=0;	/* ADC 采样值的平均值 */
static uint16_t sum_Adc=0;

/* PA4,PA5,PA6 */
uint8_t adc_channel[3]={ADC_Channel_4,ADC_Channel_5,ADC_Channel_6};


int main(void)
{
  
  /* Setup STM32 system (clocks, Ethernet, GPIO, NVIC) and STM3210C-EVAL resources */
  System_Setup();

  USART_Configuration();  
             
  /* Initilaize the LwIP satck */
  LwIP_Init();
  
  client_init();  
 
	
  while(1)
  {
	  	

     if(circle_flag==0)
	 {
		//display main menu
		printf("$8\n\r");
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
 
		printf(" %c\n\n\r",c_choice);

		/*AD 采集*/
		 for(i=0;i<3;i++)
	 	{
		 ADC_Configuration();

		 for(j=0;j<SAMP_COUNT;j++)
		 {
		 	Get_Adc(adc_channel[i]);
		 }
		 sum_Adc=sum_Adc/SAMP_COUNT;

		 printf("\n\rPA%d: %4d mv\n\r",i+4,((uint32_t)sum_Adc*3300)/4095);
		 printf("$%d%d mv\n\n\r",i+4,((uint32_t)sum_Adc*3300)/4095);

		 sum_Adc=0;
		 }

	 }

	 menu_handle();
	 begin_time=LocalTime;
	 rec_flag=0;

	 while (1)
	 {	 
		  /* Periodic tasks */
	      System_Periodic_Handle();

		  if(begin_time+2000<LocalTime)
		  {
		  		rec_flag=1;
				exe_count++;
		  }
		  if(exe_count==10)
		  {
		  		circle_flag=0;
				exe_count=0;
		  }
		
		  if(rec_flag)break; 			
	 }
  }	


}


void Get_Adc(uint8_t ch)
{
	//清空最近一次ADC转换的结果
	ADC_RegularChannelConfig(ADC1, ch, 1, ADC_SampleTime_55Cycles5);
	ADC_SoftwareStartConvCmd(ADC1, ENABLE);
	while(!ADC_GetFlagStatus(ADC1, ADC_FLAG_EOC ));//等待转换结束
	g_usAdcValue = ADC_GetConversionValue(ADC1);
	sum_Adc=sum_Adc+g_usAdcValue;
	g_usAdcValue=0;
}

/**
  * @brief  Inserts a delay time.
  * @param  nCount: number of 10ms periods to wait for.
  * @retval None
  */
void Delay(uint32_t nCount)
{
  /* Capture the current local time */
  timingdelay = LocalTime + nCount;  

  /* wait until the desired delay finish */  
  while(timingdelay > LocalTime)
  {     
  }
}

/**
  * @brief  Updates the system local time
  * @param  None
  * @retval None
  */
void Time_Update(void)
{
  LocalTime += SYSTEMTICK_PERIOD_MS;
}

/**
  * @brief  Handles the periodic tasks of the system
  * @param  None
  * @retval None
  */
void System_Periodic_Handle(void)
{
 
  /* LwIP periodic services are done here */
  LwIP_Periodic_Handle(LocalTime);
  
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
  {}
}
#endif


/******************* (C) COPYRIGHT 2009 STMicroelectronics *****END OF FILE****/
