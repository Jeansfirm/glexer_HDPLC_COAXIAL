/**
  ******************************************************************************
  * @file    client.c
  * @author  MCD Application Team
  * @version V1.0.0
  * @date    11/20/2009
  * @brief   A sample UDP/TCP client
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
#include "main.h"
#include "lwip/pbuf.h"
#include "lwip/udp.h"
#include "lwip/tcp.h"
#include <string.h>
#include <stdio.h>

#include "hdplc_struct.h"


/* Private typedef -----------------------------------------------------------*/
//define UDP_SERVER_PORT      7
#define UDP_CLIENT_PORT      4
#define UDP_SERVER_PORT      49152
//#define UDP_CLIENT_PORT      49152
#define TCP_PORT      4

/* Private define ------------------------------------------------------------*/
/* Private macro -------------------------------------------------------------*/
/* Private variables ---------------------------------------------------------*/
static struct tcp_pcb *TcpPCB;
static struct udp_pcb *upcb;

extern char c_choice;
extern int send_flag;
extern int rec_flag;
extern int circle_flag;
extern int circle_state;
extern int ini_flag;
extern unsigned char inStr[100];
extern unsigned char inMac[20];

static struct C_HDPLC_EXTCMD_IF inPlc;

void menu_handle();
void rec_handle();
int EtherTx(struct C_HDPLC_EXTCMD_IF *inPlc);
int EtherRx(struct C_HDPLC_EXTCMD_IF *inPlc);


/* Private function prototypes -----------------------------------------------*/
void udp_client_callback(void *arg, struct udp_pcb *upcb, struct pbuf *p, struct ip_addr *addr, u16_t port);
err_t tcp_client_connected(void *arg, struct tcp_pcb *tpcb, err_t err);
void tcp_client_err(void *arg, err_t err);
err_t tcp_client_sent(void *arg, struct tcp_pcb *tpcb, u16_t len);

/* Private functions ---------------------------------------------------------*/

/**
  * @brief  Initialize the client application.
  * @param  None
  * @retval None
  */
void client_init(void)
{
   
   struct pbuf *p;
   struct ip_addr ipaddr;

   //IP4_ADDR(&ipaddr, 192, 168, 1, 229);
   IP4_ADDR(&ipaddr, 192, 168, 20, 156);
                                  
   /* Create a new UDP control block  */
   upcb = udp_new();   
   
   /* Connect the upcb  */
   //udp_connect(upcb, IP_ADDR_BROADCAST, UDP_SERVER_PORT);
   udp_connect(upcb, &ipaddr, UDP_SERVER_PORT);

   p = pbuf_alloc(PBUF_TRANSPORT, 0, PBUF_RAM);

   /* Send out an UDP datagram to inform the server that we have strated a client application */
   udp_send(upcb, p);   

   /* Reset the upcb */
   //udp_disconnect(upcb);
   
   /* Bind the upcb to any IP address and the UDP_PORT port*/
   udp_bind(upcb, IP_ADDR_ANY, UDP_CLIENT_PORT);
  
   
   /* Set a receive callback for the upcb */
   udp_recv(upcb, udp_client_callback, NULL);

   /* Free the p buffer */
   pbuf_free(p);
  
}

/**
  * @brief  This function is called when a datagram is received
   * @param arg user supplied argument (udp_pcb.recv_arg)
   * @param upcb the udp_pcb which received data
   * @param p the packet buffer that was received
   * @param addr the remote IP address from which the packet was received
   * @param port the remote port from which the packet was received
  * @retval None
  */
void udp_client_callback(void *arg, struct udp_pcb *upcb, struct pbuf *p, struct ip_addr *addr, u16_t port)
{
   	memset((&inPlc)->m_buffer,0,4096);
	memcpy((&inPlc)->m_buffer,p->payload,p->len);
	//memcpy(inPlc->m_buffer,uip_buf,uip_len);
	printf("\n\n\rEthernet connection Rxbytes:%d\n\r",p->len);

	rec_handle();	  

	//print ethernet connection received data
    /*
	printf("Ethernet connection Received data:\n\r");
	for(i=0;i<uip_len;i++)
	{
		printf("%02x ",((char *)uip_appdata)[i]);
	}
	printf("\n\r");	  	*/

 
    /* Free the p buffer */
    pbuf_free(p);

}

