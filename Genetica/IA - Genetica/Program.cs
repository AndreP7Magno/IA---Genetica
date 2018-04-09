using System;

namespace IA___Genetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taxa de geração é quantos % dos membros participarão do cruzamento
            //Mutação é trocar duas posições aleatórias do vetor em todos os filhos
            Cidade cidade = new Cidade("Lisboa", 60, 200);
            GerenciaRota.AddCidade(cidade);
            Cidade cidade2 = new Cidade("Santarém", 180, 200);
            GerenciaRota.AddCidade(cidade2);
            Cidade cidade3 = new Cidade("Braga", 80, 180);
            GerenciaRota.AddCidade(cidade3);
            Cidade cidade4 = new Cidade("Bragança", 140, 180);
            GerenciaRota.AddCidade(cidade4);
            Cidade cidade5 = new Cidade("Porto", 20, 160);
            GerenciaRota.AddCidade(cidade5);
            Cidade cidade6 = new Cidade("Portalegre", 100, 160);
            GerenciaRota.AddCidade(cidade6);
            Cidade cidade7 = new Cidade("Viseu", 200, 160);
            GerenciaRota.AddCidade(cidade7);
            Cidade cidade8 = new Cidade("Setúbal", 140, 140);
            GerenciaRota.AddCidade(cidade8);
            Cidade cidade9 = new Cidade("Samora", 40, 120);
            GerenciaRota.AddCidade(cidade9);
            Cidade cidade10 = new Cidade("Beja", 100, 120);
            GerenciaRota.AddCidade(cidade10);
            Cidade cidade11 = new Cidade("Aveiro", 180, 100);
            GerenciaRota.AddCidade(cidade11);
            Cidade cidade12 = new Cidade("Barcelos", 60, 80);
            GerenciaRota.AddCidade(cidade12);
            Cidade cidade13 = new Cidade("Faro", 120, 80);
            GerenciaRota.AddCidade(cidade13);
            Cidade cidade14 = new Cidade("Guimarães", 180, 60);
            GerenciaRota.AddCidade(cidade14);
            Cidade cidade15 = new Cidade("Leiria", 20, 40);
            GerenciaRota.AddCidade(cidade15);
            Cidade cidade16 = new Cidade("Odivelas", 100, 40);
            GerenciaRota.AddCidade(cidade16);
            Cidade cidade17 = new Cidade("Sines", 200, 40);
            GerenciaRota.AddCidade(cidade17);
            Cidade cidade18 = new Cidade("Tonela", 200, 20);
            GerenciaRota.AddCidade(cidade18);
            Cidade cidade19 = new Cidade("Coimbra", 60, 20);
            GerenciaRota.AddCidade(cidade19);
            Cidade cidade20 = new Cidade("Almada", 160, 20);
            GerenciaRota.AddCidade(cidade20);
            Cidade cidade21 = new Cidade("Cascais", 150, 55);
            GerenciaRota.AddCidade(cidade21);
            Cidade cidade22 = new Cidade("Almeirim", 10, 20);
            GerenciaRota.AddCidade(cidade22);
            Cidade cidade23 = new Cidade("Chaves", 25, 85);
            GerenciaRota.AddCidade(cidade23);
            Cidade cidade24 = new Cidade("Faro", 185, 35);
            GerenciaRota.AddCidade(cidade24);
            Cidade cidade25 = new Cidade("Maia", 100, 95);
            GerenciaRota.AddCidade(cidade25);
            int taxaGeracao = 90;

            GerenciaRota rota = new GerenciaRota();
            rota.GeraRota();
            rota.GeraRota2();
            rota.GeraRota3();
            rota.GeraRota4();
            rota.GeraRota5();
            rota.GeraRota6();
            rota.GeraRota7();
            rota.GeraRota8();
            rota.GeraRota9();
            rota.GeraRota10();
            for (int i = 1; i < 1001; i++)
            {
                if (taxaGeracao == 30)
                {
                    Console.WriteLine("Geração: " + i);
                    rota.Selecao30(rota.Get1(), rota.Get2(), rota.Get3());
                    rota.SubstituiRotas();
                    rota.Mutar();
                    rota.ZeraVetores();
                }
                else if (taxaGeracao == 60)
                {
                    Console.WriteLine("Geração: " + i);
                    rota.Selecao60(rota.Get1(), rota.Get2(), rota.Get3(), rota.Get4(), rota.Get5(), rota.Get6());
                    rota.SubstituiRotas();
                    rota.Mutar();
                    rota.ZeraVetores();
                }
                else
                {
                    Console.WriteLine("Geração: " + i);
                    rota.Selecao90(rota.Get1(), rota.Get2(), rota.Get3(), rota.Get4(), rota.Get5(), rota.Get6(), rota.Get7(), rota.Get8(), rota.Get9());
                    rota.SubstituiRotas();
                    rota.Mutar();
                    rota.ZeraVetores();
                }
            }
            Console.ReadLine();
    }
    }
}
