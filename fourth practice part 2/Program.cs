using System;

namespace fourth_practice_part_2
{
    class Program
    {
        delegate bool MyDelegate1(int x);
        delegate double MyDelegate2(double precio);
        delegate DateTime MyDelegate3();

        static void Main(string[] args)
        {
            //Metodo EsImpar escrito como expresion lambda
            MyDelegate1 delegado1 = new MyDelegate1(x => (x % 2) != 0);

            //Metodo CalcularITBIS escrito como expresion lambda
            MyDelegate2 delegado2 = new MyDelegate2(precio => {
                var itebis = precio * 0.18;
                return itebis;
            });

            //Metodo GetDate() escrito como expresion lambda
            MyDelegate3 delegado3 = new MyDelegate3( () => {
                var fecha = DateTime.Now;
                return fecha;
            });
        }

    }
}
