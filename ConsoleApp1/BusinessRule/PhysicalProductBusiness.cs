using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BusinessRule
{
    public class PhysicalProductBusiness<PhysicalProduct>: IBusinessRule<PhysicalProduct>
    {
        public IRuleExecutionResult ExecuteRule(PhysicalProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
