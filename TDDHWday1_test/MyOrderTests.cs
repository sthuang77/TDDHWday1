using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
//using ExpectedObjects;
//using FluentAssertions;
using System;
using ExpectedObjects;

using FluentAssertions;


namespace TDDHWday1.Tests
{
    [TestClass()]
    public class MyOrderTests
    {

        private IList<OrderCost> GetData()
        {
            return new List<OrderCost>() {
                new OrderCost {Id=1,Cost=1,Revenue=11,SellPrice=21 },
                new OrderCost {Id=2,Cost=2,Revenue=12,SellPrice=22 },
                new OrderCost {Id=3,Cost=3,Revenue=13,SellPrice=23 },
                new OrderCost {Id=4,Cost=4,Revenue=14,SellPrice=24 },
                new OrderCost {Id=5,Cost=5,Revenue=15,SellPrice=25 },
                new OrderCost {Id=6,Cost=6,Revenue=16,SellPrice=26 },
                new OrderCost {Id=7,Cost=7,Revenue=17,SellPrice=27 },
                new OrderCost {Id=8,Cost=8,Revenue=18,SellPrice=28 },
                new OrderCost {Id=9,Cost=9,Revenue=19,SellPrice=29 },
                new OrderCost {Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new OrderCost {Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };
        }


        [TestMethod()]
        public void AddTest_1()
        {
            //3筆一組_取Cost總和結果6,15,24,21
            var target = new OrderCost();
            //'var actual = target.aaaa(3);
            var size = 3;
            var HwName = "Cost";
            var actual = target.Class1sub(GetData(),size, HwName);

            //var expected = new int[] { 6, 15, 24, 21 };
            var expected = new decimal[] { 6, 15, 24, 21 };

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void AddTest_2()
        {
            //4筆一組_取Revenue總和結果50, 66, 60
            var target = new OrderCost();     
            var size = 4;
            var HwName = "Revenue";
            var actual = target.Class1sub(GetData(), size, HwName);
            //var expected = new decimal[] { 510, 66, 60 };
            var expected = new decimal[] { 50, 66, 60 };
            expected.ToExpectedObject().ShouldEqual(actual);


        }

        
    }
}