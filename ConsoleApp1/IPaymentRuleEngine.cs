using ConsoleApp1.BusinessRule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPaymentRuleEngine
    {
        public void ExecuteRule(IBusinessRule rule);
        public IBusinessRule GetRuleInstance(RuleType ruleType);
    }
}
