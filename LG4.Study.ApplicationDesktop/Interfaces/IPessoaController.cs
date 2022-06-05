using LG4.Study.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Study.ApplicationDesktop.Interfaces {
    public interface IPessoaController {

        Pessoa? GetById(int id);
        Pessoa? GetByEmail(string email);
        void Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(int id);

    }
}
