namespace Exercicio_Aula_08
{
    public class MenuFilmes
    {
     public String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

        // 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
        public void ApresentarTodosOsFilmesSeparadosPorPontoVirgula()
        {
            for (int i = 0; i < this.listaDeFilmes.Length; i++)
            {
                Console.WriteLine($"{this.listaDeFilmes[i]};");
            }
        }

        // 1.2. Apresentar quantidade de filmes da lista.
        public void ExibirQuantidadeTotalDeFilmes()
        {
            Console.WriteLine($"São: {this.listaDeFilmes.Length} filmes no total, de 0 a 5");

        }

        // 1.3. Buscar o nome do filme de acordo com seu índice.
        public void buscarFilmePeloIndice()
        {
            Console.WriteLine("Qual o índice do filme? ");
            int indiceDoFilme = Convert.ToInt32(Console.ReadLine());
           var nomePorIndice = this.listaDeFilmes[indiceDoFilme];
           Console.WriteLine($"O filme de índice {indiceDoFilme} é o filme {nomePorIndice}");
        }

        // 1.4. Adiciona um novo filme a lista pelo seu nome.

        public void adicionarUmNovoFilmePeloSeuNome()
        {
            
        }

        // 1.5. Atualiza um filme a partir do seu índice na lista.
        public void atualizarUmFilmePeloSeuIndice()
        {
            Console.WriteLine("Qual o índice do filme que você deseja atualizar: ");
            int indiceDoFilme = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o nome do filme que deseja atualizar o índice?: ");
            string nomeFilme = Console.ReadLine();
            string listaAtualizada = this.listaDeFilmes[indiceDoFilme] = nomeFilme;
            listarTodosOsFilmesComSeuIndiceNaLista();
        }

        // 1.6. Listar todos os filmes com seu índice/posição na lista.
        public void listarTodosOsFilmesComSeuIndiceNaLista()
        {
            for (int i = 0; i < this.listaDeFilmes.Length; i++)
            {
                Console.WriteLine($"{i} - {this.listaDeFilmes[i]}");
            }
        }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuFilmes usuario1 = new MenuFilmes();
            Console.WriteLine($"Menu de opções: \r\n" +
                $"1 - Apresenta todos os filme separados por ; (ponto e vírgula) \r\n" +
                $"2 - Apresenta quantidade de filmes na lista \r\n" +
                $"3 - Busca o nome do filme de acordo com o seu índice \r\n" +
                $"4 - Adiciona um novo filme a lista pelo seu nome \r\n" +
                $"5 - Atualiza um filme a partir do seu índice na lista \r\n" +
                $"6 - Lista todos os filmes com o seu índice/posição na lista");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    usuario1.ApresentarTodosOsFilmesSeparadosPorPontoVirgula();
                    break;
                case 2:
                    usuario1.ExibirQuantidadeTotalDeFilmes();
                    break;
                case 3:
                    usuario1.buscarFilmePeloIndice();
                    break;
                case 4:
                    usuario1.adicionarUmNovoFilmePeloSeuNome();
                    break;
                case 5:
                    usuario1.atualizarUmFilmePeloSeuIndice();
                    break;
                case 6:
                    usuario1.listarTodosOsFilmesComSeuIndiceNaLista();
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;

            }
            /*basta digitar usuario1. e escolher o método que quer utilizar. 
             * criei como usuario1, pois a lógica é o usuario utilizar o programa
             * para usar os métodos para si, cada um que for utilizar pode criar um novo usuário.
             */
        }
    }
}