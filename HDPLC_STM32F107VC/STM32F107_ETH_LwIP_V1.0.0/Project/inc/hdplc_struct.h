#ifndef __HDPLC_STRUCT_H__
#define __HDPLC_STRUCT_H__

#include<stdio.h>


#define	D_COM_GET_STATUS	0xa140
#define D_COM_START_SPEEDTEST 0xa0c0
#define D_COM_GET_PHY_RATE  0x1700
#define D_COM_SYSTEMCMD		0xdff0
#define D_COM_REMOTE		0x3000
#define D_COM_START_CHANNELESTIMATE		0xa0e0
#define D_COM_GET_CINRMAP_2TO28			0xa630

#define D_COM_SYSTEMCMD_LEN			1024
#define D_COM_PADDING_DATA_SIZE		4



#define D_RETURN_SUCCESS	1
#define D_RETURN_FAILURE	0

#define D_MASTER_MODEL		1

#define D_AUTHENRICATION_TRUE	1





typedef struct
{
	unsigned char header[8];	//format indication code
	unsigned char	taskid;		//notified task
	unsigned char reserved1;	//reserved
	unsigned short length;		//length
	unsigned short cid;			//command id
	unsigned short tid;			//transaction id
	unsigned long cmdlength;	//command length
	unsigned long vid;			//vendor id
	unsigned short vcid;		//vendor command id
	unsigned short cmdver;		//command version
	
	unsigned char param[1440];	//command body(include check code area)
}T_HDPLC_EXTCMD_FORMAT;

struct C_HDPLC_EXTCMD_IF
{
	//int (*Initialize)(unsigned short,unsigned long);
	//void (*String2Hex)(char *inString,char *outData);
	
	T_HDPLC_EXTCMD_FORMAT *m_pCmdData;		//send data format
	unsigned char m_buffer[4096];			//Command buffer	
	
};


int Initialize(struct C_HDPLC_EXTCMD_IF *inStruct,unsigned short inVCID,unsigned long inSize);
void String2Hex(char *inString,char *outData);

unsigned char * GetCmdBody(struct C_HDPLC_EXTCMD_IF *inStruct);



/*get status related definition*/

typedef struct 	   
{
	unsigned long reserved;
}T_HDPLC_EXTCMD_GET_STATUS_REQ;

typedef struct
{
	unsigned char	result;
	unsigned char	reserved[3];
	unsigned char	registeredInfo;
	unsigned char 	ethLinkUp;
	unsigned short	ethSpdDpx;
	unsigned char 	multipleMode;
	unsigned char	authMode;
	unsigned char	selfAddr[6];
	unsigned char	mainVersion[32];
	unsigned char	reserved1[32];
	unsigned char	bootVersion[32];
	unsigned char 	rcvBcStatus;
	unsigned char   mtMode;
	unsigned char	mstAddr[6];
	unsigned long	termEthPktRate;
}T_HDPLC_EXTCMD_GET_STATUS_CNF;

int run_GetStatus(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_GetStatus(struct C_HDPLC_EXTCMD_IF *inPlc);



/*speed test related definition*/

typedef struct
{
	unsigned char macAddr[6];
	unsigned short reserved;
}T_HDPLC_EXTCMD_START_SPEEDTEST_REQ;

typedef struct
{
	unsigned char result;
	unsigned char reserved[3];
} T_HDPLC_EXTCMD_START_SPEEDTEST_CNF;

int run_StartSpeedTest(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_StartSpeedTest(struct C_HDPLC_EXTCMD_IF *inPlc);



/*get phy rate related difinition*/

typedef struct
{
	unsigned long reserved;	
}T_HDPLC_EXTCMD_GET_PHY_RATE_REQ;

typedef struct
{
	unsigned char plcmacAddr[6];
	unsigned short phyRate;
}PLC_RATE;

typedef struct
{
	unsigned char result;
	unsigned char termNum;
	unsigned short reserved;
	PLC_RATE plc_rate[15];
	unsigned char reserveds[904];	
}T_HDPLC_EXTCMD_GET_PHY_RATE_CNF;

int run_GetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_GetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc);



/*system command related declaration*/

typedef struct
{
	unsigned char cmdline[1024];
} T_HDPLC_EXTCMD_SYSTEMCMD_REQ;

typedef struct
{
	unsigned char result[1024];
} T_HDPLC_EXTCMD_SYSTEMCMD_CNF;

int run_SystemCmd(struct C_HDPLC_EXTCMD_IF *inPlc);
int run_SysGetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_SystemCmd(struct C_HDPLC_EXTCMD_IF *inPlc);



/*remote command related*/

typedef struct
{
	unsigned long reserved;
	unsigned char rmtPLCAddr[6];
	unsigned short waitTime;
	unsigned long reserved2;
	unsigned long comLength;
	unsigned char rmtReqCommand[1420];
} T_HDPLC_EXTCMD_PLC_REMOTE_REQ;

typedef struct
{
	unsigned char result;
	unsigned char reserved[3];
	unsigned char rmtPLCAddr[6];
	unsigned char reserved2[6];
	unsigned long comLength;
	unsigned char rmtRspCommand[1420];
} T_HDPLC_EXTCMD_PLC_REMOTE_CNF;




/*CINR related definitions*/

typedef struct
{
	unsigned char macAddr[6];
	unsigned short reserved;
} T_HDPLC_EXTCMD_START_CHANNELESTIMATE_REQ;

typedef struct
{
	unsigned char result;
	unsigned char reserved[3];
} T_HDPLC_EXTCMD_START_CHANNELESTIMATE_CNF;

typedef struct
{
	unsigned long reserved;
} T_HDPLC_EXTCMD_GET_CINRMAP_2TO28_REQ;

typedef struct
{
	unsigned char result;
	unsigned char reserved[3];
	unsigned short cinr[432];
} T_HDPLC_EXTCMD_GET_CINRMAP_2TO28_CNF;

int run_StartChannelEstimate(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_StartChannelEstimate(struct C_HDPLC_EXTCMD_IF *inPlc);
int run_GetCINRMap2To28(struct C_HDPLC_EXTCMD_IF *inPlc);
int print_GetCINRMap2To28(struct C_HDPLC_EXTCMD_IF *inPlc);


 


int run_GetAllMessages(struct C_HDPLC_EXTCMD_IF *inPlc);

int run_SetMacAddress(struct C_HDPLC_EXTCMD_IF *inPlc);
int run_SetMacAddressSub(struct C_HDPLC_EXTCMD_IF *inPlc,unsigned char* setmac_cmd);

#endif














