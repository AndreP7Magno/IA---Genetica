using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace IA___Genetica
{
    public class GerenciaRota
    {
        private static List<Cidade> cidadesDestino = new List<Cidade>();
        private static List<Cidade> rota = new List<Cidade>();
        private static List<int> numerosl = new List<int>();
        public String pCidade;
        public String pRota;
        Random random = new Random();
        private int numeroAleatorio;
        int[] numeros = new int[10];
        private int add;

        //Adiciona uma cidade à lista de cidades
        public static void addCidade(Cidade cidade)
        {
            cidadesDestino.Add(cidade);
        }

        public String PrintaCidade()
        {
            foreach (Cidade cidade in cidadesDestino)
            {
                pCidade = string.Join<Cidade>(", ", cidadesDestino.ToArray());
                Console.WriteLine("Cidade: " + pCidade.ToString());
                return pCidade;
            }
            return pCidade;
        }

        public static int NumeroDeCidades()
        {
            return cidadesDestino.Count;
        }


        public static Cidade GetCidade(int index)
        {
            return cidadesDestino[index];
        }

        public void GeraRota()
        {
            int controla = 0;
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (controla == 0)
                {
                    numeroAleatorio = random.Next(0, 9);
                    numerosl.Add(numeroAleatorio);
                    rota.Add(GetCidade(numeroAleatorio));
                    numeros[i] = numeroAleatorio;
                    controla = 1;
                }
                else
                {
                    numeroAleatorio = random.Next(0, 9);
                    add = 0;
                    for (int j = 0; j < numeros.Length; j++)
                    {
                        if (numeroAleatorio == numeros[j])
                        {
                            while (numeroAleatorio == numeros[j])
                            {
                                numeroAleatorio = random.Next(0, 9);
                            }
                        }
                        else if(add == 0 && numeroAleatorio != numeros[j])
                        {
                            numeros[i] = numeroAleatorio;
                            rota.Add(GetCidade(numeroAleatorio));
                            add = 1;
                        }
                    }
                }
            }
            
            
        }

        public String PrintaRota()
        {
            foreach (Cidade cidade in rota)
            {
                pRota = string.Join<Cidade>(", ", rota.ToArray());
                Console.WriteLine("Cidade: " + pRota.ToString());
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write(numeros[i]);
                }
                return pRota;
            }
            return pRota;
        }
    }
}
