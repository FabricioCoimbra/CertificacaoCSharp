using System;

namespace CriarTipos.Tipos
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            // pivate dentro da classe
            // internal dentro do projeto
            // public irestrito
            // proteced para os descendentes.

            Retangulo retangulo = new Retangulo(altura: 12, largura: 10);
            Console.WriteLine("retangulo.GetArea() " + retangulo.Area);

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine("retangulo.Semelhante(outroRetangulo) " + retangulo.Semelhante(outroRetangulo));

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine("retangulo.Semelhante(outroRetangulo) " + retangulo.Semelhante(outroRetangulo));

            Console.WriteLine("Retangulo.Semelhante(retangulo, outroRetangulo) " + Retangulo.Semelhante(retangulo, outroRetangulo));
        }
    }
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Area => Altura * Largura;
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");
        }        
        public bool Semelhante(Retangulo OutroRetangulo)
        {
            return
               ((Largura / Altura) == /*proporção deste retângulo*/
               (OutroRetangulo.Largura / OutroRetangulo.Altura)) /*proporção do outro retângulo*/
               ||
               ((Altura / Largura) == /*compara a proporção inversa*/
               (OutroRetangulo.Largura / OutroRetangulo.Altura));
        }
        public static bool Semelhante(Retangulo retangulo, Retangulo OutroRetangulo)
        {
            return
               ((retangulo.Largura / retangulo.Altura) ==        /*proporção deste retângulo*/
               (OutroRetangulo.Largura / OutroRetangulo.Altura)) /*proporção do outro retângulo*/
               ||
               ((retangulo.Altura / retangulo.Largura) ==        /*compara a proporção inversa*/
               (OutroRetangulo.Largura / OutroRetangulo.Altura));
        }
    }
}
