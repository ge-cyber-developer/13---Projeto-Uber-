using System;
using UsuarioClasse;


namespace MotoristaClasse
{
    class Motorista 
    {
        public string carro {get;set;}
        public string placa {get;set;}

        public Motorista (string carro, string placa)
        {
            this.carro = carro;
            this.placa = placa;
        }

        public string aceitarPassageiro(string nomeDoPassageiro)
        {
            Console.WriteLine("[MOTORISTA] "+this.nome+" a/o "+nomeDoPassageiro +" está a sua espera.");
            return "pedido aceito";
        }

        public bool receberPagamento()
        {
            Console.WriteLine("Passageiro pagou a corrida.");
            return true;            
        }
    }

}