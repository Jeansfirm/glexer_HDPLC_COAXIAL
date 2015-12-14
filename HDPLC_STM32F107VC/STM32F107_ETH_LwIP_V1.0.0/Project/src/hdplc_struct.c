#include "hdplc_struct.h"		 
#include <stdio.h>
#include <stdlib.h>

extern int circle_state;
extern int circle_flag;
extern int ini_flag;
extern int rec_flag;
extern unsigned char inStr[100];
unsigned char inCmd[100];
unsigned char inMac[20]; 

int Initialize(struct C_HDPLC_EXTCMD_IF *inStruct,unsigned short inVCID,unsigned long inSize)
{
	
	memset((inStruct->m_buffer),0,sizeof(inStruct->m_buffer));
	//bzero(inStruct->m_buffer,sizeof(inStruct->m_buffer));
	inStruct->m_pCmdData = (T_HDPLC_EXTCMD_FORMAT *)(inStruct->m_buffer+2);

	inStruct->m_pCmdData->header[0] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[1] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[2] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[3] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[4] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[5] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[6] = (unsigned char)0xaa;
	inStruct->m_pCmdData->header[7] = (unsigned char)0xab;
	

	inStruct->m_pCmdData->taskid = 3;
	inStruct->m_pCmdData->cid = 0xf000|0x0001;
	inStruct->m_pCmdData->vid = 0x0b4e7e67;			//vendor id(panasonic)
	inStruct->m_pCmdData->vcid = inVCID|0x0001;
	
	inStruct->m_pCmdData->cmdlength = 8+inSize;
	inStruct->m_pCmdData->length = (unsigned short)(16+inSize);
	
	return D_RETURN_SUCCESS;
	
}

unsigned char * GetCmdBody(struct C_HDPLC_EXTCMD_IF *inStruct)
{
	return inStruct->m_pCmdData->param;
}



void String2Hex(char *inString,char *outData)
{
	int		len, n = 0;
	char	tmp[2] = {0, 0};
	char	*po = outData;
	char	*pi = inString;
	
	len = strlen(inString);

	if (len == 0) return;
	
	while(1)
	{
		memcpy(tmp,pi,1);
		
		if (n % 2 == 0)
		{
			*po = ((char)strtoul(tmp, NULL, 16)) << 4;
		}
		else
		{
			*po |= ((char)strtoul(tmp, NULL, 16)) & 0xf;
			po++;
		}
		
		pi++;
		len--;
		n++;
		if (len == 0) break;
	}
	
	return;
}



/*get status related definition*/

int run_GetStatus(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	
	T_HDPLC_EXTCMD_GET_STATUS_REQ *theReq;
	
	if(Initialize(inPlc,D_COM_GET_STATUS,sizeof(T_HDPLC_EXTCMD_GET_STATUS_REQ)) == D_RETURN_SUCCESS)
	{
		theReq = (T_HDPLC_EXTCMD_GET_STATUS_REQ *)GetCmdBody(inPlc);
		return D_RETURN_SUCCESS;
	}else
	return D_RETURN_FAILURE;
}

int print_GetStatus(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	 T_HDPLC_EXTCMD_GET_STATUS_CNF *theCnf;

	 theCnf = (T_HDPLC_EXTCMD_GET_STATUS_CNF *)GetCmdBody(inPlc);

	 if (theCnf->result != 0)
	{
		printf("Cmd executed failed! (result!=1)\n\r");
		return D_RETURN_FAILURE;
	}

	/*-------------------------------------------------------------------------*
		displays result 
		$1 ref mac address
	 *-------------------------------------------------------------------------*/
	if ((theCnf->mtMode & 0x1) == D_MASTER_MODEL)
	{
		printf("\n\r");
		printf(" Mode ................... Master\n\r");
		printf(" MAC Address ............ %02x-%02x-%02x-%02x-%02x-%02x\n\r", theCnf->selfAddr[0], theCnf->selfAddr[1], theCnf->selfAddr[2], theCnf->selfAddr[3], theCnf->selfAddr[4], theCnf->selfAddr[5]);
	}
	else
	{
		if (theCnf->authMode == D_AUTHENRICATION_TRUE)
		{
			printf("\n\r");
			printf(" Mode ................... Terminal(authenticated)\n\r");
		}
		else
		{
			printf("\n\r");
			printf(" Mode ................... Terminal(not authenticated)\n\r");
		}
		printf(" MAC Address ............ %02x-%02x-%02x-%02x-%02x-%02x\n\r", theCnf->selfAddr[0], theCnf->selfAddr[1], theCnf->selfAddr[2], theCnf->selfAddr[3], theCnf->selfAddr[4], theCnf->selfAddr[5]);
		printf(" Master MAC Address ..... %02x-%02x-%02x-%02x-%02x-%02x\n\r", theCnf->mstAddr[0], theCnf->mstAddr[1], theCnf->mstAddr[2], theCnf->mstAddr[3], theCnf->mstAddr[4], theCnf->mstAddr[5]);

	}
	
	printf(" Registered Info ........ %d\n\r", theCnf->registeredInfo);
	printf(" Ether LinkUp ........... %d\n\r", theCnf->ethLinkUp);
	printf(" Ether SpdDpx ........... %d\n\r", theCnf->ethSpdDpx);
	printf(" Multiple Mode .......... %d\n\r", theCnf->multipleMode);

	printf(" Main Version ........... %s\n\r", theCnf->mainVersion);
	printf(" Boot Version ........... %s\n\r", theCnf->bootVersion);

	printf(" Beacon Status .......... %d\n\r", theCnf->rcvBcStatus);

	printf("\n\r$1%02x%02x%02x%02x%02x%02x\n\r", theCnf->selfAddr[0], theCnf->selfAddr[1], theCnf->selfAddr[2], theCnf->selfAddr[3], theCnf->selfAddr[4], theCnf->selfAddr[5]);

	printf("\n\r");
	
}


