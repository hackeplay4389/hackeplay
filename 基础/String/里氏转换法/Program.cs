using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换法
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个数组，将所有的类放进去
            Person[] pers = new Person[10];
            Random rs = new Random();
            for (int i=0;i<pers.Length;i++)
            {
                int number = rs.Next(1,7);
                switch (number)
                {
                    case 1:pers[i] = new Student();
                        break;
                    case 2:pers[i] = new Teacher();
                        break;
                    case 3:pers[i] = new ShuaiGou();
                        break;
                    case 4:pers[i] = new MeiLv();
                        break;
                    case 5:pers[i] = new YeShou();
                        break;
                    case 6:pers[i] = new Person();
                        break;
                }

            }

            for (int j=0;j<pers.Length;j++)
            {
                if (pers[j] is Student)
                {
                    ((Student)pers[j]).StudentSayHi();
                } else if (pers[j] is Teacher)
                {
                    ((Teacher)pers[j]).TeacherSayHi();
                } else if (pers[j] is MeiLv)
                {
                    ((MeiLv)pers[j]).MeiLvSayHi();
                } else if (pers[j] is ShuaiGou)
                {
                    ((ShuaiGou)pers[j]).ShuaiGuoHi();
                } else if (pers[j] is YeShou)
                {
                    ((YeShou)pers[j]).YeShouSayHi();
                }
                else
                {
                    pers[j].PersonSayHi();
                }

            }





            Console.ReadKey();


        }
    }



    public class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("我是人类");

        }
    }


    public class Student : Person
    {

        public void StudentSayHi()
        {

            Console.WriteLine("我是学生");
        }
    }
    

    public class Teacher : Person
    {

        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }

    }
    

    public class MeiLv : Person
    {
        public void MeiLvSayHi()
        {
            Console.WriteLine("我是美女");
        }
    }


    public class ShuaiGou:Person
    {
        public void ShuaiGuoHi()
        {
            Console.WriteLine("我是帅哥");
        }
    }


    public class YeShou : Person
    {
        public void YeShouSayHi()
        {
            Console.WriteLine("我是野兽");
        }
    }









}
