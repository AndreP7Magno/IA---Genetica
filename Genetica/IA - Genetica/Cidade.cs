using System;

namespace IA___Genetica
{
    public class Cidade
    {
        private int x;
        //Posição Y da cidade no mapa
        private int y;
        //Nome da cidade
        private String name;

        //Construtor da classe
        public Cidade(String name1, int x1, int y1)
        {
            name = name1;
            x = x1;
            y = y1;
        }


        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
        public String getName()
        {
            return name;
        }

        public double distanciaParaProximaCidade(Cidade cidade)
        {
            double distancia = 0;
            return distancia;
        }
    }
}