/*speed test related definition*/

int run_StartSpeedTest(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_START_SPEEDTEST_REQ *theReq;
	int ret;
	char theBuf[64];
	char c;
	int i=0;


	ret=Initialize(inPlc,D_COM_START_SPEEDTEST,sizeof(T_HDPLC_EXTCMD_START_SPEEDTEST_REQ));
	if(ret == D_RETURN_SUCCESS)
	{
		theReq = (T_HDPLC_EXTCMD_START_SPEEDTEST_REQ *)GetCmdBody(inPlc);
		printf("Please enter Mac address (6Byte) -->");
		//gets(theBuf);
		
		while((c=getc(stdin))!=13)
		{
			 theBuf[i]=c;
			 printf("%c",c);
			 i++;
		}
		theBuf[i]='\0';
		printf("\n\r");

		String2Hex(theBuf,(char *)theReq->macAddr);
		
		return D_RETURN_SUCCESS;
	}else
	return D_RETURN_FAILURE;
}

int print_StartSpeedTest(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_START_SPEEDTEST_CNF *theCnf;

	theCnf = (T_HDPLC_EXTCMD_START_SPEEDTEST_CNF *)GetCmdBody(inPlc);
	if (theCnf->result != 0)
	{
		printf("StartSpeedTest result!=0 failure!!\n\r");
		return D_RETURN_FAILURE;
	}
	printf("Execute speedtest command successfully!\n\r");
}



/*get phy rate related difinition*/

int run_GetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	int ret;

	ret=Initialize(inPlc,D_COM_GET_PHY_RATE,sizeof(T_HDPLC_EXTCMD_GET_PHY_RATE_REQ));
	if(ret == D_RETURN_SUCCESS)
	{
		return D_RETURN_SUCCESS;
	}else
	return D_RETURN_FAILURE;
}

int print_GetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_GET_PHY_RATE_CNF *theCnf;
	int i,num;

	theCnf = (T_HDPLC_EXTCMD_GET_PHY_RATE_CNF *)GetCmdBody(inPlc);
	if (theCnf->result != 0)
	{
		printf("GetPhyRate result=0 failure!!\n\r");
		return D_RETURN_FAILURE;
	}
	printf("Execute GetPhyRate command successfully!\n\r");

	num=theCnf->termNum;
	printf("Number of plc device connected to ref device is:%d\n\r",num);
	printf("Device 1:\n\r");
	printf("MAC Adress:\n\r");
	for(0;i<6;i++)
	{
		printf("%02x ",theCnf->plc_rate->plcmacAddr[i]);
	}
	printf("Rate:\n\r");

	return D_RETURN_SUCCESS;
}


/*system command related definition*/

