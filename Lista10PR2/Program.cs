using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
            int[] vet2;
            int t, soma = 0, media, maior, menor;
            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
          
            for (int i = 0; i < t; i++)
            {

                Console.WriteLine("qual o valor do vetor : ");
                vet2[i] = int.Parse(Console.ReadLine());
              
            }

            menor = vet2[0];
            for (int i = 0; i < t; i++)
            {

                if (menor > vet2[i])
                {
                    menor = vet2[i];
                }


            }
            maior = vet2[0];
            for (int i = 0; i < t; i++)
            {

                if (maior < vet2[i])
                {
                    maior = vet2[i];
                }


            }

            for (int i = 0; i < t; i++)
            {

                soma += vet2[i];
            }

            media = soma / t;
            Console.WriteLine("o maior numero é : " + maior);
            Console.WriteLine("o menor numero é : " + menor);
            Console.WriteLine("a media é :" + media);






        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
           
            int[] vet2;
            int t, soma = 0, media;

            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];

            for (int i = 0; i < t; i++)
            {

                Console.WriteLine("qual o valor do vetor : ");
                vet2[i] = int.Parse(Console.ReadLine());
                if(vet2[i] == 0)
                {
                    break;
                }
            }

        

            for (int i = 0; i < t; i++)
            {

                soma += vet2[i];
            }

            media = soma / t;

            for (int i = 0; i < t; i++)
            {
                if (vet2[i] >= media)
                {
                    Console.WriteLine("os numeros que são maiores ou iguais à media :" + vet2[i]);
                }
            }
                Console.WriteLine("a media é :" + media);



        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
            int[] vet2;
            int t, soma = 0, media;

            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {

                
                vet2[i] = rand.Next(1, 1000);
            
            }



            for (int i = 0; i < t; i++)
            {

                soma += vet2[i];
            }

            media = soma / t;

            for (int i = 0; i < t; i++)
            {
                if (vet2[i] >= media)
                {
                    Console.WriteLine("os numeros que são maiores ou iguais à media :" + vet2[i]);
                }
            }
            Console.WriteLine("a media é :" + media);


        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
            string[] vet2;
            int t;

            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new string[t];
            

            for (int i = 0; i < t; i++)
            {

                Console.WriteLine("quais os nomes :");
                vet2[i] = Console.ReadLine();
             

            }
            for (int i = 0; i < t; i--)
            {
                Console.WriteLine(" os nomes:" + vet2[i]);

            }

        }
        public static void Exercicio5()
        {
            Console.WriteLine("here ex5 will be encoded");

            int[] vet2;
            int t, somai = 0,  somap = 0;

            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {


                vet2[i] = rand.Next(1, 1000);

            }

            for (int i = 0; i < t; i++)
            {

                if (vet2[i] % 2 == 0)
                {
                    somai++;
                }
                else
                {
                    somap++;
                }

            }

            Console.WriteLine("neste vetor temos :" + somai + " numeros pares e : " + somap + "numeros impares");



        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("===========MENU=========");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                }

            } while (option != 0);

        }
    }
}