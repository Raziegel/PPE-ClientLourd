namespace EcostatClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Icool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExempleReponses", "Question_id", c => c.Int());
            AddColumn("dbo.Questionnaires", "Enquete_id", c => c.Int());
            AddColumn("dbo.Questions", "Questionnaire_id", c => c.Int());
            AddColumn("dbo.Recompenses", "Quizz_id", c => c.Int());
            AddColumn("dbo.Themes", "Enquete_id", c => c.Int());
            CreateIndex("dbo.Questionnaires", "Enquete_id");
            CreateIndex("dbo.Questions", "Questionnaire_id");
            CreateIndex("dbo.ExempleReponses", "Question_id");
            CreateIndex("dbo.Themes", "Enquete_id");
            CreateIndex("dbo.Recompenses", "Quizz_id");
            AddForeignKey("dbo.ExempleReponses", "Question_id", "dbo.Questions", "id");
            AddForeignKey("dbo.Questionnaires", "Enquete_id", "dbo.Enquetes", "id");
            AddForeignKey("dbo.Themes", "Enquete_id", "dbo.Enquetes", "id");
            AddForeignKey("dbo.Questions", "Questionnaire_id", "dbo.Questionnaires", "id");
            AddForeignKey("dbo.Recompenses", "Quizz_id", "dbo.Questionnaires", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recompenses", "Quizz_id", "dbo.Questionnaires");
            DropForeignKey("dbo.Questions", "Questionnaire_id", "dbo.Questionnaires");
            DropForeignKey("dbo.Themes", "Enquete_id", "dbo.Enquetes");
            DropForeignKey("dbo.Questionnaires", "Enquete_id", "dbo.Enquetes");
            DropForeignKey("dbo.ExempleReponses", "Question_id", "dbo.Questions");
            DropIndex("dbo.Recompenses", new[] { "Quizz_id" });
            DropIndex("dbo.Themes", new[] { "Enquete_id" });
            DropIndex("dbo.ExempleReponses", new[] { "Question_id" });
            DropIndex("dbo.Questions", new[] { "Questionnaire_id" });
            DropIndex("dbo.Questionnaires", new[] { "Enquete_id" });
            DropColumn("dbo.Themes", "Enquete_id");
            DropColumn("dbo.Recompenses", "Quizz_id");
            DropColumn("dbo.Questions", "Questionnaire_id");
            DropColumn("dbo.Questionnaires", "Enquete_id");
            DropColumn("dbo.ExempleReponses", "Question_id");
        }
    }
}
