using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal interface IInterface
    {
        public void Method1();
        protected void Method3();
        internal void Method4();
        abstract void Method5();
    }
}
