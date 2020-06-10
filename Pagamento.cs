using System;
using PassageiroClasse;
using MotoristaClasse;


namespace Pagamento 
{
    class Pagamento : Passageiro , Motorista 
    {
        
        public dateTime data {get;set;}
        public string status {get;set;}

        public Pagamento  (dateTime data , string status)
        {
            this.data = data;
            this.status = status;
        }
    }

}