using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiant
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "这个帅气的小伙是老蒋吗？";
            if (str.Contains("老蒋"))//检查字符串中是否有关键的文字
            {
               str= str.Replace("老蒋","**");//将老蒋替换成**
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

        



    }
}
