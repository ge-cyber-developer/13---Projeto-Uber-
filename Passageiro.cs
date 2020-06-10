using System;
using UsuarioClasse;


namespace PassageiroClasse
{
    class Passageiro
    {
        public string solicitarMotorista( )
        {
            Console.WriteLine (" Sua solicitação foi efetuada.");
            
        }
        
        public bool pagar ()
        {
        
            Console.WriteLine("Seu pagamento foi efetuado.");
            return true

        }
    }

}