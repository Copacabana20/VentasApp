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
        private static List<Producto> _prods = new List<Producto>();
        private static bool _OrderAscending;
        public Producto SelectedProduct = new Producto();

        public BuscadorProductosUc()
        {
            InitializeComponent();
        }

        private void BuscadorProductosUc_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyModernStyle(DgvProductos);
            _prods = ProductoService.ObtenerTodos();
            ActualizarGridProductos(_prods);
            TxtBusqueda.Clear();
        }

        private void ActualizarGridProductos(List<Producto> prods)
        {
            DgvProductos.DataSource = prods;
            DgvProductos.Columns["Id"].Visible = false;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGridProductos(_prods.Where(x => x.Nombre.ToLower().Contains(TxtBusqueda.Text.ToLower())).ToList());
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

            if(this.FindForm().Name == "UserControlAsDialogForm")
            {
                this.FindForm().DialogResult = DialogResult.OK;
                this.FindForm().Close();
            }

        }
    }
}
