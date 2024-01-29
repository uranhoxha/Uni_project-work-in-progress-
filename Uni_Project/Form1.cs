using System;
using System.Windows.Forms;

namespace Uni_Project
{
    //Perdorim i Iheritances Form1 trashegon prej klases Form
    public partial class Form1 : Form
    {

        private Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            UpdateUI();
        }


        //Metoda qe ju ndrron tekstin butonave
        //Perdorimi i Polimorfizmit gjendet tek Button_Click dhe Answer_Click ku te dyjat e kan funksionin e njejt por perdoren ne butona krejt te ndryshem
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //Tekstin qe ju jep pas klikimit(ne anglisht: it maps the text to the button by giving the code for -the name of the button- and a -string-)
                //Ne rastin tone butoni eshte A1 edhe po i thojm qe ne butonin A1 me vendos teksin e dhene
                Dictionary<Button, string> buttonText = new Dictionary<Button, string>
                {
                    { A1, "Detare" },
                    { A2, "E Vazhduar" },
                    { A3, "Ajrore" },
                    { A4, "Alternative" },

                    { B1, "Roja" },
                    { B2, "Shtepiak" },
                    { B3, "Amnistia" },
                    { B4, "Denimi" },

                    { C1, "Fizika" },
                    { C2, "Gitara" },
                    { C3, "Salla" },
                    { C4, "Zeri" },

                    { D1, "E embla..." },
                    { D2, "Shkolla" },
                    { D3, "Permisuese" },
                    { D4, "Shendeti" }

                };

                //I ndal krejt butonat e tjer kur klikohet nje buton(per arsye qe mos me mujt nje lojtar me i hap krejt butonat)
                if (buttonText.ContainsKey(clickedButton))
                {
                    foreach (var button in buttonText.Keys)
                    {
                        button.Enabled = (button == clickedButton);
                    }

                    clickedButton.Text = buttonText[clickedButton];
                }

            }
        }

        //Kjo eshte per me e ndrru tekstin e pergjigjjeve
        private void Answer_Click(object sender, EventArgs e)
        {
            Button clickedAnswer = sender as Button;
            Dictionary<Button, string> buttonText = new Dictionary<Button, string>
            {
                { A_Answer, "Rryma" },
                { B_Answer, "Burgu" },
                { C_Answer, "Akustik" },
                { D_Answer, "Shtepia" },
                { Final_Answer, "Izolimi" }
            };

            if (buttonText.ContainsKey(clickedAnswer))
            {
                clickedAnswer.Text = buttonText[clickedAnswer];
                clickedAnswer.Enabled = false;

                //I tregon programit pikt te cilat mund te fitohen nga nje pergjigje 100 =  me e pakta, 1000 = me e madhja
                int points = (clickedAnswer == Final_Answer) ? 1000 : 100;

                //Inicializimi i variablave qe i mbajne piket e lojtarve
                int player1Score, player2Score;

                if (!int.TryParse(firstPl_score.Text, out player1Score))
                {
                    player1Score = 0;
                }

                if (!int.TryParse(secondPl_score.Text, out player2Score))
                {
                    player2Score = 0;
                }

                //I bon update pikt sa her qe e gjen ni pergjigje te sakte
                if (game.CurrentPlayerRole == "Player1")
                {
                    firstPl_score.Text = (player1Score + points).ToString();
                }
                else
                {
                    secondPl_score.Text = (player2Score + points).ToString();
                }

                //Kjo tregon se kush e ka fitu lojen
                if (clickedAnswer == Final_Answer)
                {
                    if (player1Score > player2Score)
                    {
                        MessageBox.Show("Player 2 has won the Game!" + Environment.NewLine + "Don't give up! The game continues until you unveil all the answers.");
                    }
                    else
                    {
                        MessageBox.Show("Player 1 has won the Game!" + Environment.NewLine + "Don't give up! The game continues until you unveil all the answers.");
                    }
                }



            }
        }

        //Kjo i bon enable krejt butonat
        private void EnableAllButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        //Teksti qe tregon rradha e kujt esht
        private void UpdateUI()
        {
            label1.Text = game.CurrentPlayerRole;
        }

        //========================A1========================
        private void A1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);


        }
        private void A2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        //========================B1========================
        private void B1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        //========================C1========================
        private void C1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        //========================D1========================
        private void D1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        //======================Answers======================
        private void A_Answer_Click(object sender, EventArgs e)
        {
            Answer_Click(sender, e);
        }

        private void B_Answer_Click(object sender, EventArgs e)
        {
            Answer_Click(sender, e);
        }

        private void C_Answer_Click(object sender, EventArgs e)
        {
            Answer_Click(sender, e);
        }

        private void D_Answer_Click(object sender, EventArgs e)
        {
            Answer_Click(sender, e);
        }

        private void Final_Answer_Click(object sender, EventArgs e)
        {
            Answer_Click(sender, e);

        }

        //Butoni Next Turn qe me dal te lojtari tjeter
        private void Next_Turn_Click(object sender, EventArgs e)
        {
            game.SwitchTurn();
            UpdateUI();
            EnableAllButtons();

        }

        public string player1ScoreFile = "C:\\Users\\Admin\\source\\repos\\Uni_Project\\Score1.txt";
        public string player2ScoreFile = "C:\\Users\\Admin\\source\\repos\\Uni_Project\\Score2.txt";
        private void SaveScoresToFile()
        {

            try
            {
                // Save Player 1's score to Score1.txt
                File.WriteAllText(player1ScoreFile, firstPl_score.Text);

                // Save Player 2's score to Score2.txt
                File.WriteAllText(player2ScoreFile, secondPl_score.Text);

                MessageBox.Show("Scores have been saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving scores: {ex.Message}");
            }
        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {

            SaveScoresToFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            last_score.Text = File.ReadAllText(player1ScoreFile);
            last_score2.Text = File.ReadAllText(player2ScoreFile);
        }
    }

    //Perdorimi i Enkapsulimit kjo klas përmbledh konceptin e lojes duke fshehur detajet e zbatimit dhe duke ekspozuar vetem vetite/metodat e nevojshme (CurrentPlayerRole dhe SwitchTurn())
    public class Game
    {
        public string CurrentPlayerRole { get; private set; }

        public Game()
        {
            CurrentPlayerRole = "Player1";
        }

        //Ndrrimi mes lojtarit 1 dhe lojtarit 2
        public void SwitchTurn()
        {
            if (CurrentPlayerRole == "Player1")
            {
                CurrentPlayerRole = "Player2";
            }
            else
            {
                CurrentPlayerRole = "Player1";
            }
        }
    }
}
