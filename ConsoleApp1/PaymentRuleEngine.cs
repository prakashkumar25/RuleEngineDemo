using ConsoleApp1.BusinessRule;
using ConsoleApp1.Exception;
using RuleEngineConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PaymentRuleEngine<T> : IPaymentRuleEngine<T>
    {
        private readonly IBusinessRule<T> businessRuleInstance;
        private BookBusiness<Book> bookBusiness;

        public PaymentRuleEngine(IBusinessRule<T> businessRule)
        {
            businessRuleInstance = businessRule;

        }

        public PaymentRuleEngine(BookBusiness<Book> bookBusiness)
        {
            this.bookBusiness = bookBusiness;
        }

        public IRuleExecutionResult ExecuteRule(T rule)
        {
            return businessRuleInstance.ExecuteRule(rule);
        }

        public IBusinessRule<T> GetRuleInstance(RuleType ruleType)
        {
            switch (ruleType)
            {
                case RuleType.PaymentForBook:
                    return new BookBusiness<T>();
                case RuleType.PaymentForMembership:
                    return new MembershipBusiness<T>();
                case RuleType.PaymentForMembershipOrUpgrade:
                    return new MembershipOrUpgradeBusiness<T>();
                case RuleType.PaymentForPhysicalProduct:
                    return new PhysicalProductBusiness<T>();
                case RuleType.PaymentForVideoLearningToSki:
                    return new VideoLearningToSkiBusiness<T>();
                default:
                    throw new Exception.UnsupportedRuleException("UnKnown Rule type.");
            }
        }
    }
}
