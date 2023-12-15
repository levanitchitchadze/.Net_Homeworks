using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    public partial class Form1 : Form
    {

        int gameLevel = 1;
        int PositionX = 300;
        int PositionY = 100;
        int lettersQuantity = 3;
        private List<TextBox> generatedTextboxes = new List<TextBox>();
        Label GuessWordLabel = new Label();
        int guessNumbers = 5;
        int refreshGuessNumber = 5;
        String GuessWord = "";
        List<Label> generatedlabels = new List<Label>();
        LoginForm loginForm = new LoginForm();

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            GenerateTextBoxs();


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            

            if (loginForm.UserId == 0)
            {
                loginForm.GameForm = this;
                loginForm.Show();
                
            }


        }



        private void GenerateTextBoxs()
        {

            string  Word =String.Concat(DataBase.getRandomWord(gameLevel).Where(c=> ! Char.IsWhiteSpace(c)));


            if (generatedTextboxes.Count > 0)
            {
                removeBoxes(generatedTextboxes,0);
                generatedTextboxes.Clear();
            }


            GuessWord = Word;
            GuessWordLabel.Text = Word;
            GuessWordLabel.Location=new Point(300, 30);
            GuessWordLabel.Visible = false;
            this.Controls.Add(GuessWordLabel);

            Console.WriteLine(Word);

            int RefreshPosition = PositionX;
            int RefreshPositionY=PositionY;

            for (int j = 0; j < guessNumbers; j++)
            {


                for (int i = 0; i < Word.Length; i++)
                {
                    TextBox txt = new TextBox();
                    
                    
                    txt.Height = 50;
                    txt.Width = 20;
                   
                    txt.Enabled = false;
                    txt.Location = new Point(PositionX, PositionY);
                    generatedTextboxes.Add(txt);
                    this.Controls.Add(txt);

                    PositionX += 50;

                }
                PositionX = RefreshPosition;
                PositionY += 35;  
            }
            PositionY = RefreshPositionY; 
        }
        
        private void Easy_Click(object sender, EventArgs e)
        {


            Easy.BackColor= Color.Red;
            Medium.BackColor= Color.White;
            Hard.BackColor = Color.White;
            Pro.BackColor = Color.White;
            guessNumbers = 5;
            refreshGuessNumber = 5;
            removeBoxes(generatedTextboxes);
            gameLevel = 1;
            PositionX = 300;
            PositionY = 100;
            keyEventPositionIndex = 0;
            if (generatedlabels.Count > 0) removeLabels(generatedlabels, 0);
            GenerateTextBoxs();
            
        }

        

        private void Medium_Click(object sender, EventArgs e)
        {
            Easy.BackColor = Color.White;
            Medium.BackColor = Color.Red;
            Hard.BackColor = Color.White;
            Pro.BackColor = Color.White;
            guessNumbers = 5;
            refreshGuessNumber = 5;
            lettersQuantity = 5;
            removeBoxes(generatedTextboxes);
            gameLevel = 2;
            PositionX = 250;
            PositionY = 100;
            keyEventPositionIndex = 0;
            if (generatedlabels.Count > 0) removeLabels(generatedlabels, 0);
            GenerateTextBoxs();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Easy.BackColor = Color.White;
            Medium.BackColor = Color.White;
            Hard.BackColor = Color.Red;
            Pro.BackColor = Color.White;
            guessNumbers = 5;
            refreshGuessNumber = 5;
            lettersQuantity = 10;

            removeBoxes(generatedTextboxes);
            gameLevel = 3;
            PositionX = 100;
            PositionY = 100;
            keyEventPositionIndex = 0;
            if (generatedlabels.Count > 0) removeLabels(generatedlabels, 0);
            GenerateTextBoxs();
        }

        private void Pro_Click(object sender, EventArgs e)
        {
            Easy.BackColor = Color.White;
            Medium.BackColor = Color.White;
            Hard.BackColor = Color.White;
            Pro.BackColor = Color.Red;
            guessNumbers = 3;
            refreshGuessNumber = 3;
            lettersQuantity = 10;
            removeBoxes(generatedTextboxes);
            gameLevel = 3;
            PositionX = 100;
            PositionY = 100;
            keyEventPositionIndex = 0;
            
            GenerateTextBoxs();
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e){}



        Label TestLabel = new Label();
        int keyEventPositionIndex = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {



            bool insertWord=char.IsLetter((char) e.KeyCode);

            if (insertWord && keyEventPositionIndex < lettersQuantity)
            {
                generatedTextboxes[keyEventPositionIndex].Text = Convert.ToString(e.KeyCode);
                keyEventPositionIndex++;
            }else if (Convert.ToString(e.KeyCode) == "Back" && keyEventPositionIndex != 0)
            {
                keyEventPositionIndex--;
                generatedTextboxes[keyEventPositionIndex].Text = "";
                
            }

        }



        public void clearTextBoxes(int start,int end,List<TextBox> list)
        {
            for(int i = start; i < end; i++)
            {
                list[i].Text = "";
                keyEventPositionIndex = 0;
            }
        }

        public void checkWord(String Word)
        {
            guessNumbers--;

            removeBoxes(generatedTextboxes, lettersQuantity);

            replaceButtons(0, lettersQuantity, CheckWordsWithPosition(Word, GuessWord), CheckIfContains(Word, GuessWord));

            clearTopRowOfButtons(lettersQuantity); 
                
        }





        public List<int> CheckIfContains(string word, string secondWord)
        {
            secondWord = secondWord.ToUpper();
            List<int> YellowIndexList = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (secondWord.Contains(word[i]))
                {
                    YellowIndexList.Add(i);
                }
            }
            return YellowIndexList;
        }
        

        public void replaceButtons(int startButtonIndex,int EndButtonIndex, List<int> RedLabels, List<int> YellowLabels=null)
        {
            for (int i = 0; i < EndButtonIndex; i++)
            {
                Label label = new Label();
                if (RedLabels.Contains(i))
                {
                    label.BackColor= Color.Red;
                }else if (YellowLabels.Contains(i))
                {
                    label.BackColor = Color.Yellow;
                }
                
                label.Location = generatedTextboxes[i].Location;
                label.Width = 15;
                label.Text= generatedTextboxes[i].Text;

                generatedlabels.Add(label);
                this.Controls.Add(label);
                label = null; 

            }

        }

        public void removeBoxes(List<TextBox> list, int end=0)
        {
            if (end == 0)
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    this.Controls.Remove(list[i]);

                }
            }
            else
            {
                for (int i = 0; i < end; i++)
                {
                    this.Controls.Remove(list[i]);
                }
            }
        }

        public void removeLabels(List<Label> list, int end = 0)
        {
            if (end == 0)
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    this.Controls.Remove(list[i]);

                }
            }
            else
            {
                for (int i = 0; i < end; i++)
                {
                    this.Controls.Remove(list[i]);
                }
            }
        }


        public void clearTopRowOfButtons(int removebuttonsQuantity)
        {
            for (int i = 0; i < removebuttonsQuantity; i++)
            {
                generatedTextboxes.RemoveAt(0);

            }
        }

        public List<int> CheckWordsWithPosition(String Word, String SecondWord)
        {
            SecondWord = SecondWord.ToUpper();
            List<int> RedIndexes = new List<int>();
            for(int i =0; i < Word.Length; i++)
            {
                if(Word[i]== SecondWord[i]){
                    Console.WriteLine("Same : " + Word[i]+"  "+ SecondWord[i]);
                    RedIndexes.Add(i);
                }
                
            }

            

            return RedIndexes;
        }


        Label correctWordLabel = new Label();
        private void button1_Click(object sender, EventArgs e)
        {
            correctWordLabel.Text = "";
            if (keyEventPositionIndex == lettersQuantity )
            {
                string Word = "";
                for (int i = 0; i < lettersQuantity; i++) Word += generatedTextboxes[i].Text;

                if (Word == GuessWord.ToUpper())
                {
                    
                    MessageBox.Show("You Win !");
                    RefreshGame();


                }
                else if (guessNumbers == 1)
                {
                    //////////////////// Show Lose ////////////////////////////


                    MessageBox.Show("You Lose !  Word was: "+GuessWord);
                    RefreshGame();



                }
                else
                {
                    

                    keyEventPositionIndex = 0;
                    using (var client = new WebClient())
                    {




                        string url = "https://api.dictionaryapi.dev/api/v2/entries/en/" + Word;

                        try
                        {
                            var responseString = client.DownloadString(url);


                            checkWord(Word);


                        }
                        catch (WebException WE)
                        {
                            correctWordLabel.Text = "Word is not correct Try Again";
                            correctWordLabel.Width = 100;
                            correctWordLabel.ForeColor = Color.Red;
                            correctWordLabel.Location = new Point(300, 350);

                            clearTextBoxes(0, lettersQuantity, generatedTextboxes);

                            this.Controls.Add(correctWordLabel);
                            Console.WriteLine(WE.Status);
                        }
                    }
                }
            }

            
            
        }
        public void RefreshGame()
        {
            keyEventPositionIndex = 0;
            guessNumbers = refreshGuessNumber;
            removeLabels(generatedlabels, 0);
            removeBoxes(generatedTextboxes);
            GenerateTextBoxs();
        }
    }
}
