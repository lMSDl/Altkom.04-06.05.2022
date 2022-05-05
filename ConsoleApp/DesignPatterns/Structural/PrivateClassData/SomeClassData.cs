using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.PrivateClassData
{
    public class SomeClassData
    {
        private int _int;
        private string _string;

        public SomeClassData(int @int, string @string)
        {
            _int = @int;
            _string = @string;
        }

        public int GetInt()
        {
            return _int;
        }

        public string GetString()
        {
            return _string;
        }
    }
}
