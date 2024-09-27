using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBTTuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow SelectedRow = dataGridView1.SelectedRows[0];

                Form2 frm = new Form2
                {
                    MSNV = SelectedRow.Cells[0].Value.ToString(),
                    Ten = SelectedRow.Cells[1].Value.ToString(),
                    Luong = SelectedRow.Cells[2].Value.ToString()
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SelectedRow.Cells[0].Value = frm.MSNV;
                    SelectedRow.Cells[1].Value = frm.Ten;
                    SelectedRow.Cells[2].Value = frm.Luong;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                string id = form2.MSNV;
                string name = form2.Ten;
                string luong = form2.Luong;
                dataGridView1.Rows.Add(form2.MSNV, form2.Ten, form2.Luong);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRows = dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList(); 
                foreach (var row in selectedRows)
                {
                    dataGridView1.Rows.Remove(row);    
                }                                   
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Ban Co Muon Dong Form","Yes/No",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
