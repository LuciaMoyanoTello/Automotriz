﻿using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using AutomotrizBack.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class FrmNuevoProducto : Form
    {
        private int idNuevoProducto;
        private Producto producto;
        public FrmNuevoProducto(Producto oProducto = null)
        {
            InitializeComponent();

            producto = oProducto;
        }



        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "0";
            cboTipoProducto.SelectedIndex = -1;
        }


        //Valida los campos de creacion
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Load
        private void FrmNuevoProducto_Load(object sender = null, EventArgs e = null)
        {
            dgvConsultarProductos.Rows.Clear();
            LimpiarControles();

            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");

            txtNombreProducto.Focus();

            //Define si el formulario dira de ser usado para editar o crear un presupuesto
            if (producto != null)
            {
                lblTitulo.Text = "Editar Producto (N" + producto.Id + ")";

                txtNombreProducto.Text = producto.Nombre;
                txtPrecioProducto.Text = Convert.ToString(producto.Precio);
                cboTipoProducto.Text = producto.Tipo;
            }
            else
            {
                DataTable tabla = DBHelper.ObtenerInstancia().ConsultarSP("[SP_PROXIMO_ID_PRODUCTOS]");
                idNuevoProducto = Convert.ToInt32(tabla.Rows[0][0]);
                lblTitulo.Text = "Nuevo Producto (N" + idNuevoProducto + ")";
            }
        }


        //Valida el ingreso de datos de los campos del form
        private bool ValidarConfirmar()
        {
            if (txtNombreProducto.Text == "")
            {
                MessageBox.Show("Error\nIngrese el nombre del producto...");
                return false;
            }
            if (txtPrecioProducto.Text == "" || Convert.ToInt32(txtPrecioProducto.Text) <= 0)
            {
                MessageBox.Show("Error\nIngrese un precio valido...");
                return false;
            }
            if (cboTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Error\nIngrese el tipo de producto...");
                return false;
            }
            return true;
        }


        //Inicia insert o update con la base de datos, el camino se toma dependiendo si "producto" es null o no
        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();

            if (producto != null)
            {
                if(ValidarConfirmar())
                {
                    //Creacion de producto
                    Producto nuevoProducto = new Producto(  producto.Id,
                                                            txtNombreProducto.Text,
                                                            Convert.ToSingle(txtPrecioProducto.Text),
                                                            Convert.ToString(cboTipoProducto.SelectedValue));

                    string bodyContent = JsonConvert.SerializeObject(nuevoProducto);

                    string url = "https://localhost:7089/api/Producto/UpdateProducto";
                    var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

                    MessageBox.Show("El producto se actualizo correctamente");
                    FrmPrincipal.instancia.CambiarFormulario(FrmPrincipal.instancia.ConsultarProductos = new FrmConsultarProductos());
                }
            }
            else
            {
                if (ValidarConfirmar())
                {
                    //Creacion de producto
                    Producto nuevoProducto = new Producto(  idNuevoProducto,
                                                            txtNombreProducto.Text,
                                                            Convert.ToSingle(txtPrecioProducto.Text),
                                                            Convert.ToString(cboTipoProducto.SelectedValue));

                    string bodyContent = JsonConvert.SerializeObject(nuevoProducto);

                    string url = "https://localhost:7089/api/Producto/InsertProducto";
                    var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

                    MessageBox.Show("El producto se creo correctamente");
                    FrmNuevoProducto_Load();
                }
            }
        }


        //Evento para cancelar la creacion y reiniciar los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                FrmPrincipal.instancia.CambiarFormulario(FrmPrincipal.instancia.ConsultarProductos = new FrmConsultarProductos());
            }
            else
            {
                FrmNuevoProducto_Load();
            }
        }


        //Veriica si la tecla presionada es un numero o un "backspace", si no lo es, se ignora
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ================================================================================================================================= //
    }
}
