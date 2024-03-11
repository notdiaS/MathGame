using System.Security.Cryptography.X509Certificates;

namespace MathGame
{
    public partial class Form1 : Form
    {



        Random rnd = new Random();

        string[] Maths = { "Add", "Substract", "Multiply", "Divide" };
        string mSelected;
        int total;
        int score;
        int question = 0;
        int level = 1;
        int difficulty = 1;
        int correctans = 0;
        int star = 0;

      
        public Form1(string mathSelected)
        {
            InitializeComponent();
            mSelected = mathSelected;
            SetUpGame();

        }

        private void ButtonContinueClicked(object sender, EventArgs e)
        {
           

            StreamReader read = new StreamReader("C:/Users/M. Said G/Desktop/MathGameSave/save.txt");

            int saveCounter = 0;
            
             

            while (saveCounter < 10 )
            {
                saveLine = read.ReadLine();
                Console.WriteLine(saveLine);

                if (saveCounter == 0)
                {

                    mSelected = saveLine;
                }
                else if (saveCounter == 1)
                {

                    total = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 2)
                {

                    score = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 3)
                {

                    question = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 4)
                {

                    level = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 5)
                {

                    difficulty = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 6)
                {

                    correctans = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 7)
                {

                    star = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 8)
                {

                    numA = Convert.ToInt32(saveLine);

                }
                else if (saveCounter == 9)
                {

                    numB = Convert.ToInt32(saveLine);

                }



                saveCounter++;
            }
            
            read.Close();

            LabelLevel.Invalidate();
            LabelQuestion.Invalidate();
            LabelScore.Invalidate();
            LabelStarCount.Invalidate();    
            LabelSymbol.Invalidate();

            //Form1 f1 = new Form1(mSelected);
            //f1.ShowDialog();
        }


        private void CheckAnswer(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(AnswerBox.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Enter number(s)!");
            //    AnswerBox.Text = AnswerBox.Text.Remove(AnswerBox.Text.Length - 1);
            //}
        }



        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            int userInput = Convert.ToInt32(AnswerBox.Text);

            if (userInput == total)
            {

                LabelAnswerStatus.Text = "Correct";
                LabelAnswerStatus.ForeColor = Color.Blue;

                switch (level)
                {
                    case 1:

                        score += 1;
                        correctans += 1;
                        break;

                    case 2:

                        score += 2;
                        correctans += 1;
                        break;

                    case 3:

                        score += 3;
                        correctans += 1;
                        break;

                    case 4:
                        score += 4;
                        correctans += 1;
                        break;

                    case 5:
                        score += 5;
                        correctans += 1;
                        break;

                    default:
                        score += 5;
                        correctans += 1;
                        break;

                }


                LabelScore.Text = "Score: " + score;
                question++;
                LabelQuestion.Text = "Q " + question;
                SetUpGame();
                if ((question % 5) == 0 && correctans >= 2)
                {
                    level++;

                    switch (correctans)
                    {
                        case 3:

                            star += 1;
                            break;


                        case 4:

                            star += 2;
                            break;

                        case 5:

                            star += 3;
                            break;

                        default:
                            break;

                    }

                    LabelStarCount.Text = ": " + star;

                    correctans = 0;

                    LabelLevel.Text = "Level: " + level;


                    switch (level)
                    {
                        case 2:
                            LabelLevel.ForeColor = Color.Green;
                            difficulty = level;
                            break;

                        case 3:
                            LabelLevel.ForeColor = Color.Yellow;
                            difficulty = level;
                            break;

                        case 4:
                            LabelLevel.ForeColor = Color.Orange;
                            difficulty = level;
                            break;

                        case 5:
                            LabelLevel.ForeColor = Color.Red;
                            difficulty = level;
                            break;
                    }
                }

            }
            else
            {
                LabelAnswerStatus.Text = "Incorrect";
                LabelAnswerStatus.ForeColor = Color.Red;
            }




        }


        int numA;
        int numB;
        private void SetUpGame()
        {


            switch (difficulty)
            {
                case 1:
                    numA = rnd.Next(0, 9);
                    numB = rnd.Next(1, 9);
                    break;

                case 2:
                    numA = rnd.Next(10, 99);
                    numB = rnd.Next(1, 9);

                    break;

                case 3:
                    numA = rnd.Next(10, 99);
                    numB = rnd.Next(10, 99);

                    break;

                case 4:
                    numA = rnd.Next(100, 999);
                    numB = rnd.Next(10, 99);

                    break;


                case 5:
                    numA = rnd.Next(1000, 9999);
                    numB = rnd.Next(100, 999);


                    break;

            }




            AnswerBox.Text = null;

            switch (mSelected != "Random" ? mSelected : Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":

                    total = numA + numB;
                    LabelSymbol.Text = "+";


                    break;
                case "Substract":

                    total = numA - numB;
                    LabelSymbol.Text = "-";

                    break;
                case "Multiply":

                    total = numA * numB;
                    LabelSymbol.Text = "x";

                    break;
                case "Divide":

                    total = numA / numB;
                    LabelSymbol.Text = "÷";

                    break;

            }

            LabelNum1.Text = numA.ToString();
            LabelNum2.Text = numB.ToString();


        }


        private void SaveButtonClicked(object sender, EventArgs e)
        {
            StreamWriter save = new StreamWriter("C:/Users/M. Said G/Desktop/MathGameSave/save.txt");

            save.WriteLine(mSelected);
            save.WriteLine(total);
            save.WriteLine(score);
            save.WriteLine(question);
            save.WriteLine(level);
            save.WriteLine(difficulty);
            save.WriteLine(correctans);
            save.WriteLine(star);
            save.WriteLine(numA);
            save.WriteLine(numB);
            save.Dispose();

        }

        string saveLine;
        

     


        private void LabelDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void Timer1Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}