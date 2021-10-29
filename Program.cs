using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void PreStart(int time) // funçao que faz a pré-contagem
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }

        static void Start(int time) // funçao que faz a contagem
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }

        static void Menu() // Menu da aplicação
        {
            Console.Clear();

            Console.WriteLine("Olá! Quanto tempo deseja contar?");
            Console.WriteLine("S = Segundo => 1s => 1 segundo");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // identifica se o dado está em segundos ou minutos pelo último caractere
            int time = int.Parse(data.Substring(0, data.Length - 1)); // separa o número da unidade de contagem
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            i

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

    }
}
