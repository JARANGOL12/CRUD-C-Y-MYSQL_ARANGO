using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Alamcen.Presentacion
{
    public partial class btnMedida : Form
    {
        public btnMedida()
        {
            InitializeComponent();
        }
         private void Formato_ar()
        {
            Dvg_articulos.Columns[0].Width = 80;
            Dvg_articulos.Columns[0].HeaderText = "CODIGO";
            Dvg_articulos.Columns[1].Width = 250;
            Dvg_articulos.Columns[1].HeaderText= "ARTICULO";
            Dvg_articulos.Columns[2].Width= 150;
            Dvg_articulos.Columns[2].HeaderText = "MARCA";
            Dvg_articulos.Columns[3].Width = 80;
            Dvg_articulos.Columns[3].HeaderText = "MEDIDA";
            Dvg_articulos.Columns[4].Width = 150;
            Dvg_articulos.Columns[4].HeaderText = "CATEGORIA";
            Dvg_articulos.Columns[5].Width = 150;
            Dvg_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            Dvg_articulos.Columns[6].Visible = false;
            Dvg_articulos.Columns[7].Visible = false;
        }
        
        private void Listado_ar(String cTexto)
        {
            D_Articulos Datos = new D_Articulos();
            Dvg_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();



        }
         private void Estado_texto(bool lEstado)
        {
            
            txtArticulo.ReadOnly = !lEstado;
            txtMarca.ReadOnly = !lEstado;
            txtStock_Actual.ReadOnly = !lEstado;
        }

        private void Estado_botones_procesos(bool lEstado)
        {
            BtnMedida_um.Enabled=lEstado;
            btnCategoria.Enabled=lEstado;
            btnCancelar.Visible=lEstado;
            btnAgregar.Visible=lEstado;
            // otros detalles
            txtBuscar.ReadOnly = lEstado;
            bntBuscar.Enabled = !lEstado;
            Dvg_articulos.Enabled = !lEstado;

        }
        private void Limpia_texto()
        {
            txtArticulo.Text = "";
            txtMarca.Text ="";
            txtDescripcion_um.Text="";
            txtDescripcion_ar.Text="";
            txtStock_Actual.Text="";

        }

        private void Estado_botones_principales(bool lEstado)
        {
            btnNuevo.Enabled=lEstado;
            bntActualizar.Enabled=lEstado;
            btnEliminar.Enabled=lEstado;
            bntReporte.Enabled=lEstado;
            btnSalir.Enabled=lEstado;

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Articulos_load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
             this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            txtArticulo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
            txtBuscar.Focus();


        }
    }
}

