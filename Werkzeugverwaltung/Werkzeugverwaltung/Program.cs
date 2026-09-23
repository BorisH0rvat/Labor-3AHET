using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkzeugverwaltung
{
    internal class Program
    {
        class Tool
        {
            private string description;
            private int number;
            private bool inStore;

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public void SetNumber(int number)
            {
                this.number = number;
            }

            public void SetStatus(bool inStore)
            {
                this.inStore = inStore;
            }
            public void Print()
            {
                Console.WriteLine("{0} {1}", description, number);
                Console.Write("Im Lager: {0}", inStore);
            }
        }
        static void Main(string[] args)
        {
            int x = 12;
            Tool s1 = new Tool();
            Tool s2 = new Tool();
            Tool s3 = new Tool();
            s1.SetDescription("Schraubendreher");
            s2.SetDescription("Wasserwaage");
            s3.SetDescription("Schraubendreher");

            
            s1.SetNumber(8892);
            s2.SetNumber(19828);
            s3.SetNumber(64938);

            s1.SetStatus(true);
            s2.SetStatus(true);
            s3.SetStatus(true);

            s1.Print();
            s2.Print();
            s3.Print();

            Console.ReadKey();

            bool stayalive = true;
            char auswahl;
            do
            {
                Console.WriteLine("Werkzeug auflisten [l]");
                Console.WriteLine("Werkzeug hinzufügen [h]");
                Console.WriteLine("Werkzeug ausleihen [a]");
                Console.WriteLine("Werkzeug retournieren [r]");
                Console.WriteLine("Beenden [b]");

                auswahl = Console.ReadKey().KeyChar;

                switch (auswahl)
                {
                    case 'B':
                    case 'b': stayalive = false; break;
                }
            } while (stayalive == true);
        }
    }
}
