using System;

namespace UsuarioClasse
{
    class Usuario
    {
        public string login {get;set;}
        public string senha {get;set;}
        public string nome {get;set;} 
        public string foto {get;set;}
        public string localizacaoAtual {get;set;}
        public string tokenDeLogin {get;set;}

        public Usuario(string loginQuePassei, string senhaQuePassei, string nomeQuePassei)
        {
            this.login = loginQuePassei;
            this.senha = senhaQuePassei;
            this.nome = nomeQuePassei;
        }

        public bool Login()
        {
            Console.WriteLine("[USUARIO] "+this.nome+" logou.");
            return true;
        }

        public void Logout()
        {
            Console.WriteLine("[USUARIO] "+this.nome+" deslogou.");
        }

    }

    


}