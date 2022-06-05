using LG4.Study.Data.Models;
using LG4.Study.Repository.Interface;
using LG4.Study.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Study.Service.Services {
    public class PessoaService : IPessoaService {

        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository) {
            this._pessoaRepository = pessoaRepository;
        }

        public Pessoa? GetById(int id) {

            var pessoa = _pessoaRepository.GetById(id);

            return pessoa;

        }

        public Pessoa? GetByEmail(string email) {

            var pessoa = _pessoaRepository.GetByEmail(email);

            return pessoa;

        }

        public void Add(Pessoa pessoa) {

            _pessoaRepository.Add(pessoa);

        }

        public void Update(Pessoa pessoa) {

            _pessoaRepository.Update(pessoa);

        }

        public void Delete(int id) {

            _pessoaRepository.Delete(id);

        }

    }
}
