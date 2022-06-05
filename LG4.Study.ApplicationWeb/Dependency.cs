using LG4.Study.Repository;
using LG4.Study.Repository.Interface;
using LG4.Study.Repository.Repositories;
using LG4.Study.Service.Interface;
using LG4.Study.Service.Services;
using Microsoft.EntityFrameworkCore;

namespace LG4.Study.ApplicationWeb {
    public static class Dependency {

        public static void Configure(IServiceCollection service, string cnnString) {

            service.AddDbContext<Context>(options => options.UseMySql(cnnString, ServerVersion.AutoDetect(cnnString), x => x.MigrationsAssembly("LG4.Study.ApplicationWeb")));

            // ---- Repository --------------------------------------------------------------------

            service.AddScoped<IPessoaRepository, PessoaRepositoy>();

            // ---- Services ----------------------------------------------------------------------

            service.AddScoped<IPessoaService, PessoaService>();

        }



    }
}
