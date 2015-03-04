using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calc;
using NUnit.Framework;

namespace Nunit_MVC_Calc_Test
{
    [TestFixture]
    public class Division_Test
    {
        Calc_Controller c = new Calc_Controller();

        [TestCase]
        public void DivisionOfTwoPositiveNumber()
        {
            int result;
            result = c.div(10, 5);
            Assert.AreEqual(2m, result, "Division of two positive number failed");
        }

        [TestCase]
        public void DivisionOfOnePositiveOneNegativeNumber()
        {
            int result;
            result = c.div(-10, 5);
            Assert.AreEqual(-2m, result, "Division of one positive one negative number failed");
        }

        [TestCase]
        public void DivisionOfTwoNegativeNumber()
        {
            int result;
            result = c.div(-10, -5);
            Assert.AreEqual(2m, result, "Division of two neagtive number failed");
        }

        [TestCase]
        public void DivisionOfOneNumberOneCharacter()
        {
            int result;
            result = c.div('a', 5);
            Assert.AreEqual(19m, result, "Division of one Number and one character failed");
        }


        [TestCase]
        public void DivisionOfTwoCharacter()
        {
            int result;
            result = c.div('a', 'b');
            Assert.AreEqual(0m, result, "Division of two Character failed");
        }
    }
}
