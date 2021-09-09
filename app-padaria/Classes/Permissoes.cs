using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaPadoca.Forms_Iniciais
{
    public class Permissoes : Conexao
    {       
        public Permissoes() { }
        private int Id_Permissoes, Nivel_Usuario;
      

        public Permissoes(int Id_Permissoes,int Nivel_Usuario)
        {
            this.Id_Permissoes = Id_Permissoes;           
            this.Nivel_Usuario = Nivel_Usuario;
        }

        public Permissoes(int Nivel_Usuario)
        {
            this.Nivel_Usuario = Nivel_Usuario;
        }
    }
}
