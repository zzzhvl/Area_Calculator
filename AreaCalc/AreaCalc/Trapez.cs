using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalc
{
    class Trapez : Shape
    {
        public float Base1 { get; set; } //основание 1
        public float Base2 { get; set; } //основание 2
        public float Height { get; set; } //высота

        public Trapez() { }

        public Trapez(float base1, float base2, float height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override float Perimetr()
        {
           return Base1 * 2 + Base2 * 2;
        }

        public override float Area()
        {
            return ((Base1 + Base2) / 2) * Height;
        }
    }


}
