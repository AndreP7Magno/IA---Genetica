using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA___Genetica
{
    class Rota
    {
        private List<Cidade> rota = new List<Cidade>();
        private Double fitness = 0;
        private Double distancia = 0;

        public Rota()
        {
            for (int i = 0; i < GerenciaRota.NumeroDeCidades(); i++)
            {
                rota.Add(null);
            }
        }

        public Rota(List<Cidade> rota1)
        {
            rota = rota1;
        }

        public void geraRota()
        {
            
        }
    }
}