int run_SystemCmd(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_SYSTEMCMD_REQ	*theReq;
	int ret;
	int i=0;
	unsigned char *theBuf;
	char c;

	int theLen;
	int theRem;
	//char *str="uf_mac get";

	ret=Initialize(inPlc,D_COM_SYSTEMCMD,sizeof(T_HDPLC_EXTCMD_SYSTEMCMD_REQ));
	if(ret == D_RETURN_SUCCESS)
	{
		theReq=(T_HDPLC_EXTCMD_SYSTEMCMD_REQ *)GetCmdBody(inPlc);
		theBuf=theReq->cmdline;

		//strcpy(theBuf,str);
		printf("Please input system command -->");
		while((c=getc(stdin))!=13)
		{
			 theBuf[i]=c;
			 printf("%c",c);
			 i++;
		}
		theBuf[i]='\0';
		printf("\n\r");
		//printf("system command:%s\n\r",theBuf);

		theLen=strlen((char *)theReq->cmdline)+1;
		theRem=4-(theLen%4);
		if(theRem!=4)
		{
			for(i=0;i<theRem;i++)
			{
				theReq->cmdline[theLen+i]=0xff;
			}
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen+theRem;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen+theRem);
		}else
		{
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen);
		}

		return D_RETURN_SUCCESS;

	}else
	return D_RETURN_FAILURE;

}

void replaceChar(unsigned char *str)	 // replace '*' with space
{
	int len,i=0;
	len=strlen(str);
	while(str[i]!='\0')
	{
		if(str[i]=='*')str[i]=' ';
		i++;
	}
}

int run_SysGetPhyRate(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_SYSTEMCMD_REQ	*theReq;
	int ret;
	int i=0;
	unsigned char *theBuf;
	unsigned char *str1="uf_phyrate get ";
	unsigned char *str2=" -mbps";

	int theLen;
	int theRem;
	//char *str="uf_mac get";

	ret=Initialize(inPlc,D_COM_SYSTEMCMD,sizeof(T_HDPLC_EXTCMD_SYSTEMCMD_REQ));
	if(ret == D_RETURN_SUCCESS)
	{
		theReq=(T_HDPLC_EXTCMD_SYSTEMCMD_REQ *)GetCmdBody(inPlc);
		theBuf=theReq->cmdline;

		for(i=0;i<12;i++)
		{
		 	inMac[i]=inStr[i+1];
		}
		inMac[i]='\0';

		strcpy(inCmd,str1);
		strcat(inCmd,inMac);
		strcat(inCmd,str2);
		printf("\n\r");
		//replaceChar(inCmd);
		printf("system command:%s\n\r",inCmd);
		strcpy(theBuf,inCmd);

		theLen=strlen((char *)theReq->cmdline)+1;
		theRem=4-(theLen%4);
		if(theRem!=4)
		{
			for(i=0;i<theRem;i++)
			{
				theReq->cmdline[theLen+i]=0xff;
			}
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen+theRem;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen+theRem);
		}else
		{
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen);
		}

		return D_RETURN_SUCCESS;

	}else
	return D_RETURN_FAILURE;
}


int print_SystemCmd(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	 T_HDPLC_EXTCMD_SYSTEMCMD_CNF	*theCnf;

	 theCnf=(T_HDPLC_EXTCMD_SYSTEMCMD_CNF *)GetCmdBody(inPlc);

	 printf("\n\r");
	 printf("System Command Result Length:%d\n\r",strlen(theCnf->result));
	 printf("System Command Result:%s\n\n\r", theCnf->result);
	 printf("$2%s\n\n\r", theCnf->result);

	 return D_RETURN_SUCCESS;
}





/*Get All Messages related definitions*/

int run_GetAllMessages(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	int i;
	unsigned char *str1="uf_phyrate get ";
	unsigned char *str2=" -mbps";

	T_HDPLC_EXTCMD_SYSTEMCMD_REQ	*theReq;
	unsigned char *theBuf; 	

	if(circle_state==0&&ini_flag==1)
	{
		 //printf("Please input system command -->");
		 //scanf("%s",inMac);
		 for(i=0;i<12;i++)
		 {
		 	inMac[i]=inStr[i+1];
		 }
		 inMac[i]='\0';

		 strcpy(inCmd,str1);
		 strcat(inCmd,inMac);
		 strcat(inCmd,str2);
		 printf("\n\r");
		 //replaceChar(inCmd);
		 printf("system command:%s\n\r",inCmd);

		 Initialize(inPlc,D_COM_GET_STATUS,sizeof(T_HDPLC_EXTCMD_GET_STATUS_REQ));
		 ini_flag=0;

	}else if(circle_state==1&&ini_flag==1)
	{
		  run_SysGetPhyRate(inPlc);

		  ini_flag=0;
		  rec_flag=0;		 
	}

}




/*set mac address related definitions*/

