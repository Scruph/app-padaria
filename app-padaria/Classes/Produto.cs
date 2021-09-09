using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca
{
    class Produtos : Conexao
    {
        private int Id_Produto, Qtde_Disponivel, Unidade, Id_Fornecedores;
        private decimal Preco;
        private string Nome_Produto, Tipo_Produto,Cod_Barras;
        private DateTime Data_Validade;


        //Cadastrar
        public Produtos(int Id_Fornecedores, decimal Preco, string Nome_Produto, string Tipo_Produto, int Unidade,string Cod_Barras, int Qtde_Disponivel, DateTime Data_Validade)
        {
            this.Id_Fornecedores = Id_Fornecedores;
            this.Preco = Preco;
            this.Nome_Produto = Nome_Produto;                  
            this.Tipo_Produto = Tipo_Produto;
            this.Unidade = Unidade;
            this.Cod_Barras = Cod_Barras;
            this.Qtde_Disponivel = Qtde_Disponivel;
            this.Data_Validade = Data_Validade;
        }

        public Produtos() { }

        //Alterar
        public Produtos(int Id_Produto,int Id_Fornecedores, decimal Preco, string Nome_Produto, string Tipo_Produto, int Unidade,string Cod_Barras, int Qtde_Disponivel, DateTime Data_Validade)
        {
            this.Id_Produto = Id_Produto;
            this.Id_Fornecedores = Id_Fornecedores;
            this.Preco = Preco;
            this.Nome_Produto = Nome_Produto;
            this.Tipo_Produto = Tipo_Produto;
            this.Unidade = Unidade;
            this.Cod_Barras = Cod_Barras;
            this.Qtde_Disponivel = Qtde_Disponivel;
            this.Data_Validade = Data_Validade;
        }

        //Consultar
        public Produtos(int Id_Produto)
        {
            this.Id_Produto = Id_Produto;
        }

        //Consultar por Nome
        public Produtos(string Nome_Produto)
        {
            this.Nome_Produto = Nome_Produto;
        }

        //BD
        public bool Add_Produtos()
        {
            Conectar();
            string SQL = "INSERT INTO Produtos VALUES(0,@Id_Fornecedores,@Preco, @Nome_Produto, @Tipo_Produto,@Unidade,@Cod_Barras, @Qtde_Disponivel,@Data_Validade);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Fornecedores", Id_Fornecedores));
            Parametros.Add(new MySqlParameter("@Preco", Preco));
            Parametros.Add(new MySqlParameter("@Nome_Produto", Nome_Produto));
            Parametros.Add(new MySqlParameter("@Tipo_Produto", Tipo_Produto));
            Parametros.Add(new MySqlParameter("@Unidade", Unidade));
            Parametros.Add(new MySqlParameter("@Cod_Barras", Cod_Barras));
            Parametros.Add(new MySqlParameter("@Qtde_Disponivel", Qtde_Disponivel));
            Parametros.Add(new MySqlParameter("@Data_Validade", Data_Validade));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }
        public bool DelProduto(int Id_Produto)
        {
            Conectar();
            string SQL = "DELETE FROM Produtos WHERE Id_Produto = @Id_Produto";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Produto", Id_Produto));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public DataTable ConsultarProdutos(int Id_Produto)
        {
            Conectar();
            string SQL = "SELECT * FROM Produtos WHERE Id_Produto = @Id_Produto";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Produto", Id_Produto));
            DataTable DADOS  = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarProdutos()
        {
            Conectar();
            string SQL = "SELECT Id_Produto,Nome_Produto,Preco,Cod_Barras FROM Produtos";
            DataTable DADOS = consultaTabela(SQL, null);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarBarcode(string Cod_Barras)
        {
            Conectar();
            string SQL = "SELECT Id_Produto,Nome_Produto,Preco,Cod_Barras,Unidade FROM Produtos WHERE Cod_Barras LIKE @Cod_Barras";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Cod_Barras",Cod_Barras + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public DataTable ConsultarProdutos(string Nome_Produto)
        {
            Conectar();
            string SQL = "SELECT Id_Produto,Nome_Produto,Preco,Cod_Barras,Unidade FROM Produtos WHERE Nome_Produto LIKE @Nome_Produto";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Nome_Produto", "%" + Nome_Produto + "%"));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }

        public bool AttProduto()
        {
            Conectar();
            string SQL = "UPDATE Produtos SET Id_Fornecedores = @Id_Fornecedores, Preco = @Preco, Nome_Produto = @Nome_Produto, Tipo_Produto = @Tipo_Produto, Unidade = @Unidade, Cod_Barras = @Cod_Barras, Qtde_Disponivel = @Qtde_Disponivel, Data_Validade = @Data_Validade  WHERE Id_Produto= @Id_Produto";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Produto", Id_Produto));
            Parametros.Add(new MySqlParameter("@Id_Fornecedores", Id_Fornecedores));
            Parametros.Add(new MySqlParameter("@Preco", Preco));
            Parametros.Add(new MySqlParameter("@Nome_Produto", Nome_Produto));
            Parametros.Add(new MySqlParameter("@Tipo_Produto", Tipo_Produto));
            Parametros.Add(new MySqlParameter("@Unidade", Unidade));
            Parametros.Add(new MySqlParameter("@Cod_Barras", Cod_Barras));
            Parametros.Add(new MySqlParameter("@Qtde_Disponivel", Qtde_Disponivel));
            Parametros.Add(new MySqlParameter("@Data_Validade", Data_Validade));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

       

    }
}
