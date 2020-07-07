using RuleEngineConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BusinessRule
{
    public class UpgradeMembershipBusiness<Membership> : IBusinessRule<Membership>
    {
        public IRuleExecutionResult ExecuteRule(Membership model)
        {
            throw new NotImplementedException();
        }
    }
}
