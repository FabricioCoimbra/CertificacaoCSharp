using System;
using System.Collections.Generic;
using CriarTipos.Tipos;

namespace CriarTipos
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {
            menuItems = GetMenuItems();

            while (true)
            {
                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);

                if (valorOpcao == 0)
                {
                    break;
                }

                if (valorOpcao > menuItems.Count)
                {
                    break;
                }

                Executar(valorOpcao);
                Console.ReadKey();
            }
        }

        private static IAulaItem Executar(int valorOpcao)
        {
            MenuItem menuItem = menuItems[valorOpcao - 1];
            IAulaItem itemSelecionado = (IAulaItem)Activator.CreateInstance(menuItem.TipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado.Executar();
            Console.WriteLine("\n Tecle algo para continuar...");
            return itemSelecionado;
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Tipos de Valor", typeof(TiposDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Ponto Flututante", typeof(TiposFlutuantes)),
                new MenuItem("Decimal", typeof(TiposDecimais)),
                new MenuItem("Booleanos", typeof(TiposBooleanos)),
                new MenuItem("Estruturas", typeof(Estruturas)),
                new MenuItem("Enumeracoes", typeof(TiposEnumeracoes)),
                new MenuItem("Tipos de Refêrencia", typeof(TiposDeReferencia)),
                new MenuItem("Classes", typeof(TiposClasses)),
                new MenuItem("Interfaces", typeof(TipoInterfaces)),
                new MenuItem("Delegates", typeof(Delegates)),
                new MenuItem("Objetos", typeof(Objetos)),
                new MenuItem("Dinâmicos", typeof(Dinamicos)),
                new MenuItem("Strings", typeof(TiposStrings)),
                new MenuItem("Metodos", typeof(Metodos)),
                new MenuItem("Parâmetros Nomeados", typeof(ParametrosNomeados)),
                new MenuItem("Parâmetros Opcionais", typeof(ParametrosOpcionais)),
                new MenuItem("Métodos de Extensão", typeof(MetodosDeExtensao)),
                new MenuItem("Propriedades Indexadas", typeof(PropriedadesIndexadas)),
                new MenuItem("Sobrecargas", typeof(Sobrecargas)),
                new MenuItem("Métodos Substituidos", typeof(MetodosSubstituidos))          
            };
        }
    }
}
