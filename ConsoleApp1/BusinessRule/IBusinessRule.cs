using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BusinessRule
{
    public interface IBusinessRule<T>
    {
        public IRuleExecutionResult ExecuteRule(T ruleModel);
    }
}
