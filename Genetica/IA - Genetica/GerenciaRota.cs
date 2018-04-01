using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace IA___Genetica
{
    public class GerenciaRota
    {
        private static List<Cidade> cidadesDestino = new List<Cidade>();
        private static List<Cidade> rota = new List<Cidade>();
        private static List<Cidade> rota2 = new List<Cidade>();
        private static List<Cidade> rota3 = new List<Cidade>();
        private static List<Cidade> rota4 = new List<Cidade>();
        private static List<Cidade> rota5 = new List<Cidade>();
        public String pCidade;
        public String pRota;
        public String pRota2;
        public String pRota3;
        public String pRota4;
        public String pRota5;
        Random random = new Random();
        int[] numeros = new int[26];
        private Cidade distanciaRota = new Cidade();
        private Double totalDistanciaRota = 0;

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
            return cidadesDestino.Count + 1;
        }

        public static Cidade GetCidade(int index)
        {
            return cidadesDestino[index];
        }

        public void GeraRota()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 26;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros.Contains(temp) == false)
                    {
                        numeros[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros[25] = numeros[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota.Add(GetCidade(numeros[i]));
            }

            //Calcula distância da rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota = totalDistanciaRota + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros[i]), GetCidade(numeros[i + 1]));
                }
            }
            Console.WriteLine("Distância: " + totalDistanciaRota);
        }

        public void GeraRota2()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 26;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros.Contains(temp) == false)
                    {
                        numeros[i] = temp;
                        break;
                    }
                }
                if (i == 25)
                {
                    numeros[26] = numeros[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota2.Add(GetCidade(numeros[i]));
            }
        }

        public void GeraRota3()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 26;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros.Contains(temp) == false)
                    {
                        numeros[i] = temp;
                        break;
                    }
                }
                if (i == 25)
                {
                    numeros[26] = numeros[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota3.Add(GetCidade(numeros[i]));
            }
        }

        public void GeraRota4()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 26;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros.Contains(temp) == false)
                    {
                        numeros[i] = temp;
                        break;
                    }
                }
                if (i == 25)
                {
                    numeros[26] = numeros[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota4.Add(GetCidade(numeros[i]));
            }
        }

        public void GeraRota5()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 26;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros.Contains(temp) == false)
                    {
                        numeros[i] = temp;
                        break;
                    }
                }
                if (i == 25)
                {
                    numeros[26] = numeros[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota5.Add(GetCidade(numeros[i]));
            }
        }

        public String PrintaRota()
        {
            foreach (Cidade cidade in rota)
            {
                pRota = string.Join<Cidade>(", ", rota.ToArray());
                Console.WriteLine("Cidade: " + pRota.ToString());
                return pRota;
            }
            return pRota;
        }

        public String PrintaRota2()
        {
            foreach (Cidade cidade in rota)
            {
                pRota2 = string.Join<Cidade>(", ", rota2.ToArray());
                Console.WriteLine("Cidade: " + pRota2.ToString());
                return pRota2;
            }
            return pRota2;
        }

        public String PrintaRota3()
        {
            foreach (Cidade cidade in rota)
            {
                pRota3 = string.Join<Cidade>(", ", rota3.ToArray());
                Console.WriteLine("Cidade: " + pRota3.ToString());
                return pRota3;
            }
            return pRota3;
        }

        public String PrintaRota4()
        {
            foreach (Cidade cidade in rota)
            {
                pRota4 = string.Join<Cidade>(", ", rota4.ToArray());
                Console.WriteLine("Cidade: " + pRota4.ToString());
                return pRota4;
            }
            return pRota4;
        }

        public String PrintaRota5()
        {
            foreach (Cidade cidade in rota)
            {
                pRota5 = string.Join<Cidade>(", ", rota5.ToArray());
                Console.WriteLine("Cidade: " + pRota5.ToString());
                return pRota5;
            }
            return pRota5;
        }

    }
}
