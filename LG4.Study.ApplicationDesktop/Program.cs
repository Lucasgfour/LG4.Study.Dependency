using Microsoft.Extensions.DependencyInjection;

namespace LG4.Study.ApplicationDesktop {
    internal static class Program {

        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            Dependency.Configure(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider()) {

                var homePage = serviceProvider.GetRequiredService<Forms.A001_Home_Page>();
                Application.Run(homePage);

            }

        }
    }
}