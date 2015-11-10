/****************************************************************************

* ¡¾±¾Àı³ÌÔÚ°²¸»À³STM32F103ZE-EK¿ª·¢°åÉÏµ÷ÊÔÍ¨¹ı ¡¿
*
* ÎÄ¼şÃû: main.c
* ÄÚÈİ¼òÊö:
*		±¾Àı³ÌÒÆÖ²uIP-1.0Ğ­ÒéÕ»
*	    °²¸»À³STM32F103ZE-EK¿ª·¢°åÑ¡ÓÃµÄÍø¿¨Ğ¾Æ¬DM9000AE£¬¸ÃĞ¾Æ¬¿É×ÔÊÊÓ¦10M/100M
*	Á¬½Ó£¬×Ô¶¯Ê¶±ğÖ±Á¬ÍøÏßºÍ½»²æÍøÏß¡		
*
*/

#include "stm32f10x.h"
#include <stdio.h>
#include "usart_printf.h"
#include "systick.h"
#include "button.h"

/* ÊµÏÖuipĞèÒª°üº¬µÄhÎÄ¼ş */
#include "uip.h"
#include "uip_arp.h"
#include "tapdev.h"
#include "timer.h"
#include "dm9k_uip.h"
#include "hello-world.h"
#include "udp_demo.h"
#include "hdplc_struct.h"

#define BUF ((struct uip_eth_hdr *)&uip_buf[0])

/*½áÊø*/

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
*	º¯ÊıÃû£ºmain
*	Êä  Èë:
*	Êä  ³ö:
*	¹¦ÄÜËµÃ÷£ºÓÃ»§³ÌĞòÈë¿Ú
*/
int main(void)
{
	

	InitBoard();	/* ÎªÁËÊÇmainº¯Êı¿´ÆğÀ´¸ü¼ò½àĞ©£¬ÎÒÃÇ½«³õÊ¼»¯µÄ´úÂë·â×°µ½Õâ¸öº¯Êı */
	DispLogo();		/* ÏÔÊ¾Àı³ÌLogo */

	InitNet();		/* ³õÊ¼»¯ÍøÂçÉè±¸ÒÔ¼°UIPĞ­ÒéÕ»£¬ÅäÖÃIPµØÖ· */

	/* ´´½¨Ò»¸öTCP¼àÌı¶Ë¿Ú£¬¶Ë¿ÚºÅÎª1000 */
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
			UipPro();		/* ´¦ÀíuipÊÂ¼ş£¬±ØĞë²åÈëµ½ÓÃ»§³ÌĞòµÄÑ­»·ÌåÖĞ */

			//uip_udp_init();	

			if(rec_flag)break;		 
			
		}



	}
}

