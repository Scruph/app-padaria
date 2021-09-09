using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaPadoca.Forms_Iniciais;

namespace SistemaPadoca
{
    public class Conexao
    {
        //Criando variaveis privadas para ter uma maior segurança quando formos nos conectar com o anco de dados
        private string NomeDataBase;
        private string Host;
        private string Porta;
        private string User;
        private string Password;
        private MySqlConnection ConexaoExe;


        public Conexao(string NomeDataBase, string Host, string Porta, string User, string Password)
        {
            //Estabelencendo que as variaveis encontradas nessa classe serão atribuidas a conexão, por isso o uso do this
            this.NomeDataBase = NomeDataBase;
            this.Host = Host;
            this.Porta = Porta;
            this.User = User;
            this.Password = Password;
        }

        public Conexao()
        {
            //Atribuindo valores as variaveis criadas acima
            NomeDataBase = "App_Padaria";
            Host = "localhost";
            Porta = "3306";
            User = "root";
            Password = "";
        }

        public bool Conectar()
        {
            //Conectando a aplicação ao banco de dados com as informações aqui atribuidas
            string informacoes = "SERVER=" + this.Host + ";";
            informacoes += "PORT=" + Porta + ";";
            informacoes += "DATABASE=" + NomeDataBase + ";";
            informacoes += "UID=" + User + ";";
            informacoes += "PASSWORD=" + Password + ";";
            //Atribuido a variavel a tentativa de conexao para o banco de dados
            ConexaoExe = new MySqlConnection(informacoes);

            //Verificando se tal tentativa se possui exito.
            try
            {
                ConexaoExe.Open();
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return false;
            }

        }  
        //Executando instrução SQL no banco de dados
        protected bool SQLExe(string SQL, List<MySqlParameter> Values)
        {
            try
            {
                MySqlCommand Instruction = new MySqlCommand(SQL, ConexaoExe);
                if (Values != null)
                {
                    Instruction.Parameters.AddRange(Values.ToArray<MySqlParameter>());
                }
                Instruction.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
        }
        //Disconectar do Banco de dados
        protected void Disconnect()
        {
            ConexaoExe.Close();
        }

        //Atualizando e buscando na tabela dados inseridos no banco de dados
        protected DataTable consultaTabela(string SQL, List<MySqlParameter> DADOS)
        {
            try
            {
                MySqlDataAdapter comando = new MySqlDataAdapter(SQL, ConexaoExe);
                if (DADOS != null)
                {
                    comando.SelectCommand.Parameters.AddRange(DADOS.ToArray<MySqlParameter>());
                }
                DataTable dt = new DataTable();
                comando.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return null;
            }
        }

        public MySqlDataReader SqlReader(String sql, List<MySqlParameter> parametros)
        {
            try
            {
                //Criando uma instrução em SQL
                MySqlCommand comando = new MySqlCommand(sql, ConexaoExe);

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray<MySqlParameter>());
                }

                //Pegando o resultado da consulta
                MySqlDataReader dados = comando.ExecuteReader();

                //Retornando os dados
                return dados;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                //Caso ocorra algum erro, o retorno do método será null
                return null;
            }
        }

        protected DataTable SqlConsulta(string sql, List<MySqlParameter> valores)
        {
            try
            {
                MySqlDataAdapter comando = new MySqlDataAdapter(sql, ConexaoExe);
                comando.SelectCommand.Parameters.AddRange(valores.ToArray<MySqlParameter>());
                DataTable dt = new DataTable();
                comando.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return null;
            }
        }
        public string NomeFun(string Username, string PasswordDigitado)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Nome_Funcionario FROM Funcionario_Padaria WHERE Username = '" + Username + "' AND Password = '" + PasswordDigitado + "'", this.ConexaoExe);
            try
            {
                string nome = query.ExecuteScalar().ToString();               
                return nome;
            }
            catch (Exception)
            {                
                throw;
            }
        }
        public string IdFun(string Username, string PasswordDigitado)
        {

            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Id_Funcionario FROM Funcionario_Padaria WHERE Username = '" + Username + "' AND Password = '" + PasswordDigitado + "'", this.ConexaoExe);
            try
            {
                string nome = query.ExecuteScalar().ToString();
                return nome;
            }
            catch (Exception)
            {               
                throw;
            }
        }

        public string NomeProd()
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Nome_Produto FROM Produtos", this.ConexaoExe);
            try
            {
                string nome = query.ExecuteScalar().ToString();
                return nome;
            }
            catch (Exception)
            {               
                throw;
            }
        }

        public int Nivel(int Id)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Id_Permissoes FROM Funcionario_Padaria WHERE Id_Funcionario = "+ Id, this.ConexaoExe);
            try
            {
                int nome = Convert.ToInt32(query.ExecuteScalar().ToString());
                return nome;
            }
            catch (Exception)
            {                
                throw;
            }
        }
        public int MaxPedido()
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT MAX(Id_Pedido) FROM Pedido", this.ConexaoExe);
            try
            {
                int idPedido = Convert.ToInt16(query.ExecuteScalar().ToString());
                return idPedido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Produto(string NomeProd)
        {
            Conectar();
            string Parte2 = "";
            if(NomeProd[0] == '2' && NomeProd.Length > 6) {
                Parte2 = NomeProd.Substring(0, 6);
            }
            else
            {
                Parte2 = NomeProd;
            }         
            MySqlCommand query = new MySqlCommand("SELECT Count(Id_Produto) FROM Produtos WHERE Nome_Produto = '"+NomeProd+"' OR (Cod_Barras LIKE '"+NomeProd+ "%' OR Cod_Barras LIKE '" + Parte2 + "%')", this.ConexaoExe);
            try
            {
                int Produto = Convert.ToInt32(query.ExecuteScalar().ToString());
                return Produto;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public int Gastos(int Id_Cliente)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Count(Id_Gastos) FROM GastosCliente WHERE Id_Cliente = " + Id_Cliente, this.ConexaoExe);
            try
            {
                int nome = Convert.ToInt32(query.ExecuteScalar().ToString());
                return nome;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string NomeClienteFiado(int Id_Cliente)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Nome_Cliente from Cliente_Padaria WHERE Id_Cliente = "+Id_Cliente, this.ConexaoExe);
            try
            {
                string nome = query.ExecuteScalar().ToString();
                return nome;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int LimiteCliente(int Id_Cliente)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Limite from Cliente_Padaria WHERE Id_Cliente = " + Id_Cliente, this.ConexaoExe);
            try
            {
                int Limite = Convert.ToInt32(query.ExecuteScalar().ToString());
                return Limite;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string SenhaGerente()
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Password from Funcionario_Padaria WHERE Id_Permissoes = 1", this.ConexaoExe); 
            try
            {
                string Senha = query.ExecuteScalar().ToString();
                return Senha;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int IdDia()
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Id_Dia from Dia WHERE DataDia = CURDATE()", this.ConexaoExe);
            try
            {
                int Id = Convert.ToInt32(query.ExecuteScalar().ToString());
                return Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int IdDiaCount()
        {
            Conectar();
            MySqlCommand query = new MySqlCommand("SELECT Count(Id_Dia) from Dia WHERE DataDia = CURDATE()", this.ConexaoExe);
            try
            {
                int Id = Convert.ToInt32(query.ExecuteScalar().ToString());
                return Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
