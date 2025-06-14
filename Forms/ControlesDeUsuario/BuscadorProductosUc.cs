using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Util;

namespace VentasApp.Forms.ControlesDeUsuario
{
    public partial class BuscadorProductosUc : UserControl
    {
        private static bool _OrderAscending;
        public Producto SelectedProduct = new Producto();
        private static List<Producto> _prods = new List<Producto>();
        public event EventHandler<Producto> ProductoSeleccionadoEvento;

        public BuscadorProductosUc()
        {
            InitializeComponent();
        }

        private void BuscadorProductosUc_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyModernStyle(DgvProductos);
            //ActualizarGridProductos();
            TxtBusqueda.Clear();
            TxtBusqueda.Focus();
        }

        public void ActualizarGridProductos()
        {
            _prods = ProductoService.ObtenerTodos();
            DgvProductos.DataSource = _prods;
            DgvProductos.Columns["Id"].Visible = false; 
            TxtBusqueda_TextChanged(null, null);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            var originalProds = _prods;
            var filteredProd = originalProds.Where(x => x.Nombre.ToLower().Contains(TxtBusqueda.Text.ToLower())).ToList();
            DgvProductos.DataSource = filteredProd;
            DgvProductos.Columns["Id"].Visible = false;
        }

        private void DgvProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewStyler.OrdenarDataGridView<Producto>(DgvProductos, e.ColumnIndex, _OrderAscending);
            _OrderAscending = !_OrderAscending;
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SelectedProduct = (Producto)DgvProductos.Rows[e.RowIndex].DataBoundItem;

            if (this.FindForm().Name == "UserControlAsDialogForm")
            {
                this.FindForm().DialogResult = DialogResult.OK;
                this.FindForm().Close();
            }

            ProductoSeleccionadoEvento?.Invoke(this, SelectedProduct);
        }
    }
}
