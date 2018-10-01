using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            



            Console.ReadKey();
        }


        public static void Filesss()
        {

            //将字节转换为字符串
            byte[] by = File.ReadAllBytes(@"C:\Users\17100\Desktop\基础\File引用.txt");
            //将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            //UTF-8 GB2312 GBK ASCII Unicode
            string s = Encoding.GetEncoding("GBK").GetString(by);
            //Console.WriteLine(s);




            //将字符串转换为字节
            string str = "莫兴源在打字";
            byte[] byt = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\17100\Desktop\基础\new.txt", byt);
            Console.WriteLine("写入成功");

        }


    }
}
