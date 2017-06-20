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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using EcostatClasses;
using PPE4ApplicationLourdeYM.Ctrl;

namespace PPE4ApplicationLourdeYM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
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

        public MainWindow()
        {
            
            InitializeComponent();
            
            //enqutes
            Enquetes.IsEnabled = false;
            foreach (Enquete en in enquete.listeEnquetes())
            {
                EnquetesG.Items.Add(en);
            }
            DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Header = "Libelle de l'enquete";
            col1.Binding = new Binding("Libelle");
            EnquetesG.Columns.Insert(0, col1);
            DataGridTextColumn col2 = new DataGridTextColumn();
            col2.Header = "Date de création";
            col2.Binding = new Binding("DateCreation");
            EnquetesG.Columns.Insert(1, col2);
            DataGridTextColumn col3 = new DataGridTextColumn();
            col3.Header = "Date de Cloture";
            col3.Binding = new Binding("DateCloture");
            EnquetesG.Columns.Insert(2, col3);
            DataGridTextColumn col4 = new DataGridTextColumn();
            col4.Header = "id";
            col4.Binding = new Binding("id");
            EnquetesG.Columns.Insert(3, col4);
           
            

            //Sondages
            Sondages.IsEnabled = false;
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);

            //sondeur.ajouterSondeur("toto", "to", "letoto");

        }
   
        private async void ShowLoginDialog(object sender, RoutedEventArgs e)
        {
            var result = await this.ShowLoginAsync("Connexion", "Entrez vos identifiants", new LoginDialogSettings { ColorScheme = this.MetroDialogOptions.ColorScheme, InitialUsername = "Pseudo" });
            if (result == null)
            {
                //User pressed cancel
            }
            else
            {
                var controller = await this.ShowProgressAsync("Veuillez patienter", "");
                var pass = admin.connexion(result.Username.ToString(), result.Password.ToString());
                if ( pass == false)                
                {
                    label.Content = "Mauvais identifiants";
                    controller.CloseAsync();
                }
                else
                {
                    controller.CloseAsync();

                    label.Content = "Login correct " ;
                    BTest.Content = "Changer de compte";
                    Enquetes.IsEnabled = true;
                    Sondages.IsEnabled = true;
                    Quizz.IsEnabled = true;
                    MainTabControl.SelectedItem = Enquetes;
                   
                }
                 

                
                
                
              //  MessageDialogResult messageResult = await this.ShowMessageAsync("Authentication Information", String.Format("Username: {0}\nPassword: {1}", result.Username, result.Password));
            }
        }

        private void BTest_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void CreaEnquete_Click(object sender, RoutedEventArgs e)
        {
            WEnquete En = new WEnquete();
            
            En.Show();
        }

        private void CreaSondage_Click(object sender, RoutedEventArgs e)
        {
            WSondage s = new WSondage();
           
            s.Show();
        }

        private void CreaQuizz_Click(object sender, RoutedEventArgs e)
        {
            WQuizz Q = new WQuizz();
           
            Q.Show();
            
        }

        private void SupprEnquete_Click(object sender, RoutedEventArgs e)
        {
            var s = IdEnquete.Text;
            enquete.SupprimerEnquete(int.Parse(s));
            EnquetesG.Items.Clear();
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);


        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            EnquetesG.Items.Clear();
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);
        }

        private void SupprimerQuizz_Click(object sender, RoutedEventArgs e)
        {
            var s = IdQuizz.Text;
            quizz.SupprimerQuizz(int.Parse(s));
            EnquetesG.Items.Clear();
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);

        }

        private void SupprSondage_Click(object sender, RoutedEventArgs e)
        {
            var s = IdSondage.Text;
            sondage.SupprimerSondage(int.Parse(s));
            EnquetesG.Items.Clear();
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);
        }

        private void Refresh2_Click(object sender, RoutedEventArgs e)
        {
            SondageG.Items.Clear();
            foreach (Sondage so in sondage.listeSondages())
            {
                SondageG.Items.Add(so);
            }
            DataGridTextColumn cols1 = new DataGridTextColumn();
            cols1.Header = "Titre du sondage";
            cols1.Binding = new Binding("Titre");
            SondageG.Columns.Insert(0, cols1);
            DataGridTextColumn cols4 = new DataGridTextColumn();
            cols4.Header = "id";
            cols4.Binding = new Binding("id");
            SondageG.Columns.Insert(1, cols4);
            //Quizz
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            QuizzG.Items.Clear();
            foreach (Quizz so in quizz.listeQuizz())
            {
                QuizzG.Items.Add(so);
            }
            
            //Quizz
            Quizz.IsEnabled = false;
            foreach (Quizz qu in quizz.listeQuizz())
            {
                QuizzG.Items.Add(qu);
            }
            DataGridTextColumn colq1 = new DataGridTextColumn();
            colq1.Header = "Titre du quizz";
            colq1.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(0, colq1);
            DataGridTextColumn colq2 = new DataGridTextColumn();
            colq2.Header = "Titre du quizz";
            colq2.Binding = new Binding("Titre");
            QuizzG.Columns.Insert(1, colq2);
        }
    }
}
