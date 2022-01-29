using System;
using System.Collections.Generic;
using Projeto.Interfaces;
namespace Projeto.Classes
{
    public class SerieRepo : Irepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int Id, Series objeto)
        {
           listaSerie[Id] = objeto;
        }

        public void exclui(int Id)
        {
            listaSerie[Id].excluir();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}