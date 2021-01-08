using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsumirTipos.ConsumirTipos
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                  "\"Para\": \"Guilherme Silveira\"}";

            var mensagem = JsonConvert.DeserializeObject<Mensagem>(json);

            EnviarMensagem(mensagem);

            //dynamic + ExpandoObject remove a necessidade de criar a classe Mensagem, 
            //porém facilita muito os erros em tempo de execução

            dynamic mensagemDinamica = JsonConvert.DeserializeObject<ExpandoObject>(json);
            mensagemDinamica.Texto = "Olá, " + mensagem.Para;
            EnviarMensagem(mensagemDinamica);

            mensagemDinamica.Inverter = new Action(() => { 
                var aux = mensagemDinamica.De;
                mensagemDinamica.De = mensagemDinamica.Para;
                mensagemDinamica.Para = aux;
                mensagemDinamica.Texto = "Olá, " + mensagem.De;
            });           

            mensagemDinamica.Inverter();
            EnviarMensagem(mensagemDinamica);
    }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }

    class Mensagem
    {
        public string De { get; set; }
        public string Para { get; set; }
        public string Texto { get; set; }
    }
}
