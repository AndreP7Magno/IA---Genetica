using System;

namespace IA___Genetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dirPath = @"C:\Users\Willian\Desktop\TSPLIB95";
            //TspLib95 library = new TspLib95(dirPath);
            //int counter = library.LoadTSP("bays29");
            //Console.WriteLine("Loaded problems: " + counter);

            Cidade cidade = new Cidade("Lisboa", 60, 200);
            GerenciaRota.addCidade(cidade);
            Cidade cidade2 = new Cidade("Santarém", 180, 200);
            GerenciaRota.addCidade(cidade2);
            Cidade cidade3 = new Cidade("Braga", 80, 180);
            GerenciaRota.addCidade(cidade3);
            Cidade cidade4 = new Cidade("Bragança", 140, 180);
            GerenciaRota.addCidade(cidade4);
            Cidade cidade5 = new Cidade("Porto", 20, 160);
            GerenciaRota.addCidade(cidade5);
            Cidade cidade6 = new Cidade("Portalegre", 100, 160);
            GerenciaRota.addCidade(cidade6);
            Cidade cidade7 = new Cidade("Viseu", 200, 160);
            GerenciaRota.addCidade(cidade7);
            Cidade cidade8 = new Cidade("Setúbal", 140, 140);
            GerenciaRota.addCidade(cidade8);
            Cidade cidade9 = new Cidade("Samora", 40, 120);
            GerenciaRota.addCidade(cidade9);
            Cidade cidade10 = new Cidade("Beja", 100, 120);
            GerenciaRota.addCidade(cidade10);
            Cidade cidade11 = new Cidade("Aveiro", 180, 100);
            GerenciaRota.addCidade(cidade11);
            Cidade cidade12 = new Cidade("Barcelos", 60, 80);
            GerenciaRota.addCidade(cidade12);
            Cidade cidade13 = new Cidade("Faro", 120, 80);
            GerenciaRota.addCidade(cidade13);
            Cidade cidade14 = new Cidade("Guimarães", 180, 60);
            GerenciaRota.addCidade(cidade14);
            Cidade cidade15 = new Cidade("Leiria", 20, 40);
            GerenciaRota.addCidade(cidade15);
            Cidade cidade16 = new Cidade("Odivelas", 100, 40);
            GerenciaRota.addCidade(cidade16);
            Cidade cidade17 = new Cidade("Sines", 200, 40);
            GerenciaRota.addCidade(cidade17);
            Cidade cidade18 = new Cidade("Tonela", 200, 20);
            GerenciaRota.addCidade(cidade18);
            Cidade cidade19 = new Cidade("Coimbra", 60, 20);
            GerenciaRota.addCidade(cidade19);
            Cidade cidade20 = new Cidade("Almada", 160, 20);
            GerenciaRota.addCidade(cidade20);
            Cidade cidade21 = new Cidade("Cascais", 150, 55);
            GerenciaRota.addCidade(cidade21);
            Cidade cidade22 = new Cidade("Almeirim", 10, 20);
            GerenciaRota.addCidade(cidade22);
            Cidade cidade23 = new Cidade("Chaves", 25, 85);
            GerenciaRota.addCidade(cidade23);
            Cidade cidade24 = new Cidade("Faro", 185, 35);
            GerenciaRota.addCidade(cidade24);
            Cidade cidade25 = new Cidade("Maia", 100, 95);
            GerenciaRota.addCidade(cidade25);

            GerenciaRota lista = new GerenciaRota();
            //lista.PrintaCidade();
            GerenciaRota rota = new GerenciaRota();
            GerenciaRota rota2 = new GerenciaRota();
            GerenciaRota rota3 = new GerenciaRota();
            GerenciaRota rota4 = new GerenciaRota();
            GerenciaRota rota5 = new GerenciaRota();
            rota.GeraRota();
            //rota.PrintaRota();
            rota.GeraRota2();
            //rota.PrintaRota2();
            rota.GeraRota3();
            //rota.PrintaRota3();
            rota.GeraRota4();
            //rota.PrintaRota4();
            rota.GeraRota5();
            //rota.PrintaRota5();
            rota.Selecao(rota.GetMelhor(), rota.GetPior());
            Console.ReadLine();
    }
    }
}
