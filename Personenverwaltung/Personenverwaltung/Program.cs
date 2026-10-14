using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Person> person = new List<Person> ();

            for (int i = 0; i < 10; i++)
            {
                person.Add(new Person());
            }

            person[0].SetName("Anna Gruber");
            person[0].SetBirthday(12);
            person[0].SetBirthMonth(03);
            person[0].SetBirthYear(1985);
            person[0].SetCountry("Österreich");
            person[0].SetPostalcode(3830);
            person[0].SetCity("Waidhofen an der Thaya");
            person[0].SetAddress("Hauptplatz 5");
        }
    }
}
