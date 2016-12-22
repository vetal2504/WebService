using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.ServiceReferenceBD;

namespace WindowsClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetDataInGrid();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
        }

        public static void SetDataInGrid()
        {
            using (ServiceDataClient client = new ServiceDataClient())
            {
                client.Open();

                var student = client.GetStudents();
                int count = 0;
                foreach(var stud in student)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[count].Cells[0].Value = stud.Id.ToString();
                    dataGridView1.Rows[count].Cells[1].Value = stud.Name.ToString();
                    dataGridView1.Rows[count].Cells[2].Value = stud.Date.ToString();
                    count++;
                }

                client.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (ServiceDataClient client = new ServiceDataClient())
            {
                var list = client.GetStudents();
                for(int i = 0; i < list.Count(); i++)
                {
                    if(i == dataGridView1.CurrentRow.Index)
                    {
                        client.DeleteStudent(list.ElementAt(i));
                    }
                }
            }
                
        }
        public static void DeleteDataInGrid()
        {
            dataGridView1.Rows.Clear();            
        }

        private static void button_update_Click(object sender, EventArgs e)
        {
            DeleteDataInGrid();
            SetDataInGrid();
        }
    }
}
