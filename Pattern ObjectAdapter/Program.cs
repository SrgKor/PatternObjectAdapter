using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_ObjectAdapter
{

    class Program
    {
        static void Main()
        {
            ITargetInterface s;
            Adaptee adaptee = new Adaptee();
            ObjectAdapter adapter = new ObjectAdapter(adaptee);
            s = adapter;
            s.targetMethod();

        }
    }

        interface ITargetInterface
        {
            void targetMethod();
        }

        class ObjectAdapter : ITargetInterface
        {
            public ObjectAdapter(Adaptee adaptee)
            {
                this.adaptee = adaptee;
            }

            private Adaptee adaptee;

            public void targetMethod() //вызов метода через целевой интерфейсный метод
            {
                adaptee.method();
            }
        }

        class Adaptee   
        {
            public void method()
            {
                Console.WriteLine("Наш метод");
                Console.ReadLine();
            }
        }

        
    
}
