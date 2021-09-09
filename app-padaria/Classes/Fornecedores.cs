using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca
{
    class Fornecedores : Conexao
    {
        private int Id_Fornecedores;
        private string Nome_Fornecedores, Nome_Vendedor, Telefone_Fixo_Fornecedor, Telefone_Celular_Fornecedor;

        public Fornecedores()
        {

        }

        public Fornecedores(string Nome_Fornecedores, string Nome_Vendedor, string Telefone_Fixo_Fornecedor, string Telefone_Celular_Fornecedor)
        {
            this.Nome_Fornecedores = Nome_Fornecedores;
            this.Nome_Vendedor = Nome_Vendedor;
            this.Telefone_Fixo_Fornecedor = Telefone_Fixo_Fornecedor;
            this.Telefone_Celular_Fornecedor = Telefone_Celular_Fornecedor;
        }

        public Fornecedores(int Id_Fornecedores, string Nome_Fornecedores, string Nome_Vendedor, string Telefone_Fixo_Fornecedor, string Telefone_Celular_Fornecedor)
        {
            this.Id_Fornecedores = Id_Fornecedores;
            this.Nome_Fornecedores = Nome_Fornecedores;
            this.Nome_Vendedor = Nome_Vendedor;
            this.Telefone_Fixo_Fornecedor = Telefone_Fixo_Fornecedor;
            this.Telefone_Celular_Fornecedor = Telefone_Celular_Fornecedor;
        }

        public Fornecedores(int Id_Fornecedores)
        {
            this.Id_Fornecedores = Id_Fornecedores;
        }

        public Fornecedores(string Nome_Fornecedores)
        {
            this.Nome_Fornecedores = Nome_Fornecedores;
        }

        public bool Add_Fornecedores()
        {
            Conectar();
            string SQL = "INSERT INTO Fornecedores VALUES(0, @Nome_Fornecedores, @Nome_Vendedor, @Telefone_Fixo_Fornecedor, @Telefone_Celular_Fornecedor);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Fornecedores", Nome_Fornecedores));
            Parametros.Add(new MySqlParameter("@Nome_Vendedor", Nome_Vendedor));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Fornecedor", Telefone_Fixo_Fornecedor));
            Parametros.Add(new MySqlParameter("@Telefone_Celular_Fornecedor", Telefone_Celular_Fornecedor));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool DelFornecedores(int Id_Fornecedores)
        {
            Conectar();
            string SQL = "DELETE FROM Fornecedores WHERE Id_Fornecedores = @Id_Fornecedores";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Fornecedores", Id_Fornecedores));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public DataTable ConsultarFornecedores(int Id_Fornecedores)
        {
            Conectar();
            string SQL = "SELECT * FROM Fornecedores WHERE Id_Fornecedores = @Id_Fornecedores";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Fornecedores", Id_Fornecedores));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultaFornecedores(string Nome_Fornecedores)
        {
            Conectar();
            string SQL = "SELECT * FROM Fornecedores WHERE Nome_Fornecedores LIKE @Nome_Fornecedores";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Fornecedores", "%" + Nome_Fornecedores + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }
        public DataTable ConsultaFornecedores()
        {
            Conectar();
            string SQL = "SELECT * FROM Fornecedores";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public bool AttFornec()
        {
            Conectar();
            string SQL = "UPDATE Fornecedores SET Nome_Fornecedores = @Nome_Fornecedores, Nome_Vendedor = @Nome_Vendedor, Telefone_Fixo_Fornecedor = @Telefone_Fixo_Fornecedor, Telefone_Celular_Fornecedor = @Telefone_Celular_Fornecedor WHERE Id_Fornecedores= @Id_Fornecedores";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Fornecedores", Id_Fornecedores));
            Parametros.Add(new MySqlParameter("@Nome_Fornecedores", Nome_Fornecedores));
            Parametros.Add(new MySqlParameter("@Nome_Vendedor", Nome_Vendedor));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Fornecedor", Telefone_Fixo_Fornecedor));
            Parametros.Add(new MySqlParameter("@Telefone_Celular_Fornecedor", Telefone_Celular_Fornecedor));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

    }
}

