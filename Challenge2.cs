using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITS228_ParametersReturnsVoids_KS
{
    public partial class Challenge2 : Form
    {
        int someThingElse = 24;

        public Challenge2()
        {
            InitializeComponent();
        }

        private void Challenge2_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// concepts of returning functions within the parameters; within the parameters of the paranthesis is a value where only pertains within the function's brackets.
        /// </summary>
        /// <returns></returns>
        private int testFunction(int someThing)
        {
            someThing = 1;

            return someThing;
        }

        /// <summary>
        /// pointers are dangerous tools to complex the process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = testFunction(someThingElse).ToString();
        }
        
    }
}
