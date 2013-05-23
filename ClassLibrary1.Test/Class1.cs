using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using TestNUnitWeb;


namespace TestNUnitWeb_test.Test
{
  [TestFixture]
    public class Class1
    {
      [TestCase]
      public void AddTestCorrect()
      {
        MathsHelper helper = new MathsHelper();
        int result = helper.Add(20, 10);
        Assert.AreEqual(30, result);
      }

      [TestCase]
      public void AddTestIncorrect()
      {
        MathsHelper helper = new MathsHelper();
        int result = helper.Add(20, 10);
        Assert.AreEqual(40, result);
      }

    
    }
}
