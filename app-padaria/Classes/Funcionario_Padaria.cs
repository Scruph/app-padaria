using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;
using System.CodeDom.Compiler;

namespace SistemaPadoca
{
    class Funcionario_Padaria : Conexao
    {
        private string CPF_Funcionario, Nome_Funcionario, Bairro_Funcionario, Rua_Funcionario, Numero_Residencia_Funcionario, Telefone_Fixo_Funcionario, Telefone_Cel_Funcionario;
        private int Id_Funcionario,Id_Permissoes;
        private string Username, Password;
        MySqlDataReader info;
        public bool Cadastrado = false;
             
        public Funcionario_Padaria()
        {
        }

        public Funcionario_Padaria(int Id_Permissoes,string Username,string Password,string CPF_Funcionario, string Nome_Funcionario, string Bairro_Funcionario, string Rua_Funcionario, string Numero_Residencia_Funcionario, string Telefone_Fixo_Funcionario, string Telefone_Cel_Funcionario)
        {           
            this.Id_Permissoes = Id_Permissoes;
            this.Username = Username;
            this.Password = Password;
            this.CPF_Funcionario = CPF_Funcionario;
            this.Nome_Funcionario = Nome_Funcionario;
            this.Bairro_Funcionario = Bairro_Funcionario;
            this.Rua_Funcionario = Rua_Funcionario;
            this.Numero_Residencia_Funcionario = Numero_Residencia_Funcionario;
            this.Telefone_Fixo_Funcionario = Telefone_Fixo_Funcionario;
            this.Telefone_Cel_Funcionario = Telefone_Cel_Funcionario;
        }


        public Funcionario_Padaria(int Id_Funcionario,int Id_Permissoes,string Username, string Password,string CPF_Funcionario, string Nome_Funcionario, string Bairro_Funcionario, string Rua_Funcionario, string Numero_Residencia_Funcionario, string Telefone_Fixo_Funcionario, string Telefone_Cel_Funcionario)
        {          
            this.Id_Funcionario = Id_Funcionario;
            this.Id_Permissoes = Id_Permissoes;
            this.Username = Username;
            this.Password = Password;
            this.CPF_Funcionario = CPF_Funcionario;
            this.Nome_Funcionario = Nome_Funcionario;
            this.Bairro_Funcionario = Bairro_Funcionario;
            this.Rua_Funcionario = Rua_Funcionario;
            this.Numero_Residencia_Funcionario = Numero_Residencia_Funcionario;
            this.Telefone_Fixo_Funcionario = Telefone_Fixo_Funcionario;
            this.Telefone_Cel_Funcionario = Telefone_Cel_Funcionario;

        }


        public Funcionario_Padaria(int Id_Funcionario)
        {
            this.Id_Funcionario = Id_Funcionario;
        }

