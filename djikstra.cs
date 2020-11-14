using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DjikstraAlgorithm
{
    class Dijkstra
    {

        private static int DistanciaMinima(int[] distancia, bool[] menorCaminhoArvore, int qtdVertices)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < qtdVertices; ++v)
            {
                if (menorCaminhoArvore[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        

        public static ProjetoIntegradorDijkstra.RetornoDijkstra DijkstraAlgo(int[,] graf, int origem, int qtdVertices)
        {
            ProjetoIntegradorDijkstra.RetornoDijkstra retornoDijkstra = new ProjetoIntegradorDijkstra.RetornoDijkstra();
            int[] distancia = new int[qtdVertices];
            bool[] menorCaminhoArvore = new bool[qtdVertices];

            for (int i = 0; i < qtdVertices; ++i)
            {
                distancia[i] = int.MaxValue;
                menorCaminhoArvore[i] = false;
            }

            distancia[origem] = 0;

            for (int count = 0; count < qtdVertices - 1; ++count)
            {
                int u = DistanciaMinima(distancia, menorCaminhoArvore, qtdVertices);
                menorCaminhoArvore[u] = true;

                for (int v = 0; v < qtdVertices; ++v)
                    if (!menorCaminhoArvore[v] && Convert.ToBoolean(graf[u, v]) && distancia[u] != int.MaxValue && distancia[u] + graf[u, v] < distancia[v])
                        distancia[v] = distancia[u] + graf[u, v];
            }
            retornoDijkstra.distancia = distancia;
            retornoDijkstra.qtdVertices = qtdVertices;
            return retornoDijkstra;
        }
    }
}