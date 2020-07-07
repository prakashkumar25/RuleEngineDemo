using ConsoleApp1.BusinessRule;
using ConsoleApp1.Exception;
using DotNetRuleEngine;
using DotNetRuleEngine.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PaymentRuleEngine : IPaymentRuleEngine
    {
        private readonly IBusinessRule businessRuleInstance;
        public PaymentRuleEngine(IBusinessRule businessRule)
        {
            businessRuleInstance = businessRule;

        }
        public void ExecuteRule(IBusinessRule rule)
        {
            businessRuleInstance.ExecuteRule();
        }

        public IBusinessRule GetRuleInstance(RuleType ruleType)
        {
            switch (ruleType)
            {
                case RuleType.PaymentForBook:
                    return new BookBusiness();
                case RuleType.PaymentForMembership:
                    return new MembershipBusiness();
                case RuleType.PaymentForMembershipOrUpgrade:
                    return new MembershipOrUpgradeBusiness();
                case RuleType.PaymentForPhysicalProduct:
                    return new PhysicalProductBusiness();
                case RuleType.PaymentForVideoLearningToSki:
                    return new VideoLearningToSkiBusiness();
                default:
                    throw new Exception.UnsupportedRuleException("UnKnown Rule type.");
            }
        }
    }
}
