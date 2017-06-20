using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM
{
    /// <summary>
    /// Interaction logic for WQuizz.xaml
    /// </summary>
    public partial class WQuizz : MetroWindow
    {
        Ctrl.administateur admin = new Ctrl.administateur();
        Ctrl.enquete enquete = new Ctrl.enquete();
        Ctrl.exemplereponse exemplereponse = new Ctrl.exemplereponse();
        Ctrl.question question = new Ctrl.question();
        Ctrl.quizz quizz = new Ctrl.quizz();
        Ctrl.recompense recompense = new Ctrl.recompense();
        Ctrl.reponse reponse = new Ctrl.reponse();
        Ctrl.sequence sequence = new Ctrl.sequence();
        Ctrl.sondage sondage = new Ctrl.sondage();
        Ctrl.sonde sonde = new Ctrl.sonde();
        Ctrl.sondequestionnaire sq = new Ctrl.sondequestionnaire();
        Ctrl.sondeur sondeur = new Ctrl.sondeur();
        Ctrl.theme theme = new Ctrl.theme();

        public WQuizz()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {

            List<Recompense> r = new List<Recompense>();
            List<Question> q = new List<Question>();
            quizz.ajouterQuizz(TitreQuizz.Text, q, r);
            var ctrl = await this.ShowMessageAsync("Succès! ", "Quizz " + TitreQuizz.Text + " enregistré");
        }

        private async void AjouterQuestion_Click(object sender, RoutedEventArgs e)
        {
            List<Quizz> l = quizz.listeQuizz();
            exemplereponse.ajouterExempleReponse(Reponse1.Text);
            ExempleReponse r1 = new ExempleReponse();
            using (var db = new Context())
            {
                r1 = db.ExempleReponses.Single(x => x.Contenu == Reponse1.Text);
            };

            exemplereponse.ajouterExempleReponse(Reponse2.Text);
            ExempleReponse r2 = new ExempleReponse();
            using (var db = new Context())
            {
                r2 = db.ExempleReponses.Single(x => x.Contenu == Reponse2.Text);
            };
            exemplereponse.ajouterExempleReponse(Reponse3.Text);
            ExempleReponse r3 = new ExempleReponse();
            using (var db = new Context())
            {
                r3 = db.ExempleReponses.Single(x => x.Contenu == Reponse3.Text);
            };

            exemplereponse.ajouterExempleReponse(Reponse4.Text);
            ExempleReponse r4 = new ExempleReponse();
            using (var db = new Context())
            {
                r4 = db.ExempleReponses.Single(x => x.Contenu == Reponse4.Text);
            };

            List<ExempleReponse> q = new List<ExempleReponse>();
            q.Add(r1);
            q.Add(r2);
            q.Add(r3);
            q.Add(r4);
            question.ajouterQuestion(TitreQuestion.Text, q);
            Question qs = new Question();
            Question[] temp = new Question[0];
            Quizz s = new Quizz();
            using (var db = new Context())
            {
                s = l.Single(x => x.Titre == TitreQuizz.Text);
                qs = db.Questions.Single(y => y.Intitule == TitreQuestion.Text);
                s.Questions.Add(qs);
                db.SaveChanges();
            };
            var ctrl = await this.ShowMessageAsync("Succès! ", "Question " + TitreQuestion.Text + " enregistrée dans la séquence " + TitreQuizz.Text);
        }

        private void Terminer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void AjouterRecompense_Click(object sender, RoutedEventArgs e)
        {
            List<Quizz> l = quizz.listeQuizz();
            recompense.ajouterRecompense(Recompense.Text);
            Recompense r = new Recompense();
            Quizz q = new Quizz();
            Quizz temp = new Quizz();
            using (var db = new Context())
            {
                 r = db.Recompenses.Single(x => x.Libelle == Recompense.Text);
                q = l.Single(y => y.Titre == TitreQuizz.Text);
                q.Recompenses.Add(r);
                db.SaveChanges();
            };

            var ctrl = await this.ShowMessageAsync("Succès! ", "Recompense " + Recompense.Text + " enregistrée pour le quizz " + TitreQuizz.Text);


        }
    }
}
