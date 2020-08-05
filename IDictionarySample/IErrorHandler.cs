using System;
using System.Collections.Generic;
using System.Text;

namespace IDictionarySample
{
    public interface IErrorHandler
    {
        string GetError(int cod);
    }
}
