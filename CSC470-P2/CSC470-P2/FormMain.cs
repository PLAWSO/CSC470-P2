using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void btnSeeFish_Click(object sender, EventArgs e)
        {
            string selectedFish = "";
            if (radioCrappie.Checked)
            {
                selectedFish = "Crappie";
            }
            else if (radioPerch.Checked)
            {
                selectedFish = "Perch";
            }
            else if (radioWalleye.Checked)
            {
                selectedFish = "Walleye";
            }
            FormSeeFish formseefish = new FormSeeFish(selectedFish);
            DialogResult result = formseefish.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Decision to Keep It.", "DecisionResult");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Decision to throw it back.", "DecisionResult");
            }
            else
            {
                MessageBox.Show("Decision canceled.", "DecisionResult");
            }
        }

    }
}
