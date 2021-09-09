using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPadoca.Classes
{
    class FecharCaixa:Conexao
    {
        private int Id_Dia;
        private decimal ValorTotalDia, ValorDinheiroDia, ValorDebitoDia, ValorCreditoDia, ValorFiadoDia, ValorRetiradaDia;
        private DateTime DataDia;

        public FecharCaixa() { }

        public FecharCaixa(decimal ValorTotalDia,decimal ValorDinheiroDia,decimal ValorDebitoDia,decimal ValorCreditoDia,decimal ValorFiadoDia, decimal ValorRetiradaDia, DateTime DataDia)
        {
            this.ValorTotalDia = ValorTotalDia;
            this.ValorDinheiroDia = ValorDinheiroDia;
            this.ValorDebitoDia = ValorDebitoDia;
            this.ValorCreditoDia = ValorCreditoDia;
            this.ValorFiadoDia = ValorFiadoDia;
            this.ValorRetiradaDia = ValorRetiradaDia;
            this.DataDia = DataDia;
        }

        public FecharCaixa(int Id_Dia,decimal ValorTotalDia, decimal ValorDinheiroDia, decimal ValorDebitoDia, decimal ValorCreditoDia, decimal ValorFiadoDia, decimal ValorRetiradaDia)
        {
            this.Id_Dia = Id_Dia;
            this.ValorTotalDia = ValorTotalDia;
            this.ValorDinheiroDia = ValorDinheiroDia;
            this.ValorDebitoDia = ValorDebitoDia;
            this.ValorCreditoDia = ValorCreditoDia;
            this.ValorFiadoDia = ValorFiadoDia;
            this.ValorRetiradaDia = ValorRetiradaDia;
        }

        public bool Add_Dia()
        {
            Conectar();
            string SQL = "INSERT INTO Dia VALUES(0, @ValorTotalDia, @ValorDinheiroDia, @ValorDebitoDia, @ValorCreditoDia , @ValorFiadoDia, @ValorRetiradaDia, @DataDia)";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@ValorTotalDia", ValorTotalDia));
            Parametros.Add(new MySqlParameter("@ValorDinheiroDia", ValorDinheiroDia));
            Parametros.Add(new MySqlParameter("@ValorDebitoDia", ValorDebitoDia));
            Parametros.Add(new MySqlParameter("@ValorCreditoDia", ValorCreditoDia));
            Parametros.Add(new MySqlParameter("@ValorFiadoDia", ValorFiadoDia));
            Parametros.Add(new MySqlParameter("@ValorRetiradaDia", ValorRetiradaDia));
            Parametros.Add(new MySqlParameter("@DataDia", DataDia));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public bool Att_Dia()
        {
            Conectar();
            string SQL = "UPDATE Dia SET ValorTotalDia = (ValorTotalDia + @ValorTotalDia), ValorDinheiroDia = (ValorDinheiroDia + @ValorDinheiroDia), ValorDebitoDia = (ValorDebitoDia + @ValorDebitoDia), ValorCreditoDia = (ValorCreditoDia + @ValorCreditoDia), ValorFiadoDia = (ValorFiadoDia + @ValorFiadoDia), ValorRetiradaDia = (ValorRetiradaDia + @ValorRetiradaDia) WHERE DataDia = CURDATE() AND Id_Dia = @Id_Dia";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Id_Dia", Id_Dia));
            Parametros.Add(new MySqlParameter("@ValorTotalDia", ValorTotalDia));
            Parametros.Add(new MySqlParameter("@ValorDinheiroDia", ValorDinheiroDia));
            Parametros.Add(new MySqlParameter("@ValorDebitoDia", ValorDebitoDia));
            Parametros.Add(new MySqlParameter("@ValorCreditoDia", ValorCreditoDia));
            Parametros.Add(new MySqlParameter("@ValorFiadoDia", ValorFiadoDia));
            Parametros.Add(new MySqlParameter("@ValorRetiradaDia", ValorRetiradaDia));
            bool Info = SQLExe(SQL, Parametros);
            Disconnect();
            return Info;
        }

        public DataTable ConsultaRelatorio(DateTime Inicio, DateTime Fim)
        {
            Conectar();
            string SQL = "SELECT * FROM Dia WHERE DataDia BETWEEN @Inicio and @Fim";
            List<MySqlParameter> Parametros = new List<MySqlParameter>();
            Parametros.Add(new MySqlParameter("@Inicio", Inicio));
            Parametros.Add(new MySqlParameter("@Fim", Fim));
            DataTable DADOS = consultaTabela(SQL, Parametros);
            Disconnect();
            return DADOS;
        }
    }
}