        public bool Add_Funcionarios()
        {
            Conectar();
            string SQL = "INSERT INTO Funcionario_Padaria VALUES(0, @Id_Permissoes,@Username,@Password,@CPF_Funcionario, @Nome_Funcionario, @Bairro_Funcionario,@Rua_Funcionario,@Numero_Residencia_Funcionario,@Telefone_Fixo_Funcionario,@Telefone_Cel_Funcionario);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Permissoes", Id_Permissoes));
            Parametros.Add(new MySqlParameter("@Username", Username));
            Parametros.Add(new MySqlParameter("@Password", Password));
            Parametros.Add(new MySqlParameter("@CPF_Funcionario", CPF_Funcionario));
            Parametros.Add(new MySqlParameter("@Nome_Funcionario", Nome_Funcionario));
            Parametros.Add(new MySqlParameter("@Bairro_Funcionario", Bairro_Funcionario));
            Parametros.Add(new MySqlParameter("@Rua_Funcionario", Rua_Funcionario));
            Parametros.Add(new MySqlParameter("@Numero_Residencia_Funcionario", Numero_Residencia_Funcionario));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Funcionario", Telefone_Fixo_Funcionario));
            Parametros.Add(new MySqlParameter("@Telefone_Cel_Funcionario", Telefone_Cel_Funcionario));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool DelFuncionarios(int Id_Funcionario)
        {
            Conectar();
            string SQL = "DELETE FROM Funcionario_Padaria WHERE Id_Funcionario = @Id_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public DataTable ConsultarFuncionarios(int Id_Funcionario)
        {
            Conectar();
            string SQL = "SELECT * FROM Funcionario_Padaria WHERE Id_Funcionario = @Id_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarFuncionarios(string Nome_Funcionario)
        {
            Conectar();
            string SQL = "SELECT * FROM Funcionario_Padaria WHERE Nome_Funcionario LIKE @Nome_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Funcionario","%" + Nome_Funcionario + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarFuncionariosDgv(string Nome_Funcionario)
        {
            Conectar();
            string SQL = "SELECT Id_Funcionario,Id_Permissoes,Nome_Funcionario,Telefone_Fixo_Funcionario FROM Funcionario_Padaria WHERE Nome_Funcionario LIKE @Nome_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Funcionario", "%" + Nome_Funcionario + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarFuncionariosDgv()
        {
            Conectar();
            string SQL = "SELECT Id_Funcionario,Id_Permissoes,Nome_Funcionario,Telefone_Fixo_Funcionario FROM Funcionario_Padaria";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarFuncionariosDgv(int Id_Funcionario)
        {
            Conectar();
            string SQL = "SELECT Id_Funcionario,Id_Permissoes,Nome_Funcionario,Telefone_Fixo_Funcionario FROM Funcionario_Padaria WHERE Id_Funcionario = @Id_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }


        public DataTable ConsultarFuncionarios()
        {
            Conectar();
            string SQL = "SELECT * FROM Funcionario_Padaria";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public bool AttFuncionarios()
        {
            Conectar();
            string SQL = "UPDATE Funcionario_Padaria SET Id_Permissoes= @Id_Permissoes, Username = @Username, Password = @Password, CPF_Funcionario = @CPF_Funcionario, Nome_Funcionario = @Nome_Funcionario, Bairro_Funcionario = @Bairro_Funcionario, Rua_Funcionario = @Rua_Funcionario, Numero_Residencia_Funcionario = @Numero_Residencia_Funcionario, Telefone_Fixo_Funcionario = @Telefone_Fixo_Funcionario, Telefone_Celular_Funcionario = @Telefone_Cel_Funcionario WHERE Id_Funcionario = @Id_Funcionario";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            Parametros.Add(new MySqlParameter("@Id_Permissoes", Id_Permissoes));
            Parametros.Add(new MySqlParameter("@Username", Username));
            Parametros.Add(new MySqlParameter("@Password", Password));
            Parametros.Add(new MySqlParameter("@CPF_Funcionario", CPF_Funcionario));
            Parametros.Add(new MySqlParameter("@Nome_Funcionario", Nome_Funcionario));
            Parametros.Add(new MySqlParameter("@Bairro_Funcionario", Bairro_Funcionario));
            Parametros.Add(new MySqlParameter("@Rua_Funcionario", Rua_Funcionario));
            Parametros.Add(new MySqlParameter("@Numero_Residencia_Funcionario", Numero_Residencia_Funcionario));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Funcionario", Telefone_Fixo_Funcionario));
            Parametros.Add(new MySqlParameter("@Telefone_Cel_Funcionario", Telefone_Cel_Funcionario));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool LoginFuncionarios(string Username, string Password)
        {
            Conectar();
            string SQL = "SELECT Id_Funcionario from Funcionario_Padaria WHERE Username = @Username AND Password = @Password";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Username", Username));
            Parametros.Add(new MySqlParameter("@Password", Password));
            info = SqlReader(SQL, Parametros);

            try
            {
                if (info.HasRows)
                {
                    return Cadastrado = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Senha e/ou Username incorretos");
                throw;
            }
            return Cadastrado;
        }
    }
}

