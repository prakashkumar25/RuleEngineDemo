using ConsoleApp1.BusinessRule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPaymentRuleEngine<T>
    {
        public IRuleExecutionResult ExecuteRule(T rule);
        public IBusinessRule<T> GetRuleInstance(RuleType ruleType);
    }
}
