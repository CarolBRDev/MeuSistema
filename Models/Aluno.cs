using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroNotas.Models
{
    [Table("Alunos")]

    public class Aluno
    {
        public string NomeCompleto { get; private set; }
        public string Matricula { get; private set; }
        public string Senha { get; set; }
        public Dictionary<string, List<double>> Disciplinas { get; private set; }
        public double Presenca { get; private set; }

        public Aluno(string nomeCompleto, string matricula, string senha, int presenca)
        {
            NomeCompleto = nomeCompleto;
            Matricula = matricula;
            Senha = senha;
            Presenca = presenca;
            Disciplinas = new Dictionary<string, List<double>>();

        }

        public static Aluno CadastrarAluno()
        {
            Console.WriteLine("Digite o nome completo do aluno:");
            string nomeCompleto = Console.ReadLine();
            
            Console.WriteLine("Insira a matricula:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Insira a senha:");
            string senha = Console.ReadLine();

            Console.WriteLine("Insira o número de faltas:");
            int presenca = int.Parse(Console.ReadLine());

            return new Aluno(nomeCompleto, matricula, senha, presenca);
        }

        public void AdicionarDisciplina(string disciplina)
        {
            if (!Disciplinas.ContainsKey(disciplina))
            {
                Disciplinas[disciplina] = new List<double>();
            }
            else
            {
                Console.WriteLine("Disciplina já existe.");
            }
        }

        public void AdicionarNotas(string disciplina, double nota)
        {
            if (Disciplinas.ContainsKey(disciplina))
            {
                Disciplinas[disciplina].Add(nota);
                Console.WriteLine($"Disciplina: {disciplina} | Nota: {nota}");
            }
            else
            {
                Console.WriteLine("Disciplina não encontrada");
            }
        }

    }


}

