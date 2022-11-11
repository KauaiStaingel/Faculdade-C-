using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoes_071022
{
    class Departamento
    {
        public string nome;
        ArrayList lista = new ArrayList();

        public Departamento(string nome)
        {
            this.nome = nome;
        }

        public void adicionaFuncionario(Funcionario f)
        {
            lista.Add(f);
        }

        public void imprimeDepartamento()
        {
            foreach (Funcionario funcionario in lista)
            {
                Console.WriteLine(funcionario.getNome()+" "+funcionario.getMatricula()+" "+funcionario.getCpf());
            }
        }
    }
}

namespace colecoes_071022
{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private string cpf;

        public Funcionario (string nome,int matricula,string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void imprimeFuncionario()
        {
            Console.WriteLine("Nome: " + this.nome + " Matricula: " + this.matricula + " CPF: " + this.cpf);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Departamento d1 = new Departamento("vendas");
        Funcionario f1 = new Funcionario("maria", 123, "6765657");
        Funcionario f2 = new Funcionario("pedro", 789, "2213438");
        d1.adicionaFuncionario(f1);
        d1.adicionaFuncionario(f2);
        d1.imprimeDepartamento();
    }
}