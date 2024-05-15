using System;
using System.Collections.Generic;
using CadastroNotas.Controllers;

namespace CadastroNotas.Views
{
    public class View{
        public static void ExibirMenu()
        {
            Console.WriteLine("===== Cadastro de Alunos =====");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Mostrar Boletim");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public static void ExibirBoletim(AlunoController controller)
        {
            Console.WriteLine("===== Boletim =====");
            controller.MostrarBoletim();
            Console.WriteLine("====================");
        }

        public static void LimparTela()
        {
            Console.Clear();
        }
    }
}


