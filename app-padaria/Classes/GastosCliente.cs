using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca.Classes
{
    class GastosCliente:Conexao
    {
        private decimal ValorPago, ValorAtual;
        private int Id_Gastos,Id_Cliente;
        private DateTime UltimaData;

        public GastosCliente(int Id_Gastos,int Id_Cliente,decimal ValorAtual,decimal ValorPago,DateTime UltimaData)
        {
            this.Id_Gastos = Id_Gastos;
            this.Id_Cliente = Id_Cliente;
            this.ValorAtual = ValorAtual;
            this.ValorPago = ValorPago;
            this.UltimaData = UltimaData;
        }
        public GastosCliente(int Id_Cliente, decimal ValorAtual, decimal ValorPago, DateTime UltimaData)
        {         
            this.Id_Cliente = Id_Cliente;
            this.ValorAtual = ValorAtual;
            this.ValorPago = ValorPago;
            this.UltimaData = UltimaData;
        }

        public GastosCliente(int Id_Cliente, decimal ValorAtual,decimal ValorPago)
        {
            this.Id_Cliente = Id_Cliente;
            this.ValorAtual = ValorAtual;
            this.ValorPago = ValorPago;
        }

        public GastosCliente(int Id_Cliente, decimal ValorAtual)
        {
            this.Id_Cliente = Id_Cliente;
            this.ValorAtual = ValorAtual;
        }

        public GastosCliente(int Id_Cliente) {

            this.Id_Cliente = Id_Cliente;
        }

        public bool Add_Gastos()
        {
            Conectar();
            string SQL = "INSERT INTO GastosCliente VALUES(0, @Id_Cliente, @ValorAtual,0,now());";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            Parametros.Add(new MySqlParameter("@ValorAtual", ValorAtual));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool Att_Gastos()
        {
            Conectar();
            string SQL = "UPDATE GastosCliente SET ValorAtual = (ValorAtual + @ValorAtual), ValorPago =(ValorPago + @ValorPago), UltimaData = now() WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            Parametros.Add(new MySqlParameter("@ValorAtual", ValorAtual));
            Parametros.Add(new MySqlParameter("@ValorPago", ValorPago));
            Parametros.Add(new MySqlParameter("@UltimaData", UltimaData));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool Att_Valor()
        {
            Conectar();
            string SQL = "UPDATE GastosCliente SET ValorAtual = (ValorAtual - @ValorPago), ValorPago = (ValorPago + @ValorPago) WHERE Id_Cliente = @Id_Cliente;";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            Parametros.Add(new MySqlParameter("@ValorAtual", ValorAtual));
            Parametros.Add(new MySqlParameter("@ValorPago", ValorPago));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool Baixa(int Id_Cliente)
        {
            Conectar();
            string SQL = "UPDATE GastosCliente SET  ValorPago = ValorAtual, ValorAtual = 0  WHERE Id_Cliente = @Id_Cliente;";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public GastosCliente() { }

        public DataTable ConsultaGastos()
        {
            Conectar();
            string SQL = "SELECT * FROM GastosCliente";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarGastos(int Id_Gastos)
        {
            Conectar();
            string SQL = "SELECT * FROM GastosCliente WHERE Id_Gastos = @Id_Gastos";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Gastos", Id_Gastos));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarGastosId(int Id_Cliente)
        {
            Conectar();
            string SQL = "SELECT Nome_Cliente,Limite FROM Cliente_Padaria cp INNER JOIN gastoscliente gc ON cp.Id_Cliente = gp.Id_Cliente WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarGastosIdCliente(int Id_Cliente)
        {
            Conectar();
            string SQL = "SELECT Nome_Cliente,Limite WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }



    }
}
