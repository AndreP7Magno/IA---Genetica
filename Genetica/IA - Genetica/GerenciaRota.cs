using System.Collections.Generic;

namespace IA___Genetica
{
    public class GerenciaRota
    {
        private static List<Cidade> cidadesDestino = new List<Cidade>();

        //Adiciona uma cidade à lista de cidades
        public static void addCidade(Cidade cidade)
        {
            cidadesDestino.Add(cidade);
        }
    }
}
