using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RulettiSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Program.winNumber = Program.getWinningNumber();
            String winColor = Program.getWinningColor();

            this.label5.Text = "Tulos: " + winColor + "(" + Program.winNumber + ")";
        }
    }
    }
