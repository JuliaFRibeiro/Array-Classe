using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor adicionado pelo usuario
            Console.WriteLine("Informe a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            //tamanho do vetor 
            Console.WriteLine("Informe a altura das pessoas: ");
            double[] vect = new double[n];

            //criação de um vetor conforme o tamanho indicado pelo usuario
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;

            //soma de todas as alturas das pessoas
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;
            Console.WriteLine("O valor da media das pessoas é: " + media);

            Console.ReadKey();
        }

    }
}
