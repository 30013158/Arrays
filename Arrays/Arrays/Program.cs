using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string[] name = new string[3];

            Console.WriteLine("Please enter the name of  the GOLD medal winner: ");
            name[0] = Console.ReadLine();
            Console.WriteLine("Please enter the name of  the SILVER medal winner: ");
            name[1] = Console.ReadLine();
            Console.WriteLine("Please enter the name of  the BRONZE medal winner: ");
            name[2] = Console.ReadLine();
           
            Console.WriteLine("Which medal winner would you like to see.");
            Console.WriteLine("1 - Gold");
            Console.WriteLine("2 - Silver");
            Console.WriteLine("3 - Bronze");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The medal winner is: {name[num-1]}");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();
            //2nd method
            int result = 0;
            string[] names = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Please enter name {i + 1}: ");
                    names[i] = Console.ReadLine();
            }

            Console.WriteLine("which medal winner would you like to see..\n1 - Gold\n2 - Silver\n3 - Bronze");
            if(int.TryParse(Console.ReadLine(), out result))
            switch (result)
                {    case 1:
                    Console.WriteLine($"Gold medal winner is - {names[result - 1]}");
                    break;
                    case 2:
                    Console.WriteLine($"silver medal winner is - {names[result - 1]}");
                    break;
                   case 3:
                    Console.WriteLine($"bronze medal winner is - {names[result - 1]}");
                    break;
                }
                Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();*/
            //ques3
            Console.WriteLine("******Translator app*********");
            string[] english = new string[5] { "Hello", "Welcome", "Love", "Meeting", "Gift" };
            string[] maori = new string[5] { "Kia Ora", "Haeri Mai", "Koha", "jklj", "Koha" };
            Console.WriteLine("This app can translate the following words: ");
            for( int i=0; i<english.Length; i++)
            { Console.WriteLine($"{i + 1}. {english[i]}"); }
            Console.WriteLine("Which word would you like translate to Maori:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{english[number-1] } translated to maori is: {maori[number-1]}");
            Console.ReadLine();

        }
    }
}
