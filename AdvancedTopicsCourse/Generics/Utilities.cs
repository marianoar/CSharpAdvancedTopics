using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //where T: IComparable
    //where T: Product
    //where T: struct
    //where T: class
    //where T: new ()
    public class Utilities<T> where T: new() // <T> where T: IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //generics version
        public T Max<T>(T a, T b) where T: IComparable // esto puede ir a nivel de clase
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
