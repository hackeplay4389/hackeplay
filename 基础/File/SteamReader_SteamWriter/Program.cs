using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SteamReader_SteamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用SteamReader读取
            //SteamR();

            //用StreamWrite写入
            SteamW();
                
            Console.ReadKey();


        }

        /// <summary>
        /// 用SteamReader读取
        /// </summary>
        public static void SteamR()
        {
            using (StreamReader steamR=new StreamReader(@"C:\Users\17100\Desktop\基础\new.txt",Encoding.Default))
            {
                while (!steamR.EndOfStream)
                {
                    Console.WriteLine(steamR.ReadLine());
                }
            }


        }

        /// <summary>
        ///用StreamWrite写入
        /// </summary>
        public static void SteamW()
        {

            using (StreamWriter streamw=new StreamWriter(@"C:\Users\17100\Desktop\基础\new1.txt"))
            {

                streamw.Write("这是一个新的TXT文件");
                Console.WriteLine("写入成功");

            }

        }




    }
}
