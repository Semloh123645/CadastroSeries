using System.Collections.Generic;
namespace Projeto.Interfaces
{
    public interface Irepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int Id);
         void Insere(T entidade);
        void exclui (int Id);
        void Atualiza(int Id, T entidade);
        int ProximoId();
        

    }
}