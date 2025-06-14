using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VentasApp.Dto;
using VentasApp.Forms.ControlesDeUsuario;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Util;

namespace VentasApp.Forms
{
    public partial class VentasForm : Form
    {
        private static List<GridDetalleVentaDto> _DetalleVentaList = new List<GridDetalleVentaDto>();
        private static int _IdCaja = 0;
        private static int _Cantidad = 1;

        public VentasForm()
        {
            InitializeComponent();
            ValidarCajaAbierta();
            ActualizarDatos();
        }
        private void VentasForm_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyModernStyle(DgvVentas);
            LimpiarCodigo();
        }

        #region Abrir o Cerrar caja
        private bool ValidarCajaAbierta()
        {
            bool ok = true;
            var caja = CajaService.ObtenerUltimaCajaAbierta();
            if (caja == null)
            {
                _IdCaja = 0;
                LblFechaApertura.Visible = false;
                Dialog.Ok("No se encontró una caja abierta! Necesita abrir una caja para continuar");
                ok = false;
            }
            else
            {
                if (caja.FechaApertura.Date < DateTime.Now.Date)
                {
                    Dialog.Ok("Se encontró una caja abierta de un dia anterior. por favor cierre la caja y abra una nueva!");
                    ok = false;
                }
                _IdCaja = caja.Id;
                LblFechaApertura.Visible = true;
                LblFechaApertura.Text = $"La caja fue abierta el: {caja.FechaApertura}";
            }
            TxtCodigo.Enabled = ok;
            ActualizarBtnCaja();
            return ok;
        }

        private void iconBtnAbrirCerrarCaja_Click(object sender, EventArgs e)
        {
            if (_IdCaja == 0)
            {
                CajaService.AbrirCaja();
                ValidarCajaAbierta();
                Toast.Success("Caja abierta Exitosamente");
                LimpiarCodigo();
                return;
            }

            if (_DetalleVentaList.Any())
            {
                Toast.Warning("No se puede cerrar la caja porque hay una venta en proceso");
                return;
            }    

            if(Dialog.Confirm("¿Esta seguro de cerrar la caja?"))
            {
                CajaService.CerrarCaja(_IdCaja);
                _IdCaja = 0;
                LblFechaApertura.Visible = false;
                TxtCodigo.Enabled = false;
                Toast.Success("Caja cerrada Exitosamente");
                ActualizarBtnCaja();
                this.Close();
            }
        }

        #endregion

        #region Actualizar datos
        private void ActualizarBtnCaja()
        {
            const string textAbrirCaja = "Abrir caja";
            const string textCerrarCaja = "Cerrar caja";
            iconBtnAbrirCerrarCaja.Text = _IdCaja == 0 ? textAbrirCaja : textCerrarCaja;
        }

        private void ActualizarArticulos()
        {
            LblArticulos.Text = _DetalleVentaList.Count.ToString();
        }

        private void ActualizarSubTotal() 
        {
            LblSubTotal.Text = _DetalleVentaList.Sum(x => x.Subtotal).ToString("C2");
        }

        private void ActualizarGrid()
        {
            DgvVentas.DataSource = null;
            DgvVentas.DataSource = _DetalleVentaList;
            DgvVentas.Columns["Id"].Visible = false;
        }

        private void LimpiarCodigo()
        {
            TxtCodigo.Clear();
            TxtCodigo.Focus();
        }

        private void ActualizarDatos()
        {
            _Cantidad = 1;
            ActualizarArticulos();
            ActualizarSubTotal();
            ActualizarGrid();
            LimpiarCodigo();
        }

        #endregion

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '+')
                {
                    CargarProductoSinCodigo();
                    e.Handled = true;
                }
                else if (e.KeyChar == '*')
                {
                    ModificarCantidad();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Toast.Error(ex.Message);
                ActualizarDatos();
            }
        }


        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (string.IsNullOrEmpty(TxtCodigo.Text))
                        {
                            FinalizarVenta();
                        }
                        else
                        {
                            CargarProductoPorCodigo();
                        }
                        break;
                    case Keys.Escape:
                    case Keys.Delete:
                        CancelarVenta();
                        break;
                    case Keys.F1:
                        CargarProductoPorNombre();
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast.Error(ex.Message);
                ActualizarDatos();
            }
        }

        #region Cargar productos detalle
        private void CargarProductoPorNombre()
        {
            var miControl = new BuscadorProductosUc();
            miControl.ActualizarGridProductos();
            var result = Dialog.ShowUserControlAsDialog(miControl, "Buscar Producto");

            if (result == DialogResult.OK)
            {
                var seleccionado = miControl.SelectedProduct;
                CargarProductoPorCodigo(seleccionado);
            }
        }
        private void CargarProductoPorCodigo(Producto producto = null)
        {
            var prod = producto ?? ProductoService.BuscarPorCodigo(TxtCodigo.Text);
            if (prod == null)
                throw new Exception("El producto no existe");

            var detalleExistente = _DetalleVentaList.SingleOrDefault(x => x.Id == prod.Id);
            if (detalleExistente == null)
            {
                var detalleVenta = new GridDetalleVentaDto(_Cantidad, prod);
                _DetalleVentaList.Add(detalleVenta);
            }
            else
            {
                detalleExistente.Cantidad += _Cantidad;
            }

            ActualizarDatos();
        }
        private void CargarProductoSinCodigo()
        {
            decimal precio;
            if (!decimal.TryParse(TxtCodigo.Text,NumberStyles.Currency,CultureInfo.InvariantCulture,out precio))
            {
                throw new Exception("Ingrese un precio valido");
            }

            var detalleVenta = new GridDetalleVentaDto(_Cantidad,precio);
            _DetalleVentaList.Add(detalleVenta);
            ActualizarDatos();
        }

        #endregion
        
        private void ModificarCantidad() 
        {
            if (!int.TryParse(TxtCodigo.Text,out _Cantidad))
            {
                Toast.Error("Ingrese un numero valido");
            }
            else
            {
                Toast.Info($"Se modificó la cantidad a vender. Valor actual: {_Cantidad}");
            }
            LimpiarCodigo();
        }

        private void CancelarVenta()
        {
            if (Dialog.Confirm("¿Esta seguro de cancelar la venta?"))
            {
                ReiniciarVenta();
            }
        }

        private void ReiniciarVenta()
        {
            _DetalleVentaList.Clear();
            ActualizarDatos();
        }

        private void FinalizarVenta()
        {
            if (!_DetalleVentaList.Any())
            {
                Toast.Warning("No hay productos vendidos. Cargue algunos productos antes de finalizar la venta");
                return;
            }


            Venta VentaRealizada = new Venta(_IdCaja,_DetalleVentaList);
            var result = Dialog.ShowUserControlAsDialog(new ConfirmarVentaUc(VentaRealizada),width: 480, height: 350);
            if (result == DialogResult.OK)
            {
                Toast.Success("Venta realizada con exito");
                ReiniciarVenta();
            }
        }
    }

}
