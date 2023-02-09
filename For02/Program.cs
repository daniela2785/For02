using System;
using System.Globalization;


namespace For02
{
    class Program
    {
        static void Main(string[] args)
        {

            //02
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++){
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++){
                if (vet[i] % 2 == 0){
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            int quantidade = 0;
            for (int i = 0; i < N; i++){
                if (vet[i] % 2 == 0) {
                    quantidade++;
                }
            }

            Console.Write(quantidade);

        }
    }
}
