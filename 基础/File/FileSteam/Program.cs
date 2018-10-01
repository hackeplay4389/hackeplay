using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSteams
{
    class Program
    {

        static void Main(string[] args)
        {
            //读取
            //FileR();

            //写入
            //FileW();


            //复制
            FileC();
            Console.ReadKey();


        }

        /// <summary>
        /// 使用FileStream来读取数据
        /// </summary>
        public static void FileR()
        {

            FileStream file = new FileStream(@"C:\Users\17100\Desktop\基础\File引用.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //返回本次实际读取到的有效字节数
            int r = file.Read(buffer, 0, buffer.Length);
            //将字节数组中每个元素按照指定的编码格式解码成字符串
            string str = Encoding.Default.GetString(buffer, 0, r);
            //关闭流
            file.Close();
            //释放流所占用的资源
            file.Dispose();
            Console.WriteLine(str);

        }


        /// <summary>
        /// 用FileStream来写入数据
        /// </summary>
        public static void FileW()
        {

            using (FileStream file = new FileStream(@"C:\Users\17100\Desktop\基础\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "这是一段很长的字符串";
                byte[] by = Encoding.Default.GetBytes(str);
                file.Write(by,0,by.Length);

            }
            Console.WriteLine("写入成功");

        }


        /// <summary>
        /// 复制文件
        /// </summary>
        public static void FileC()
        {
            //思路：先把要复制的文件进行读取，然后写入一个文件
            string strsouss = @"C:\Users\17100\Desktop\打上花火.mp4";
            string strcout = @"C:\Users\17100\Desktop\new.mp4";
            //创建一个按照读取的流
            using (FileStream fsread=new FileStream(strsouss,FileMode.Open,FileAccess.Read))
            {
                //创建一个写入的流
                using (FileStream fswrite = new FileStream(strcout,FileMode.OpenOrCreate,FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能比较大，所以我们在读取的时候，因该通过一个循环读取
                    while (true)
                    {
                        int i = fsread.Read(buffer, 0, buffer.Length);
                        //当i的值变成0时，就意味着什么都没读取到
                        if (i==0)
                        {
                            break;
                        }
                        fswrite.Write(buffer,0,i);
                    }


                 }
            }
        }



    }
}
