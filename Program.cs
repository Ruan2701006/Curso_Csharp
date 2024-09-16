﻿using Curso_C_;
using CursoCSharp;
using CursoCSharp.Paradigmas;
using System;
using System.Collections.Generic;
using System.Text.Json;

/*namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}*/

/*// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();*/

/*/ Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();*/

/*// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/

/*// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/

/*AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();*/

/*// Criando instâncias de classes que implementam a interface
IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();*/

/*var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Marcenaria
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Servico> servicos = new List<Servico>();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE MARCENARIA   ========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Clientes");
                Console.WriteLine("2. Gerenciar Serviços");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuClientes();
                        break;
                    case 2:
                        MenuServicos();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuClientes()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR CLIENTES   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Remover Cliente");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        RemoverCliente();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuServicos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR SERVIÇOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Serviço");
                Console.WriteLine("2. Listar Serviços");
                Console.WriteLine("3. Atualizar Serviço");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarServico();
                        break;
                    case 2:
                        ListarServicos();
                        break;
                    case 3:
                        AtualizarServico();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarCliente()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO CLIENTE   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (clientes.Any(c => c.Cpf == cpf))
            {
                Console.WriteLine("\nCliente com este CPF já existe.");
                return;
            }

            Cliente cliente = new Cliente(nome, cpf);
            clientes.Add(cliente);
            Console.WriteLine("\nCliente adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarClientes();
        }

        static void ListarClientes()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   LISTA DE CLIENTES CADASTRADOS   =========");
            Console.WriteLine("==============================================");

            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
            else
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {clientes[i].Nome} - CPF: {clientes[i].Cpf}");
                }
            }
        }

        static void RemoverCliente()
        {
            ListarClientes();
            Console.Write("\nDigite o número do cliente a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < clientes.Count)
            {
                clientes.RemoveAt(indice);
                Console.WriteLine("\nCliente removido com sucesso!");
                SalvarClientes(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void AdicionarServico()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO SERVIÇO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a descrição do serviço: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o valor do serviço: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Servico servico = new Servico(descricao, valor);
            servicos.Add(servico);
            Console.WriteLine("\nServiço adicionado com sucesso!");
            SalvarServicos(); // Atualiza o arquivo após adicionar serviço
        }

        static void ListarServicos()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   LISTA DE SERVIÇOS CADASTRADOS   =========");
            Console.WriteLine("==============================================");

            if (servicos.Count == 0)
            {
                Console.WriteLine("\nNenhum serviço cadastrado.");
            }
            else
            {
                for (int i = 0; i < servicos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {servicos[i].Descricao} - Valor: {servicos[i].Valor:C}");
                }
            }
        }

        static void AtualizarServico()
        {
            ListarServicos();
            Console.Write("\nDigite o número do serviço a ser atualizado: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < servicos.Count)
            {
                Console.Write("Digite a nova descrição do serviço: ");
                string descricao = Console.ReadLine();
                Console.Write("Digite o novo valor do serviço: ");
                decimal valor = decimal.Parse(Console.ReadLine());

                servicos[indice] = new Servico(descricao, valor);
                Console.WriteLine("\nServiço atualizado com sucesso!");
                SalvarServicos(); // Atualiza o arquivo após atualização
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void CarregarDados()
        {
            // Carregar clientes
            string caminhoClientes = @"C:\Users\Aluno Noite\Desktop\Marcenaria\Clientes.json";
            if (File.Exists(caminhoClientes))
            {
                string json = File.ReadAllText(caminhoClientes);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        clientes = dados.Clientes;
                        Console.WriteLine("Clientes carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos clientes: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de clientes não encontrado.");
            }

            // Carregar serviços
            string caminhoServicos = @"C:\Users\Aluno Noite\Desktop\Marcenaria\Servicos.json";
            if (File.Exists(caminhoServicos))
            {
                string json = File.ReadAllText(caminhoServicos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        servicos = dados.Servicos;
                        Console.WriteLine("Serviços carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos serviços: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de serviços não encontrado.");
            }
        }

        static void SalvarClientes()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\CursoC#Ruan\Curso_Csharp\Usuarios.json";

            try
            {
                var dados = new Dados
                {
                    Clientes = clientes,
                    Servicos = new List<Servico>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Clientes salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar clientes: {ex.Message}");
            }
        }

        static void SalvarServicos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\CursoC#Ruan\Curso_Csharp\livros.json";

            try
            {
                var dados = new Dados
                {
                    Clientes = new List<Cliente>(), // Lista vazia
                    Servicos = servicos
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Serviços salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar serviços: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            SalvarClientes();
            SalvarServicos();
        }
    }

    public class Dados
    {
        public List<Cliente> Clientes { get; set; }
        public List<Servico> Servicos { get; set; }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

    public class Servico
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Servico(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}

