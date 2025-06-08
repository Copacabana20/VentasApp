using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VentasApp.Util
{
    public static class DataGridViewStyler
    {
        public static void ApplyModernStyle(DataGridView dgv)
        {
            // Fuente y padding general
            dgv.Font = new Font("Segoe UI", 13);
            dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);

            // Bordes y colores de fondo
            dgv.BackgroundColor = Color.FromArgb(31, 30, 68); // Fondo del control
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(45, 45, 45);

            // Color de filas
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 72);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(72, 133, 237);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Encabezado de columna
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 30, 68);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 35;

            // Alternar color de filas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 60);

            // Ajustes varios
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void ApplyLightStyle(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.Padding = new Padding(5);

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 35;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void ApplyNeonDarkStyle(DataGridView dgv)
        {
            dgv.Font = new Font("Consolas", 10);
            dgv.RowTemplate.Height = 28;

            dgv.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgv.GridColor = Color.FromArgb(40, 40, 40);
            dgv.BorderStyle = BorderStyle.None;

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            dgv.DefaultCellStyle.ForeColor = Color.Lime;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Aqua;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 11, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);

            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void ApplyMaterialStyle(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 30;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.Gainsboro;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void OrdenarDataGridView<T>(DataGridView dgv, int columnIndex, bool ordenAscendente) where T : class
        {
            dgv.Columns[columnIndex].SortMode = DataGridViewColumnSortMode.Programmatic;
            string nombreColumna = dgv.Columns[columnIndex].DataPropertyName;

            if (string.IsNullOrEmpty(nombreColumna)) return;

            var listaOriginal = (List<T>)dgv.DataSource;

            List<T> listaOrdenada;

            if (ordenAscendente)
                listaOrdenada = listaOriginal.OrderBy(x => x.GetType().GetProperty(nombreColumna).GetValue(x)).ToList();
            else
                listaOrdenada = listaOriginal.OrderByDescending(x => x.GetType().GetProperty(nombreColumna).GetValue(x)).ToList();

            dgv.DataSource = null;
            dgv.DataSource = listaOrdenada;
            var ColumnId = dgv.Columns["Id"];
            if (ColumnId != null)
                ColumnId.Visible = false;

            dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection = ordenAscendente ? SortOrder.Ascending : SortOrder.Descending;
        }

    }
}
