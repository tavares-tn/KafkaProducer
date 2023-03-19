using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // usado para criar migraçãoes
            var connectionDatabase = "Server=localhost;Port=3306;Database=teste;Uid=root;Pwd=admin";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            optionsBuilder.UseMySql(connectionDatabase);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
