using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solicitud_de_Servicio_Interno_HVLH.Vista.Admin
{
    public partial class FrmProbandoNroTick : Form
    {
        public FrmProbandoNroTick()
        {
            InitializeComponent();
        }

        private void btnReadeR_Click(object sender, EventArgs e)
        {

            int Cod_Pa;
            //numeroFactura = 1999999;
            Cod_Pa = 1000001;

            string idFactura = Cod_Pa.ToString("T000-000000");
            txtNum.Text = idFactura;
            string varrr="T001-999999";
            string sss=idFactura;
            if (varrr == sss)
            {
                Cod_Pa = 2999999;
                string idFacturas = Cod_Pa.ToString("T000-000000");
                txtNum.Text = idFacturas;


            }
           
        }

       
    }
}
