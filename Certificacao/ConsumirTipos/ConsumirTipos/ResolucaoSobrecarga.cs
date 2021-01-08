using System;

namespace ConsumirTipos.ConsumirTipos
{
    class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;
            var test = Somar(int1, int2);
            object obj = Somar(int1, int2);

            Console.WriteLine($"soma: {test}, {obj}");
            Console.WriteLine();

            short short1 = 123;
            short short2 = 456;
            short resultado = (short)Somar(short1, short2);
            obj = Somar(short1, short2);
            Console.WriteLine($"short: {resultado}, {obj}");
            Console.WriteLine();

            double double1 = 123.45;
            double double2 = 456.78;

            double resultadodouble = (double)Somar(double1, double2);
            obj = Somar(double1, double2);
            Console.WriteLine($"resultado double: {resultadodouble}, {obj}");
            Console.WriteLine();

            Console.WriteLine($"Somar('ABc', 'xyz'): {Somar("ABc", "xyz")}");
        }

        int Somar(int parcela1, int parcela2)
        {
            Console.WriteLine("int Somar(int parcela1, int parcela2)");
            return parcela1 + parcela2;
        }
        //Se descomentar essa função não precisa do cast no short 
        //short Somar(short parcela1, short parcela2)
        //{
        //    Console.WriteLine("short Somar(short parcela1, short parcela2)");
        //    return (short)(parcela1 + parcela2);
        //}

        //object Somar(object parcela1, object parcela2)
        //{
        //    Console.WriteLine("object Somar(object parcela1, object parcela2)");
        //    return (double)parcela1 + (double)parcela2;
        //}

        //dynamic causa o mesmo efeito do object porém não precisa o cast na soma 
        //e não permite a sobrecarga pois o compilador considera ambos como object durante a compilação e não conseguiria resolver a sobrecarga
        dynamic Somar(dynamic parcela1, dynamic parcela2)
        {
            Console.WriteLine("dynamic Somar(object parcela1, object parcela2)");
            return parcela1 + parcela2;
        }
    }
}
