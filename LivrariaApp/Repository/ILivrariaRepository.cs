using LivrariaApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaApp.Repository
{
    public interface ILivrariaRepository
    {
        // Tipo genérico onde o que eu passar será passado pela entidade.
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<Livro>> ListarLivros();
        Task<Livro> SelecionarLivroPorId(int? id);
        Task<Livro> SelecionarLivroPorNome(string titulo);
        bool LivroExiste(int id);

    }
}
