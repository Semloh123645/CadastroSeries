
namespace Projeto.Classes
{
    public class Series: EntidadeBase
    {
        //atributos
        private string Titulo{get;set;}

        private string Descricao{get; set;}
        private int Ano{get; set;}
        private Genero Genero{get;set;}
        private bool excluido{get; set;}
        public Series(int Id, Genero Genero, string Titulo, string Descricao, int Ano){
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.excluido = false;

        }
        public override string ToString()
        {   string retorno = "";

            retorno += "Gênero: "+ this.Genero+ System.Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo+ System.Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao+ System.Environment.NewLine;
            retorno += "Ano de início: "+ this.Ano+ System.Environment.NewLine;
            retorno += "Excluido "+ this.excluido+ System.Environment.NewLine;



            return retorno;
        }
        public int returnId(){
            return this.Id;
        }
        public string returnTitulo(){
            return this.Titulo;
        }
        public bool RetornaExcluido(){
            return this.excluido;
        }
        public void excluir(){
            this.excluido = true;
        }
    }
    

}