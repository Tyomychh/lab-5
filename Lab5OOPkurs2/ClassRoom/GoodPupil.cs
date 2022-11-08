using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Iнколи читаю");
            Console.WriteLine("Люблю художню лiтературу");
        }

        public override void Relax()
        {
            Console.WriteLine("Прогулююсь слухаючи музику");
        }

        public override void Study()
        {
            Console.WriteLine("Я хороший учень");

        }

        public override void Write()
        {
            Console.WriteLine("Вмію швидко писати");
        }
    }
}
