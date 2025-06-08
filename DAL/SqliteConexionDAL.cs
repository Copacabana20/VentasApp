using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace VentasApp.DAL
{
    public class SqliteConexionDAL
    {
        private SQLiteDataReader _reader;
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private SQLiteDataAdapter _adapter;
        private SQLiteTransaction _transaction;

        public SQLiteConnection Conexion => _connection;
        public SQLiteDataReader Reader { get => _reader; set => _reader = value; }
        public SQLiteDataAdapter Adapter { get => _adapter; set => _adapter = value; }
        public SQLiteTransaction Transaction { get => _transaction; set => _transaction = value; }

        public SqliteConexionDAL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["VentasDB"].ConnectionString;
            _connection = new SQLiteConnection(connectionString);
        }

        private void InicializarComando(string query, SQLiteParameter[] parametros)
        {
            AbrirConexion();

            _command = new SQLiteCommand(query, _connection, _transaction);
            _command.CommandType = CommandType.Text;
            _command.Parameters.Clear();

            if (parametros != null)
                _command.Parameters.AddRange(parametros);
        }

        public void AbrirConexion()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
        }

        public void CerrarConexion()
        {
            if (_transaction == null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public SQLiteParameter CrearParametro(string nombre, object valor, ParameterDirection direction = ParameterDirection.Input)
        {
            return new SQLiteParameter(nombre, valor) { Direction = direction };
        }

        public int TraerUnValor(string query, SQLiteParameter[] parametros= null)
        {
            InicializarComando(query, parametros);
            var result = Convert.ToInt32(_command.ExecuteScalar());
            CerrarConexion();
            return result;
        }

        public string TraerUnValorString(string query, SQLiteParameter[] parametros = null)
        {
            InicializarComando(query, parametros);
            var result = _command.ExecuteScalar()?.ToString();
            CerrarConexion();
            return result;
        }

        public void Ejecutar(string query, SQLiteParameter[] parametros = null)
        {
            InicializarComando(query, parametros);
            _command.ExecuteNonQuery();
            if (_transaction == null)
                CerrarConexion();
        }

        public DataSet TraerDataSet(string query, SQLiteParameter[] parametros = null)
        {
            InicializarComando(query, parametros);
            _adapter = new SQLiteDataAdapter(_command);
            var ds = new DataSet();
            _adapter.Fill(ds);
            CerrarConexion();
            return ds;
        }

        public DataTable TraerDataTable(string query, SQLiteParameter[] parametros=null)
        {
            InicializarComando(query, parametros);
            _reader = _command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(_reader);
            CerrarConexion();
            return dt;
        }

        public void BeginTransaction()
        {
            AbrirConexion();
            _transaction = _connection.BeginTransaction();
        }

        public void RollBackTransaction()
        {
            _transaction?.Rollback();
            CerrarConexion();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            CerrarConexion();
        }
    }
}
