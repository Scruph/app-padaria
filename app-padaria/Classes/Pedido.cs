using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca.Forms_Iniciais
{
    class Pedido : Conexao
    {
        private decimal ValorPedido;        
        private string Descricao;

        public Pedido(decimal ValorPedido,string Descricao)
        {
            this.ValorPedido = ValorPedido;
            this.Descricao = Descricao;         
        }

        public bool AddPedido()
        {
            Conectar();
            string SQL = "INSERT INTO Pedido VALUES(0,@ValorPedido,@Descricao, Now())";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@ValorPedido", ValorPedido));
            Parametros.Add(new MySqlParameter("@Descricao", Descricao));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }


    }
}
