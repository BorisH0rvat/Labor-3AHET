using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
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
            private bool inStore = true;

            public void SetDescription(string description)
            {
                this.description = description;
            }
            public void SetNumber(int number)
            {
                this.number = number;
            }
            public int GetNumber()
            {
                return this.number;
            }
            public bool GetStatus()
            {
                return this.inStore;
            }
            public void SetStatus(bool inStore)
            {
                this.inStore = inStore;
            }
            public void Print()
            {
                Console.WriteLine("{0} {1} Im Lager: {2}", description, number, inStore);
            }
        }
        static void Main(string[] args)
        {
            List<Tool> tools = new List<Tool>();
            tools.Add(new Tool());
            tools.Add(new Tool());
            tools.Add(new Tool());


            string toolDescription;
            int toolNumber;
            int searchNumber;
            
            tools[0].SetDescription("Schraubendreher");
            tools[0].SetNumber(8892);
            tools[0].SetStatus(true);
            

            tools[1].SetDescription("Wasserwaage");
            tools[1].SetNumber(19828);
            tools[1].SetStatus(true);
            

            tools[2].SetDescription("Schraubendreher");
            tools[2].SetNumber(64938);
            tools[2].SetStatus(true);
            

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
                    case 'l':
                    case 'L':
                        foreach (Tool t in tools)
                        {
                            t.Print();
                        }
                        break;
                    case 'h':
                    case 'H': 
                        toolDescription = Console.ReadLine();
                        toolNumber = Console.Read();
                        tools.Add(new Tool());
                        tools[tools.Count].SetDescription(toolDescription);
                        tools[tools.Count].SetNumber(toolNumber);
                        tools[tools.Count].SetStatus(true);
                        break;
                    case 'a':
                    case 'A':
                        Console.WriteLine("Ausleihen (Inventarnummer): ");
                        searchNumber = int.Parse(Console.ReadLine());
                        int i = 0;
                        int foundNum;
                        bool found = false;
                        int number;
                        do
                        {
                            if (tools[i].GetNumber() == searchNumber)
                            {
                                found = true;
                                foundNum = i;
                            }
                        } while ((i <= tools.Count) || (found = false));
                        if (found = false)
                        {
                            Console.WriteLine("Es wurde nichts gefunden.");
                        }
                        else if (found  = true)
                        {

                        }
                            break;
                }
            } while (stayalive == true);
        }
    }
}
