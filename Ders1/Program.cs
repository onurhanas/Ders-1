using System;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b =2;
            sbyte s =2;

            short ss=2;
            ushort us=2;

            Int16 i16=2;
            int i=2;
            Int32 i32=2;
            Int64 i64=2;

            uint ui=2;
            long l=2;
            ulong ul=2;

            float f=2.3f;
            double d=2.4;
            decimal dd=2.3m;

            char ch='d';
            string str="xd";

            bool b1=true;
            bool b2=false;


            DateTime dt =DateTime.Now;
            Console.WriteLine(dt);

            object o1 ="xds";
            object o2 =31;
            object o3 =3.2;

            string str1 =string.Empty;
            str1="Onurhan As";
            string ad="Onurhan";
            string soyad ="As";
            string tamIsim= ad+""+soyad;

            int integer1=2;
            int integer2=4;
            int integer3= integer1*integer2;

            bool bool2=10>2;

            string str20 ="20";
            int int20=20;
            string yenideger = str20 + int20.ToString();

            int int40= int20+ Convert.ToInt32(str20);
            
                   }
    }
}