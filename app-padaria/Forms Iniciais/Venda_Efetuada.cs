using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca.Forms_Iniciais
{
    class Venda_Efetuada:Conexao
    {
        private int Id_Venda,Id_Funcionario, Id_Produto, Id_Cliente,Turno;
        private decimal Valor_Venda;
        private string Pagamento;
        private string Data_Venda,Hora_Venda;

        //Cadastrar
        public Venda_Efetuada(int Id_Funcionario,int Id_Produto,int Id_Cliente, string Pagamento ,decimal Valor_Venda,string Data_Venda ,int Turno,string Hora_Venda) 
        {       
            this.Id_Funcionario = Id_Funcionario;
            this.Id_Produto = Id_Produto;
            this.Id_Cliente = Id_Cliente;
            this.Pagamento = Pagamento;
            this.Valor_Venda = Valor_Venda;
            this.Data_Venda = Data_Venda;
            this.Turno = Turno;
            this.Hora_Venda = Hora_Venda;
        }

        public bool Add_Venda()
        {
            Conectar();
            string SQL = "INSERT INTO Venda_Efetuada VALUES(0,@Id_Funcionario, @Id_Produto, @Id_Cliente,@Pagamento,@Valor_Venda, @Data_Venda,@Turno,@Hora_Venda);";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Funcionario", Id_Funcionario));
            Parametros.Add(new MySqlParameter("@Id_Produto", Id_Produto));
            Parametros.Add(new MySqlParameter("@Id_Cliente", Id_Cliente));
            Parametros.Add(new MySqlParameter("@Pagamento", Pagamento));
            Parametros.Add(new MySqlParameter("@Valor_Venda", Valor_Venda));
            Parametros.Add(new MySqlParameter("@Data_Venda", Data_Venda));
            Parametros.Add(new MySqlParameter("@Turno", Turno));
            Parametros.Add(new MySqlParameter("@Hora_Venda", Hora_Venda));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

    }
}
