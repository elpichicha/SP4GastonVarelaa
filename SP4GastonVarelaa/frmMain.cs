using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP4GastonVarelaa
{
    public partial class frmMain : Form
    {
        public int[] vecDatos = new int[10];
        public int[,] matDatos = new int[5, 4];
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            int i = 0;

            for (i = 0; i <= 4; i++)
            {
                dgvTabla.Rows.Add();
            }
            //Asigno nombres a la primer columna
            dgvTabla.Rows[0].Cells[0].Value = "Julio";
            dgvTabla.Rows[1].Cells[0].Value = "Esteban";
            dgvTabla.Rows[2].Cells[0].Value = "Javier";
            dgvTabla.Rows[3].Cells[0].Value = "Gonzalo";
            dgvTabla.Rows[4].Cells[0].Value = "Alberto";
            //Todas las celdas de la columna cero "Mozo" son ineditables
            dgvTabla.Columns[0].ReadOnly = true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }