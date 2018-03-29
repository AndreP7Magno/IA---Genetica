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

            //bla
        }
    }
}
