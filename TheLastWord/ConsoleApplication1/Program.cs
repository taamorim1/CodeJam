using System;
using System.Collections.Generic;

namespace TheLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int qtdeTentativas = Convert.ToInt32(Console.ReadLine());
            int cont = 1;

            while (cont <= qtdeTentativas)
            {
                Console.WriteLine();
                string letras = Console.ReadLine();
                List<string> listaLetras = new List<string>();
                int contarLetras = 0;

                while (contarLetras < letras.Length)
                {
                   string letra =  letras.Substring(contarLetras, 1);
                   listaLetras.Add(letra.ToUpper());
                   contarLetras = contarLetras + 1;
                }

                string[] arrayLetrasOrdenadas = new string[letras.Length];

                int ultimoValor = 0;
                foreach (string letra in listaLetras)
                {
                    int valor = 0;
                    
                    switch(letra)
                    {
                        case "A":
                            valor = 1;
                            break;
                        case "B":
                            valor = 2;
                            break;
                        case "C":
                            valor = 3;
                            break;
                        case "D":
                            valor = 4;
                            break;
                        case "E":
                            valor = 5;
                            break;
                        case "F":
                            valor = 6;
                            break;
                        case "G":
                            valor = 7;
                            break;
                        case "H":
                            valor = 8;
                            break;
                        case "I":
                            valor = 9;
                            break;
                        case "J":
                            valor = 10;
                            break;
                        case "K":
                            valor = 11;
                            break;
                        case "L":
                            valor = 12;
                            break;
                        case "M":
                            valor = 13;
                            break;
                        case "N":
                            valor = 14;
                            break;
                        case "O":
                            valor = 15;
                            break;
                        case "P":
                            valor = 16;
                            break;
                        case "Q":
                            valor = 17;
                            break;
                        case "R":
                            valor = 18;
                            break;
                        case "S":
                            valor = 19;
                            break;
                        case "T":
                            valor = 20;
                            break;
                        case "U":
                            valor = 21;
                            break;
                        case "V":
                            valor = 22;
                            break;
                        case "W":
                            valor = 23;
                            break;
                        case "X":
                            valor = 24;
                            break;
                        case "Y":
                            valor = 25;
                            break;
                        case "Z":
                            valor = 26;
                            break;
                    }

                    if (arrayLetrasOrdenadas[0] == null)
                    {
                        arrayLetrasOrdenadas[0] = letra;
                        ultimoValor = valor;
                    }
                    else
                    {
                        if (valor >= ultimoValor)
                        {
                            int posicao = Array.IndexOf(arrayLetrasOrdenadas, null);
                            int x = 1;
                            int y = 0;
                            while (x <= posicao)
                            {
                                string letrTrocar = arrayLetrasOrdenadas[posicao - x];
                                arrayLetrasOrdenadas[posicao + y] = letrTrocar;

                                x++;
                                y--;
                            }
                            
                            arrayLetrasOrdenadas[0] = letra;
                            ultimoValor = valor;

                        }
                        else
                        {
                           int posicao = Array.IndexOf(arrayLetrasOrdenadas, null);
                            arrayLetrasOrdenadas[posicao] = letra;
                        }

                    }

                }
                Console.WriteLine("case #" + cont + ": ");
                foreach(string l in arrayLetrasOrdenadas)
                {
                    Console.Write(l);
                }

                cont = cont + 1;

            }

            Console.ReadKey(); 
        }
    }
}
