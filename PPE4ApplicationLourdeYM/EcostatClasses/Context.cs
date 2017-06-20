namespace EcostatClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class MigrationsContextFactory : IDbContextFactory<Context>
    {
        public Context Create()
        {
            return new Context();
        }
    }
    public class Context : DbContext , IObjectContextAdapter
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EcostatClasses.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.

        public Context()
            : base("name=Context")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Enquete> Enquetes { get; set; }
        public virtual DbSet<ExempleReponse> ExempleReponses { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Quizz> Quizzs { get; set; }
        public virtual DbSet<Recompense> Recompenses { get; set; }
        public virtual DbSet<Reponse> Reponses { get; set; }
        public virtual DbSet<Sequence> Sequences { get; set; }
        public virtual DbSet<Sondage> Sondages { get; set; }
        public virtual DbSet<Sonde> Sondes { get; set; }
        public virtual DbSet<SondeQuestionnaire> SondeQuestionnaires { get; set; }
        public virtual DbSet<Sondeur> Sondeurs { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}