/****************************************************************************
* Copyright (C), 2010 安富莱电子 www.armfly.com
*
* 【本例程在安富莱STM32F103ZE-EK开发板上调试通过             】
* 【QQ: 1295744630, 旺旺：armfly, Email: armfly@qq.com       】
*
* 文件名: main.c
* 内容简述:
*		本例程移植uIP-1.0协议栈，演示开发板和PC间的TCP通信。自定义了一个简单的应用层
*	通信协议。本例程实现的功能有：
*		（1）通过PC机控制板子上的LED；
*		（2）测试TCP上传速度和TCP下传速度。
*		（3）在不影响通信的条件下实现了按键的检测和打印键值功能。
*
*	    安富莱STM32F103ZE-EK开发板选用的网卡芯片DM9000AE，该芯片可自适应10M/100M
*	连接，自动识别直连网线和交叉网线。
*		本例程设置的缺省IP地址是 192.168.1.10，默认的TCP监听端口是1000。
*		开发板工作在TCP服务器模式。PC机工作在TCP客户端模式。
*	 	PC机上需要运行TcpTest软件，C++ Builder 6.0(sp4)开发，提供源码。
*	用户可以做如下测试：
*	（1）ping 试验
*		点击windows 开始-运行，执行cmd命令，然后在dos窗口输入 ping 192.168.1.10
*		应该看到如下结果：
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*			Reply from 192.168.1.10: bytes=32 time<1ms TTL=128
*
*	（2）PC机控制开发板上的LED试验
*		运行TcpTest软件，在命令输入窗口输入控制LED的命令字符串，然后点击发送，开发板
*	上对应的LED灯会发生变化。TcpTest软件有8个按钮，点击后可以直接发送Led的控制
*	命令。
*		命令代码如下： (末尾无0x00和回车字符)
*		ledon 1     ----- 点亮LED1
*		ledoff 1    ----- 关闭LED1
*		ledon 2     ----- 点亮LED2
*		ledoff 2    ----- 关闭LED2
*		ledon 3     ----- 点亮LED3
*		ledoff 3    ----- 关闭LED3
*		ledon 4     ----- 点亮LED4
*		ledoff 4    ----- 关闭LED4
*		txtest      ----- 通知目标板进入上传测试状态。
*		rxtest      ----- 通知目标板进入传测试状态。
*		stop		----- 退出上传或下传测试状态，进入命令状态
*
*	（3）测试目标板连续上传数据包的通信速度
*		发送 txtest 命令，或者点击“上传测试”按钮。目标板接收到此命令后会连续发送数据包，
*	每个包的大小为1400字节。TcpTest软件会显示通信速度。
*		注：由于缺省时windows对TCP包会延迟200ms再确认，导致每秒只能上传5包。实测上传速度
*	为7000字节/秒。
*		如果勾选了“收到数据后立即应答”，则TcpTest收到数据后会发送1个字符‘A'，这样就可以实现
*	及时应答。实测上传速度为 1.2M字节/秒。

*	（4）测试目标板连续上传数据包的通信速度
*		发送 extest 命令，或者点击“下传测试”按钮。 PC机会连续发送数据包给目标板，
*	每个包的大小为1400字节。TcpTest软件会显示通信速度。实测下传速度为 1.4M字节/秒。
*
*	（5）通信中按键试验
*		随时操作开发板上的3个按钮或摇杆，串口1会打印出键值。需要连上串口线，打开串口工具进行观察。
*
* 文件历史:
* 版本号  日期       作者    说明
* v0.1    2010-02-01 armfly  创建该文件
*
*/

#include "stm32f10x.h"
#include <stdio.h>
#include "usart_printf.h"
#include "systick.h"
#include "button.h"

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
	函数名：GPIO_Configuration
	输  入:
	输  出:
	功能说明：配置4个LED为输出口线

	LED口线分配：
	LED1 : PF6  (输出0点亮)
	LED2 : PF7  (输出0点亮)
	LED3 : PF8  (输出0点亮)
	LED4 : PF9  (输出0点亮)

*/
void GPIO_Configuration(void)
{
	GPIO_InitTypeDef GPIO_InitStructure;

	/* 第1步：打开GPIOA GPIOC GPIOD GPIOF GPIOG的时钟
	   注意：这个地方可以一次性全打开
	*/
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA | RCC_APB2Periph_GPIOC
			| RCC_APB2Periph_GPIOD | RCC_APB2Periph_GPIOF | RCC_APB2Periph_GPIOG,
				ENABLE);

	/* 第2步：配置所有的按键GPIO为浮动输入模式(实际上CPUf复位后就是输入状态) */
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

	/* 第3步：配置所有的LED指示灯GPIO为推挽输出模式 */
	/* 由于将GPIO设置为输出时，GPIO输出寄存器的值缺省是0，因此会驱动LED点亮
		这是我不希望的，因此在改变GPIO为输出前，先修改输出寄存器的值为1 */
	GPIO_SetBits(GPIOF,  GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9);
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOF, &GPIO_InitStructure);
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

	/* 配置按键GPIO和LED GPIO */
	GPIO_Configuration();

	/* 配置串口 */
	USART_Configuration();

	/* 在 SysTick_Config()前，必须先调用 */
	InitButtonVar();

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

/**
  * @}
  */

/**
  * @}
  */

/******************* (C) COPYRIGHT 2009 STMicroelectronics *****END OF FILE****/

