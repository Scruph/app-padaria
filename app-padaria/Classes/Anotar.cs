using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca.Forms_Iniciais
{
    class Anotar: Conexao
    {
        private int Id_Anotacao;
        private string Situacao, Descricao;
        private DateTime Data;

        //Insert
        public Anotar(string Descricao, string Situacao,DateTime Data)
        {
            this.Descricao = Descricao;
            this.Situacao = Situacao;
            this.Data = Data;
        }

        //Update
        public Anotar(int Id_Anotacao,string Descricao, string Situacao, DateTime Data)
        {
            this.Id_Anotacao = Id_Anotacao;
            this.Descricao = Descricao;
            this.Situacao = Situacao;
            this.Data = Data;
        }

        //Select Pelo Nome
        public Anotar(string Descricao)
        {
            this.Descricao = Descricao;
        }

        //ADD Anotaçao
        public bool AddAnotacao()
        {
            Conectar();
            string SQL = "INSERT INTO Anotacao VALUES(0, @Descricao, @Data, @Situacao);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Descricao", Descricao));
            Parametros.Add(new MySqlParameter("@Data", Data));
            Parametros.Add(new MySqlParameter("@Situacao", Situacao));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        //ATT Anotacao
        public bool AttAnotacao()
        {
            Conectar();
            string SQL = "UPDATE Anotacao SET Descricao = @Descricao, Situacao = @Situacao WHERE Id_Anotacao= @Id_Anotacao";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Anotacao", Id_Anotacao));
            Parametros.Add(new MySqlParameter("@Descricao", Descricao));
            Parametros.Add(new MySqlParameter("@Situacao", Situacao));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        //Delete Anotacao
        public bool DelFornecedores(int Id_Anotacao)
        {
            Conectar();
            string SQL = "DELETE FROM Anotacao WHERE Id_Anotacao = @Id_Anotacao";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Anotacao", Id_Anotacao));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        //Consulta Anotacao
        public DataTable ConsultaAnotacao(string Descricao)
        {
            Conectar();
            string SQL = "SELECT * FROM Anotacao WHERE Descricao LIKE @Descricao";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Descricao", "%" + Descricao + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultaAnotacao()
        {
            Conectar();
            string SQL = "SELECT * FROM Anotacao";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultaAnotacao(int Id_Anotacao)
        {
            Conectar();
            string SQL = "SELECT * FROM Anotacao WHERE Id_Anotacao = @Id_Anotacao";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Anotacao", Id_Anotacao));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }


        //Metodo de Chamada
        public Anotar() { }


    }
}
