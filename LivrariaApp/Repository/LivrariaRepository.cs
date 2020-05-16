using LivrariaApp.Data;
using LivrariaApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApp.Repository
{
    public class LivrariaRepository : ILivrariaRepository
    {
        private readonly ApplicationDbContext _context;

        public LivrariaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public async Task<IEnumerable<Livro>> ListarLivros()
        {
            return await _context.Livros.ToListAsync();
        }
        public async Task<Livro> SelecionarLivroPorId(int? id)
        {
            return await _context.Livros.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Livro> SelecionarLivroPorNome(string titulo)
        {
            return await _context.Livros.Where(x => x.Titulo == titulo).FirstOrDefaultAsync();
        }
        public bool LivroExiste(int id)
        {
            return _context.Livros.Any(e => e.Id == id);
        }
    }
}
