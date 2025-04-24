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
using System.IO;
using System.Collections.ObjectModel;

namespace HCI_Kviz_Gradovi
{
    /// <summary>
    /// Interaction logic for Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
       
        public static string rankFile = "Leaderboard.txt";
       
        //public List<Player> players { get; set; }
        public ObservableCollection<Player> Players { get; set; }
        public Leaderboard()
        {
            InitializeComponent();

            //DataContext = new { Items = players };
            //refreshListView();

            Players = loadPlayers();
           
           
            
            
            /*
            Players = new ObservableCollection<Player>
        {
            new Player { Name = "John", Score = 85 },
            new Player { Name = "Jane", Score = 90 },
            new Player { Name = "Bob", Score = 78 }
        };
            */
            
            this.DataContext = this;
            this.Closed += Leaderboard_Closed;
        }

        private void Leaderboard_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        /*
        public void refreshListView()
        {
            listPl.ItemsSource = null;
            listPl.ItemsSource = players;
        }
        */


        private void savePlayers(Player player)
        {
            //var lines = players.Select(x => $"{x.Name},{x.Score},{x.Time}");
            //File.AppendAllLines(rankFile, lines);
            using(StreamWriter sw = new StreamWriter(rankFile, true))
            {
                sw.WriteLine($"{player.Name},{player.Score},{player.Time}");
            }
        }

        
        public void addPlayer(Player player)
        {
            Players.Add(player);
            savePlayers(player);

            //Players=Players.OrderByDescending(p => p.Score).ThenBy(p => p.Time).ToList();
            var sortedPlayers = Players.OrderByDescending(p => p.Score).ThenBy(p => p.Time).ToList();

            Players.Clear(); 
            foreach (var sortedPlayer in sortedPlayers)
            {
                Players.Add(sortedPlayer); 
            }


        }
        
        private ObservableCollection<Player> loadPlayers()
        {
          

            var players = new ObservableCollection<Player>();
            using (StreamReader reader = new StreamReader(rankFile))
            {
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3 && int.TryParse(parts[1], out int score) &&
                       double.TryParse(parts[2], out double time))
                    {
                        //players.Add(new Player(parts[0], (int)score, (double)time));
                        players.Add(new Player { Name = parts[0], Score = score, Time = time });
                    }
                }
                    
            }
            return players;


        }

    }
}
