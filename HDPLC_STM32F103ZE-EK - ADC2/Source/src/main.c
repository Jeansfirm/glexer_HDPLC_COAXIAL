/****************************************************************************  
*
* 在安富莱STM32F103ZE-EK开发板上调试通过 
*
* 文件名: main.c
* 内容简述:
*		移植uIP-1.0协议栈
*	    安富莱STM32F103ZE-EK开发板选用的网卡芯片DM9000AE	
*
*/

#include "stm32f10x.h"
#include <stdio.h>
#include "usart_printf.h"
#include "systick.h"


/* 实现uip需要包含的h文件 */
#include "uip.h"
#include "uip_arp.h"
#include "tapdev.h"
#include "timer.h"
#include "dm9k_uip.h"
#include "hello-world.h"
#include "udp_demo.h"
#include "hdplc_struct.h"

#define BUF ((struct uip_eth_hdr *)&uip_buf[0])

/*结束*/

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
*	函数名：main
*	输  入:
*	输  出:
*	功能说明：用户程序入口
*/

int main(void)
{  

	InitBoard();	/* 为了是main函数看起来更简洁些，我们将初始化的代码封装到这个函数 */
	DispLogo();		/* 显示例程Logo */

	InitNet();		/* 初始化网络设备以及UIP协议栈，配置IP地址 */

	/* 创建一个TCP监听端口，端口号为1000 */
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
			UipPro();		/* 处理uip事件，必须插入到用户程序的循环体中 */

			//uip_udp_init();	

			if(rec_flag)break;		 
			
		}	


	}
}



/*******************************************************************************
*	函数名：UipPro
*	输  入:
*	输  出:
*	功能说明：uip协议栈的实现入口，必须被轮询处理。未用中断模式
*/
void UipPro(void)
{
	uint8_t i;
	static struct timer periodic_timer, arp_timer;
	static char timer_ok = 0;	/* armfly */

	/* 创建2个定时器，只用执行1次 */
	if (timer_ok == 0)
	{
		timer_ok = 1;
		timer_set(&periodic_timer, CLOCK_SECOND / 2);  /* 创建1个0.5秒的定时器 */
		timer_set(&arp_timer, CLOCK_SECOND * 10);	   /* 创建1个10秒的定时器 */
	}

	/*
		从网络设备读取一个IP包,返回数据长度 (非阻塞)
		这个地方没有使用DM9000AEP的中断功能，采用的是查询方式
	*/
	uip_len = tapdev_read();	/* uip_len 是在uip中定义的全局变量 */
	if(uip_len > 0)
	{
		/* 处理IP数据包(只有校验通过的IP包才会被接收) */
		if(BUF->type == htons(UIP_ETHTYPE_IP))
		{
			uip_arp_ipin();
			uip_input();
			/*
				当上面的函数执行后，如果需要发送数据，则全局变量 uip_len > 0
				需要发送的数据在uip_buf, 长度是uip_len  (这是2个全局变量)
			*/
			if (uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}
		/* 处理arp报文 */
		else if (BUF->type == htons(UIP_ETHTYPE_ARP))
		{
			uip_arp_arpin();
			/*
				当上面的函数执行后，如果需要发送数据，则全局变量 uip_len > 0
				需要发送的数据在uip_buf, 长度是uip_len  (这是2个全局变量)
			*/
			if (uip_len > 0)
			{
				tapdev_send();
			}
		}
	}
	else if(timer_expired(&periodic_timer))	/* 0.5秒定时器超时 */
	{
		timer_reset(&periodic_timer);	/* 复位0.5秒定时器 */

		/* 轮流处理每个TCP连接, UIP_CONNS缺省是10个 */
		for(i = 0; i < UIP_CONNS; i++)
		{
			uip_periodic(i);	/* 处理TCP通信事件 */
			/*
				当上面的函数执行后，如果需要发送数据，则全局变量 uip_len > 0
				需要发送的数据在uip_buf, 长度是uip_len  (这是2个全局变量)
			*/
			if(uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}

	#if UIP_UDP
		/* 轮流处理每个UDP连接, UIP_UDP_CONNS缺省是10个 */
		for(i = 0; i < UIP_UDP_CONNS; i++)
		{
			uip_udp_periodic(i);	/*处理UDP通信事件 */
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

		/* 每隔10秒调用1次ARP定时器函数 */
		if (timer_expired(&arp_timer))
		{
			timer_reset(&arp_timer);
			uip_arp_timer();
		}
	}
}




/*******************************************************************************
*	函数名：InitNet
*	输  入:
*	输  出:
*	功能说明：初始化网络硬件、UIP协议栈、配置本机IP地址
*/
void InitNet(void)
{
	uip_ipaddr_t ipaddr;

	/* 检测网卡芯片 */
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
	函数名：InitBoard
	输  入:
	输  出:
	功能说明：初始化硬件设备
*/
static void InitBoard(void)
{
	/*
		这个函数是ST库中的函数，函数实体在
		Libraries\CMSIS\Core\CM3\system_stm32f10x.c

		配置内部Flash接口，初始化PLL，配置系统频率
		系统时钟缺省配置为72MHz，你如果需要更改，则需要去修改相关的头文件中的宏定义
	 */
	SystemInit();

	/* 配置串口 */
	USART_Configuration();

	/* 配置systic作为1ms中断,这个函数在
	\Libraries\CMSIS\Core\CM3\core_cm3.h */
	SysTick_Config(SystemFrequency / 1000);

}



/*******************************************************************************
	函数名: DispLogo
	输  入:
	输  出:
	功能说明：显示例程Logo (通过串口打印到PC机的超级终端显示)
*/
static void DispLogo(void)
{
	/* 通过串口输出例程名和更新日期 */
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





