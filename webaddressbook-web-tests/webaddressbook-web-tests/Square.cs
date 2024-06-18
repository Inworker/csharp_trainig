using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webaddressbook_web_tests
{
    class Square
    {
        private int size;
        public Square(int size)
        { this.size = size; 
        }

        public int getSize()
            { return size; }
        public void setSize(int size) 
        { 
            this.size = size;
        }
    }
}
