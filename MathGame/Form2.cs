using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{

    public partial class Form2 : Form
    {


        string mathSelected;


        public void PassMath()
        {
            if (RadioSetAdd.Checked == true)
            {
                mathSelected = "Add";

            }
            else if (RadioSetSubstract.Checked == true)
            {
                mathSelected = "Substract";

            }
            else if (RadioSetMultiply.Checked == true)
            {
                mathSelected = "Multiply";

            }
            else if (RadioSetDivide.Checked == true)
            {
                mathSelected = "Divide";

            }
            else
            {
                mathSelected = "Random";

            }
        }

        public Form2()
        {

            InitializeComponent();
        }

        private void NewGameClickedEvent(object sender, EventArgs e)
        {
            PassMath();
            Form1 objForm1 = new Form1(mathSelected);
            objForm1.Show();
            Console.WriteLine(mathSelected);

        }

      
    }
}
