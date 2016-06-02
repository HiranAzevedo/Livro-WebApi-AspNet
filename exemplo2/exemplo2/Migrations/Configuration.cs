namespace exemplo2.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<exemplo2.Models.exemplo2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(exemplo2Context context)
        {
            context.Products.AddOrUpdate(
                   p => p.Id,
                   new Product
                   {
                       Id = 1,
                       Nome = "produto	1",
                       Codigo = "COD1",
                       Descricao = "descrição  produto 1",
                       Preco = 10
                   },


                   new Product
                   {
                       Id = 2,
                       Nome = "produto	2",
                       Codigo = "COD2",
                       Descricao = "descrição  produto 2",
                       Preco = 20
                   },


                   new Product
                   {
                       Id = 3,
                       Nome = "produto	3",
                       Codigo = "COD3",
                       Descricao = "descrição  produto 3",
                       Preco = 30
                   }                   );
        }
    }
}
