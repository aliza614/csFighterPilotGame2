using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csFighterPilotGame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void MovePB(PictureBox pb, int deltaX, int deltaY)
        {
            pb.Left += deltaX;
            pb.Top+= deltaY;
        }
    }
}
