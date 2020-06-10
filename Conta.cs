using System;
using UsuarioClasse;
using MotoristaClasse;

namespace ContaClasse
{
    class Conta : Motorista
    {
        public string agencia {get;set;}
        public string conta {get;set;}
      
        public Conta (string agencia, string conta,string carro, string placa, string loginQuePassei, string senhaQuePassei, string nomeQuePassei) : base( carro,  placa, loginQuePassei ,  senhaQuePassei,  nomeQuePassei)
        {
            this.agencia = agencia;
            this.conta = conta;
        }
       
        public string cadastrar ( )
        {
            Console.WriteLine (" Sua conta foi cadastrada com sucesso. ");
            
        }
        
        public void excluir ()
        {
        
            Console.WriteLine(" Sua conta foi excluida com sucesso");


        }

        public void funcaoAleatoria()
        {
            
        }

    }


}