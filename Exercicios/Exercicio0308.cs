using CursoCSharp.Guia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static CursoCSharp.Exercicios.EscopoVariaveisExercicio;

namespace CursoCSharp.Exercicios
{
    public class Pessoa
    {

        string? nome;
        int? idade;

        /*1. Classe e Instanciação Básica
        Crie uma classe chamada Pessoa com as propriedades Nome e Idade.Adicione um construtor
        que inicialize essas propriedades e um método Falar que imprima uma mensagem dizendo
        &quot; Olá, meu nome é[Nome] e eu tenho[Idade] anos.&quot;. Em seguida, crie uma instância da classe
        Pessoa, defina os valores das propriedades e chame o método Falar.*/

        public Pessoa(string Nome, int Idade)
        {
            this.nome = Nome;
            this.idade = Idade;
        }
        public void ImprimaMenssagem(string Nome, int idade)
        {
            Console.WriteLine($"Ola meu nome é {nome} e eu tenho {idade}");
        }

        /*2. Métodos com Parâmetros
        Crie uma classe Calculadora com um método Soma que recebe dois parâmetros inteiros e
        retorna a soma deles.Adicione também um método Subtracao que realiza a subtração de dois
        números.Instancie a classe Calculadora, use os métodos para fazer algumas operações e exiba
        os resultados.*/

        public class Calculadora
        {
            public int Soma(int a, int b)
            {
                return a + b;
            }

            public int subtracao(int a, int b)
            {
                return a - b;
            }
        }

        /*3. Encapsulamento e Propriedades
        Crie uma classe Carro com as propriedades Modelo, Ano e Preco.Utilize propriedades
        automáticas para encapsular essas informações. Adicione um método ExibirInfo que exiba os
        detalhes do carro.Instancie a classe Carro, defina valores para as propriedades e chame o
        método ExibirInfo.*/

        public class Carro
        {
            public string? Modelo;
            public string? Ano;
            public string? Preco;

            public void ExibirMetodo(string Modelo,int Ano,int Preco)
            {
                Console.WriteLine($"O Modelo do Carro é {Modelo} o ano é {Ano} e o preco é {Preco}");
            }
        }

        /*4. Métodos Estáticos
        Crie uma classe Matematica com um método estático Fatorial que calcula o fatorial de um
        número inteiro não-negativo.O método deve retornar o resultado.Utilize o método Fatorial
        para calcular o fatorial de alguns números e exiba os resultados.*/

        public class Matematica
        {
            public static int Fatorial(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentException("O número deve ser não-negativo.");
                }

                int resultado = 1;
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }

        /*5. Construtores Sobrecarrregados
        Crie uma classe Retangulo com propriedades Largura e Altura.Implemente dois construtores:
        um que aceita largura e altura como parâmetros e outro que usa valores padrão(largura e
        altura de 1). Adicione um método CalcularArea que retorna a área do retângulo.Instancie a
        classe Retangulo usando ambos os construtores e exiba a área calculada.*/

        public class Retangulo
        {
            public double Largura { get; set; }
            public double Altura { get; set; }

            public Retangulo(double largura, double altura)
            {
                this.Largura = largura;
                this.Altura = altura;
            }

            public Retangulo()
            {
                Largura = 1;
                Altura = 1;
            }

            public double CalcularArea()
            {
                return Largura * Altura;
            }
        }

        /*6. Métodos de Instância e Estáticos
        Crie uma classe Pessoa com um método de instância AumentarIdade que incrementa a idade
        da pessoa e um método estático CriarPessoa que cria uma nova instância de Pessoa com idade
        inicial de 0. Instancie a classe usando o método estático e chame o método AumentarIdade.*/

        public class NewPessoa
        {
            public int Idade = 0;
            public int AumentarIdade()
            {
                return Idade++;
            }

            public int CriarPessoa()
            {
                return Idade = 0;
            }
        }
    }
}
