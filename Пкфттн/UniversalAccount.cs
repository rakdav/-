using System;
using System.Collections.Generic;
using System.Text;

namespace Пкфттн
{
    class UniversalAccount<T> : Account<T> where T:class
    {
        public UniversalAccount(T id) : base(id)
        {
        }
    }
}
