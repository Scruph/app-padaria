using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaPadoca
{
    class Venda_Efetuada : Conexao
    {
        private int Id_Venda, Id_Funcionario, Id_Pagamento, Id_Produto;
        private decimal Valor_Venda;

        public Venda_Efetuada()
        {
        }

        public Venda_Efetuada(int Id_Funcionario, int Id_Pagamento, int Id_Produto, decimal Valor_Venda)
        {
            this.Id_Funcionario = Id_Funcionario;
            this.Id_Pagamento = Id_Pagamento;
            this.Id_Produto = Id_Produto;
            this.Valor_Venda = Valor_Venda;
        }

        public Venda_Efetuada(int Id_Venda, int Id_Funcionario, int Id_Pagamento, int Id_Produto, decimal Valor_Venda)
        {
            this.Id_Venda = Id_Venda;
            this.Id_Funcionario = Id_Funcionario;
            this.Id_Pagamento = Id_Pagamento;
            this.Id_Produto = Id_Produto;
            this.Valor_Venda = Valor_Venda;
        }

        public Venda_Efetuada(int Id_Venda)
        {
            this.Id_Venda = Id_Venda;
        }

        public bool Add_Venda()
        {
            string SQL = "INSERT INTO Venda_Efetuada VALUES(0, @Id_Funcionario, @Id_Pagamento, @Id_Produto, @Valor_Venda);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            Parametros.Add(new MySqlParameter("@Id_Pagamento", Id_Pagamento));
            Parametros.Add(new MySqlParameter("@Id_Produto", Id_Produto));
            Parametros.Add(new MySqlParameter("@Valor_Venda", Valor_Venda));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }
    }
}
