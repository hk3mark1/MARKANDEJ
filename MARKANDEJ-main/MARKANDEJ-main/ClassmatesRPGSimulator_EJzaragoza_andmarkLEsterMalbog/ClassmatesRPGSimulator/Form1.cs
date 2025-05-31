using System;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;

namespace ClassmatesRPGSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Attach the event handler to the Start Battle button
            btnStartBattle.Click += btnStartBattle_Click;
            this.Load += Form1_Load;

            cbCharacter1.SelectedIndexChanged += cbCharacter1_SelectedIndexChanged;
            cbCharacter2.SelectedIndexChanged += cbCharacter2_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCharacter1.Items.Clear();
            cbCharacter2.Items.Clear();

            
            cbCharacter1.Items.Add("mark_Marksman");
            cbCharacter1.Items.Add("ej_Assassin");

            
            cbCharacter2.Items.Add("mark_Marksman");
            cbCharacter2.Items.Add("EJ_Assassin");


            cbCharacter1.SelectedIndex = 0;
            cbCharacter2.SelectedIndex = 1;

            lblHealth1.Text = $"{txtPlayer1.Text} Health: 0/0";
            lblHealth2.Text = $"{txtPlayer2.Text} Health: 0/0";
            lblWinner.Text = "";
        }


        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                string name1 = txtPlayer1.Text.Trim();
                string name2 = txtPlayer2.Text.Trim();
                string char1 = cbCharacter1.SelectedItem?.ToString();
                string char2 = cbCharacter2.SelectedItem?.ToString();

                // Validate inputs
                if (string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2))
                    throw new Exception("Please enter both player names.");
                if (string.IsNullOrEmpty(char1) || string.IsNullOrEmpty(char2))
                    throw new Exception("Please select a character for both players.");

                Character player1 = CreateCharacter(char1, name1);
                Character player2 = CreateCharacter(char2, name2);

                lstBattleLog.Items.Clear();
                lblWinner.Text = "";

                Random rng = new Random();
                bool player1Turn = rng.Next(2) == 0; // Randomly pick who starts

                while (player1.Health > 0 && player2.Health > 0)
                {
                    if (player1Turn)
                    {
                        int damage = player1.Attack(player2); // <-- FIXED
                        player2.TakeDamage(damage);
                        lstBattleLog.Items.Add($"{player1.Name} attacks {player2.Name} for {damage} damage!");
                    }
                    else
                    {
                        int damage = player2.Attack(player1); // <-- FIXED
                        player1.TakeDamage(damage);
                        lstBattleLog.Items.Add($"{player2.Name} attacks {player1.Name} for {damage} damage!");
                    }

                    lblHealth1.Text = $"{player1.Name} Health: {player1.Health}/{player1.MaxHealth}";
                    lblHealth2.Text = $"{player2.Name} Health: {player2.Health}/{player2.MaxHealth}";

                    player1Turn = !player1Turn;

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(500);
                }


                string winner = player1.Health > 0 ? player1.Name : player2.Name;
                lblWinner.Text = $"Winner: {winner}!";
                MessageBox.Show($"{winner} wins the battle!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCharacter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacter1.SelectedItem != null)
            {
                lblHealth1.Text = "Health: " + GetCharacterHealth(cbCharacter1.SelectedItem.ToString());

                // ✅ Update image
                UpdateCharacterImage(pictureBox1, cbCharacter1.SelectedItem.ToString());
            }
        }


        private int GetCharacterHealth(string characterName)
        {
            Character character = CreateCharacter(characterName, "Temp");
            Character dummyOpponent = new carl_Fighter("Dummy"); // to call Attack safely if needed
            return character.Health;
        }




        private void cbCharacter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacter2.SelectedItem != null)
            {
                lblHealth2.Text = "Health: " + GetCharacterHealth(cbCharacter2.SelectedItem.ToString());
                UpdateCharacterImage(pictureBox2, cbCharacter2.SelectedItem.ToString());
            }
        }
        private Character CreateCharacter(string characterType, string playerName)
        {
            switch (characterType)
            {
                
                case "mark_Marksman":
                    return new Mark_Marksman(playerName);
                case "EJ_Assassin":
                    return new EJ_Assassin(playerName);
                default:
                    throw new Exception("Unknown character selected.");
            }
        }

        private void UpdateCharacterImage(PictureBox pictureBox, string characterName)
        {
            try
            {
                string imagePath = $"Images/{characterName}.png";
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox.Image = null; // or a default image
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading character image: " + ex.Message);
            }
        }



        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void lblHealth1_Click(object sender, EventArgs e)
        {

        }
    }
}
