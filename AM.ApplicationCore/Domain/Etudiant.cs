using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Etudiant : Person
    {
        public int Matricule { get; set; }
        public string Specialite { get; set; }

        // override bsh madech nchoufou el methode de classe mere w lezem nzidou virtuel lel methode mere 
        public override void getMyType()
        {
            Console.WriteLine("I'am a student");
        }
    }
}
