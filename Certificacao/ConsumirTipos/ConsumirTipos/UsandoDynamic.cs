using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumirTipos.ConsumirTipos
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            string s = "Certificação C#";
            var v = "Certificação C#";
            object o = "Certificação C#";
            Imrpime(s, v, o);
            Console.WriteLine(o.GetType());
            o = 123;

            o = (int)o + 4;
            Console.WriteLine(o.GetType());
            o = v;

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Imrpime(s, v, o);

            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d += 4;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
        }

        private static void Imrpime(string s, string v, object o)
        {
            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine();
        }
    }
}
