using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHOC
{
    public partial class Provisions_Report : Form
    {
        public Provisions_Report()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;
        }
        public void addItem(string itemText)//add a new listbox entry with the specified string
        {
            listboxReport.Items.Add(itemText);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Provisions myprov = new Provisions();
            myprov.Visible = true;
            Close();
        }
    }
}
