using System;
using System.Windows.Forms;

namespace Uni_Project
{
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
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //Tekstin qe ju jep pas klikimit(ne anglisht: it maps the text to the button by giving the code for -the name of the button- and a -string-)
                //Ne rastin tone butoni eshte A1 edhe po i thojm qe ne butonin A1 me vendos teksin e dhene
                Dictionary<Button, string> buttonText = new Dictionary<Button, string>
                {
                    { A1, "test1" },
                    { A2, "test2" },
                    { A3, "test3" },
                    { A4, "test4" },

                    { B1, "B Text 1" },
                    { B2, "B Text 2" },
                    { B3, "B Text 3" },
                    { B4, "B Text 4" },

                    { C1, "C Text 1" },
                    { C2, "C Text 2" },
                    { C3, "C Text 3" },
                    { C4, "C Text 4" },

                    { D1, "D Text 1" },
                    { D2, "D Text 2" },
                    { D3, "D Text 3" },
                    { D4, "D Text 4" }

                };


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

        private void Answer_Click(object sender, EventArgs e)
        {
            Button clickedAnswer = sender as Button;
            Dictionary<Button, string> buttonText = new Dictionary<Button, string>
            {
                { A_Answer, "Answer1" },
                { B_Answer, "Answer2" },
                { C_Answer, "Answer3" },
                { D_Answer, "Answer4" },
                {Final_Answer, "FinalAnswer" }
            };

            if (buttonText.ContainsKey(clickedAnswer))
            {
                clickedAnswer.Text = buttonText[clickedAnswer];
            }

            clickedAnswer.Enabled = false;

        }

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
    }

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
