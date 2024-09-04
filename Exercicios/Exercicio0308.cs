using CursoCSharp.Guia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
    }
}
