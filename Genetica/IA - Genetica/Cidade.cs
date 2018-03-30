using System;

namespace IA___Genetica
{
    public class Cidade
    {
        private int x;
        //Posição Y da cidade no mapa
        private int y;
        //Nome da cidade
        private String nome;

        //Construtor da classe
        public Cidade(String nome1, int x1, int y1)
        {
            nome = nome1;
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
        public String getNome()
        {
            return nome;
        }

        public double DistanciaParaProximaCidade(Cidade cidade)
        {
            int xDif = Math.Abs(this.x - cidade.x);
            int yDif = Math.Abs(this.y - cidade.y);
            double distancia = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distancia;
        }
        override
        public String ToString()
        {
            return "" + nome + "(" + x + "," + y + ")";
        }
    }
}
