using System;

class Program
{
    static void Main()
    {
        string lista = "Atletico-MG, Cruzeiro, America-Mg, Villa Nova, Tombense";
        string[] times = lista.Split(", ");

        Console.WriteLine(" Tabela 1: ida e volta ");
        int numeroJogos = 1;
        for (int i = 0; i < times.Length; i++)
        {
            for (int j = 0; j < times.Length; j++)
            {
                if (i != j)
                {
                    Console.WriteLine($"[{numeroJogos++}] {times[i]} X {times[j]}");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine(" Tabela 2: turno unico ");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.Length; i++)
        {
            for (int j = i + 1; j < times.Length; j++)
            {
                totalTurnoUnico++;
                Console.WriteLine($"[{totalTurnoUnico}] {times[i]} X {times[j]}");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Total de confrontos no turno unico: {totalTurnoUnico}");
    }
}
