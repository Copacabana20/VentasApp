using System.Drawing;
using System;
using System.Windows.Forms;

namespace VentasApp.Forms
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private Label lblNombreNegocio;
        private Button btnAbrirCaja;
        private Button btnCerrarCaja;
        private Button btnProductos;
        private Button btnReportes;
        private DataGridView dgvVenta;
        private TextBox txtCodigo;
        private Label lblTotal;
        private Button btnFinalizarVenta;

        private void ConfigurarControles()
        {
            this.Text = "Branty Ventas";
            this.Size = new Size(800, 600);

            lblNombreNegocio = new Label
            {
                Text = "Branty Ventas",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 10),
                AutoSize = true
            };

            txtCodigo = new TextBox { Location = new Point(20, 100), Width = 300 };
            txtCodigo.KeyDown += TxtCodigo_KeyDown;

            dgvVenta = new DataGridView
            {
                Location = new Point(20, 140),
                Size = new Size(740, 300),
                AllowUserToAddRows = false,
                ReadOnly = true
            };
            dgvVenta.Columns.Add("Producto", "Producto");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Subtotal", "Subtotal");

            lblTotal = new Label
            {
                Text = "Total: $0.00",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(600, 450),
                AutoSize = true
            };

            btnFinalizarVenta = new Button
            {
                Text = "Finalizar Venta",
                Location = new Point(600, 500),
                Size = new Size(160, 40),
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            this.Controls.AddRange(new Control[]
            {
            lblNombreNegocio, btnAbrirCaja, btnCerrarCaja,
            btnProductos, btnReportes, txtCodigo,
            dgvVenta, lblTotal, btnFinalizarVenta
            });
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simulación: buscar producto y agregar
                string codigo = txtCodigo.Text.Trim();
                if (!string.IsNullOrEmpty(codigo))
                {
                    dgvVenta.Rows.Add("Producto demo", 1, 100, 100);
                    ActualizarTotal();
                    txtCodigo.Clear();
                }
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lblTotal.Text = $"Total: ${total:N2}";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {

        }
    }

}
