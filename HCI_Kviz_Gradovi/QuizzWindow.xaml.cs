
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;


namespace HCI_Kviz_Gradovi
{
    /// <summary>
    /// Interaction logic for QuizzWindow.xaml
    /// </summary>
    /// 
    public partial class QuizzWindow : Window
    {

        private List<string> shuffledCountries;
        private HashSet<string> askedCountries = new HashSet<string>();
        private Random rand = new Random();
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string correctAnswer;
        private DateTime startTime;
        private static int totalQuestions = 10;
        private int answeredQuestions = 0;

        private DispatcherTimer quizTimer;
        private Stopwatch stopW;
        private static double elapsed;

        Leaderboard board;

        public QuizzWindow()
        {
            InitializeComponent();

            //board = new Leaderboard();



            quizTimer = new DispatcherTimer();
            quizTimer.Interval = TimeSpan.FromMilliseconds(100);
            quizTimer.Tick += QuizTimer_Tick;
            stopW = new Stopwatch();
            QuizProgress.Minimum = 0;
            QuizProgress.Maximum = QuizzWindow.totalQuestions;
            StartNewGame();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            QuizzWindow.elapsed = stopW.Elapsed.TotalSeconds;
            TimerTextBlock.Text = $"Time: {elapsed}";
        }
        private void StartNewGame()
        {
            board = new Leaderboard();
            stopW.Restart();
            quizTimer.Start();
            shuffledCountries = MainWindow.countryCapitalDict.Keys.OrderBy(x => rand.Next()).ToList();
            currentQuestionIndex = 0;
            score = 0;
            startTime = DateTime.Now;
            UpdateQuestion();
        }

        private void UpdateQuestion()
        {
            
            if (currentQuestionIndex < QuizzWindow.totalQuestions)
            {
                string currentCountry = shuffledCountries[currentQuestionIndex];
                this.askedCountries.Add(currentCountry);
                correctAnswer = MainWindow.countryCapitalDict[currentCountry];
                QuestionText.Text = $"{currentQuestionIndex+1}. What is the capital of {currentCountry}?";

                //pogresni odgovori
                var wrongAnswers = MainWindow.countryCapitalDict.Values.Where(capital => capital != correctAnswer).OrderBy(
                    x => rand.Next()).Take(3).ToList();

                var allAnswers = wrongAnswers.Concat(new[] {correctAnswer}).OrderBy( x=> rand.Next()).ToList();
                AnswerButtonA.Content = allAnswers[0];
                AnswerButtonB.Content = allAnswers[1];
                AnswerButtonC.Content = allAnswers[2];
                AnswerButtonD.Content = allAnswers[3];
            }
            else
            {
                //ShowResult();
                this.EndQuiz();
                AnswerButtonA.IsEnabled = false;
                AnswerButtonB.IsEnabled = false;
                AnswerButtonC.IsEnabled = false;
                AnswerButtonD.IsEnabled = false;
            }

          
        }
        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            answeredQuestions++;

            QuizProgress.Value = answeredQuestions;

            Button clickedButton = (Button)sender;
            if (clickedButton.Content.ToString() == correctAnswer)
            {
                score++;
            }
            currentQuestionIndex++;
            UpdateQuestion();
        }

        private void EndQuiz()
        {
            quizTimer.Stop();
            stopW.Stop();
            TimeSpan time = DateTime.Now - startTime;
            double seconds = time.TotalSeconds;
            Player player = new Player(MainWindow.username, score, QuizzWindow.elapsed);
            board.addPlayer(player);

            /*
            MessageBoxResult res = MessageBox.Show("Your score: [" + score + "/" + QuizzWindow.totalQuestions + "] " +
                $"Your time: {QuizzWindow.elapsed} seconds\n\nDo you want to see the leaderboard?",
                "Quiz Completed", MessageBoxButton.YesNo);
            */
            //Player player = new Player(MainWindow.username, score, QuizzWindow.elapsed);

            /*
            if (res == MessageBoxResult.Yes)
            {
                
                this.Hide();
               
                board.Show();
                
            }
            
            else
            {
            

            }
            */

            MessageBoxResult res = MessageBox.Show("Your score: [" + score + "/" + QuizzWindow.totalQuestions + "] " +
                $"Your time: {QuizzWindow.elapsed} seconds\n\nDo you want play the new quiz?",
                "Quiz Completed", MessageBoxButton.YesNo);

           // MessageBoxResult result1 = MessageBox.Show("Thanks for playing!\nDo you want to play new quiz?", "Play or Exit", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                this.Hide();
                new QuizzWindow().Show();
            }
            else
            {
                //Environment.Exit(0);
                Application.Current.Shutdown();
            }

        }


    }
}
