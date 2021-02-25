using System;
using System.Collections.Generic;
using System.Text;

namespace Пкфттн
{
    class Account<T>
    {
        public T Id { get; private set; }
        public int Sum { get; set; }

        public Account(T id)
        {
            this.Id = id;
        }
    }
}
