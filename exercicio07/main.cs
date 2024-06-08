using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite a sua idade:");
            int idade;

            if (int.TryParse(Console.ReadLine(), out idade))
            {
                if (idade >= 0 && idade <= 12)
                {
                    Console.WriteLine("Você é uma criança.");
                }
                else if (idade >= 13 && idade <= 17)
                {
                    Console.WriteLine("Você é um adolescente.");
                }
                else if (idade >= 18 && idade <= 59)
                {
                    Console.WriteLine("Você é um adulto.");
                }
                else if (idade >= 60)
                {
                    Console.WriteLine("Você é um idoso.");
                }
                else
                {
                    Console.WriteLine("Idade inválida.");
            }
        }
    }
}

