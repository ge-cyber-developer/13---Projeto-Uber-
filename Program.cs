using System;

using UsuarioClasse;

using MotoristaClasse;

namespace S
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorista Georgia = new Motorista("Ferrari", "ice-069","georginha","123456","Georgia Souza Duarte");
            Georgia.Login();
            Georgia.aceitarPassageiro("André");
            Georgia.Logout();
        }
    }
}
