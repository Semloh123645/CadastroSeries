using System;
using Projeto.Classes;

namespace Projeto
{
    class Program
    {
        static SerieRepo repositorio = new SerieRepo();
        static void Main(string[] args)
        {
            string ObterOpcaoUser = ObterOpcao();
            while (ObterOpcaoUser != "X"){
                switch(ObterOpcaoUser){
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break; 

                    case "3":
                        AtualizarSerie();
                        break;
                    
                    case "4":
                        ExcluirSerie();
                        break;
                    
                    case "5":
                        VisualizarSerie();
                        break;           
                        
                }
                ObterOpcaoUser = ObterOpcao();

            } 
            Console.WriteLine("Obrigado por utilizar nossos serviços!!");
        }
        private static string ObterOpcao(){
            Console.WriteLine();
            Console.WriteLine("Dio Series a seu serviço!");
            Console.WriteLine("Informe a opção:");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUser;

        }
        private static void ListarSeries(){
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach(var serie in lista){
                var excluido = serie.RetornaExcluido();
                Console.WriteLine("#ID{0}: - {1}  {2}",
                                  serie.returnId(),
                                  serie.returnTitulo(),
                                  (excluido ? "Excluído" : " "));

            }

        }
        private static void InserirSerie(){
            Console.WriteLine("Inseri nova série");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o título: ");
            string Entradatitulo = Console.ReadLine();
            Console.WriteLine("Digite o ano: ");
            int EntradaAno= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descrição ");
            string EntradaDesc = Console.ReadLine();
            
            Series novaSerie = new Series(Id: repositorio.ProximoId(),Genero: (Genero)EntradaGenero,Titulo: Entradatitulo, Ano
            : EntradaAno, Descricao: EntradaDesc );

            repositorio.Insere(novaSerie);

        }
        private static void AtualizarSerie(){
            Console.WriteLine("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o título: ");
            string Entradatitulo = Console.ReadLine();
            Console.WriteLine("Digite o ano: ");
            int EntradaAno= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descrição ");
            string EntradaDesc = Console.ReadLine();
            Series AtualizaSerie = new Series(Id: repositorio.ProximoId(),Genero: (Genero)EntradaGenero,Titulo: Entradatitulo, Ano
            : EntradaAno, Descricao: EntradaDesc );

            repositorio.Atualiza(indiceSerie, AtualizaSerie);

        }
        private static void ExcluirSerie(){
            
            Console.WriteLine("Digite o  id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
            repositorio.exclui(indiceSerie);

        }
        private static void VisualizarSerie(){
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
            
        }
    }
}
