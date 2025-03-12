using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330096
{
    internal class FanLaptop
    {
        public enum State { Quiet, Balanced, Performance, Turbo }; //membuat enum untuk state

        public static void run()
        {
            State state = State.Quiet; //inisialisasi value state menjadi Quiet
            string[] screenName = {"Quiet","Balanced","Performance","Turbo" }; //membuat screenName untuk output tiap perubahan state
            bool exit = false; //varible untuk while loop
            while (!exit) //while loop selama exit == false
            {
                Console.WriteLine(screenName[(int)state] + " Screen"); //output screenName berdasarkan state
                Console.Write("Enter Command: "); //input command

                string command = Console.ReadLine(); //set command

                switch (state) //switch berdasarkan state
                {
                    //case berdasarkan state sesuai dengan soal. di tiap case dan if command, akan merubah state sesuai dengan soal.
                    case State.Quiet:
                        if(command == "Turbo Shortcut")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Turbo");
                            state = State.Turbo;
                        } else if (command == "Mode Up")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Balanced");
                            state = State.Balanced;
                        }
                        break;
                    case State.Balanced:
                        if (command == "Mode Up")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Performance");
                            state = State.Performance;
                        }
                        else if (command == "Mode Down")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Quiet");
                            state = State.Quiet;
                        }
                        break;
                    case State.Performance:
                        if (command == "Mode Up")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Turbo");
                            state = State.Turbo;
                        }
                        else if (command == "Mode Down")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Balanced");
                            state = State.Balanced;
                        }
                        break;
                    case State.Turbo:
                        if (command == "Turbo Shortcut")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Quiet");
                            state = State.Quiet;
                        }
                        else if (command == "Mode Down")
                        {
                            Console.WriteLine($"Fan {state} berubah menjadi Performance");
                            state = State.Performance;
                        }
                        break;
                }
                if (command == "Exit") // if command == exit, exit akan menjadi true dan program berhenti
                {
                    exit = true;
                }
            }
            
        }
    }
}
