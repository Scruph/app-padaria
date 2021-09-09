using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca
{
    class Cliente_Padaria : Conexao
    {
        private int Id_Cliente, Situacao,Limite;
        private string CPF_Cliente, Nome_Cliente, Bairro_Cliente, Rua_Cliente, Numero_Residencia_Cliente, Telefone_Fixo_Cliente, Telefone_Celular_Cliente;

        public Cliente_Padaria()
        {
        }

        //Metodo construtor onde são passados os valores necessarios para inserção do cadastro no banco de dados
        public Cliente_Padaria(string CPF_Cliente, string Nome_Cliente, string Bairro_Cliente, string Rua_Cliente, string Numero_Residencia_Cliente, string Telefone_Fixo_Cliente, string Telefone_Celular_Cliente, int Situacao, int Limite)
        {
            this.CPF_Cliente = CPF_Cliente;
            this.Nome_Cliente = Nome_Cliente;
            this.Bairro_Cliente = Bairro_Cliente;
            this.Rua_Cliente = Rua_Cliente;
            this.Numero_Residencia_Cliente = Numero_Residencia_Cliente;
            this.Telefone_Fixo_Cliente = Telefone_Fixo_Cliente;
            this.Telefone_Celular_Cliente = Telefone_Celular_Cliente;
            this.Situacao = Situacao;
            this.Limite = Limite;
        }

        //metodo construtor responsavel pelo alterar
        public Cliente_Padaria(int Id_Cliente, string CPF_Cliente, string Nome_Cliente, string Bairro_Cliente, string Rua_Cliente, string Numero_Residencia_Cliente, string Telefone_Fixo_Cliente, string Telefone_Celular_Cliente, int Situacao, int Limite)
        {
            this.Id_Cliente = Id_Cliente;
            this.CPF_Cliente = CPF_Cliente;
            this.Nome_Cliente = Nome_Cliente;
            this.Bairro_Cliente = Bairro_Cliente;
            this.Rua_Cliente = Rua_Cliente;
            this.Numero_Residencia_Cliente = Numero_Residencia_Cliente;
            this.Telefone_Fixo_Cliente = Telefone_Fixo_Cliente;
            this.Telefone_Celular_Cliente = Telefone_Celular_Cliente;
            this.Situacao = Situacao;
            this.Limite = Limite;
        }

        //metodo construtor responsavel pelo delete
        public Cliente_Padaria(int Id_Cliente)
        {
            this.Id_Cliente = Id_Cliente;
        }

        //Função responsavel por captar as variaveis e realizar o cadastro
        public bool Add_Cliente()
        {
            Conectar();
            string SQL = "INSERT INTO Cliente_Padaria VALUES(0, @CPF_Cliente, @Nome_Cliente, @Bairro_Cliente, @Rua_Cliente, @Numero_Residencia_Cliente, @Telefone_Fixo_Cliente, @Telefone_Celular_Cliente, @Situacao,@Limite);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@CPF_Cliente", CPF_Cliente));
            Parametros.Add(new MySqlParameter("@Nome_Cliente", Nome_Cliente));
            Parametros.Add(new MySqlParameter("@Bairro_Cliente", Bairro_Cliente));
            Parametros.Add(new MySqlParameter("@Rua_Cliente", Rua_Cliente));
            Parametros.Add(new MySqlParameter("@Numero_Residencia_Cliente", Numero_Residencia_Cliente));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Cliente", Telefone_Fixo_Cliente));
            Parametros.Add(new MySqlParameter("@Telefone_Celular_Cliente", Telefone_Celular_Cliente));
            Parametros.Add(new MySqlParameter("@Situacao", Situacao));
            Parametros.Add(new MySqlParameter("@Limite", Limite));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        //função responsavel por apagar registros
        public bool DelCliente(int Id_Cliente)
        {
            Conectar();
            string SQL = "DELETE FROM Cliente_Padaria WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        //funçao para consulta utilizando o id
        public DataTable ConsultarClientes(int Id_Cliente)
        {
            Conectar();
            string SQL = "SELECT * FROM Cliente_Padaria WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        // funçao para consulta utlizando string
        public DataTable ConsultarClientes(string Nome_Cliente)
        {
            Conectar();
            string SQL = "SELECT * FROM Cliente_Padaria WHERE Nome_Cliente LIKE @Nome_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Cliente", "%" + Nome_Cliente + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }
        public DataTable ConsultarClientes()
        {
            Conectar();
            string SQL = "SELECT * FROM Cliente_Padaria";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarClientesDvg()
        {
            Conectar();
            string SQL = "SELECT Id_Cliente,Nome_Cliente,Cpf_Cliente,Limite,Situacao FROM Cliente_Padaria";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarClientesDvg(string Nome_Cliente)
        {
            Conectar();
            string SQL = "SELECT Id_Cliente,Nome_Cliente,Cpf_Cliente,Limite,Situacao FROM Cliente_Padaria WHERE Nome_Cliente LIKE @Nome_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Cliente", "%" + Nome_Cliente + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarClientesDgv(int Id_Cliente)
        {
            Conectar();
            string SQL = "SELECT Id_Cliente,Cpf_Cliente,Nome_Cliente,Limite,Situacao FROM Cliente_Padaria WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable DadosFinancaCliente(int Id_Cliente)
        {
            Conectar();
            string SQL = "SELECT * FROM GastosCliente WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable DadosFinancaCliente()
        {
            Conectar();
            string SQL = "SELECT * FROM GastosCliente ";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        // funçao responsavel por atualizar registro
        public bool AttCliente()
        {
            Conectar();
            string SQL = "UPDATE Cliente_Padaria SET CPF_Cliente = @CPF_Cliente, Nome_Cliente = @Nome_Cliente, Bairro_Cliente = @Bairro_Cliente, Rua_Cliente = @Rua_Cliente, Numero_Residencia_Cliente = @Numero_Residencia_Cliente, Telefone_Fixo_Cliente = @Telefone_Fixo_Cliente, Telefone_Celular_Cliente = @Telefone_Celular_Cliente,Situacao = @Situacao, Limite = @Limite WHERE Id_Cliente = @Id_Cliente";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            Parametros.Add(new MySqlParameter("@CPF_Cliente", CPF_Cliente));
            Parametros.Add(new MySqlParameter("@Nome_Cliente", Nome_Cliente));
            Parametros.Add(new MySqlParameter("@Bairro_Cliente", Bairro_Cliente));
            Parametros.Add(new MySqlParameter("@Rua_Cliente", Rua_Cliente));
            Parametros.Add(new MySqlParameter("@Numero_Residencia_Cliente", Numero_Residencia_Cliente));
            Parametros.Add(new MySqlParameter("@Telefone_Fixo_Cliente", Telefone_Fixo_Cliente));
            Parametros.Add(new MySqlParameter("@Telefone_Celular_Cliente", Telefone_Celular_Cliente));
            Parametros.Add(new MySqlParameter("@Situacao", Situacao));
            Parametros.Add(new MySqlParameter("@Limite", Limite));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

    }
}
