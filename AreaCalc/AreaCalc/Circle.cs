using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalc
{
    class Circle : Shape
    {
        public float Radius { get; set; } //радиус

        public Circle() { }

        public Circle(float radius)
        {
            Radius = radius;
        }


        public override float Perimetr()
        {
            return 2 * (float)Math.PI * Radius;
        }

        public override float Area()
        {
            return (float)Math.PI * (Radius * Radius);
        }
    }
}
