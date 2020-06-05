using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreaCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RectanglePage : ContentPage
    {
        public RectanglePage()
        {
            InitializeComponent();
        }

        private void CalculateRectBtn_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(a_RectEntry.Text)) || (String.IsNullOrEmpty(b_RectEntry.Text)) || (a_RectEntry.Text == ",") || (b_RectEntry.Text == ","))
            {
                ErrorRectLbl.Text = "Введённые данные должны быть положительными";
                PerimetrRectLbl.Text = "0";
                AreaRectLbl.Text = "0";
            }

            else
            {    
            float a, b, p, s;

             a = float.Parse(a_RectEntry.Text);
             b = float.Parse(b_RectEntry.Text);

                if ((a > 0) & (b > 0))
                {
                    Rectangle temp = new Rectangle(a, b);
                    p = temp.Perimetr();
                    s = temp.Area();

                    PerimetrRectLbl.Text = p.ToString();
                    AreaRectLbl.Text = s.ToString();
                    ErrorRectLbl.Text = "";
                }

                else
                {
                    ErrorRectLbl.Text = "Введённые данные должны быть положительными";
                    PerimetrRectLbl.Text = "0";
                    AreaRectLbl.Text = "0";
                }
            }
        }
    }
}