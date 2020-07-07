using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RuleExecutionResult : IRuleExecutionResult
    {
        public string Name { get; set; }
        public object Result { get; set; }
        public Dictionary<string, object> Data { get; set; }
        public IError Error { get; set; }
    }
}
