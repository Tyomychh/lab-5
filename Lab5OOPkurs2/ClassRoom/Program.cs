using System;
using System.Collections.Generic;

namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExelentPupil exelentPupil = new ExelentPupil();
            BadPupil badPupil1 = new BadPupil();
            GoodPupil goodPupil1 = new GoodPupil();
            GoodPupil goodPupil2 = new GoodPupil();
            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(exelentPupil);
            pupils.Add(goodPupil1);
            pupils.Add(goodPupil2);
            pupils.Add(badPupil1);
            ClassRoom classRoom = new ClassRoom(pupils);
            classRoom.InfoAboutClassRoom();
        }
    }
}
