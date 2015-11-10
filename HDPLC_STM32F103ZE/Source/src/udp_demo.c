//#include "sys/sys.h"
//#include "usart/usart.h"

#include <stdlib.h>
#include <stdio.h>
#include <string.h>


#include "uip.h"
#include "udp_demo.h"
#include "hdplc_struct.h"

void uip_udp_init(void) {
	uip_ipaddr_t ipaddr;
	static struct uip_udp_conn *conn_udp = 0;
	
	//uip_ipaddr(ipaddr, 255,255,255,255);
	//uip_ipaddr(ipaddr, 192,168,1,243);
	uip_ipaddr(ipaddr, 192,168,20,156);
	//printf("initializing udp!!\n\r");

	if(0 != conn_udp) {
		// 如果连接已经建立，则删除该连接
		uip_udp_remove(conn_udp);
		//printf("udp communication exists!!\n\r");
	}
	conn_udp = uip_udp_new(&ipaddr, HTONS(UDP_PORT));
	if(0 != conn_udp) {
		// 绑定本地端口
		//conn_tftp->lport = HTONS(UDP_PORT);
		uip_udp_bind(conn_udp, HTONS(UDP_PORT));
		udp_sta |= 1<<7;
		//printf("new udp conn udp_sta:%d!!\n\r",udp_sta);
	}
}

void udp_demo_appcall(void) {
	switch(uip_udp_conn->lport) {
		case HTONS(UDP_PORT):
			udp_appcall();
			break;
		
		default:
			//printf("uip_udp_conn->lport:%d\n\r",uip_udp_conn->lport);
			break;
	}
}

//u8_t udp_data_buf[512];
u8_t udp_data_buf[4096];
u8_t udp_sta;
//[7]:0,无连接;1,已经连接;
//[6]:0,无数据;1,收到客户端数据
//[5]:0,无数据;1,有数据需要发送
u16_t udp_len=0;
extern char c_choice;
extern int send_flag;
extern int rec_flag;
extern int circle_flag;
extern int circle_state;
extern unsigned char inMac[20];
int ini_flag=1;
struct C_HDPLC_EXTCMD_IF inPlc;


void udp_appcall(void) {
	struct udp_demo_appstate *s = (struct udp_demo_appstate *)&uip_udp_conn->appstate;

	 if(uip_len==0)
	 //if(send_flag)
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

	}

	//printf("waitting for new data!\n\r");	

	if(uip_newdata()) {
				
		//if(0 == (udp_sta&(1<<6)))
		//printf("new data arrives!\n\r"); 
		if(rec_flag==0)
		{
			/*	udp_len = uip_len;
			memset(udp_data_buf, 0, sizeof(udp_data_buf));
			memcpy(udp_data_buf, uip_appdata, udp_len);
			printf("processed: len %d\n\r", udp_len);	*/

			EtherRx(&inPlc);

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
					break;
				case '5':
					//printf("system command response received!\n\r");
					print_SystemCmd(&inPlc);
					break;
				case '6':
					//printf("system command response received!\n\r");
					print_SystemCmd(&inPlc);
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
					if(circle_state==2)circle_flag=0;
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
					if(circle_state==4)circle_flag=0;
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
	}else if(1) 
		{
			/*	s->textptr = udp_data_buf;
			s->textlen = udp_len;
			udp_senddata();
			udp_sta &= ~(1<<5);	*/
			//printf("not new data!\n\r");
		}
	
}

void udp_senddata(void) {
	struct udp_demo_appstate *s = (struct udp_demo_appstate *)&uip_udp_conn->appstate;
	int i;

	if(s->textlen>0)uip_send(s->textptr, s->textlen);//发送数据包

	//print ethernet connectiong transmit data
	/*
	printf("\n\rEtherTx data:\n\r");
	for(i=0;i<s->textlen;i++)
	{
		printf("%02x ",((char *)s->textptr)[i]);
	}
	printf("\n\r");
	*/

	s->textlen==0;	

}
