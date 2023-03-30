using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        public FormAllPlayer()
        {
            InitializeComponent();
            dataGridView1.DataSource = listPlayer;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer =formInfo.getPlayer();
                //Add new player to list
                this.listPlayer.Add(newPlayer);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                //Add list to datagrid view
                formInfo.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save data form list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt| CSV|*.csv";
            saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != "")
            using (StreamWriter writer = new StreamWriter("output.csv"))
            {
                foreach(Player item in listPlayer)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}",
                        item.Name,
                        item.Lastname,
                        item.Major));
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                // do something with the selected file
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Player selectPlayer = (Player)row.DataBoundItem;

                this.tbName.Text = selectPlayer.Name;
            }
        }
    }
}
