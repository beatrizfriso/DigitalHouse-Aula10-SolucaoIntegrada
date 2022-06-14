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
 

        }
    }
}