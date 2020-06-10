using System;
using UsuarioClasse;


namespace CorridaClasse
{
    class Corrida 
    {
        public string localInicio  {get;set;}
        public string localchegando {get;set;}
        public string statuscorrida {get;set;}
        public string motorista {get;set;}
        public string passageiro {get;set;}
    
        public Corrida (string localinicio , string localchegando, string statuscorrida, string motorista, string passageiro) 
        { 
            this.localinicio  = localinicio;
            this.localchegando = localchegando;
            this.statuscorrida = statuscorrida;
            this.motorista = motorista;
            this.passageiro = passageiro;
        }

        public string cancelar()
        {
            Console.WriteLine("[MOTORISTA] "+this.nome+" a/o "+nomeDoPassageiro +" cancelou a corrida.");
            return "corrida cancelada";
        }
    }

}