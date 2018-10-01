using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //String中的ToCharArray方法，可以将字符串转换为单个字符数组
            //SToCA();

            //String.ToUper()  将字符串转换为大写
           // SToU();

            //通过Equal方法的StringComparison.OrdinalIgnoreCase来忽略大小写
            //ToE();

            //分割字符串Split
            //SP();

            //截取文件路径
            //LastIndexOf
            Lo();




            Console.ReadKey();
        }



        //String中的ToCharArray方法，可以将字符串转换为单个字符数组
        public static void SToCA()
        {
            string a = "abcdefg";
            char[] b = a.ToCharArray();
            b[0] = 'A';
            a = new string(b);

            Console.WriteLine(a);
            

        }



        
        //String.ToUper()  将字符串转换为大写
        //小写转换是ToLower()
        public static void SToU()
        {

            Console.WriteLine("输入你所喜欢的课程：");
            string str= Console.ReadLine();
            Console.WriteLine("请输入你同学喜欢的课程");
            String str2 = Console.ReadLine();
            str2 = str2.ToUpper();
            str = str.ToUpper();
            if (str == str2)
            {
                Console.WriteLine("你们喜欢的的课程相同");

            }
            else
            {
                Console.WriteLine("你们喜欢的是不一样的课程");
            }

        }



        //通过Equal方法的StringComparison.OrdinalIgnoreCase来忽略大小写
        public static void ToE()
        {
            Console.WriteLine("输入你所喜欢的课程：");
            string str = Console.ReadLine();
            Console.WriteLine("请输入你同学喜欢的课程");
            String str2 = Console.ReadLine();
            if (str.Equals(str2,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("你们喜欢的的课程相同");
            }
            else
            {
                Console.WriteLine("你们喜欢的是不一样的课程");
            }

        }


        //分割字符串Split
        //2.StartsWith和EndsWith的用法,这个函数用来判断字符当中是否是以指定字符开始或者结束的
        //3.字符的插入Insert,Remove,可以在指定位置插入一个字符，并返回处理过的字符串,Remove可以在指定位置删除指定长度的字符
        //4.去掉字符串中头部或则尾部的一些其他指定字符,Trim名为修剪，就是修饰用的,该方法只能去掉字符串的头部或则尾部中间的部分不能去掉

        public static void SP()
        {
            Console.WriteLine("输入日期(YYYY-MM-DD):");
            string str = Console.ReadLine();
            char[] ch = {'-',' ',',','=','+'};
            string[] str1 = str.Split(ch,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(str1[0]+"年"+str1[1]+"月"+str1[2]+"日");


        }

        //截取文件路径
        //LastIndexOf
        public static void Lo()
        {
            string str = @"\fa\afd\adf\ads\fdger\fgdrt\fscd\abcd.vav";
            int index = str.LastIndexOf("\\");
            str = str.Substring(index + 1);
            Console.WriteLine(str);

        }



    }
}
