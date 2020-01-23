using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SysCondominio.DAL.Controllers
{
    public class Conexao
    {
        protected MySqlConnection Con;
        protected MySqlCommand Cmd;
        protected MySqlDataReader Dr;


        protected void AbrirConexao()
        {
            try
            {
                Con = new MySqlConnection("Server=mysql873.umbler.com; Port=41890; Database=dbcondominio; Uid=jardel1995; Pwd=Dinheiro2019;");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
