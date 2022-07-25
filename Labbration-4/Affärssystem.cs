using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labbration_4
{
    public partial class Affärssystem : Form
    {
      
        public Affärssystem()
        {
            InitializeComponent();
           
           
        }

        private void KassaButton_Click(object sender, EventArgs e)
        {
            Kassa kassa = new Kassa();
            kassa.ShowDialog();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

        private void AvslutaButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            LagerTabs lager = new LagerTabs();
            lager.ShowDialog();
            
        }

        
    }
}
