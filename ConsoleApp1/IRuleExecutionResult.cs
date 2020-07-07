using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IRuleExecutionResult
    {
        string Name { get; set; }
        object Result { get; set; }
        Dictionary<string, object> Data { get; set; }
        IError Error { get; set; }
    }
}
