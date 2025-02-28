using System;
using System.Formats.Asn1;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool Answer = false;
            while (Answer==false)
            {
                Console.WriteLine("Insira a questão ou digite EXIT para terminar:");
                string userQuestion = Console.ReadLine();
                if (userQuestion == "EXIT")
                {
                    Answer = true;
                }
                else if ( userQuestion == "Oi, como saio deste looping?")
                {
                    Console.WriteLine("Pode deixar que eu fecho para você.");
                    Answer = true;
                }
                else if (userQuestion == "Qual e o seu nome?")
                {
                    Console.WriteLine("Meu nome é ChatGPTOne. Adeus.");
                    Answer = true;
                }
                else if (userQuestion == "Qual e a sua idade?")
                {
                    Console.WriteLine("Olha, eu acabei de ser escrito, entao provavelmente tenho menos de 1 mes...");
                    Answer = true;
                }
                else if (userQuestion == "Sera que eu vou passar nesta cadeira?")
                {
                    Console.WriteLine("Olha rapaz... boa sorte");
                    Answer = true;
                }
                else 
                {
                    Console.WriteLine("Desculpe, não sei responder a esta questão.");
                    Answer = false;
                }
            }
        }
    }
}
