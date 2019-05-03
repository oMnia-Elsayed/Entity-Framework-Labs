namespace ITI.Smart.UI.EF.CodeFirst
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITI.Smart.UI.EF.CodeFirst.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Passport> Passport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .ToTable("City")
                .HasRequired<Country>(cn => cn.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey<int>(c => c.FK_CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .ToTable("Country");

            modelBuilder.Entity<User>()
                .HasMany<City>(c => c.Cities)
                .WithMany(u => u.Users)
                .Map(uc =>
                {
                    uc.MapLeftKey("FK_UserId");
                    uc.MapRightKey("FK_CityId");
                    uc.ToTable("UserCities");
                });

            modelBuilder.Entity<City>()
                .HasOptional(b => b.Book)
                .WithRequired(c => c.City);


            modelBuilder.Entity<Book>()
                .ToTable("Book")
                .HasRequired(b => b.Cover)
                .WithRequiredPrincipal(c => c.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasMaxLength(50);

            modelBuilder.Entity<Cover>()
                .ToTable("Cover")
                .Property(c => c.Code)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
    
}