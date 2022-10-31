using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomiceDesing();
        }

        private void CustomiceDesing()
        {
            panelSudMenuInicio.Visible = false;
            panel_SudMenuFact.Visible = false;
            
        }
        private void HidSudMenu()
        {
            if (panelSudMenuInicio.Visible == true)
                //panelSudMenuInicio = false;
            if (panel_SudMenuFact.Visible == true)
                panel_SudMenuFact.Visible = false;
        }

        private void showSudMenu(Panel sudMenu)
        {
            if (sudMenu.Visible == false)
            {
                HidSudMenu();
                sudMenu.Visible = true;
            }
            else
                sudMenu.Visible = false;
        }
        private void btn_Mercancia_Click(object sender, EventArgs e)
        {

        }

        private void btn_costos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_INICIO_Click(object sender, EventArgs e)
        {
            showSudMenu(panelSudMenuInicio);
        }

        private void btn_Fact_Click(object sender, EventArgs e)
        {
            showSudMenu(panel_SudMenuFact);
        }
    }
}
