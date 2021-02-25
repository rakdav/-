using System;
using System.Collections.Generic;
using System.Text;

namespace Пкфттн
{
    class Transaction<T> where T:class
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }
        

    }
}
