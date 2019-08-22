using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace errorHandlingExample
{
    public partial class Defult : System.Web.UI.Page
    {
        protected void Sum_Click(object sender, EventArgs e)
        {
            Trace.Write("Button Clicked", "Button was Clicked");

            int x;
            int y;
            int answer;
            if (int.TryParse(Number1.Text, out x) == true && int.TryParse(Number2.Text, out y) == true)
            {
                answer = x + y;
                Result.Text = answer.ToString();

                Trace.Write("Result Written", $"{answer}");

                System.Diagnostics.Debug.Assert(answer != 21);
            }
            else
            {
                Result.Text = "Error";

                Trace.Warn("Button Clicked", "Could not parse both as numbers.");
            }
        }
    }
}
