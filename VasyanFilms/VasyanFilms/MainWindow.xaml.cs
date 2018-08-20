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

namespace VasyanFilms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //MIGRATION!!!!!!!!!
            //
            //   Tools->NuGet Package Manager -> Package Manager Console
            //   ->
            //   enable-migrations   - 1 raz
            //   ->
            //   add-mirgarion  name1   
            //   ->
            //   update-database
            //   ->
            //


            InitializeComponent();


            //Vasyan db = new Vasyan();
            //listshow.ItemsSource = db.Films.ToList();
            ////Vasyan db = new Vasyan();
            //////Genre g = new Genre() { NameGenre = "Adventure" };
            //////db.Genres.Add(g);

            ////Film f = new Film()
            ////{
            ////    Genre = db.Genres.FirstOrDefault(x => x.NameGenre == "Horror"),
            ////    Year = 2017,
            ////    Name = "It",
            ////    Score = 85,
            ////};

            ////Actor a1 = new Actor() { NameActor = "Bill Skarsgard", Age = 28 };
            ////Actor a2 = new Actor() { NameActor = "Finn Wolfhard", Age = 15 };

            ////f.Actors.Add(a1);
            ////f.Actors.Add(a2);

            //////a1.Films.Add(f);
            //////a2.Films.Add(f);

            ////db.Films.Add(f);

            ////db.SaveChanges();
        }
    }
}
