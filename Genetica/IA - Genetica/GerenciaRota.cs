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
        int[] numeros2 = new int[26];
        int[] numeros3 = new int[26];
        int[] numeros4 = new int[26];
        int[] numeros5 = new int[26];
        private Cidade distanciaRota = new Cidade();
        private Double totalDistanciaRota = 0;
        private Double totalDistanciaRota2 = 0;
        private Double totalDistanciaRota3 = 0;
        private Double totalDistanciaRota4 = 0;
        private Double totalDistanciaRota5 = 0;
        private Double fitness = 0;
        private Double fitness2 = 0;
        private Double fitness3 = 0;
        private Double fitness4 = 0;
        private Double fitness5 = 0;

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

        public int[] GetMelhor()
        {
            if(totalDistanciaRota > totalDistanciaRota2 && totalDistanciaRota > totalDistanciaRota3 && totalDistanciaRota > totalDistanciaRota4 && totalDistanciaRota > totalDistanciaRota5)
            {
                return numeros;
            }

            if (totalDistanciaRota2 > totalDistanciaRota && totalDistanciaRota2 > totalDistanciaRota3 && totalDistanciaRota2 > totalDistanciaRota4 && totalDistanciaRota2 > totalDistanciaRota5)
            {
                return numeros2;
            }

            if (totalDistanciaRota3 > totalDistanciaRota && totalDistanciaRota3 > totalDistanciaRota2 && totalDistanciaRota3 > totalDistanciaRota4 && totalDistanciaRota3 > totalDistanciaRota5)
            {
                return numeros3;
            }

            if (totalDistanciaRota4 > totalDistanciaRota && totalDistanciaRota4 > totalDistanciaRota2 && totalDistanciaRota4 > totalDistanciaRota3 && totalDistanciaRota4 > totalDistanciaRota5)
            {
                return numeros4;
            }

            return numeros5;
        }

        public int[] GetPior()
        {
            if (totalDistanciaRota < totalDistanciaRota2 && totalDistanciaRota < totalDistanciaRota3 && totalDistanciaRota < totalDistanciaRota4 && totalDistanciaRota < totalDistanciaRota5)
            {
                return numeros;
            }

            if (totalDistanciaRota2 < totalDistanciaRota && totalDistanciaRota2 < totalDistanciaRota3 && totalDistanciaRota2 < totalDistanciaRota4 && totalDistanciaRota2 < totalDistanciaRota5)
            {
                return numeros2;
            }

            if (totalDistanciaRota3 < totalDistanciaRota && totalDistanciaRota3 < totalDistanciaRota2 && totalDistanciaRota3 < totalDistanciaRota4 && totalDistanciaRota3 < totalDistanciaRota5)
            {
                return numeros3;
            }

            if (totalDistanciaRota4 < totalDistanciaRota && totalDistanciaRota4 < totalDistanciaRota2 && totalDistanciaRota4 < totalDistanciaRota3 && totalDistanciaRota4 < totalDistanciaRota5)
            {
                return numeros4;
            }

            return numeros5;
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
            for (int i = 0; i < numeros2.Length; i++)
            {
                numeros2[i] = 26;
            }
            for (int i = 0; i < numeros2.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros2.Contains(temp) == false)
                    {
                        numeros2[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros2[25] = numeros2[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota2.Add(GetCidade(numeros2[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota2 = totalDistanciaRota2 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros2[i]), GetCidade(numeros2[i + 1]));
                }
            }
            Console.WriteLine("Distância: " + totalDistanciaRota2);
        }

        public void GeraRota3()
        {
            for (int i = 0; i < numeros3.Length; i++)
            {
                numeros3[i] = 26;
            }
            for (int i = 0; i < numeros3.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros3.Contains(temp) == false)
                    {
                        numeros3[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros3[25] = numeros3[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota3.Add(GetCidade(numeros3[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota3 = totalDistanciaRota3 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros3[i]), GetCidade(numeros3[i + 1]));
                }
            }
            Console.WriteLine("Distância: " + totalDistanciaRota3);
        }

        public void GeraRota4()
        {
            for (int i = 0; i < numeros4.Length; i++)
            {
                numeros4[i] = 26;
            }
            for (int i = 0; i < numeros4.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros4.Contains(temp) == false)
                    {
                        numeros4[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros4[25] = numeros4[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota4.Add(GetCidade(numeros4[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota4 = totalDistanciaRota4 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros4[i]), GetCidade(numeros4[i + 1]));
                }
            }
            Console.WriteLine("Distância: " + totalDistanciaRota4);
        }

        public void GeraRota5()
        {
            for (int i = 0; i < numeros5.Length; i++)
            {
                numeros5[i] = 26;
            }
            for (int i = 0; i < numeros5.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros5.Contains(temp) == false)
                    {
                        numeros5[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros5[25] = numeros5[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota5.Add(GetCidade(numeros5[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota5 = totalDistanciaRota5 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros5[i]), GetCidade(numeros5[i + 1]));
                }
            }
            Console.WriteLine("Distância: " + totalDistanciaRota5);
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
            foreach (Cidade cidade in rota2)
            {
                pRota2 = string.Join<Cidade>(", ", rota2.ToArray());
                Console.WriteLine("Cidade: " + pRota2.ToString());
                return pRota2;
            }
            return pRota2;
        }

        public String PrintaRota3()
        {
            foreach (Cidade cidade in rota3)
            {
                pRota3 = string.Join<Cidade>(", ", rota3.ToArray());
                Console.WriteLine("Cidade: " + pRota3.ToString());
                return pRota3;
            }
            return pRota3;
        }

        public String PrintaRota4()
        {
            foreach (Cidade cidade in rota4)
            {
                pRota4 = string.Join<Cidade>(", ", rota4.ToArray());
                Console.WriteLine("Cidade: " + pRota4.ToString());
                return pRota4;
            }
            return pRota4;
        }

        public String PrintaRota5()
        {
            foreach (Cidade cidade in rota5)
            {
                pRota5 = string.Join<Cidade>(", ", rota5.ToArray());
                Console.WriteLine("Cidade: " + pRota5.ToString());
                return pRota5;
            }
            return pRota5;
        }

    }
}
