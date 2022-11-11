using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade02
{
    internal class Funcionario
    {
        private string nome;
        private int matricula;
        private double salario;
        public Funcionario (string nome, int matricula, double salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = salario;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }
        public void imprimir()
        {
            Console.WriteLine("Salários acima da média: " + this.nome + " " + this.matricula);
        }
    }
}

namespace atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media; double soma=0;
            Funcionario[] lista = new Funcionario[4];
            lista[0] = new Funcionario("Thiago", 400, 1400.50);
            lista[1] = new Funcionario("Pedro", 401, 1500.50);
            lista[2] = new Funcionario("Maria", 402, 1600.52);
            lista[3] = new Funcionario("Daniel", 403, 1400.50);
            for (int i = 0; i < lista.Length; i++)
            {
                soma += lista[i].getSalario();
            }
            media = (float)(soma / 4);
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].getSalario() > media)
                {
                lista[i].imprimir();
                }
            }
        }
    }
}