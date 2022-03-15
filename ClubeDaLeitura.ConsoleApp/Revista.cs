using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista
    {
        public string tipo_colecao;
        public int numero_edicao;
        public DateTime ano_revista;
        public Caixa[] caixas;

        public int DefinirPosicaoParaCaixa()
        {
            int posicao = -1;//caso não exista posicao retorna -1
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }
    }
}