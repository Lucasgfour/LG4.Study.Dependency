using LG4.Study.Data.Models;

namespace LG4.Study.Service.Interface {
    public interface IPessoaService {

        Pessoa? GetById(int id);
        Pessoa? GetByEmail(string email);
        void Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(int id);

    }
}
