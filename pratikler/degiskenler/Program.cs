
using System;

namespace consoleprogramlama {
class Program {

    public static void Main (String [] args){

byte b=5;
sbyte sb=5;
short sh= 2;
ushort ush=2;

Int16 i16=1;
int i=2;
Int32 i32 = 3;
Int64 i64=5;
uint ui = 5;
long l=5;
ulong ul=9;

float f =1;
double d=2;
decimal de =3;

char c='a';
string str ="aysenur";

bool bl = true;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 ="x";
object o2='y';
object o3 =4;
object o4 = 4.5;

string str1=string.Empty;
str1="aysenur";
string ad=str;
string soyad ="grbz";
string tamisim= ad+" "+soyad;


int integer =4;
int integer2=5;
int integer3= integer+integer2;


bool boo= 10<2;
 

 string str20="20";
 int int20=20;
 string yenideger = str20 + int20.ToString();
Console.WriteLine(yenideger);


int int21= int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22= int20 + int.Parse(str20);

string datetime= DateTime.Now.ToString("dd/mm/yyyy");
Console.WriteLine(datetime);

string datetime2= DateTime.Now.ToString("HH:mm");
Console.WriteLine(datetime2);




    }
}

}
