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

namespace Project09_02_2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Teams Objects
            Teams t1 = new Teams() { Name = "Manchester City", Played = 22, Wins = 15, Draws = 5, Losses = 2, GoalDifference = 29, Points = 50, YearFounded = 1880, Networth = 950, Titles = 4, Manager = "Pep Guardiola"};
            Teams t2 = new Teams() { Name = "Manchester United", Played = 23, Wins = 13, Draws = 6, Losses = 4, GoalDifference = 19, Points = 45, YearFounded = 1878, Networth = 930, Titles = 13, Manager = "Ole Gunnar Solskjaer" };
            Teams t3 = new Teams() { Name = "Leicester City", Played = 23, Wins = 13, Draws = 4, Losses = 6, GoalDifference = 14, Points = 43, YearFounded = 1919, Networth = 705, Titles = 1, Manager = "Brendan Rodgers" };
            Teams t4 = new Teams() { Name = "Liverpool", Played = 23, Wins = 11, Draws = 7, Losses = 5, GoalDifference = 15, Points = 40, YearFounded = 1892, Networth = 960, Titles = 1, Manager = "Jurgen Klopp" };
            Teams t5 = new Teams() { Name = "Chelsea", Played = 23, Wins = 11, Draws = 6, Losses =6 , GoalDifference = 14, Points = 39, YearFounded = 1905, Networth = 800, Titles = 5, Manager = "Frank Lampard" };
            Teams t6 = new Teams() { Name = "Westham United", Played = 23, Wins = 11, Draws = 6, Losses = 6, GoalDifference = 6, Points = 39, YearFounded = 1895, Networth = 307, Titles = 0, Manager = "David Moyes" };
            Teams t7 = new Teams() { Name = "Everton", Played = 21, Wins = 11, Draws = 4, Losses = 6, GoalDifference = 6, Points = 37, YearFounded = 1878, Networth = 500, Titles = 0, Manager = "Carlo Ancelotti" };
            Teams t8 = new Teams() { Name = "TottenHam Hotspur", Played = 22, Wins = 10, Draws = 6, Losses = 6, GoalDifference = 14, Points = 36, YearFounded = 1882, Networth = 672, Titles = 0, Manager = "Jose Mourinho" };
            Teams t9 = new Teams() { Name = "Aston Villa", Played = 21, Wins = 11, Draws = 2, Losses = 8, GoalDifference = 12, Points = 35, YearFounded = 1874, Networth = 242, Titles = 0, Manager = "Dean Smith" };
            Teams t10 = new Teams() { Name = "Leeds United", Played = 22, Wins = 10, Draws = 2, Losses = 10, GoalDifference = 0, Points = 32, YearFounded = 1919, Networth = 160, Titles = 0, Manager = "Marcelo Biesla" };
            Teams t11 = new Teams() { Name = "Arsenal", Played = 23, Wins = 9, Draws = 4, Losses = 10, GoalDifference = 4, Points = 31, YearFounded = 1886, Networth = 489, Titles = 3, Manager = "Mikel Arteta" };
            Teams t12 = new Teams() { Name = "Southampton", Played = 22, Wins = 8, Draws = 5, Losses = 9, GoalDifference = -8, Points = 29, YearFounded = 1885, Networth = 231, Titles = 0, Manager = "Ralph Hasenhuttl" };
            Teams t13 = new Teams() { Name = "Crystal Palace", Played = 23, Wins = 8, Draws = 5, Losses = 10, GoalDifference = -12, Points = 29, YearFounded = 1905, Networth = 146, Titles = 0, Manager = "Roy Hodgson" };
            Teams t14 = new Teams() { Name = "Wolves", Played = 23, Wins = 7, Draws = 6, Losses = 10, GoalDifference = -12, Points = 27, YearFounded = 1877, Networth = 136, Titles = 0, Manager = "Nuno Santo" };
            Teams t15 = new Teams() { Name = "Brighton", Played = 23, Wins = 5, Draws = 10, Losses = 8, GoalDifference = -5, Points = 25, YearFounded = 1901, Networth = 122, Titles = 0, Manager = "Graham Potter" };
            Teams t16 = new Teams() { Name = "Newcastle United", Played = 23, Wins = 7, Draws = 4, Losses = 12, GoalDifference = -13, Points = 25, YearFounded = 1892, Networth = 264, Titles = 0, Manager = "Steve Bruce" };
            Teams t17 = new Teams() { Name = "Burnley", Played = 22, Wins = 6, Draws = 5, Losses = 12, GoalDifference = -13, Points = 23, YearFounded = 1882, Networth = 145, Titles = 0, Manager = "Sean Dyche" };
            Teams t18 = new Teams() { Name = "Fulham", Played = 22, Wins = 2, Draws = 9, Losses = 11, GoalDifference = -14, Points = 15, YearFounded = 1879, Networth = 105, Titles = 0, Manager = "Scott Parker" };
            Teams t19 = new Teams() { Name = "West Brom", Played = 23, Wins = 2, Draws = 6, Losses = 15, GoalDifference = -36, Points = 12, YearFounded = 1878, Networth = 103, Titles = 0, Manager = "Sam Allardyce" };
            Teams t20 = new Teams() { Name = "sheffield United", Played = 23, Wins = 3, Draws = 2, Losses = 18, GoalDifference = -22, Points = 11, YearFounded = 1889, Networth = 114, Titles = 0, Manager = "Chris Wilder" };   
        }
    }
}
