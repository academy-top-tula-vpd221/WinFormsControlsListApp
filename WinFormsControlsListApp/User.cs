using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControlsListApp
{
    internal class User
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
