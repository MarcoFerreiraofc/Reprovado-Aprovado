using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string situacao = "";

            Console.WriteLine("Digite sua primeira nota"); 
            double nota1 = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite sua segunda nota"); 
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if(media > 7){ 
                situacao = "Aprovado"; 
            }
            else{ 
                situacao = "Reprovado";
            }

            Console.WriteLine(situacao);
        }
    }
}
