using System;
using System.Windows.Forms;
using VentasApp.DAL.Validacion;
using VentasApp.Servicios;

namespace VentasApp
{
    public partial class MainForm : Form
    {
        private static int _index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _index++;
            switch (_index)
            {
                case 1:
                    LblCarga.Text = "Cargando Configuracion";
                    GenerarArchivosDeConfiguracion();
                    break;
                case 2:
                    LblCarga.Text = "Verificando Datos";                
                    GenerarBaseDeDatos();
                    break;
                case 3:
                    LblCarga.Text = "Aplicando Productos";
                    //Todo: aplicar productos por defecto
                    break;
                case 4:
                    LblCarga.Text = "Iniciando aplicacion";
                    FinalizarConfiguracion();
                    break;
                default:
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LblCarga.Text += ".";
        }

        private void GenerarBaseDeDatos()
        {
            BaseDeDatos.ValidarExistenciaBaseDeDatos();
        }

        private void GenerarArchivosDeConfiguracion()
        {
            DatosNegocioService.CrearArchivoJson();
        }

        private void FinalizarConfiguracion()
        {
            timer1.Stop();
            timer2.Stop();
            this.Close();
        }
    }
}
