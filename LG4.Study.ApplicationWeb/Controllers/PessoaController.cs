using LG4.Study.Commom.Models;
using LG4.Study.Data.Models;
using LG4.Study.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LG4.Study.ApplicationWeb.Controllers {
    [Route("v1/pessoa")]
    [ApiController]
    public class PessoaController : ControllerBase {

        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) { 

            _pessoaService = pessoaService;

        }

        [HttpGet]
        [Route("id/{id}")]
        public DefaultResponse<Pessoa> GetById([FromRoute]int id) {

            var pessoa = _pessoaService.GetById(id);

            if (pessoa == null)
                return new DefaultResponse<Pessoa>(false, "Não há pessoas com id informado.");

            return new DefaultResponse<Pessoa>(true, pessoa);

        }

        [HttpPost]
        [Route("email")]
        public DefaultResponse<Pessoa> GetByEmail([FromBody] string email) {

            var pessoa = _pessoaService.GetByEmail(email);

            if (pessoa == null)
                return new DefaultResponse<Pessoa>(false, "Não há pessoas com email informado.");

            return new DefaultResponse<Pessoa>(true, pessoa);

        }

        [HttpPost]
        [Route("add")]
        public DefaultResponse<Object> Add([FromBody] Pessoa pessoa) {

            _pessoaService.Add(pessoa);

            return new DefaultResponse<Object>(true, "Inserido com sucesso.");

        }

        [HttpPost]
        [Route("update")]
        public DefaultResponse<Object> Update([FromBody] Pessoa pessoa) {

            _pessoaService.Update(pessoa);

            return new DefaultResponse<Object>(true, "Alterado com sucesso.");

        }

        [HttpDelete]
        [Route("id/{id}")]
        public DefaultResponse<object> Delete([FromRoute]int id) {

            _pessoaService.Delete(id);

            return new DefaultResponse<Object>(true, "Deletado com sucesso.");

        }



    }
}
