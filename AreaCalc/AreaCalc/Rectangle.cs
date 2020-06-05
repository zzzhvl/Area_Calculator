using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalc
{
    class Rectangle : Shape
    {
        public float Lenght { get; set; } //длина
        public float Windth { get; set; } //ширина

        public Rectangle() { }

        //перепределение полей
        public Rectangle(float lenght, float windth)
        {
            Lenght = lenght;
            Windth = windth;
        }

        // переопределение метода "Периметр"
        public override float Perimetr()
        {
            return Lenght * 2 + Windth * 2;
        }

        // переопределение метода "Площадь"
        public override float Area()
        {
            return Lenght * Windth;
        }
    }
}
