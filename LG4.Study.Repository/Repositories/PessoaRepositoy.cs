using LG4.Study.Data.Models;
using LG4.Study.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LG4.Study.Repository.Repositories {
    public class PessoaRepositoy : IPessoaRepository {

        private readonly Context _context;

        public PessoaRepositoy(Context context) {
            this._context = context;
        }

        public Pessoa? GetByEmail(string email) {

            var pessoa = _context
                .Pessoa
                .AsNoTracking()
                .Where(x => x.email.Equals(email))
                .FirstOrDefault();

            return pessoa;

        }

        public Pessoa? GetById(int id) {

            var pessoa = _context
                .Pessoa
                .Where(x => x.id == id)
                .FirstOrDefault();

            return pessoa;

        }

        public void Add(Pessoa pessoa) {
            
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();

        }

        public void Update(Pessoa pessoa) {

            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();

        }

        public void Delete(int id) {
            
            var pessoa = GetById(id);

            if (pessoa == null)
                throw new Exception("ID não localizado.");

            _context.Pessoa.Remove(pessoa);
            _context.SaveChanges();

        }
    }
}
