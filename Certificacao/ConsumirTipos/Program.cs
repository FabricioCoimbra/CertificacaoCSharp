﻿using ConsumirTipos.ConsumirTipos;
using System;
using System.Collections.Generic;

namespace ConsumirTipos
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
                new MenuItem("Boxing e Unboxing", typeof(Boxing)),
                new MenuItem("Conversoes Implícitas", typeof(ConversoesImplicitas)),
                new MenuItem("Conversoes Explícitas", typeof(ConversoesExplicitas)),
                new MenuItem("Operadores IS e AS", typeof(OperadoresISeAS)),
                new MenuItem("Operadores de Conversão", typeof(OperadoresDeConversao)),
                new MenuItem("Métodos Auxiliares de Conversão", typeof(MetodosAuxiliares)),
                new MenuItem("Usando Dynamic", typeof(UsandoDynamic)),
                new MenuItem("Conversões de Dynamic", typeof(ConversoesDeDynamic)),
                new MenuItem("Resolucão de Sobrecarga", typeof(ResolucaoSobrecarga)),
                new MenuItem("Usando ExpandObject", typeof(UsandoExpandObject)),
                new MenuItem("Interoperabilidade COM", typeof(InteropCOM))                
            };
        }
    }

}
