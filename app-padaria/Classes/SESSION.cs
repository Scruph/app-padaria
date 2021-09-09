using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadoca.Forms_Iniciais
{
    public static class SESSION
    {
        //Ao logar vai Definir Informaçoes para essas variaveis estaticas
        //para serem usadas diate todo formulario.
        public static int IdUser;
        public static string UserName;
        public static int TurnoUser;
        public static int NivelUser;
        public static string SenhaGerente;

        //Valores De Fluxo de Caixa
        //Todas os valores da venda do pdv iram somar e vir para as variaveis estaticas
        public static decimal ValorTotalDia = 0;
        public static decimal ValorDinheiroDia =0;
        public static decimal ValorDebitoDia =0;
        public static decimal ValorCreditoDia = 0;
        public static decimal ValorFiadoDia = 0;
        public static decimal ValorRetiradaDia = 0;
        public static DateTime DataDia;
    }

   

  

}
