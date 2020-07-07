using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BusinessRule
{
    public class BookBusiness<T> : IBusinessRule<T>
    {
        public BookBusiness()
        {
                
        }
        public IRuleExecutionResult ExecuteRule(T ruleModel)
        {
            throw new NotImplementedException();
        }
    }
}
