﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestNUnitWeb
{
  public class MathsHelper
  {
    public MathsHelper() { }
    public int Add(int a, int b)
    {
      int x = a + b;
      return x;
    }

    public int Subtract(int a, int b)
    {
      int x = a - b;
      return x;
    }
  }
}