/*******************************************************************************
*	º¯ÊıÃû£ºUipPro
*	Êä  Èë:
*	Êä  ³ö:
*	¹¦ÄÜËµÃ÷£ºuipĞ­ÒéÕ»µÄÊµÏÖÈë¿Ú£¬±ØĞë±»ÂÖÑ¯´¦Àí¡£Î´ÓÃÖĞ¶ÏÄ£Ê½
*/
void UipPro(void)
{
	uint8_t i;
	static struct timer periodic_timer, arp_timer;
	static char timer_ok = 0;	/* armfly */

	/* ´´½¨2¸ö¶¨Ê±Æ÷£¬Ö»ÓÃÖ´ĞĞ1´Î */
	if (timer_ok == 0)
	{
		timer_ok = 1;
		timer_set(&periodic_timer, CLOCK_SECOND / 2);  /* ´´½¨1¸ö0.5ÃëµÄ¶¨Ê±Æ÷ */
		timer_set(&arp_timer, CLOCK_SECOND * 10);	   /* ´´½¨1¸ö10ÃëµÄ¶¨Ê±Æ÷ */
	}

	/*
		´ÓÍøÂçÉè±¸¶ÁÈ¡Ò»¸öIP°ü,·µ»ØÊı¾İ³¤¶È (·Ç×èÈû)
		Õâ¸öµØ·½Ã»ÓĞÊ¹ÓÃDM9000AEPµÄÖĞ¶Ï¹¦ÄÜ£¬²ÉÓÃµÄÊÇ²éÑ¯·½Ê½
	*/
	uip_len = tapdev_read();	/* uip_len ÊÇÔÚuipÖĞ¶¨ÒåµÄÈ«¾Ö±äÁ¿ */
	if(uip_len > 0)
	{
		/* ´¦ÀíIPÊı¾İ°ü(Ö»ÓĞĞ£ÑéÍ¨¹ıµÄIP°ü²Å»á±»½ÓÊÕ) */
		if(BUF->type == htons(UIP_ETHTYPE_IP))
		{
			uip_arp_ipin();
			uip_input();
			/*
				µ±ÉÏÃæµÄº¯ÊıÖ´ĞĞºó£¬Èç¹ûĞèÒª·¢ËÍÊı¾İ£¬ÔòÈ«¾Ö±äÁ¿ uip_len > 0
				ĞèÒª·¢ËÍµÄÊı¾İÔÚuip_buf, ³¤¶ÈÊÇuip_len  (ÕâÊÇ2¸öÈ«¾Ö±äÁ¿)
			*/
			if (uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}
		/* ´¦Àíarp±¨ÎÄ */
		else if (BUF->type == htons(UIP_ETHTYPE_ARP))
		{
			uip_arp_arpin();
			/*
				µ±ÉÏÃæµÄº¯ÊıÖ´ĞĞºó£¬Èç¹ûĞèÒª·¢ËÍÊı¾İ£¬ÔòÈ«¾Ö±äÁ¿ uip_len > 0
				ĞèÒª·¢ËÍµÄÊı¾İÔÚuip_buf, ³¤¶ÈÊÇuip_len  (ÕâÊÇ2¸öÈ«¾Ö±äÁ¿)
			*/
			if (uip_len > 0)
			{
				tapdev_send();
			}
		}
	}
	else if(timer_expired(&periodic_timer))	/* 0.5Ãë¶¨Ê±Æ÷³¬Ê± */
	{
		timer_reset(&periodic_timer);	/* ¸´Î»0.5Ãë¶¨Ê±Æ÷ */

		/* ÂÖÁ÷´¦ÀíÃ¿¸öTCPÁ¬½Ó, UIP_CONNSÈ±Ê¡ÊÇ10¸ö */
		for(i = 0; i < UIP_CONNS; i++)
		{
			uip_periodic(i);	/* ´¦ÀíTCPÍ¨ĞÅÊÂ¼ş */
			/*
				µ±ÉÏÃæµÄº¯ÊıÖ´ĞĞºó£¬Èç¹ûĞèÒª·¢ËÍÊı¾İ£¬ÔòÈ«¾Ö±äÁ¿ uip_len > 0
				ĞèÒª·¢ËÍµÄÊı¾İÔÚuip_buf, ³¤¶ÈÊÇuip_len  (ÕâÊÇ2¸öÈ«¾Ö±äÁ¿)
			*/
			if(uip_len > 0)
			{
				uip_arp_out();
				tapdev_send();
			}
		}

	#if UIP_UDP
		/* ÂÖÁ÷´¦ÀíÃ¿¸öUDPÁ¬½Ó, UIP_UDP_CONNSÈ±Ê¡ÊÇ10¸ö */
		for(i = 0; i < UIP_UDP_CONNS; i++)
		{
			uip_udp_periodic(i);	/*´¦ÀíUDPÍ¨ĞÅÊÂ¼ş */
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

		/* Ã¿¸ô10Ãëµ÷ÓÃ1´ÎARP¶¨Ê±Æ÷º¯Êı */
		if (timer_expired(&arp_timer))
		{
			timer_reset(&arp_timer);
			uip_arp_timer();
		}
	}
}

/*******************************************************************************
*	º¯ÊıÃû£ºInitNet
*	Êä  Èë:
*	Êä  ³ö:
*	¹¦ÄÜËµÃ÷£º³õÊ¼»¯ÍøÂçÓ²¼ş¡¢UIPĞ­ÒéÕ»¡¢ÅäÖÃ±¾»úIPµØÖ·
*/
void InitNet(void)
{
	uip_ipaddr_t ipaddr;

	/* ¼ì²âÍø¿¨Ğ¾Æ¬ */
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
	º¯ÊıÃû£ºGPIO_Configuration
	Êä  Èë:
	Êä  ³ö:
	¹¦ÄÜËµÃ÷£ºÅäÖÃ4¸öLEDÎªÊä³ö¿ÚÏß

	LED¿ÚÏß·ÖÅä£º
	LED1 : PF6  (Êä³ö0µãÁÁ)
	LED2 : PF7  (Êä³ö0µãÁÁ)
	LED3 : PF8  (Êä³ö0µãÁÁ)
	LED4 : PF9  (Êä³ö0µãÁÁ)

*/
void GPIO_Configuration(void)
{
	GPIO_InitTypeDef GPIO_InitStructure;

	/* µÚ1²½£º´ò¿ªGPIOA GPIOC GPIOD GPIOF GPIOGµÄÊ±ÖÓ
	   ×¢Òâ£ºÕâ¸öµØ·½¿ÉÒÔÒ»´ÎĞÔÈ«´ò¿ª
	*/
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA | RCC_APB2Periph_GPIOC
			| RCC_APB2Periph_GPIOD | RCC_APB2Periph_GPIOF | RCC_APB2Periph_GPIOG,
				ENABLE);

	/* µÚ2²½£ºÅäÖÃËùÓĞµÄ°´¼üGPIOÎª¸¡¶¯ÊäÈëÄ£Ê½(Êµ¼ÊÉÏCPUf¸´Î»ºó¾ÍÊÇÊäÈë×´Ì¬) */
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

	/* µÚ3²½£ºÅäÖÃËùÓĞµÄLEDÖ¸Ê¾µÆGPIOÎªÍÆÍìÊä³öÄ£Ê½ */
	/* ÓÉÓÚ½«GPIOÉèÖÃÎªÊä³öÊ±£¬GPIOÊä³ö¼Ä´æÆ÷µÄÖµÈ±Ê¡ÊÇ0£¬Òò´Ë»áÇı¶¯LEDµãÁÁ
		ÕâÊÇÎÒ²»Ï£ÍûµÄ£¬Òò´ËÔÚ¸Ä±äGPIOÎªÊä³öÇ°£¬ÏÈĞŞ¸ÄÊä³ö¼Ä´æÆ÷µÄÖµÎª1 */
	GPIO_SetBits(GPIOF,  GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9);
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_6 | GPIO_Pin_7 | GPIO_Pin_8 | GPIO_Pin_9;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_Out_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOF, &GPIO_InitStructure);
}

/*******************************************************************************
	º¯ÊıÃû£ºInitBoard
	Êä  Èë:
	Êä  ³ö:
	¹¦ÄÜËµÃ÷£º³õÊ¼»¯Ó²¼şÉè±¸
*/
static void InitBoard(void)
{
	/*
		Õâ¸öº¯ÊıÊÇST¿âÖĞµÄº¯Êı£¬º¯ÊıÊµÌåÔÚ
		Libraries\CMSIS\Core\CM3\system_stm32f10x.c

		ÅäÖÃÄÚ²¿Flash½Ó¿Ú£¬³õÊ¼»¯PLL£¬ÅäÖÃÏµÍ³ÆµÂÊ
		ÏµÍ³Ê±ÖÓÈ±Ê¡ÅäÖÃÎª72MHz£¬ÄãÈç¹ûĞèÒª¸ü¸Ä£¬ÔòĞèÒªÈ¥ĞŞ¸ÄÏà¹ØµÄÍ·ÎÄ¼şÖĞµÄºê¶¨Òå
	 */
	SystemInit();

	/* ÅäÖÃ°´¼üGPIOºÍLED GPIO */
	GPIO_Configuration();

	/* ÅäÖÃ´®¿Ú */
	USART_Configuration();

	/* ÔÚ SysTick_Config()Ç°£¬±ØĞëÏÈµ÷ÓÃ */
	InitButtonVar();

	/* ÅäÖÃsystic×÷Îª1msÖĞ¶Ï,Õâ¸öº¯ÊıÔÚ
	\Libraries\CMSIS\Core\CM3\core_cm3.h */
	SysTick_Config(SystemFrequency / 1000);
}

/*******************************************************************************
	º¯ÊıÃû: DispLogo
	Êä  Èë:
	Êä  ³ö:
	¹¦ÄÜËµÃ÷£ºÏÔÊ¾Àı³ÌLogo (Í¨¹ı´®¿Ú´òÓ¡µ½PC»úµÄ³¬¼¶ÖÕ¶ËÏÔÊ¾)
*/
static void DispLogo(void)
{
	/* Í¨¹ı´®¿ÚÊä³öÀı³ÌÃûºÍ¸üĞÂÈÕÆÚ */
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

