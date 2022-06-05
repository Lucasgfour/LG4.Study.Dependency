using LG4.Study.ApplicationDesktop.Controllers;
using LG4.Study.ApplicationDesktop.Interfaces;
using LG4.Study.Repository;
using LG4.Study.Repository.Interface;
using LG4.Study.Repository.Repositories;
using LG4.Study.Service.Interface;
using LG4.Study.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LG4.Study.ApplicationDesktop {
    public static class Dependency {

        public static void Configure(IServiceCollection service) {

            var cnnString = $"server={ConnectionString.Default.Host}; database={ConnectionString.Default.Database}; user=root; password=1234";
            

            service.AddDbContext<Context>(options => options.UseMySql(cnnString, ServerVersion.AutoDetect(cnnString), x => x.MigrationsAssembly("LG4.Study.ApplicationWeb")));

            // ---- Repository --------------------------------------------------------------------

            service.AddScoped<IPessoaRepository, PessoaRepositoy>();

            // ---- Services ----------------------------------------------------------------------

            service.AddScoped<IPessoaService, PessoaService>();

            // ---- Controller --------------------------------------------------------------------

            service.AddSingleton<IPessoaController, PessoaController>();

            // ---- Forms -------------------------------------------------------------------------

            service.AddScoped<Forms.A001_Home_Page>();

        }

    }
}
