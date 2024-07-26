using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrRidee
{
    internal class LoadParent
    {
        public void show()   // overloading
        {

            Console.WriteLine("Parent's show method is called");
        }
        public virtual void Test()   // this method is ovveridable
        {
            Console.WriteLine("Parents test method is called");

        }
    }
    class LoadChild : LoadParent
    {
        public void show(int i)
        {

            Console.WriteLine("child's  show method is called");
        }

        public override void Test()
        {
            Console.WriteLine("child's test method is called");

        }
        static void Main(string[] args)
        {
            LoadChild c = new LoadChild();
            c.show();
            c.show(69);
            c.Test();

            Console.ReadLine();
        }
    }
}
