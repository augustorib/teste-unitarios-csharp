using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{


    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;


        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int n1, int n2)
        {
            int res = n1 + n2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data );

            return res;
        }

        public int subtrair(int n1, int n2)
        {
            int res = n1 - n2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);

            return res;
        }

        public int multiplicar(int n1, int n2)
        {
            int res = n1 * n2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            
            return res;
        }

        public int dividir(int n1, int n2)
        {   
            int res = n1/n2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);

            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
