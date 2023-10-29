using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Reflection;

namespace CSharpProgram
{

    class Cprogram
    {

        public static double CalcularArea(double raio)
        {
            const double pi = 3.1415;
            double area = pi * raio * raio;
            return area;
        }

        public static int ParseInt(string opcao)
        {
            int result;

            if (int.TryParse(opcao, out int op))
            {
                result = op;
            }
            else
            {
                Console.WriteLine("valor digitado inválido , digite um numero inteiro");
                result = -1;
            }
            return result;
        }

        public static int Calculadora(int a, int b, int operacao)
        {

            return operacao switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b,
                5 => a % b,
                6=> (int) Potenciacao((double)a, (double)b),
                _ => 0,
            };
        }
        public static double Potenciacao( double a, double b){
            double  result = Math.Pow(a , b);
            return  result;
        }
        public static void Main()
        {
            int op;
            do
            {
                Console.WriteLine("digite o valor int de A");
                 string valorA = Console.ReadLine();
                 int va = ParseInt(valorA)  ;

                Console.WriteLine("digite o valor int de B");
                string valorB = Console.ReadLine();
                int vb = ParseInt(valorB);

                Console.WriteLine("digite 1- para soma 2- para subtracao 3- para multiplicao  4- para divisao 5- para resto 6 - para potenciação 7- limpar tela");
                string operacao = Console.ReadLine();
                op = ParseInt(operacao);
                if(op==7){
                    Console.Clear();
                }
              
                double resultado = Calculadora(va, vb, op);
                Console.WriteLine("o resultado da operacao é : " + resultado);
                
                
            } while (op != 0);

        }

    }


}
