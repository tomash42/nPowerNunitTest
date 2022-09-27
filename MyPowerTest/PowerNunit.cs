using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyPower;

namespace MyPowerTest
{
    public class PowerNunit
    {
        Power pwr;
        [SetUp]
        public void Setup()
        {
        
            pwr = new Power();
        }
        [Test]
        public void Power_2_of_2_ShouldReturn_4()
        {
            //arrange
            //acct
            var res = pwr.PowerCalc(10, 2);
            //assert
            Assert.AreEqual(100, res);

        }
        [Test]
        public void Power_minus2_of_3_ShouldReturn_minus8()
        {
            //arrange
            //acct
            var res = pwr.PowerCalc(-2, 3);
            //assert
            Assert.AreEqual(-8, res);

        }[Test]
        public void Power_154_of_0_ShouldReturn_1()
        {
            //arrange
            //acct
            var res = pwr.PowerCalc(154, 0);
            //assert
            Assert.AreEqual(1, res);

        }      
        [Test]
        public void Power_0_of_745_ShouldReturn_0()
        {
            //arrange
            //acct
            var res = pwr.PowerCalc(0, 754);
            //assert
            Assert.AreEqual(0, res);
        
        }     
        [Test]
        public void Power_2_of_mins3_ShouldReturnMInus3()
        {
            //arrange
            //acct
          
            //assert
          
            Assert.Throws<ArgumentOutOfRangeException>(()=> {
                pwr.PowerCalc(2,-3);
            });
        
        }
    }
}
