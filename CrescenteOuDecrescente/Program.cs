//Problema "crescente" (adaptado de URI 1113)
//Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma
//mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O
//programa deve finalizar quando forem digitados dois valores iguais. 

namespace CrescenteOuDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE!");
                }

                Console.WriteLine("Digite outros dois numeros:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
