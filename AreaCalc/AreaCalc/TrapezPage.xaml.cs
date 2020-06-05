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
    public partial class TrapezPage : ContentPage
    {
        public TrapezPage()
        {
            InitializeComponent();
        }

        private void CalculateTrapezBtn_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(a_TrapezEntry.Text)) || (String.IsNullOrEmpty(b_TrapezEntry.Text)) || (String.IsNullOrEmpty(h_TrapezEntry.Text)) || (a_TrapezEntry.Text == ",") || (b_TrapezEntry.Text == ",") || (h_TrapezEntry.Text == ","))
            {
                ErroTrapezLbl.Text = "Введённые данные должны быть положительными";
                PerimetrTrapezLbl.Text = "0";
                AreaTrapezLbl.Text = "0";
            }

            else
            {
                float a, b, h, p, s;

                a = float.Parse(a_TrapezEntry.Text);
                b = float.Parse(b_TrapezEntry.Text);
                h = float.Parse(h_TrapezEntry.Text);

                if ((a > 0) & (b > 0) & (h > 0))
                {
                    Trapez temp = new Trapez(a, b, h);
                    p = temp.Perimetr();
                    s = temp.Area();

                    PerimetrTrapezLbl.Text = p.ToString();
                    AreaTrapezLbl.Text = s.ToString();
                    ErroTrapezLbl.Text = "";
                }

                else
                {
                    ErroTrapezLbl.Text = "Введённые данные должны быть положительными";
                    PerimetrTrapezLbl.Text = "0";
                    AreaTrapezLbl.Text = "0";
                }
            }
        }
    }
}