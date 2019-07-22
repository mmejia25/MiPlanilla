using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlanilla.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var empleadobl = new EmpleadoBL();
            var listadeempleados = empleadobl.Obtener();

            listadeEmpleadosBindingSource.DataSource = listadeempleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
      
         }

        private void empleadoBLDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
