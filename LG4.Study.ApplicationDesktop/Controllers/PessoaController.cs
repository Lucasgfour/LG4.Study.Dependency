using LG4.Study.ApplicationDesktop.Interfaces;
using LG4.Study.Data.Models;
using LG4.Study.Service.Interface;

namespace LG4.Study.ApplicationDesktop.Controllers {
    public class PessoaController : IPessoaController {

        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) {

            _pessoaService = pessoaService;

        }

        public Pessoa? GetById(int id) {

            var pessoa = _pessoaService.GetById(id);

            return pessoa;

        }

        public Pessoa? GetByEmail(string email) {

            var pessoa = _pessoaService.GetByEmail(email);

            return pessoa;

        }

        public void Add(Pessoa pessoa) {

            _pessoaService.Add(pessoa);

        }

        public void Update(Pessoa pessoa) {

            _pessoaService.Update(pessoa);

        }

        public void Delete(int id) {

            _pessoaService.Delete(id);

        }

    }
}
