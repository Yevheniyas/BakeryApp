using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BakeryApp
{
    public partial class Form1 : Form
    {
        private List<Bread> breadPrototypes = new List<Bread>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateBread_Click(object sender, EventArgs e)
        {
            var builder = new ConcreteBreadBuilder();
            var director = new BakeryDirector(builder);

            if (radioBasicBread.Checked)
                director.BuildBasicBread();
            else if (radioSweetBread.Checked)
                director.BuildSweetBread();

            var bread = builder.GetBread();
            breadPrototypes.Add(bread);
            listBoxBread.Items.Add(bread.ToString());
        }

        private void btnCloneBread_Click(object sender, EventArgs e)
        {
            if (listBoxBread.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bread to clone.");
                return;
            }

            var selectedBread = breadPrototypes[listBoxBread.SelectedIndex];
            var clonedBread = selectedBread.Clone();

            breadPrototypes.Add(clonedBread);
            listBoxBread.Items.Add(clonedBread.ToString());
        }
    }
}