using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.PrivateClassData
{
    public class SomeClass
    {

        //private int _int;
        //private string _string;
        private SomeClassData _data;

        public SomeClass(int @int, string @string)
        {
            _data = new SomeClassData(@int, @string);
        }


        public void SomeMethod()
        {
            //_int = 0;
            //_string = "";
            
        }
    }
}
