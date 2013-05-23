using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestNUnitWeb
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      // initializing the variables and helper classes
      int iNumber1;
      int iNumber2;
      MathsHelper helper = new MathsHelper();

      //Validating the input provided
      if (txtInput1.Text != "" && txtInput2.Text != "")
      {
        try
        {
          //assigning the variables with the input provided
          iNumber1 = int.Parse(txtInput1.Text);
          iNumber2 = int.Parse(txtInput2.Text);


          //performing the addition
          int x = helper.Add(iNumber1, iNumber2);
          lblOutPut.Text = x.ToString();
        }
        catch (Exception ex)
        {
          //returning the error to user
          lblOutPut.Text = "Error : " + ex.Message;
        }
      }
      else
      {
        lblOutPut.Text = "Input provided should be greater than zero";
      }

    }
  }
}