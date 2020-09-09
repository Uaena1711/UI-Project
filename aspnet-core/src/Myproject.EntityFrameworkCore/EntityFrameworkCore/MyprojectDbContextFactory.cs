using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Myproject.Configuration;
using Myproject.Web;

namespace Myproject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyprojectDbContextFactory : IDesignTimeDbContextFactory<MyprojectDbContext>
    {
        public MyprojectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyprojectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyprojectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyprojectConsts.ConnectionStringName));

            return new MyprojectDbContext(builder.Options);
        }
    }
}
