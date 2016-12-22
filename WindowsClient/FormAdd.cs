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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (ServiceDataClient client = new ServiceDataClient())
            {
                client.Open();

                client.AddStudent(1, textBox1.Text, dateTimePicker1.Value);

                client.Close();
            }
            MainForm.DeleteDataInGrid();
            MainForm.SetDataInGrid();
            this.Close();
        }
    }
}
