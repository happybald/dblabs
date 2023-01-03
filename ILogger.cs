using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    interface ILogger
    {
        void LogError(string message);
        void LogError(string message, Exception exception, bool printStackTrace = false);
    }
}
