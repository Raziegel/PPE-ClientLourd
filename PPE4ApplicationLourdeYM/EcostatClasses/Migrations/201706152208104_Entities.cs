namespace EcostatClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Pseudo = c.String(unicode: false),
                        MDP = c.String(unicode: false),
                        Nom = c.String(unicode: false),
                        Prenom = c.String(unicode: false),
                        RaisonSociale = c.String(unicode: false),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Enquetes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(unicode: false),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateCloture = c.DateTime(nullable: false, precision: 0),
                        Enqueteur_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Personnes", t => t.Enqueteur_id)
                .Index(t => t.Enqueteur_id);
            
            CreateTable(
                "dbo.ExempleReponses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Contenu = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Titre = c.String(unicode: false),
                        DateCreation = c.DateTime(precision: 0),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Intitule = c.String(unicode: false),
                        media = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Recompenses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Reponses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        HeureReponse = c.DateTime(nullable: false, precision: 0),
                        Contenu_id = c.Int(),
                        Sonde_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ExempleReponses", t => t.Contenu_id)
                .ForeignKey("dbo.Personnes", t => t.Sonde_id)
                .Index(t => t.Contenu_id)
                .Index(t => t.Sonde_id);
            
            CreateTable(
                "dbo.SondeQuestionnaires",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Valide = c.Boolean(nullable: false),
                        Localisation = c.String(unicode: false),
                        Questionnaire_id = c.Int(),
                        Sonde_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Questionnaires", t => t.Questionnaire_id)
                .ForeignKey("dbo.Personnes", t => t.Sonde_id)
                .Index(t => t.Questionnaire_id)
                .Index(t => t.Sonde_id);
            
            CreateTable(
                "dbo.Themes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SondeQuestionnaires", "Sonde_id", "dbo.Personnes");
            DropForeignKey("dbo.SondeQuestionnaires", "Questionnaire_id", "dbo.Questionnaires");
            DropForeignKey("dbo.Reponses", "Sonde_id", "dbo.Personnes");
            DropForeignKey("dbo.Reponses", "Contenu_id", "dbo.ExempleReponses");
            DropForeignKey("dbo.Enquetes", "Enqueteur_id", "dbo.Personnes");
            DropIndex("dbo.SondeQuestionnaires", new[] { "Sonde_id" });
            DropIndex("dbo.SondeQuestionnaires", new[] { "Questionnaire_id" });
            DropIndex("dbo.Reponses", new[] { "Sonde_id" });
            DropIndex("dbo.Reponses", new[] { "Contenu_id" });
            DropIndex("dbo.Enquetes", new[] { "Enqueteur_id" });
            DropTable("dbo.Themes");
            DropTable("dbo.SondeQuestionnaires");
            DropTable("dbo.Reponses");
            DropTable("dbo.Recompenses");
            DropTable("dbo.Questions");
            DropTable("dbo.Questionnaires");
            DropTable("dbo.ExempleReponses");
            DropTable("dbo.Enquetes");
            DropTable("dbo.Personnes");
        }
    }
}
