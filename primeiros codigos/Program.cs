using System;
using System.Collections.Generic;
using System.Drawing;

namespace primeiros_codigos
{
class Program
    {
    static void Main(string[] args)
        {
            string palavra1 = "buceta";
            Console.WriteLine("Hello World! " + palavra1);

            Console.WriteLine($"A palavra {palavra1} Tem exatamente " + palavra1.Length + " Caracteres");
            Console.WriteLine("------------------------------------------------------------");

            int num1 = 50;
            int num2 = 20;
            int num3 = 50;

            Console.WriteLine($"Olha, Temos aqui {num1} e {num2} e {num3}, e agora Vamos somar essa porra");
            Console.WriteLine("Preparado? não? nem eu, mas vamos");
            Console.Write("");

            Console.WriteLine("------------------------------------------------------------");


            int total = num1 + num2 + num3;
            Console.WriteLine("Cara, deu exatamente: " + total);

            if (total > 90)
            {
                Console.WriteLine("O Total é maior que 90 rsrs, bora fuder???");
            }
            else
            {
                Console.WriteLine("O total não é maior que 90, não gostei :( ....");
            }
            int counter = 0;


            while (counter < 11)
            {
                Console.WriteLine($"contador {counter}");
                counter++;
            }

            /*do
            {
                Console.WriteLine($"O contador e rsrs {counter}");
                counter++;
            } while (counter < 10);*/

            /*
             for(int counter2 = 0; counter2 < 11; counter2++)
            {
                Console.WriteLine($"O contador ta na pqp {counter2}");
            }

            Console.WriteLine("------------------------------------------------------------");

            for (char column = 'a'; column < 'ç'; column++)
            {
                Console.WriteLine($"A coluna é {column}");
            }
            */

            /*
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"A celula é ({row}, {column})");
                }
            }
            */

            /*
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 1 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"o sum é {sum}");
            */

            var names = new List<string> { "Marina", "Carlos", "xerecuda" };

            names.Add("Maria");
            names.Add("BUCETA");
            names.Remove("xerecuda");
            foreach (var name in names)
            {
                Console.WriteLine($"Olá {name.ToUpper()}!");

            }
            Console.WriteLine($"Vão tomar no cu👍");

            Console.WriteLine($"Meu nome é {names[1]}");

            Console.WriteLine($"Eu adicionei {names[0]} e {names[3]} e {names[2]} para essa merda de lisa do caralho.");

            Console.WriteLine($"A lista tem exatamente {names.Count} pessoas, AI SIM CARALHO");

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"o nome {names[index]} indice {index} rsrs ");

            var notFound = names.IndexOf("Não encontrado");
            Console.WriteLine($"O nome não foi encontrado, no indice, returnando {notFound}");

            //ISSO CLASSIFICA OS NOMES POR ORDEM ALFABETICA, MUITOOOO FODA
            names.Sort();
            //
            foreach (var name in names)
            {
                Console.WriteLine($"Olá {name.ToUpper()}!");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 50)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 1];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

    }
}

