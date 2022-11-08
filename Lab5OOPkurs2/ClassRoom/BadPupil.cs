using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Я не читаю");
            Console.WriteLine("Книжки для дурнiв");
        }

        public override void Relax()
        {
            Console.WriteLine("Я піду поганяю м'яча");
        }

        public override void Study()
        {
            Console.WriteLine("Я не люблю навчатися");
        }

        public override void Write()
        {
            Console.WriteLine("Граматика дається мені погано");
        }
    }
}
