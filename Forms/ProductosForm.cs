﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Util;

namespace VentasApp.Forms
{
    public partial class ProductosForm : Form
    {
        private static int _currentProductId = 0;

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            ActualizarGridProductos();
        }

        private void LimpiarForm()
        {
            _currentProductId = 0;
            TxtCodigo.Clear();
            TxtProducto.Clear();
            TxtPrecio.Clear();
            iconBtnEditCod.Visible = false;
            iconBtnEditProd.Visible = false;
            LblUltActualizacion.Visible = false;
            TxtProducto.Enabled = true;
            TxtCodigo.Enabled = true;
            TxtCodigo.Focus();
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var prod = ProductoService.BuscarPorCodigo(TxtCodigo.Text);

                if (prod != null)
                {
                    _currentProductId = prod.Id;
                    TxtProducto.Text = prod.Nombre;
                    
                    TxtProducto.Enabled = false;
                    iconBtnEditProd.Visible = true;
                    LblUltActualizacion.Text = $"Producto actualizado por ultima vez el {prod.UltimaActualizacion.ToString("dd/MM/yyyy")}";
                    LblUltActualizacion.Visible=true;
                    TxtPrecio.Text = prod.Precio.ToString().Replace(",",".");
                    TxtPrecio.Focus();
                    TxtPrecio.Select();
                }
                else
                {
                    _currentProductId = 0;
                    LblUltActualizacion.Text = $"Se insertará un producto nuevo";
                    LblUltActualizacion.Visible = true;
                    TxtProducto.Enabled = true;
                    iconBtnEditProd.Visible = false;
                    TxtProducto.Focus();
                }

                TxtCodigo.Enabled = false;
                iconBtnEditCod.Visible = true;
            }
        }
        private void TxtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPrecio.Focus();
                TxtPrecio.Select();
            }
        }
        private void TxtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var producto = ValidarDatosCorrectos();
                    GuardarProducto(producto);
                    ActualizarGridProductos();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    Toast.Error(ex.Message);
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = ((TextBox)sender).Text;
            if (char.IsControl(e.KeyChar) || (e.KeyChar == '.' && !txt.Contains(".")))
            {
                return; 
            }

            if (char.IsDigit(e.KeyChar))
            {
                if (!txt.Contains("."))
                    return;

                if (txt.Split('.')[1].Length < 2)
                    return;
            }

            e.Handled = true;
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = ValidarDatosCorrectos();
                if (Dialog.Confirm("¿Desea guardar los productos?"))
                {
                    GuardarProducto(producto);
                    ActualizarGridProductos();
                    LimpiarForm();
                }
            }
            catch (Exception ex)
            {
                Toast.Error(ex.Message);
            }
        }

        private Producto ValidarDatosCorrectos()
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text) ||
                string.IsNullOrEmpty(TxtProducto.Text) ||
                string.IsNullOrEmpty(TxtPrecio.Text))
            {
                throw new Exception("Complete todos los campos");
            }
            decimal precio;
            if (!decimal.TryParse(TxtPrecio.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out precio))
            {
                throw new Exception("el precio no es valido");
            }

            Producto producto = new Producto()
            {
                Id = _currentProductId,
                Codigo = TxtCodigo.Text,
                Nombre = TxtProducto.Text,
                Precio = decimal.Parse(TxtPrecio.Text, CultureInfo.InvariantCulture),
                UltimaActualizacion = DateTime.Now,
            };

            return producto;
        }

        private void GuardarProducto(Producto producto)
        {
            if (producto == null || producto?.Id == 0)
            {
                ProductoService.AgregarProducto(producto);
            }
            else
            {
                ProductoService.ActualizarProducto(producto);
            }
            Toast.Success("El producto se guardó correctamente");
        }

        private void ActualizarGridProductos()
        {
            buscadorProductosUc1.ActualizarGridProductos();
        }

        private void iconBtnEditCod_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = true;
            iconBtnEditCod.Visible = false;
            TxtCodigo.Focus();
        }

        private void iconBtnEditProd_Click(object sender, EventArgs e)
        {
            TxtProducto.Enabled = true;
            iconBtnEditProd.Visible = false;
            TxtProducto.Focus();
        }

        private void TxtPrecio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void buscadorProductosUc1_ProductoSeleciconado(object sender, Producto e)
        {
            Producto prod = e;
            _currentProductId = prod.Id;
            TxtProducto.Text = prod.Nombre;

            TxtProducto.Enabled = false;
            iconBtnEditProd.Visible = true;
            LblUltActualizacion.Text = $"Producto actualizado por ultima vez el {prod.UltimaActualizacion.ToString("dd/MM/yyyy")}";
            LblUltActualizacion.Visible = true;
            TxtPrecio.Text = prod.Precio.ToString().Replace(",",".");
            TxtCodigo.Text = prod.Codigo;
            TxtCodigo.Enabled = false;
            iconBtnEditCod.Visible = true;
            TxtPrecio.Focus();
            TxtPrecio.Select();
        }
    }
}
