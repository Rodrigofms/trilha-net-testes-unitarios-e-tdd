using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes_Console.Models
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;
        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }
        public int somar(int val1, int val2)
        {
            int val3 = val1 + val2;
            historico.Insert(0, $"Res {val3} | {data}");
            return val3;
            
        }
        public int subtrair(int val1, int val2)
        {
            int val3 = val1 - val2;
            historico.Insert(0, $"Res {val3} | {data}");
            return val3;
        }
        public int dividir(int val1, int val2)
        {
            int val3 = val1 / val2;
            historico.Insert(0, $"Res {val3} | {data}");
            return val3;

        }
        public int multiplicar(int val1, int val2)
        {
            int val3 = val1 * val2;
            historico.Insert(0, $"Res {val3} | {data}");
            return val3;
        }
        public List<string> hitorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}