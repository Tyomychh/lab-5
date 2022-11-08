using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ExelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Постiйно щось читаю");
            Console.WriteLine("Обожнюю наукову лiтературу");
        }

        public override void Study()
        {
            Console.WriteLine("Обожнюю навчатися");
        }

        public override void Relax()
        {
            Console.WriteLine("Навчання це i є мiй вiдпочинок");
        }

        public override void Write()
        {
            Console.WriteLine("Вмiю швидко i грамотно писати");
        }
    }
}
