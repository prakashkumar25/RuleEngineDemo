using ConsoleApp1;
using ConsoleApp1.BusinessRule;
using RuleEngineConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RuleEngineTests
{
    public class PaymentRuleEngineTest
    {
        [Fact]
        public void GetRuleInstance_ValidRule_ReturnsPaymentForBookRef()
        {
            //Arrange
            var ruleType = RuleType.PaymentForBook;
            var paymentruleEngine = new PaymentRuleEngine<Book>(new BookBusiness<Book>());

            //Act
            var instance = paymentruleEngine.GetRuleInstance(ruleType);

            //Assert
            Assert.IsType<BookBusiness<Book>>(instance);
        }
    }
}
