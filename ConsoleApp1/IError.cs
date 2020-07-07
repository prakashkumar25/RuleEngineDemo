using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Custom Error interface
    /// </summary>
    public interface IError
    {
        string Message { get; set; }
        System.Exception Exception { get; set; }
    }
}
