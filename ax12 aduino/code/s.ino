#include <SoftHalfDuplexSerial.h>
//舵机控制头文件
#include <DynamixelAx.h>
#include <math.h>
int maxangle=300;//最大角度
int mid1=512;//腿设置
int mid2=300;
int mid3=724;
int lr1=5;//left red
int lr2=6;
int lr3=13;
int rg1=8;//right green
int rg2=7;
int rg3=16;
int lg1=12;//left green
int lg2=18;
int lg3=17;
int rr1=4;//right red
int rr2=3;
int rr3=10;
float sposition[12]={0};//位置接收数组


//使用arduino控制板上的pin 8 管脚
softHalfDuplexSerial port(8); 
//舵机通信端跟这个管脚进行绑定
dxlAx dxlCom(&port);

void smove(int id,int p)//舵机控制
{
  dxlCom.setGoalPosition(id, p);
  delay(10);
}

void sinit()
{
  smove(lr1, mid1);
  smove(lr2, mid1);
  smove(lg1, mid1);
  smove(lg2, mid1);
  smove(rg1, mid1);
  smove(rg2, mid1);
  smove(rr1, mid1);
  smove(rr2, mid1);
  
  smove(lr3, mid3);
  smove(lg3, mid3);
  smove(rg3, mid2);
  smove(rr3, mid2);
}

void splay(float angle1[12])//舵机设置
{
  float angle[12]={0};
  for(int i=0;i<12;i++)
  {
   angle[i]=angle1[i];
   angle[i]=(angle[i]*57.32)*512*2/maxangle+512;
  }
  smove(rg1,int(angle[0]));
  smove(rg2,int(angle[1]));
  smove(rg3,int(angle[2])-212);
  
  smove(rr1,int(angle[3]));
  smove(rr2,int(angle[4]));
  smove(rr3,int(angle[5])-212);
  
  smove(lr1,int(angle[6]));
  smove(lr2,int(angle[7]));
  smove(lr3,int(angle[8])+212);
  
  smove(lg1,int(angle[9]));
  smove(lg2,int(angle[10]));
  smove(lg3,int(angle[11])+212);
}

void sread(float angle[12])//信息接收
{
  int mark=0;
  String comdata = "";
  while (Serial.available() > 0)  
    {
        comdata += char(Serial.read());
        delay(2);
        mark=1;
    }
    if(mark==1)
    {
  int j=0,k=0,l=0;//计数，小数判断，正负判断
  angle[j]=0;
  for(int i = 0; i < comdata.length() ; i++)
    {
      if(comdata[i] == '-')
      l=1;
      if(comdata[i] == ',')
      {
        if(l==1)
        angle[j]=-angle[j];
        j++;
        k=0; 
        angle[j]=0;
        l=0;
      }
      else
      {
        if(comdata[i] == '-')
        l=1;
        else if(comdata[i] == '.')
        k=1;
        else if(k==0)
          angle[j] = angle[j] * 10 + (comdata[i] - '0') ;
        else if(k!=0)
        {
          angle[j] = angle[j] + pow(0.1,k)*(comdata[i] - '0');
          k++;
        }
      }
    }
    if(l==1)
        angle[j]=-angle[j];
    comdata = "";
    }
}

void setup() {
  Serial.begin(57600);
  while (!Serial) {
    ; // 等待串口连接完成
  }
  Serial.println("Starting COM!");
  
  //设置跟舵机通信的波特率
  dxlCom.begin(1000000);
  sinit();
}

/////////////////////////////////////////////////////////////////////////////////////

void loop()
{
 sread(sposition);
 splay(sposition);
}
