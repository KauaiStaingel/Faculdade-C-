using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3009_heranca
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string endereco;
        private string rg;

        public Pessoa(string nome, string cpf, string endereco, string rg)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.rg = rg;
        }

        public Pessoa()
        {
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public void ImprimePessoa()
        {
            Console.WriteLine(this.nome + " " + this.cpf + " " + this.endereco + " " + this.cpf);
        }

    }
}


namespace _3009_heranca
{
    class Aluno : Pessoa
    {
        private int matricula;
        private int falta;
        private float p1;
        private float p2;

        public Aluno(string nome, string cpf, string endereco, string rg, int matricula, int falta, float p1, float p2) : base(nome, cpf, endereco, rg)
        {
            this.matricula = matricula;
            this.falta = falta;
            this.p1 = p1;
            this.p2 = p2;
        }

        public Aluno()
        {
        }

        public int getMatricula()
        {
            return this.matricula;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public int getFalta()
        {
            return this.falta;
        }
        public void setFalta(int falta)
        {
            this.falta = falta;
        }

        public float getP1()
        {
            return this.p1;
        }
        public void setP1(float p1)
        {
            this.p1 = p1;
        }

        public float getP2()
        {
            return this.p2;
        }
        public void setP2(float p2)
        {
            this.p2 = p2;
        }

        public void imprimeAluno()
        {
            Console.WriteLine("Dados do aluno>>  Nome: " + getNome() + " CPF: " + getCpf() + " endereco: " + getEndereco() + " RG: " + getRg() + " Matricula: " + this.matricula);
        }

        public void imprimeFaltas()
        {
            Console.WriteLine("Total de faltas: " + this.falta);
        }

        public void imprimeResultado()
        {
            float media = (this.p1 + this.p2) / 2;

            if (this.falta > 10 || media < 3.0)
            {
                Console.WriteLine("Reprovado.");
            }
            if (media > 7.0)
            {
                Console.WriteLine("Aprovado.");
            }
            if (media > 3.0 && media < 7.0)
            {
                Console.WriteLine("Reavaliação.");
            }
            
        }
            

    }
}

namespace _3009_heranca
{
    class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.setNome("Pedro");
            a1.setEndereco("Rua Almeida, 20");
            a1.setCpf("456.876.123-12");
            a1.setRg("4.687.098-2");
            a1.setMatricula(59751);
            a1.setP1(4.5f);
            a1.setP2(8.0f);
            a1.setFalta(10);

            a1.imprimeAluno();
            a1.imprimeFaltas();
            a1.imprimeResultado();

        }
    }
}
