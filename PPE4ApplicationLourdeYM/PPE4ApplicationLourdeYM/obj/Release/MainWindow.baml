   M S B A M L   `   `   `  ����   PPE4ApplicationLourdeYM(    "PPE4ApplicationLourdeYM.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$  Ecostat��$	��600��$	��960��.���  � ColumnDefinitions ��  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+�=  7MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl  -     Name$ MainTabControl��$��1��.@��� -   $��	Connexion��$��	Connexion��.���� $��0��$��0,0,2,0q�.+��� -    ��Name$ label��$��Bonjour et Bienvenue�����	#FF292828$��Center=�$��Center=�$	��156���� -    ��Name$ BTest��$��182,166,234,57q�$��Se connecter��$	��101���� -   $��Enquetes��$��Enquetes��.���� $��0��.+��� -    ��Name$ 	IdEnquete��$��	0,0,836,0q��� -   $ SupprEnquete��$��Supprimer Enquete��$��Stretch=�$
��Left=��� -   $ CreaEnquete��$��Creer Enquete��$��Stretch=�$
��Left=� J� RenderTransformOrigin$ 0.545,2.426&�&   System.Windows.Controls.DataGrid  -	     Name$ 	EnquetesG��$��
208,0,31,0q�$	��280��$	��Top=�$��Right=�����    MetroDataGrid	 �� BasedOn#	 [  
 �� 
TargetType"
  .���  �� Property  �@ AlternatingRowBackground  GrayBrush10 �� Value# �     RowStyle ��   MetroDataGridRow#	 [ )  #System.Windows.Controls.DataGridRow"
     Columns �� -
   $ Refresh��$��
Rafraichir��$��	0,0,717,0q��� -   $��Sondages��$��Sondage��.���� -    ��Name$ SupprSondage��$��0��.+��� -   $ 	IdSondage��$��	0,0,833,0q��� -   $ SuppriSondage��$��Supprimer Sondage��$��Stretch=�$
��Left=��� -   $ CreaSondage��$��Creer Sondage��$��Stretch=�$
��Left=�  -   $ SondageG��$��
208,0,31,0q�$	��280��$	��Top=�$��Right=����� #	 [  "
  .���   �@ AlternatingRowBackground# �   �� #	 [ "
   �� -   $ button2��$��
Rafraichir��$��	0,0,736,0q��� -   $��Quizz��$��Quizz��.���� $��0��.+��� -   $ IdQuizz��$��	0,0,851,0q��� -   $ 
SupprQuizz��$��Supprimer Quizz��$��Stretch=�$
��Left=��� -   $ 	CreaQuizz��$��Creer Quizz��$��Stretch=�$
��Left=�  -   $ QuizzG��$��
208,0,31,0q�$	��280��$	��Top=�$��Right=����� #	 [  "
  .���   �@ AlternatingRowBackground# �   �� #	 [ "
   �� -   $ Refresh2��$��
Rafraichir��$��	0,0,736,0q