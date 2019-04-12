using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavlovDmitryHome2_3
{

    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupils)
        {
            this.pupils[0] = pupils;
        }
        public ClassRoom(Pupil pupils1, Pupil pupils2)
        {
            pupils[0] = pupils1;
            pupils[1] = pupils2;
        }
        public ClassRoom(Pupil pupils1, Pupil pupils2, Pupil pupils3)
        {
            pupils[0] = pupils1; 
            pupils[1] = pupils2;
            pupils[2] = pupils3;
        }
        public ClassRoom(Pupil pupils1, Pupil pupils2, Pupil pupils3, Pupil pupils4)
        {
            pupils[0] = pupils1;
            pupils[1] = pupils2;
            pupils[2] = pupils3;
            pupils[3] = pupils4;
        }

        public void ViewClassInfo()
        {
            int i = 0;
            while (i <  pupils.Length )
            {
                pupils[i].Study(pupils[i]);
                pupils[i].Relax(pupils[i]);
                pupils[i].Read(pupils[i]);
                pupils[i].Write( pupils[i]);
                Console.WriteLine(new string('-', 30));
                i++;
            }
        }
    }
    class Pupil
    {
        public virtual void Study(Pupil p)
        {
            Console.WriteLine(p + " Pupil study");
        }
        public virtual void Read(Pupil p)
        {
            Console.WriteLine(p + " Pupil read");
        }
        public virtual void Write(Pupil p)
        {
            Console.WriteLine(p + " Pupil write");
        }
        public virtual void Relax(Pupil p)
        {
            Console.WriteLine(p + " Pupil relax");
        }
    }
    class ExcelentPupil:Pupil
    {
        public override void Study(Pupil p)
        {
            Console.WriteLine(p + " ExcelentPupil study");
        }
        public override void Read(Pupil p)
        {
            Console.WriteLine(p + " ExcelentPupil read");
        }
        public override void Write(Pupil p)
        {
            Console.WriteLine(p + " ExcelentPupil write");
        }
        public override void Relax(Pupil p)
        {
            Console.WriteLine(p + " ExcelentPupil relax");
        }
    }

    class GoodPupil :Pupil
    {
        public override void Study(Pupil p)
        {
            Console.WriteLine(p + " GoodPupil study");
        }
        public override void Read(Pupil p)
        {
            Console.WriteLine(p + " GoodPupil read");
        }
        public override void Write(Pupil p)
        {
            Console.WriteLine(p + " GoodPupil write");
        }
        public override void Relax(Pupil p)
        {
            Console.WriteLine(p + " GoodPupil relax");
        }
    }

    class BadPupil:Pupil
    {
        public override void Study(Pupil p)
        {
            Console.WriteLine(p + " BadPupil study");
        }
        public override void Read(Pupil p)
        {
            Console.WriteLine(p + " BadPupil read");
        }
        public override void Write(Pupil p)
        {
            Console.WriteLine(p + " BadPupil write");
        }
        public override void Relax(Pupil p)
        {
            Console.WriteLine(p + " BadPupil relax");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupils = new Pupil();
            Pupil pupils1 = new ExcelentPupil();
            Pupil pupils2 = new BadPupil();
            Pupil pupils3 = new GoodPupil();

            ClassRoom A1 = new ClassRoom(pupils);
            ClassRoom B1 = new ClassRoom(pupils1,pupils2);
            ClassRoom C1 = new ClassRoom(pupils1, pupils2, pupils3);
            ClassRoom D1 = new ClassRoom(pupils1, pupils2, pupils3,pupils);

            A1.ViewClassInfo();
            B1.ViewClassInfo();
            C1.ViewClassInfo();
            D1.ViewClassInfo();

            Console.ReadKey();
        }
    }
}
