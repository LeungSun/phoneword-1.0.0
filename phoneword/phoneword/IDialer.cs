using System;
using System.Collections.Generic;
using System.Text;

namespace phoneword
{
    namespace Phoneword
    {
        public interface IDialer
        {
            bool Dial(string number);
        }
    }
}