int run_SetMacAddressSub(struct C_HDPLC_EXTCMD_IF *inPlc,unsigned char* setmac_cmd)
{
	T_HDPLC_EXTCMD_SYSTEMCMD_REQ	*theReq;
	int ret;
	unsigned char *theBuf;

	int theLen;
	int theRem;
	int i;
	
	ret=Initialize(inPlc,D_COM_SYSTEMCMD,sizeof(T_HDPLC_EXTCMD_SYSTEMCMD_REQ));
	if(ret == D_RETURN_SUCCESS)
	{
		theReq=(T_HDPLC_EXTCMD_SYSTEMCMD_REQ *)GetCmdBody(inPlc);
		theBuf=theReq->cmdline;

		printf("\n\r");
		strcpy(theBuf,setmac_cmd);
		printf("system command:%s\n\r",theBuf);

		theLen=strlen((char *)theReq->cmdline)+1;
		theRem=4-(theLen%4);
		if(theRem!=4)
		{
			for(i=0;i<theRem;i++)
			{
				theReq->cmdline[theLen+i]=0xff;
			}
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen+theRem;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen+theRem);
		}else
		{
			inPlc->m_pCmdData->cmdlength = 8+sizeof(char)*theLen;
			inPlc->m_pCmdData->length = (unsigned short)(16+sizeof(char)*theLen);
		}

		return D_RETURN_SUCCESS;

	}else
	return D_RETURN_FAILURE;
}


int run_SetMacAddress(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	int i;

	if(circle_state==0&&ini_flag==1)
	{
		 //printf("Please input system command -->");
		 //scanf("%s",inMac);
		 for(i=0;i<12;i++)
		 {
		 	inMac[i]=inStr[i+1];
		 }
		 inMac[i]='\0';

		 strcpy(inCmd,"uf_factorypwd set newpassword 0123456789");
		 printf("\n\r");

		 run_SetMacAddressSub(inPlc,inCmd);

		 ini_flag=0;

	}else if(circle_state==1&&ini_flag==1)
	{
		  strcpy(inCmd,"uf_restoremac set 0123456789");
		  printf("\n\r");
		  run_SetMacAddressSub(inPlc,inCmd);

		  ini_flag=0;
		  rec_flag=0;		 
	}else if(circle_state==2&&ini_flag==1)
	{
		  strcpy(inCmd,"uf_mac set ");
		  strcat(inCmd,inMac);
		  printf("\n\r");
		  run_SetMacAddressSub(inPlc,inCmd);
		  
		  ini_flag=0;
		  rec_flag=0;		  
	}else if(circle_state==3&&ini_flag==1)
	{
		  strcpy(inCmd,"ul_reset");
		  printf("\n\r");
		  run_SetMacAddressSub(inPlc,inCmd);

		  ini_flag=0;
		  rec_flag=0;
	}
}



/*CINR related difinitions*/
int run_StartChannelEstimate(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	int i;
	T_HDPLC_EXTCMD_START_CHANNELESTIMATE_REQ *theReq;

	Initialize(inPlc,D_COM_START_CHANNELESTIMATE,sizeof(T_HDPLC_EXTCMD_START_CHANNELESTIMATE_REQ));
	theReq=(T_HDPLC_EXTCMD_START_CHANNELESTIMATE_REQ *)GetCmdBody(inPlc);

	for(i=0;i<12;i++)
	{
	 	inMac[i]=inStr[i+1];
	}
	inMac[i]='\0';
	
	String2Hex(inMac,(char *)theReq->macAddr);

	return D_RETURN_SUCCESS;
		
}

int print_StartChannelEstimate(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_START_CHANNELESTIMATE_CNF *theCnf;

	theCnf = (T_HDPLC_EXTCMD_START_CHANNELESTIMATE_CNF *)GetCmdBody(inPlc);
	if (theCnf->result != 0)
	{
		printf("StartChannelEstimate result!=0 failure!!\n\r");
		return D_RETURN_FAILURE;
	}
	printf("Execute StartChannelEstimate command successfully!\n\r");
}

int run_GetCINRMap2To28(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	Initialize(inPlc,D_COM_GET_CINRMAP_2TO28,sizeof(T_HDPLC_EXTCMD_GET_CINRMAP_2TO28_REQ));
}


int print_GetCINRMap2To28(struct C_HDPLC_EXTCMD_IF *inPlc)
{
	T_HDPLC_EXTCMD_GET_CINRMAP_2TO28_CNF *theCnf;
	int i;

	theCnf = (T_HDPLC_EXTCMD_GET_CINRMAP_2TO28_CNF *)GetCmdBody(inPlc);
	if (theCnf->result != 0)
	{
		printf("Get CINR Map result!=0 failure!!\n\r");
		return D_RETURN_FAILURE;
	}
	printf("Execute Get CINR Map command successfully!\n\r");

	for(i=0;i<432;i++)
	{
		printf("cinr[%d]:%d\t",i,theCnf->cinr[i]);
	}
}


