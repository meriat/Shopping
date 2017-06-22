namespace Shopping
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShoppingModel : DbContext
    {
        // Your context has been configured to use a 'ShoppingModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Shopping.ShoppingModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ShoppingModel' 
        // connection string in the application configuration file.
        public ShoppingModel()
            : base("name=ShoppingModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<History> Histories { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}