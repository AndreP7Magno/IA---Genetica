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
        private static List<Cidade> rota6 = new List<Cidade>();
        private static List<Cidade> rota7 = new List<Cidade>();
        private static List<Cidade> rota8 = new List<Cidade>();
        private static List<Cidade> rota9 = new List<Cidade>();
        private static List<Cidade> rota10 = new List<Cidade>();
        public String pCidade;
        public String pRota;
        public String pRota2;
        public String pRota3;
        public String pRota4;
        public String pRota5;
        public String pRota6;
        public String pRota7;
        public String pRota8;
        public String pRota9;
        public String pRota10;
        Random random = new Random();
        int[] numeros = new int[26];
        int[] numeros2 = new int[26];
        int[] numeros3 = new int[26];
        int[] numeros4 = new int[26];
        int[] numeros5 = new int[26];
        int[] numeros6 = new int[26];
        int[] numeros7 = new int[26];
        int[] numeros8 = new int[26];
        int[] numeros9 = new int[26];
        int[] numeros10 = new int[26];
        int[] melhorSub = new int[26];
        int[] piorSub = new int[26];
        int[] melhorSub2 = new int[26];
        int[] melhorSub3 = new int[26];
        int[] melhorSub4 = new int[26];
        int[] melhorSub5 = new int[26];
        int[] melhorSub6 = new int[26];
        int[] melhorSub7 = new int[26];
        int[] melhorSub8 = new int[26];
        int[] melhorSub9 = new int[26];
        int[] melhorSub10 = new int[26];
        private Cidade distanciaRota = new Cidade();
        private Double totalDistanciaRota = 0;
        private Double totalDistanciaRota2 = 0;
        private Double totalDistanciaRota3 = 0;
        private Double totalDistanciaRota4 = 0;
        private Double totalDistanciaRota5 = 0;
        private Double totalDistanciaRota6 = 0;
        private Double totalDistanciaRota7 = 0;
        private Double totalDistanciaRota8 = 0;
        private Double totalDistanciaRota9 = 0;
        private Double totalDistanciaRota10 = 0;
        private Double melhorDistancia = 0;
        private Double fitness = 0;
        private Double fitness2 = 0;
        private Double fitness3 = 0;
        private Double fitness4 = 0;
        private Double fitness5 = 0;
        private Double fitness6 = 0;
        private Double fitness7 = 0;
        private Double fitness8 = 0;
        private Double fitness9 = 0;
        private Double fitness10 = 0;
        private int aux = 0;
        private int primeiraPosicaoCruzamento = 0;
        private int ultimaPosicaoCruzamento = 0;

        //Adiciona uma cidade à lista de cidades
        public static void AddCidade(Cidade cidade)
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

        public void ZeraVetores()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                melhorSub[i] = 0;
                piorSub[i] = 0;
                melhorSub2[i] = 0;
            }
        }

        public void SubstituiRotas()
        {
            if (Get1() == numeros)
            {
                rota.Clear();
                totalDistanciaRota = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    rota.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota = totalDistanciaRota + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness = 1 / totalDistanciaRota;
                Console.WriteLine("Distância: " + totalDistanciaRota.ToString("#0"));
            }
            else if (Get2() == numeros2)
            {
                rota2.Clear();
                totalDistanciaRota2 = 0;
                for (int i = 0; i < numeros2.Length; i++)
                {
                    rota2.Add(GetCidade(piorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota2 = totalDistanciaRota2 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness2 = 1 / totalDistanciaRota2;
                Console.WriteLine("Distância: " + totalDistanciaRota2.ToString("#0"));
            }
            else if (Get3() == numeros3)
            {
                rota3.Clear();
                totalDistanciaRota3 = 0;
                for (int i = 0; i < numeros3.Length; i++)
                {
                    rota3.Add(GetCidade(melhorSub2[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota3 = totalDistanciaRota3 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub2[i]), GetCidade(melhorSub2[i + 1]));
                    }
                }
                fitness3 = 1 / totalDistanciaRota3;
                Console.WriteLine("Distância: " + totalDistanciaRota3.ToString("#0"));
            }
            else if (Get4() == numeros4)
            {
                rota4.Clear();
                totalDistanciaRota4 = 0;
                for (int i = 0; i < numeros4.Length; i++)
                {
                    rota4.Add(GetCidade(melhorSub3[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota4 = totalDistanciaRota4 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness4 = 1 / totalDistanciaRota4;
                Console.WriteLine("Distância: " + totalDistanciaRota4.ToString("#0"));
            }
            else if (Get5() == numeros5)
            {
                rota5.Clear();
                totalDistanciaRota5 = 0;
                for (int i = 0; i < numeros5.Length; i++)
                {
                    rota5.Add(GetCidade(melhorSub4[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota5 = totalDistanciaRota5 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness5 = 1 / totalDistanciaRota5;
                Console.WriteLine("Distância: " + totalDistanciaRota5.ToString("#0"));
            }
            else if (Get6() == numeros6)
            {
                rota6.Clear();
                totalDistanciaRota6 = 0;
                for (int i = 0; i < numeros6.Length; i++)
                {
                    rota6.Add(GetCidade(melhorSub5[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota6 = totalDistanciaRota6 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness6 = 1 / totalDistanciaRota6;
                Console.WriteLine("Distância: " + totalDistanciaRota6.ToString("#0"));
            }
            else if (GetPior() == numeros7)
            {
                rota7.Clear();
                totalDistanciaRota7 = 0;
                for (int i = 0; i < numeros7.Length; i++)
                {
                    rota7.Add(GetCidade(piorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota7 = totalDistanciaRota7 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness7 = 1 / totalDistanciaRota7;
                Console.WriteLine("Distância: " + totalDistanciaRota7.ToString("#0"));
            }
            else if (GetPior() == numeros8)
            {
                rota8.Clear();
                totalDistanciaRota8 = 0;
                for (int i = 0; i < numeros8.Length; i++)
                {
                    rota8.Add(GetCidade(piorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota8 = totalDistanciaRota8 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness8 = 1 / totalDistanciaRota8;
                Console.WriteLine("Distância: " + totalDistanciaRota8.ToString("#0"));
            }
            else if (GetPior() == numeros9)
            {
                rota9.Clear();
                totalDistanciaRota9 = 0;
                for (int i = 0; i < numeros9.Length; i++)
                {
                    rota6.Add(GetCidade(piorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota9 = totalDistanciaRota9 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness9 = 1 / totalDistanciaRota9;
                Console.WriteLine("Distância: " + totalDistanciaRota9.ToString("#0"));
            }
            else
            {
                rota10.Clear();
                totalDistanciaRota10 = 0;
                for (int i = 0; i < numeros10.Length; i++)
                {
                    rota10.Add(GetCidade(piorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota10 = totalDistanciaRota10 + distanciaRota.DistanciaParaProximaCidade(GetCidade(piorSub[i]), GetCidade(piorSub[i + 1]));
                    }
                }
                fitness10 = 1 / totalDistanciaRota10;
                Console.WriteLine("Distância: " + totalDistanciaRota10.ToString("#0"));
            }

            if (GetMelhor() == numeros)
            {
                rota.Clear();
                totalDistanciaRota = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    rota.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota = totalDistanciaRota + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness = 1 / totalDistanciaRota;
                //Console.WriteLine("Distância: " + totalDistanciaRota);
            }
            else if (GetMelhor() == numeros2)
            {
                rota2.Clear();
                totalDistanciaRota2 = 0;
                for (int i = 0; i < numeros2.Length; i++)
                {
                    rota2.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota2 = totalDistanciaRota2 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota2 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness2 = 1 / totalDistanciaRota2;
                //Console.WriteLine("Distância: " + totalDistanciaRota2);
            }
            else if (GetMelhor() == numeros3)
            {
                rota3.Clear();
                totalDistanciaRota3 = 0;
                for (int i = 0; i < numeros3.Length; i++)
                {
                    rota3.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota3 = totalDistanciaRota3 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota3 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness3 = 1 / totalDistanciaRota3;
                //Console.WriteLine("Distância: " + totalDistanciaRota3);
            }
            else if (GetMelhor() == numeros4)
            {
                rota4.Clear();
                totalDistanciaRota4 = 0;
                for (int i = 0; i < numeros4.Length; i++)
                {
                    rota4.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota4 = totalDistanciaRota4 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota4 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness4 = 1 / totalDistanciaRota4;
                //Console.WriteLine("Distância: " + totalDistanciaRota4);
            }
            else if (GetPior() == numeros5)
            {
                rota5.Clear();
                totalDistanciaRota5 = 0;
                for (int i = 0; i < numeros5.Length; i++)
                {
                    rota5.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota5 = totalDistanciaRota5 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota5 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness5 = 1 / totalDistanciaRota5;
                //Console.WriteLine("Distância: " + totalDistanciaRota5);
            }
            else if (GetPior() == numeros6)
            {
                rota6.Clear();
                totalDistanciaRota6 = 0;
                for (int i = 0; i < numeros6.Length; i++)
                {
                    rota6.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota6 = totalDistanciaRota6 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota6 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness6 = 1 / totalDistanciaRota6;
                //Console.WriteLine("Distância: " + totalDistanciaRota6);
            }
            else if (GetPior() == numeros7)
            {
                rota7.Clear();
                totalDistanciaRota7 = 0;
                for (int i = 0; i < numeros7.Length; i++)
                {
                    rota7.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota7 = totalDistanciaRota7 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota7 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness7 = 1 / totalDistanciaRota7;
                //Console.WriteLine("Distância: " + totalDistanciaRota7);
            }
            else if (GetPior() == numeros8)
            {
                rota8.Clear();
                totalDistanciaRota8 = 0;
                for (int i = 0; i < numeros8.Length; i++)
                {
                    rota5.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota8 = totalDistanciaRota8 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota8 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness8 = 1 / totalDistanciaRota8;
                //Console.WriteLine("Distância: " + totalDistanciaRota8);
            }
            else if (GetPior() == numeros9)
            {
                rota9.Clear();
                totalDistanciaRota9 = 0;
                for (int i = 0; i < numeros9.Length; i++)
                {
                    rota9.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota9 = totalDistanciaRota9 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota9 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness9 = 1 / totalDistanciaRota9;
                //Console.WriteLine("Distância: " + totalDistanciaRota9);
            }
            else
            {
                rota10.Clear();
                totalDistanciaRota10 = 0;
                for (int i = 0; i < numeros10.Length; i++)
                {
                    rota10.Add(GetCidade(melhorSub[i]));
                    if (i <= 24)
                    {
                        totalDistanciaRota10 = totalDistanciaRota10 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                        melhorDistancia = totalDistanciaRota10 + distanciaRota.DistanciaParaProximaCidade(GetCidade(melhorSub[i]), GetCidade(melhorSub[i + 1]));
                    }
                }
                fitness10 = 1 / totalDistanciaRota10;
                //Console.WriteLine("Distância: " + totalDistanciaRota10);
            }
        }

        public void Selecao(int[] melhor, int[] pior)
        {
            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(pior[i]) || piorSub.Contains(melhor[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if(melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = pior[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = melhor[i];
                                break;
                            }
                        }
                        melhor[i] = pior[i];
                        pior[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = pior[i];
                        piorSub[i] = melhor[i];
                        melhor[i] = pior[i];
                        pior[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(melhor[i]) || piorSub.Contains(pior[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = melhor[i];
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = pior[i];
                            }
                        }
                        melhor[i] = melhor[i];
                        pior[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = melhor[i];
                        piorSub[i] = pior[i];
                        melhor[i] = melhor[i];
                        pior[i] = pior[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub[i] = melhorSub[0];
                    piorSub[i] = piorSub[0];
                    melhor[i] = melhor[0];
                    pior[i] = pior[0];
                }
            }
        }

        public void Selecao30(int[] num, int[] num2, int[] num3)
        {
            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num2[i]) || piorSub.Contains(num[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num2[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = num[i];
                                break;
                            }
                        }
                        num[i] = num2[i];
                        num2[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num2[i];
                        piorSub[i] = num[i];
                        num[i] = num2[i];
                        num2[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num[i]) || piorSub.Contains(num2[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = num2[i];
                                break;
                            }
                        }
                        num[i] = num2[i];
                        num[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num[i];
                        piorSub[i] = num2[i];
                        num[i] = num[i];
                        num2[i] = num2[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub[i] = melhorSub[0];
                    piorSub[i] = piorSub[0];
                    num[i] = num[0];
                    num2[i] = num2[0];
                }
            }

            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num3[i]) || melhorSub2.Contains(num[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num3[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                melhorSub2[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub2[i] = num[i];
                                break;
                            }
                        }
                        num[i] = num3[i];
                        num[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num3[i];
                        melhorSub2[i] = num[i];
                        num[i] = num3[i];
                        num3[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num[i]) || melhorSub2.Contains(num3[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num[i];
                                break;
                            }
                            if (melhorSub2.Contains(temp) == false)
                            {
                                melhorSub2[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub2[i] = num3[i];
                            }
                        }
                        num[i] = num[i];
                        num3[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num[i];
                        melhorSub2[i] = num3[i];
                        num[i] = num[i];
                        num3[i] = num3[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub[i] = melhorSub[0];
                    melhorSub2[i] = melhorSub2[0];
                    num[i] = num[0];
                    num3[i] = num3[0];
                }
            }
        }

        public void Selecao60(int[] num, int[] num2, int[] num3, int[] num4, int[] num5, int[] num6)
        {
            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num2[i]) || piorSub.Contains(num[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num2[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = num[i];
                                break;
                            }
                        }
                        num[i] = num2[i];
                        num2[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num2[i];
                        piorSub[i] = num[i];
                        num[i] = num2[i];
                        num2[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num[i]) || piorSub.Contains(num2[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                piorSub[i] = temp;
                                break;
                            }
                            else
                            {
                                piorSub[i] = num2[i];
                                break;
                            }
                        }
                        num[i] = num2[i];
                        num[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num[i];
                        piorSub[i] = num2[i];
                        num[i] = num[i];
                        num2[i] = num2[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub[i] = melhorSub[0];
                    piorSub[i] = piorSub[0];
                    num[i] = num[0];
                    num2[i] = num2[0];
                }
            }

            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num3[i]) || melhorSub2.Contains(num[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num3[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                melhorSub2[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub2[i] = num[i];
                                break;
                            }
                        }
                        num[i] = num3[i];
                        num[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num3[i];
                        melhorSub2[i] = num[i];
                        num[i] = num3[i];
                        num3[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub.Contains(num[i]) || melhorSub2.Contains(num3[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub.Contains(temp) == false)
                            {
                                melhorSub[i] = temp;
                                break;
                            }
                            else if (melhorSub.Contains(temp) == true)
                            {
                                melhorSub[i] = num[i];
                                break;
                            }
                            if (melhorSub2.Contains(temp) == false)
                            {
                                melhorSub2[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub2[i] = num3[i];
                            }
                        }
                        num[i] = num[i];
                        num3[i] = aux;
                    }
                    else
                    {
                        melhorSub[i] = num[i];
                        melhorSub2[i] = num3[i];
                        num[i] = num[i];
                        num3[i] = num3[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub[i] = melhorSub[0];
                    melhorSub2[i] = melhorSub2[0];
                    num[i] = num[0];
                    num3[i] = num3[0];
                }
            }

            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub3.Contains(num4[i]) || melhorSub4.Contains(num3[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub3.Contains(temp) == false)
                            {
                                melhorSub3[i] = temp;
                                break;
                            }
                            else if (melhorSub3.Contains(temp) == true)
                            {
                                melhorSub3[i] = num4[i];
                                break;
                            }
                            if (piorSub.Contains(temp) == false)
                            {
                                melhorSub4[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub4[i] = num3[i];
                                break;
                            }
                        }
                        num4[i] = num3[i];
                        num3[i] = aux;
                    }
                    else
                    {
                        melhorSub3[i] = num4[i];
                        melhorSub4[i] = num3[i];
                        num3[i] = num4[i];
                        num4[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub3.Contains(num3[i]) || melhorSub4.Contains(num4[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub3.Contains(temp) == false)
                            {
                                melhorSub3[i] = temp;
                                break;
                            }
                            else if (melhorSub3.Contains(temp) == true)
                            {
                                melhorSub3[i] = num3[i];
                                break;
                            }
                            if (melhorSub4.Contains(temp) == false)
                            {
                                melhorSub4[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub4[i] = num4[i];
                                break;
                            }
                        }
                        num4[i] = num3[i];
                        num4[i] = aux;
                    }
                    else
                    {
                        melhorSub3[i] = num3[i];
                        melhorSub4[i] = num4[i];
                        num3[i] = num3[i];
                        num4[i] = num4[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub3[i] = melhorSub3[0];
                    melhorSub4[i] = melhorSub4[0];
                    num3[i] = num3[0];
                    num4[i] = num4[0];
                }
            }

            primeiraPosicaoCruzamento = random.Next(0, 25);
            ultimaPosicaoCruzamento = random.Next(primeiraPosicaoCruzamento, 25);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i >= primeiraPosicaoCruzamento && i <= ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub4.Contains(num6[i]) || melhorSub5.Contains(num5[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub4.Contains(temp) == false)
                            {
                                melhorSub4[i] = temp;
                                break;
                            }
                            else if (melhorSub4.Contains(temp) == true)
                            {
                                melhorSub4[i] = num6[i];
                                break;
                            }
                            if (melhorSub5.Contains(temp) == false)
                            {
                                melhorSub5[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub5[i] = num5[i];
                                break;
                            }
                        }
                        num6[i] = num5[i];
                        num6[i] = aux;
                    }
                    else
                    {
                        melhorSub5[i] = num5[i];
                        melhorSub4[i] = num6[i];
                        num6[i] = num5[i];
                        num5[i] = aux;
                    }
                }
                else if (i < primeiraPosicaoCruzamento || i > ultimaPosicaoCruzamento && i < numeros.Length)
                {
                    if (melhorSub4.Contains(num5[i]) || melhorSub5.Contains(num6[i]))
                    {
                        while (true)
                        {
                            int temp = random.Next(0, 25);
                            if (melhorSub4.Contains(temp) == false)
                            {
                                melhorSub4[i] = temp;
                                break;
                            }
                            else if (melhorSub5.Contains(temp) == true)
                            {
                                melhorSub4[i] = num5[i];
                                break;
                            }
                            if (melhorSub5.Contains(temp) == false)
                            {
                                melhorSub5[i] = temp;
                                break;
                            }
                            else
                            {
                                melhorSub5[i] = num6[i];
                            }
                        }
                        num5[i] = num5[i];
                        num6[i] = aux;
                    }
                    else
                    {
                        melhorSub5[i] = num6[i];
                        melhorSub4[i] = num5[i];
                        num5[i] = num5[i];
                        num6[i] = num6[i];
                    }
                }
                else if (i == numeros.Length)
                {
                    melhorSub5[i] = melhorSub6[0];
                    melhorSub4[i] = melhorSub5[0];
                    num5[i] = num5[0];
                    num6[i] = num6[0];
                }
            }
        }

        public int[] Get1() {
            return numeros;
        }

        public int[] Get2()
        {
            return numeros2;
        }

        public int[] Get3()
        {
            return numeros3;
        }

        public int[] Get4()
        {
            return numeros4;
        }

        public int[] Get5()
        {
            return numeros5;
        }

        public int[] Get6()
        {
            return numeros6;
        }

        public void Mutar()
        {
            int primeiraPosicaoMutacao = random.Next(0, 25);
            int segundaPosicaoMutacao = random.Next(0, 25);
            int aux;
            aux = melhorSub[primeiraPosicaoMutacao];
            melhorSub[primeiraPosicaoMutacao] = melhorSub[segundaPosicaoMutacao];
            melhorSub[segundaPosicaoMutacao] = aux;
            aux = piorSub[primeiraPosicaoMutacao];
            piorSub[primeiraPosicaoMutacao] = piorSub[segundaPosicaoMutacao];
            piorSub[segundaPosicaoMutacao] = aux;
            aux = melhorSub2[primeiraPosicaoMutacao];
            melhorSub2[primeiraPosicaoMutacao] = melhorSub2[segundaPosicaoMutacao];
            melhorSub2[segundaPosicaoMutacao] = aux;
        }


        public static int NumeroDeCidades()
        {
            return cidadesDestino.Count + 1;
        }

        public static Cidade GetCidade(int index)
        {
            return cidadesDestino[index];
        }

        public int[] GetPior()
        {
            if(totalDistanciaRota > totalDistanciaRota2 && totalDistanciaRota > totalDistanciaRota3 && totalDistanciaRota > totalDistanciaRota4 && totalDistanciaRota > totalDistanciaRota5
               && totalDistanciaRota > totalDistanciaRota6 && totalDistanciaRota > totalDistanciaRota7 && totalDistanciaRota > totalDistanciaRota8 && totalDistanciaRota > totalDistanciaRota9
               && totalDistanciaRota > totalDistanciaRota10)
            {
                return numeros;
            }

            if (totalDistanciaRota2 > totalDistanciaRota && totalDistanciaRota2 > totalDistanciaRota3 && totalDistanciaRota2 > totalDistanciaRota4 && totalDistanciaRota2 > totalDistanciaRota5
               && totalDistanciaRota2 > totalDistanciaRota6 && totalDistanciaRota2 > totalDistanciaRota7 && totalDistanciaRota2 > totalDistanciaRota8 && totalDistanciaRota2 > totalDistanciaRota9
               && totalDistanciaRota2 > totalDistanciaRota10)
            {
                return numeros2;
            }

            if (totalDistanciaRota3 > totalDistanciaRota && totalDistanciaRota3 > totalDistanciaRota2 && totalDistanciaRota3 > totalDistanciaRota4 && totalDistanciaRota3 > totalDistanciaRota5
               && totalDistanciaRota3 > totalDistanciaRota6 && totalDistanciaRota3 > totalDistanciaRota7 && totalDistanciaRota3 > totalDistanciaRota8 && totalDistanciaRota3 > totalDistanciaRota9
               && totalDistanciaRota3 > totalDistanciaRota10)
            {
                return numeros3;
            }

            if (totalDistanciaRota4 > totalDistanciaRota && totalDistanciaRota4 > totalDistanciaRota2 && totalDistanciaRota4 > totalDistanciaRota3 && totalDistanciaRota4 > totalDistanciaRota5
               && totalDistanciaRota4 > totalDistanciaRota6 && totalDistanciaRota4 > totalDistanciaRota7 && totalDistanciaRota4 > totalDistanciaRota8 && totalDistanciaRota4 > totalDistanciaRota9
               && totalDistanciaRota4 > totalDistanciaRota10)
            {
                return numeros4;
            }

            if (totalDistanciaRota5 > totalDistanciaRota && totalDistanciaRota5 > totalDistanciaRota2 && totalDistanciaRota5 > totalDistanciaRota3 && totalDistanciaRota5 > totalDistanciaRota4
               && totalDistanciaRota5 > totalDistanciaRota6 && totalDistanciaRota5 > totalDistanciaRota7 && totalDistanciaRota5 > totalDistanciaRota8 && totalDistanciaRota5 > totalDistanciaRota9
               && totalDistanciaRota5 > totalDistanciaRota10)
            {
                return numeros5;
            }

            if (totalDistanciaRota6 > totalDistanciaRota && totalDistanciaRota6 > totalDistanciaRota2 && totalDistanciaRota6 > totalDistanciaRota3 && totalDistanciaRota6 > totalDistanciaRota4
               && totalDistanciaRota6 > totalDistanciaRota5 && totalDistanciaRota6 > totalDistanciaRota7 && totalDistanciaRota6 > totalDistanciaRota8 && totalDistanciaRota6 > totalDistanciaRota9
               && totalDistanciaRota6 > totalDistanciaRota10)
            {
                return numeros6;
            }

            if (totalDistanciaRota7 > totalDistanciaRota && totalDistanciaRota7 > totalDistanciaRota2 && totalDistanciaRota7 > totalDistanciaRota3 && totalDistanciaRota7 > totalDistanciaRota4
               && totalDistanciaRota7 > totalDistanciaRota5 && totalDistanciaRota7 > totalDistanciaRota6 && totalDistanciaRota7 > totalDistanciaRota8 && totalDistanciaRota7 > totalDistanciaRota9
               && totalDistanciaRota7 > totalDistanciaRota10)
            {
                return numeros7;
            }

            if (totalDistanciaRota8 > totalDistanciaRota && totalDistanciaRota8 > totalDistanciaRota2 && totalDistanciaRota8 > totalDistanciaRota3 && totalDistanciaRota8 > totalDistanciaRota4
               && totalDistanciaRota8 > totalDistanciaRota5 && totalDistanciaRota8 > totalDistanciaRota6 && totalDistanciaRota8 > totalDistanciaRota7 && totalDistanciaRota8 > totalDistanciaRota9
               && totalDistanciaRota8 > totalDistanciaRota10)
            {
                return numeros8;
            }

            if (totalDistanciaRota9 > totalDistanciaRota && totalDistanciaRota9 > totalDistanciaRota2 && totalDistanciaRota9 > totalDistanciaRota3 && totalDistanciaRota9 > totalDistanciaRota4
               && totalDistanciaRota9 > totalDistanciaRota5 && totalDistanciaRota9 > totalDistanciaRota6 && totalDistanciaRota9 > totalDistanciaRota7 && totalDistanciaRota9 > totalDistanciaRota8
               && totalDistanciaRota9 > totalDistanciaRota10)
            {
                return numeros9;
            }
            return numeros10;
        }

        public int[] GetMelhor()
        {
            if (totalDistanciaRota < totalDistanciaRota2 && totalDistanciaRota < totalDistanciaRota3 && totalDistanciaRota < totalDistanciaRota4 && totalDistanciaRota < totalDistanciaRota5
               && totalDistanciaRota < totalDistanciaRota6 && totalDistanciaRota < totalDistanciaRota7 && totalDistanciaRota < totalDistanciaRota8 && totalDistanciaRota < totalDistanciaRota9
               && totalDistanciaRota < totalDistanciaRota10)
            {
                return numeros;
            }

            if (totalDistanciaRota2 < totalDistanciaRota && totalDistanciaRota2 < totalDistanciaRota3 && totalDistanciaRota2 < totalDistanciaRota4 && totalDistanciaRota2 < totalDistanciaRota5
               && totalDistanciaRota2 < totalDistanciaRota6 && totalDistanciaRota2 < totalDistanciaRota7 && totalDistanciaRota2 < totalDistanciaRota8 && totalDistanciaRota2 < totalDistanciaRota9
               && totalDistanciaRota2 < totalDistanciaRota10)
            {
                return numeros2;
            }

            if (totalDistanciaRota3 < totalDistanciaRota && totalDistanciaRota3 < totalDistanciaRota2 && totalDistanciaRota3 < totalDistanciaRota4 && totalDistanciaRota3 < totalDistanciaRota5
               && totalDistanciaRota3 < totalDistanciaRota6 && totalDistanciaRota3 < totalDistanciaRota7 && totalDistanciaRota3 < totalDistanciaRota8 && totalDistanciaRota3 < totalDistanciaRota9
               && totalDistanciaRota3 < totalDistanciaRota10)
            {
                return numeros3;
            }

            if (totalDistanciaRota4 < totalDistanciaRota && totalDistanciaRota4 < totalDistanciaRota2 && totalDistanciaRota4 < totalDistanciaRota3 && totalDistanciaRota4 < totalDistanciaRota5
               && totalDistanciaRota4 < totalDistanciaRota6 && totalDistanciaRota4 < totalDistanciaRota7 && totalDistanciaRota4 < totalDistanciaRota8 && totalDistanciaRota4 < totalDistanciaRota9
               && totalDistanciaRota4 < totalDistanciaRota10)
            {
                return numeros4;
            }

            if (totalDistanciaRota5 < totalDistanciaRota && totalDistanciaRota5 < totalDistanciaRota2 && totalDistanciaRota5 < totalDistanciaRota3 && totalDistanciaRota5 < totalDistanciaRota4
               && totalDistanciaRota5 < totalDistanciaRota6 && totalDistanciaRota5 < totalDistanciaRota7 && totalDistanciaRota5 < totalDistanciaRota8 && totalDistanciaRota5 < totalDistanciaRota9
               && totalDistanciaRota5 < totalDistanciaRota10)
            {
                return numeros5;
            }

            if (totalDistanciaRota6 < totalDistanciaRota && totalDistanciaRota6 < totalDistanciaRota2 && totalDistanciaRota6 < totalDistanciaRota3 && totalDistanciaRota6 < totalDistanciaRota4
               && totalDistanciaRota6 < totalDistanciaRota5 && totalDistanciaRota6 < totalDistanciaRota7 && totalDistanciaRota6 < totalDistanciaRota8 && totalDistanciaRota6 < totalDistanciaRota9
               && totalDistanciaRota6 < totalDistanciaRota10)
            {
                return numeros6;
            }

            if (totalDistanciaRota7 < totalDistanciaRota && totalDistanciaRota7 < totalDistanciaRota2 && totalDistanciaRota7 < totalDistanciaRota3 && totalDistanciaRota7 < totalDistanciaRota4
               && totalDistanciaRota7 < totalDistanciaRota5 && totalDistanciaRota7 < totalDistanciaRota6 && totalDistanciaRota7 < totalDistanciaRota8 && totalDistanciaRota7 < totalDistanciaRota9
               && totalDistanciaRota7 < totalDistanciaRota10)
            {
                return numeros7;
            }

            if (totalDistanciaRota8 < totalDistanciaRota && totalDistanciaRota8 < totalDistanciaRota2 && totalDistanciaRota8 < totalDistanciaRota3 && totalDistanciaRota8 < totalDistanciaRota4
               && totalDistanciaRota8 < totalDistanciaRota5 && totalDistanciaRota8 < totalDistanciaRota6 && totalDistanciaRota8 < totalDistanciaRota7 && totalDistanciaRota8 < totalDistanciaRota9
               && totalDistanciaRota8 < totalDistanciaRota10)
            {
                return numeros8;
            }

            if (totalDistanciaRota9 < totalDistanciaRota && totalDistanciaRota9 < totalDistanciaRota2 && totalDistanciaRota9 < totalDistanciaRota3 && totalDistanciaRota9 < totalDistanciaRota4
               && totalDistanciaRota9 < totalDistanciaRota5 && totalDistanciaRota9 < totalDistanciaRota6 && totalDistanciaRota9 < totalDistanciaRota7 && totalDistanciaRota9 < totalDistanciaRota8
               && totalDistanciaRota9 < totalDistanciaRota10)
            {
                return numeros9;
            }
            return numeros10;
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
            fitness = 1/totalDistanciaRota;
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
            fitness = 1 / totalDistanciaRota2;
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
            fitness = 1 / totalDistanciaRota3;
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
            fitness = 1 / totalDistanciaRota4;
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
            fitness = 1 / totalDistanciaRota5;
            Console.WriteLine("Distância: " + totalDistanciaRota5);
        }

        public void GeraRota6()
        {
            for (int i = 0; i < numeros6.Length; i++)
            {
                numeros6[i] = 26;
            }
            for (int i = 0; i < numeros6.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros6.Contains(temp) == false)
                    {
                        numeros6[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros6[25] = numeros6[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota.Add(GetCidade(numeros6[i]));
            }

            //Calcula distância da rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota6 = totalDistanciaRota6 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros6[i]), GetCidade(numeros6[i + 1]));
                }
            }
            fitness = 1 / totalDistanciaRota6;
            Console.WriteLine("Distância: " + totalDistanciaRota6);
        }

        public void GeraRota7()
        {
            for (int i = 0; i < numeros7.Length; i++)
            {
                numeros7[i] = 26;
            }
            for (int i = 0; i < numeros7.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros7.Contains(temp) == false)
                    {
                        numeros7[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros7[25] = numeros7[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota7.Add(GetCidade(numeros7[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota7 = totalDistanciaRota7 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros7[i]), GetCidade(numeros7[i + 1]));
                }
            }
            fitness = 1 / totalDistanciaRota7;
            Console.WriteLine("Distância: " + totalDistanciaRota7);
        }

        public void GeraRota8()
        {
            for (int i = 0; i < numeros8.Length; i++)
            {
                numeros8[i] = 26;
            }
            for (int i = 0; i < numeros8.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros8.Contains(temp) == false)
                    {
                        numeros8[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros8[25] = numeros8[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota8.Add(GetCidade(numeros8[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota8 = totalDistanciaRota8 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros8[i]), GetCidade(numeros8[i + 1]));
                }
            }
            fitness = 1 / totalDistanciaRota8;
            Console.WriteLine("Distância: " + totalDistanciaRota8);
        }

        public void GeraRota9()
        {
            for (int i = 0; i < numeros9.Length; i++)
            {
                numeros9[i] = 26;
            }
            for (int i = 0; i < numeros9.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros9.Contains(temp) == false)
                    {
                        numeros9[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros9[25] = numeros9[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota9.Add(GetCidade(numeros9[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota9 = totalDistanciaRota9 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros9[i]), GetCidade(numeros9[i + 1]));
                }
            }
            fitness = 1 / totalDistanciaRota9;
            Console.WriteLine("Distância: " + totalDistanciaRota9);
        }

        public void GeraRota10()
        {
            for (int i = 0; i < numeros10.Length; i++)
            {
                numeros10[i] = 26;
            }
            for (int i = 0; i < numeros10.Length; i++)
            {
                while (true)
                {
                    int temp = random.Next(0, 25);
                    if (numeros10.Contains(temp) == false)
                    {
                        numeros10[i] = temp;
                        break;
                    }
                }
                if (i == 24)
                {
                    numeros10[25] = numeros10[0];
                    break;
                }
            }
            //Adiciona na rota
            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                rota10.Add(GetCidade(numeros10[i]));
            }

            for (int i = 0; i < NumeroDeCidades(); i++)
            {
                if (i <= 24)
                {
                    totalDistanciaRota10 = totalDistanciaRota10 + distanciaRota.DistanciaParaProximaCidade(GetCidade(numeros10[i]), GetCidade(numeros10[i + 1]));
                }
            }
            fitness = 1 / totalDistanciaRota10;
            Console.WriteLine("Distância: " + totalDistanciaRota10);
        }


        public String PrintaRota()
        {
            foreach (Cidade cidade in rota)
            {
                //pRota = string.Join<Cidade>(", ", rota.ToArray());
                //Console.WriteLine("Cidade: " + pRota.ToString());
                Console.Write("1: ");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write(" " + numeros[i]);
                }
                Console.WriteLine("");
                return pRota;
            }
            return pRota;
        }

        public String PrintaRota2()
        {
            foreach (Cidade cidade in rota2)
            {
                //pRota2 = string.Join<Cidade>(", ", rota2.ToArray());
                //Console.WriteLine("Cidade: " + pRota2.ToString());
                Console.Write("2: ");
                for (int i = 0; i < numeros2.Length; i++)
                {
                    Console.Write(" " + numeros2[i]);
                }
                Console.WriteLine("");
                return pRota2;
            }
            return pRota2;
        }

        public String PrintaRota3()
        {
            foreach (Cidade cidade in rota3)
            {
                //pRota3 = string.Join<Cidade>(", ", rota3.ToArray());
                //Console.WriteLine("Cidade: " + pRota3.ToString());
                Console.Write("3: ");
                for (int i = 0; i < numeros3.Length; i++)
                {
                    Console.Write(" " + numeros3[i]);
                }
                Console.WriteLine("");
                return pRota3;
            }
            return pRota3;
        }

        public String PrintaRota4()
        {
            foreach (Cidade cidade in rota4)
            {
                //pRota4 = string.Join<Cidade>(", ", rota4.ToArray());
                //Console.WriteLine("Cidade: " + pRota4.ToString());
                Console.Write("4: ");
                for (int i = 0; i < numeros4.Length; i++)
                {
                    Console.Write(" " + numeros4[i]);
                }
                Console.WriteLine("");
                return pRota4;
            }
            return pRota4;
        }

        public String PrintaRota5()
        {
            foreach (Cidade cidade in rota5)
            {
                //pRota5 = string.Join<Cidade>(", ", rota5.ToArray());
                //Console.WriteLine("Cidade: " + pRota5.ToString());
                Console.Write("5: ");
                for (int i = 0; i < numeros5.Length; i++)
                {
                    Console.Write(" " + numeros5[i]);
                }
                Console.WriteLine("");
                return pRota5;
            }
            return pRota5;
        }

    }
}
