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
    public partial class CirclePage : ContentPage
    {
        public CirclePage()
        {
            InitializeComponent();
        }

        private void CalculateCircleBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(R_CircleEntry.Text) || (R_CircleEntry.Text == ","))
            {
                ErrorCircleLbl.Text = "Введённые данные должны быть положительными";
                PerimetrCircleLbl.Text = "0";
                AreaCircleLbl.Text = "0";
            }

            else
            {
                float r, p, s;

                r = float.Parse(R_CircleEntry.Text);

                if (r > 0)
                {
                    Circle temp = new Circle(r);
                    p = temp.Perimetr();
                    s = temp.Area();

                    PerimetrCircleLbl.Text = p.ToString();
                    AreaCircleLbl.Text = s.ToString();
                    ErrorCircleLbl.Text = "";
                }

                else
                {
                    ErrorCircleLbl.Text = "Введённые данные должны быть положительными";
                    PerimetrCircleLbl.Text = "0";
                    AreaCircleLbl.Text = "0";
                }
            }
        }
    }
}