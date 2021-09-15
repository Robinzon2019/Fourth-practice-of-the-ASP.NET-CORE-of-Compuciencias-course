using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_practice
{
    delegate bool MyDelegate(int numero); 
    public static class Helper
    {
        public static List<int> Pares(this List<int> listaEnteros)
        {
            List<int> listaPares;
            MyDelegate delegado = new MyDelegate(i => (i % 2) == 0);
            listaPares = listaEnteros.FindAll(delegado.Invoke);
            return listaPares;
        }
    }
}
