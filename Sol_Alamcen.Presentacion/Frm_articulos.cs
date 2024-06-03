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
       
        int codigo_ar = 0;
        int nEstadoGuarda = 0;

        private void Formato_ar()
        {
            Dvg_articulos.Columns[0].Width = 80;
            Dvg_articulos.Columns[0].HeaderText = "CODIGO";
            Dvg_articulos.Columns[1].Width = 250;
            Dvg_articulos.Columns[1].HeaderText = "ARTICULO";
            Dvg_articulos.Columns[2].Width = 150;
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
            BtnMedida_um.Enabled = lEstado;
            btnCategoria.Enabled = lEstado;
            btnCancelar.Visible = lEstado;
            btnAgregar.Visible = lEstado;
            // otros detalles
            txtBuscar.ReadOnly = lEstado;
            bntBuscar.Enabled = !lEstado;
            Dvg_articulos.Enabled = !lEstado;

        }
        private void Limpia_texto()
        {
            txtArticulo.Text = "";
            txtMarca.Text = "";
            txtDescripcion_um.Text = "";
            txtDescripcion_ar.Text = "";
            txtStock_Actual.Text = "";

        }

        private void Estado_botones_principales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            bntActualizar.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            bntReporte.Enabled = lEstado;
            btnSalir.Enabled = lEstado;

        }
        private void selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dvg_articulos.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("selecciona un registro",
                    "aviso del sistema " ,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
            }
            else
            {
                this.codigo_ar = Convert.ToInt32(Dvg_articulos.CurrentRow.Cells["codigo_ar"].Value);
                txtArticulo.Text = Convert.ToString(Dvg_articulos.CurrentRow.Cells["descripcion_ar"].Value);
                txtMarca.Text = Convert.ToString(Dvg_articulos.CurrentRow.Cells["marca_ar"].Value);
                txtDescripcion_um.Text = Convert.ToString(Dvg_articulos.CurrentRow.Cells["descripcion_um"].Value);
                txtDescripcion_ar.Text = Convert.ToString(Dvg_articulos.CurrentRow.Cells["descripcion_ca"].Value);
                txtStock_Actual.Text = Convert.ToString(Dvg_articulos.CurrentRow.Cells["stock_Actual"].Value);

            }
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
            nEstadoGuarda = 1;//nuevo Registro
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_Articulos Oar = new P_Articulos();
            Oar.codigo_ar = codigo_ar;
            Oar.descripcion_ar = txtArticulo.Text.Trim();
            Oar.marca_ar = txtMarca.Text.Trim();
            Oar.codigo_um = 1;
            Oar.codigo_ca = 1;
            Oar.stock_Actual = Convert.ToDecimal(txtStock_Actual.Text);
            Oar.fecha_crea = DateTime.Now.ToString("yyyy-MM-dd");
            Oar.fecha_modifica = DateTime.Now.ToString("yyyy-MM-dd");
           

            D_Articulos datos = new D_Articulos();
            Rpta = datos.guardar_ar(nEstadoGuarda, Oar);

            if (Rpta.Equals("ok")){
                this.Estado_texto(false);
                this.Estado_botones_procesos(false);
                this.Estado_botones_principales(true);
                this.Listado_ar("%");
                codigo_ar = 0;
                nEstadoGuarda = 0;


                MessageBox.Show("Los datos han sido Guardados Correctamente","Aviso del Sistema",
                       MessageBoxButtons.OK,  
                       MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta, 
                    "aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2;
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            txtArticulo.Focus();

        }

        private void Dvg_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecciona_item();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigo_ar > 0)
            {
                String Rpta = "";
                D_Articulos datos = new D_Articulos();
                Rpta = datos.Eliminar_ar(codigo_ar);
                if (Rpta.Equals("OK"))
                {
                    this.Limpia_texto();
                    this.Listado_ar("%");
                    codigo_ar = 0;
                    MessageBox.Show("Registro eliminado correctamente",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el registro: " + Rpta,
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún registro para eliminar",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }
        }
    }






