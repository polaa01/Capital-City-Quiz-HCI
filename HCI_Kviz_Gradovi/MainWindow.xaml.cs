using System;
using System.Collections.Generic;
using System.IO;
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

namespace HCI_Kviz_Gradovi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {

        public static string countryCityFile = "CountryCity.txt";
        public static string usernamesFile = "Usernames.txt";
        public static HashSet<string> usernames;
        public static string username;

        public static Dictionary<string, string> countryCapitalDict = new Dictionary<string, string>()
        {
             {"France", "Paris"},
            {"Germany", "Berlin"},
            {"Japan", "Tokyo"},
            {"Brazil", "Brasilia"},
            {"USA", "Washington D.C."},
            {"Serbia", "Belgrade"},
            {"Austria", "Vienna" },
            {"Spain", "Madrid" },
            {"Slovenia", "Ljubljana" },
            {"Italy", "Rome" },
            {"Slovakia", "Bratislava" },
            {"Norway", "Oslo" },
            {"China", "Beijing" },
            {"Greece", "Athens" },
            {"Portugal", "Lisabon" },
            {"Canada", "Ottawa" },
            {"Turkey", "Ankara" },
            {"Bosnia & Herzegovina", "Sarajevo" },
            {"Croatia", "Zagreb" },
            {"Poland", "Warsaw" },
            {"Montenegro", "Podgorica" },
            {"Hungary", "Budapest" },
            {"Russia", "Moscow" },
            {"Sweden", "Stockholm" },
            {"Denmark", "Copenhagen" },
            {"Czech Republic", "Prague" },
            {"Egypt", "Cairo" },
            {"Togo", "Lome" },
            {"Morocco", "Rabat" },
            {"Angola", "Luanda" },
            {"Zambia", "Lusaka" },  
            {"Senegal", "Dacar" },
            {"Vietnam", "Hanoi" },
            {"Philippines", "Manilla" },
            {"Thailand", "Bangkok"}
        };

        static void SaveDictionaryToFile(Dictionary<string, string> dictionary, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    
                    writer.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }

           
        }

        private void LoadUsernames()
        {
            usernames = new HashSet<string>();
            if(File.Exists(usernamesFile))
            {
                foreach(var line in File.ReadLines(usernamesFile))
                {
                    usernames.Add(line.Trim());
                }
            }
        }

        private void saveUsername(string username)
        {
            using(StreamWriter sw = new StreamWriter(usernamesFile, true))
            {
                sw.WriteLine(username);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadUsernames();
            SaveDictionaryToFile(countryCapitalDict, countryCityFile);
        }

       

        private void Start_Click(object sender, EventArgs e)
        {

            username = UsernameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (usernames.Contains(username))
            {
                MessageBox.Show("Username already exists. Please choose a new one");
                UsernameTextBox.Clear();
                return;
                
            }

            usernames.Add(username);
            saveUsername(username);


                this.Hide();
                QuizzWindow qw = new QuizzWindow();
                qw.Show();

            
        }
    }
}
