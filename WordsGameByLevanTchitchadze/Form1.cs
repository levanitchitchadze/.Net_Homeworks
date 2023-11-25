using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WordsGameByLevanTchitchadze
{
    public partial class GamePlatform : Form
    {
        public GamePlatform()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            String Word = "Something";
            GamePlatform gamePlatform = new GamePlatform();


            int   positionX = 500;
            
            for (int i = 0; i < Word.Length-1; i++) {
                
                var label = new Label();


                label.Name = Convert.ToString(i);

                label.Text = "_";
                label.Width = 10;
                

                label.Location = new Point(positionX, 200);
                positionX +=20;


                Console.WriteLine(label.Location);
                this.Controls.Add(label);

            }


            

            

        }

        private void GamePlatform_KeyDown(object sender, KeyEventArgs e)
        {

            CharLabel.Text += " " + e.KeyValue;
            
        }

        private void GamePlatform_KeyPress(object sender, KeyPressEventArgs e)
        {

            CharLabel.Text = "someText: " + e.KeyChar;


        }
    }
}
