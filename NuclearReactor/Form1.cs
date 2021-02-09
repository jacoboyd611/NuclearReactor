using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            leftReactorColour.BackColor = Color.Red;
            rightReactorColour.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.Text = "Meltdown Imminent";

            Refresh();
            Thread.Sleep(1000);

            leftReactorColour.BackColor = Color.White;
            rightReactorColour.BackColor = Color.White;
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            leftReactorColour.BackColor = Color.Red;
            rightReactorColour.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            leftReactorColour.BackColor = Color.White;
            rightReactorColour.BackColor = Color.White;
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            leftReactorColour.BackColor = Color.Red;
            rightReactorColour.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;
        }
    }
}
