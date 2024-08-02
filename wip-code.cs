using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        // Abre o arquivo CSV para leitura
        using (StreamReader sr = new StreamReader("./addresses.csv"))
        {
            // Lista para armazenar todas as linhas dos dados CSV
            List<List<string>> listOfLists = new List<List<string>>();
            
            // Le o arquivo linha por linha
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // Divide a linha em campos usando a virgula como delimitador
                string[] splitLine = line.Split(',');

                // Lista para armazenar os campos da linha atual
                List<string> listLines = new List<string>();

                foreach (string field in splitLine)
                {
                    // Verifica se o campo contem aspas
                    bool containsQuotes = field.Contains("\"");

                    if (containsQuotes)
                    {
                        // Remove as aspas do campo
                        string cleanedField = field.Replace("\"", "");
                        listLines.Add(cleanedField);
                    }
                    else
                    {
                        listLines.Add(field);
                    }
                }

                // Adiciona a lista de campos a lista principal
                listOfLists.Add(listLines);
            }

            if (listOfLists.Count > 3 && listOfLists[3].Count > 0)
            {
                Console.WriteLine(listOfLists[3][0]);
            }
            else
            {
                Console.WriteLine("Linha ou campo nao encontrado.");
            }
        } // O arquivo e fechado automaticamente ao sair do bloco using
    }
}
