#ifndef __UDP_DEMO_H
#define __UDP_DEMO_H

//#include "sys/sys.h"
#include "uipopt.h"

extern u8_t udp_data_buf[];
extern u8_t udp_sta;
extern u16_t udp_len;

struct udp_demo_appstate
{
	u8_t state;
	u8_t *textptr;
	int textlen;
};	 
typedef struct udp_demo_appstate uip_udp_appstate_t;

#ifndef UIP_UDP_APPCALL
//#define UIP_UDP_APPCALL udp_appcall
#define UIP_UDP_APPCALL udp_demo_appcall
#endif



#ifndef UIP_UDP_CONNS
#define UIP_UDP_CONNS 10
#endif

#ifndef UIP_CONF_BROADCAST
#define UIP_CONF_BROADCAST 1
#endif


#define UDP_PORT	0xc000

void uip_udp_init(void);
void udp_demo_appcall(void);
void udp_appcall(void);
void udp_senddata(void);

#endif
