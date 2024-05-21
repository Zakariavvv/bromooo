using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromoo_Airliness
{
    public partial class master_bandara : Form
    {
        public master_bandara()
        {
            InitializeComponent();
        }

        private void master_bandara_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdurrahman", "MLG");
            dataGridView1.Rows.Add("syastg", "gdtdys");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu form = new menu();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }
    }
}
