using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
            finalGrade.Text = "Submit your grade percentage to see your final grade!";
        }
        protected void ComputeFinalGrade(object sender, EventArgs e)
        {
            try
            {
                double rawGrade = double.Parse(percentageGrade.Text);
                if (rawGrade <= 100 && rawGrade > 96)
                {
                    Response.Write($"<script>alert('Your Final Grade is 1.00!')</script>");
                    finalGrade.Text = "1.00";
                }
                else if (rawGrade <= 96 && rawGrade >= 91.51)
                {
                    finalGrade.Text = "1.25";
                }
                else if (rawGrade <= 91.50 && rawGrade >= 87.01)
                {
                    finalGrade.Text = "1.50";
                }
                else if (rawGrade <= 87 && rawGrade >= 82.51)
                {
                    finalGrade.Text = "1.75";
                }
                else if (rawGrade <= 82.50 && rawGrade >= 78.01)
                {
                    finalGrade.Text = "2.00";
                }
                else if (rawGrade <= 78 && rawGrade >= 73.51)
                {
                    finalGrade.Text = "2.25";
                }
                else if (rawGrade <= 73.50 && rawGrade >= 69.01)
                {
                    finalGrade.Text = "2.50";
                }
                else if (rawGrade <= 69 && rawGrade >= 64.51)
                {
                    finalGrade.Text = "2.75";
                }
                else if (rawGrade <= 64.50 && rawGrade >= 60.00)
                {
                    finalGrade.Text = "3.00";
                }
                else if (rawGrade <= 60 && rawGrade >= 0)
                {
                    finalGrade.Text = "5.00";
                }
                else {
                    Response.Write($"<script>alert('Please a number between 0-100.')</script>");
                }
            }
            catch {
                Response.Write($"<script>alert('Invalid Input.')</script>");
            }
        }
    }
}
