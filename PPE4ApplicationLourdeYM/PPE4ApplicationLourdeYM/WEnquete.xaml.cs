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
using EcostatClasses;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace PPE4ApplicationLourdeYM
{
   
    /// <summary>
    /// Interaction logic for WEnquete.xaml
    /// </summary>
    public partial class WEnquete : MetroWindow
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

        public WEnquete()
        {
            
            
            InitializeComponent();

            foreach (Sondeur so in sondeur.listeSondeurs())
            {
                Clients.Items.Add(so.RaisonSociale);
            }

        }
        
        private async void AjouterSequence_Click(object sender, RoutedEventArgs e)
        {
            List<Enquete> l = enquete.listeEnquetes();
            List<Question> q = new List<Question>();
            DateTime d = DateTime.Parse(DateSequence.SelectedDate.ToString());
            sequence.ajouterSequence(TitreSequence.Text, q, d);
            Sequence s = new Sequence();
            Enquete en = new Enquete();
            Enquete temp = new Enquete();
            using (var db = new Context())
            {
                s = db.Sequences.Single(x => x.Titre == TitreSequence.Text);
                
                en = l.Single(y => y.Libelle == TitreEnquete.Text);
                en.Sequences.Add(s);
                
                db.SaveChanges();
            };
            SelectionSequence.Items.Add(TitreSequence.Text);
            var ctrl = await this.ShowMessageAsync("Succès! ", "Enquete " + TitreSequence.Text + " enregistrée");


        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {

            DateTime d1 = DateTime.Parse(DateCrea.SelectedDate.ToString());
            DateTime d2 = DateTime.Parse(DateClo.SelectedDate.ToString());
            Sondeur s = new Sondeur();
            using (var db = new Context())
            {
                s = db.Sondeurs.Single(x => x.RaisonSociale == Clients.Text);
            };
            enquete.ajouterEnquete(TitreEnquete.Text, d1, d2, s);

            var ctrl = await this.ShowMessageAsync("Succès! ", "Enquete " + TitreEnquete.Text + " enregistrée");
           
            
        }

        private async void AjouterQuestion_Click(object sender, RoutedEventArgs e)
        {
            List<Sequence> l = sequence.listeSequences();
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
            question.ajouterQuestion(TitreQuestion.Text,q);
            Question qs = new Question();
            Question[] temp = new Question[0];
            Sequence s = new Sequence();
            using (var db = new Context())
            {
                s = l.Single(x => x.Titre == SelectionSequence.Text);
                qs = db.Questions.Single(y => y.Intitule == TitreQuestion.Text);
                s.Questions.Add(qs);
                db.SaveChanges();
            };
            var ctrl = await this.ShowMessageAsync("Succès! ", "Question " + TitreQuestion.Text + " enregistrée dans la séquence " + TitreSequence.Text);
        }

        private void Terminer_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();

        }
    }
}
