using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //为了多态，接口不能被实例化，只能通过子类来实现
            IFlyable ifa = new person();
            ifa.fly();

            Console.ReadKey();
        }
    }


    /// <summary>
    /// 一个类继承了接口，就必须实现该接口的所有成员
    /// </summary>
    public class person : IFlyable
    {
        public string name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void fly()
        {
            Console.WriteLine("这个是接口的一个方法");
        }
    }









    /// <summary>
    /// 接口
    /// 注意：接口只能继承接口，不能继承其他
    /// </summary>
    public interface IFlyable
    {
        //接口中不允许有访问修饰符，默认的为 Public
        //接口中可以有方法，自动属性
        void fly();

        string name
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 一个接口可以继承多个接口
    /// </summary>
    public interface IChilderable:IBindable,ITigerable,IPandable
    {
        void Text4();
    }


    /// <summary>
    /// 当一个类继承的是一个含有多个接口的接口时，这个类将必须实现所有接口的方法
    /// 一个类可以同时继承一个类并实现多个接口，如果一个子类同时继承了父类A，并实现了接口IA，那么语法上A必须写在IA的前面
    /// </summary>
    public class car : IChilderable
    {
        public void Text1()
        {
            throw new NotImplementedException();
        }

        public void Text2()
        {
            throw new NotImplementedException();
        }

        public void Text3()
        {
            throw new NotImplementedException();
        }

        public void Text4()
        {
            throw new NotImplementedException();
        }
    }



    public interface IBindable
    {
        void Text1();
    }

    public interface ITigerable
    {
        void Text2();
    }

    public interface IPandable
    {
        void Text3();
    }






}
