using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroNotas.Model {
    public class Usuarios {

        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuarios(string login, string senha) {
            Login = login;
            Senha = senha;
        }

        public static Usuarios LoginUsuario () {
            Console.WriteLine("Insira seu login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Insira sua senha: ");
            string senha = Console.ReadLine();

            return new Usuarios(login, senha);
        }

    }
}