/**
  * @brief  This function is called when the connection with the remote 
  *         server is established
  * @param arg user supplied argument
  * @param tpcb the tcp_pcb which received data
  * @param err error value returned by the tcp_connect 
  * @retval error value
  */
err_t tcp_client_connected(void *arg, struct tcp_pcb *tpcb, err_t err)
{
  LCD_DisplayStringLine(Line5, "Led control started ");
  
  /* Display Leds Control blocks */
  LCD_SetTextColor(Blue);
  LCD_DrawRect(180, 310, 40, 60);
  LCD_SetTextColor(Red);
  LCD_DrawRect(180, 230, 40, 60);
  LCD_SetTextColor(Yellow);
  LCD_DrawRect(180, 150, 40, 60);
  LCD_SetTextColor(Green);
  LCD_DrawRect(180, 70, 40, 60);

  TcpPCB = tpcb;
  
  return ERR_OK;
}

/**
  * @brief  Send to the server the led that should be toogled.
  * @param  Led the led that should be toogled
  * @retval None
  */
void tcp_led_control(Led_TypeDef Led)
{
  char ledstatus;

  ledstatus = (char) Led;
  
  tcp_write(TcpPCB, &ledstatus, sizeof(ledstatus), 1);

  /* send the data right now */
  tcp_output(TcpPCB); 
}

/******************* (C) COPYRIGHT 2009 STMicroelectronics *****END OF FILE****/

void menu_handle()
{
		 switch(c_choice)
		{
			case '0':
				printf("Return to Main Menu...\n\n\r");
				rec_flag=1;
				break;

			case '1':
				if(send_flag) 
				{	
					printf("Ready to run GetStatus...\n\r");
					if(run_GetStatus(&inPlc) == D_RETURN_SUCCESS)
					printf("GetStatus C_HDPLC_EXTCMD_IF initialize sucessfully!\n\r");
					else printf("GetStatus C_HDPLC_EXTCMD_IF initialize failed!\n\r");
					printf("Command GetStatus sent successfully!\n\n\r");
				}

				EtherTx(&inPlc);
				send_flag=0;  

		   		break;

			case '2':
				if(send_flag) 
				{	
					printf("Ready to run StartSpeedTest...\n\r");
					if(run_StartSpeedTest(&inPlc) == D_RETURN_SUCCESS)
					printf("StartSpeedTest C_HDPLC_EXTCMD_IF initialize sucessfully!\n\r");
					else printf("StartSpeedTest C_HDPLC_EXTCMD_IF initialize failed!\n\r");
					printf("Command StartSpeedTest sent successfully!\n\n\r");
				}
				
				EtherTx(&inPlc);
				send_flag=0;

				break;
		  
		  	case '4':
				if(send_flag) 
				{	
					printf("Ready to run GetPhyRate...\n\r");
					if(run_GetPhyRate(&inPlc) == D_RETURN_SUCCESS)
					printf("GetPhyRate EXT_CMD_IF initialized successfully!\n\r");
					else printf("GetPhyRate C_HDPLC_EXTCMD_IF initialize failed!\n\r");
					printf("Command GetPhyRate sent successfully!\n\n\r");
				}
				
				EtherTx(&inPlc);   
				send_flag=0;

				break;

			case '5':
				if(send_flag) 
				{	
					printf("Ready to run SystemCommand...\n\r");
					if(run_SystemCmd(&inPlc) == D_RETURN_SUCCESS)
					printf("SystemCmd EXT_CMD_IF initialized successfully!\n\r");
					else printf("Systemcmd C_HDPLC_EXTCMD_IF initialize failed!\n\r");
					printf("Command SystemCommand sent successfully!\n\n\r");
				}
				
				EtherTx(&inPlc);
				send_flag=0;

				break;

			case '6':
				if(send_flag) 
				{	
					printf("Ready to run SysGetPhyRate...\n\r");
					if(run_SysGetPhyRate(&inPlc) == D_RETURN_SUCCESS)
					printf("SysGetPhyRate EXT_CMD_IF initialized successfully!\n\r");
					else printf("SysGetPhyRate C_HDPLC_EXTCMD_IF initialize failed!\n\r");
					printf("Command SysGetPhyRate sent successfully!\n\n\r");
				}
				
				EtherTx(&inPlc);
				send_flag=0;

				break;

			case '7':
				if(send_flag) 
				{
					 printf("Ready to run GetAllMessages...\n\r");
				}

				run_GetAllMessages(&inPlc);
				EtherTx(&inPlc);

				send_flag=0;

				break;

			case '8':
				if(send_flag) 
				{
					 printf("Ready to run SetMacAddress...\n\r");
				}

				run_SetMacAddress(&inPlc);
				EtherTx(&inPlc);

				send_flag=0;

				break;

			case '9':
				if(send_flag) 
				{	
					printf("Ready to run StartChannelEstimate...\n\r");
					run_StartChannelEstimate(&inPlc);
					printf("Command StartChannelEstimate sent successfully!\n\n\r");
				}
				
				EtherTx(&inPlc);
				send_flag=0;

				break;

			case 'a':
				if(send_flag) 
				{	
					printf("Ready to run GetCINRMap...\n\r");
					run_GetCINRMap2To28(&inPlc);
					printf("Command GetCINRMap2To28 sent successfully!\n\n\r");
				}

				EtherTx(&inPlc);
				send_flag=0;
				
				break;

			default:
				printf("Please input number correctly!\n\r");
				printf("Return to Main Menu...\n\n\r");
				rec_flag=1;
				break;
		}



	//printf("waitting for new data!\n\r");	

	
}

int EtherTx(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	int theSize,theRet;
	struct pbuf *p;
		
	theSize=12+inPlc->m_pCmdData->length+2;

	p = pbuf_alloc(PBUF_TRANSPORT, theSize, PBUF_RAM);
	p->payload=(void *)inPlc->m_buffer; 

	printf("Tx:%d\t",theSize);		
	udp_send(upcb, p); 
	pbuf_free(p);
}

int EtherRx(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	return;
}

void rec_handle()
{
		if(rec_flag==0)
		{
		
			switch(c_choice)
			{
				case '1':
					print_GetStatus(&inPlc);

					break;
				case '2':
					print_StartSpeedTest(&inPlc);
					
					break;
				case '4':
					//printf("get phy rate response received!\n\r");
					print_GetPhyRate(&inPlc);
					rec_flag==1;
					break;
				case '5':
					//printf("system command response received!\n\r");
					print_SystemCmd(&inPlc);
					rec_flag==1;
					break;
				case '6':
					//printf("system command response received!\n\r");
					print_SystemCmd(&inPlc);
					rec_flag==1;
					break;
				case '7':
					if(circle_state==0)
					{
						print_GetStatus(&inPlc);
					}else
					{
						print_SystemCmd(&inPlc);
					}
					circle_state++;
					ini_flag=1;
					if(circle_state==2)
					{
						circle_flag=0;
						
					}
					break;
				case '8': 				
					if(circle_state==0)
					{
						printf("Execute cmd: uf_factorypwd set newpassword 0123456789\n\r");
						print_SystemCmd(&inPlc);
					}else if(circle_state==1)
					{
						printf("Execute cmd: uf_restoremac set 0123456789\n\r");
						print_SystemCmd(&inPlc);
					}else
					{
						printf("Execute cmd: uf_mac set %s\n\r",inMac);
						print_SystemCmd(&inPlc);
					}
				
					circle_state++;
					ini_flag=1;
					if(circle_state==4)
					{
						circle_flag=0;
						NVIC_SystemReset();		//software reset	 				

					}
					break;

				case '9':
					print_StartChannelEstimate(&inPlc);

					break;

				case 'a':
					print_GetCINRMap2To28(&inPlc);
					
					break;

				default:
					
					break;		
						
			}

			rec_flag=1;

	   }

}