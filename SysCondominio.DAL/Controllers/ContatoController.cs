using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SysCondominio.DAL.Models;

namespace SysCondominio.DAL.Controllers
{
   public class ContatoController : Conexao
    {
        public void Create(Contato c)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("INSERT INTO contato ( nome_completo, email, titulo, descricao, data_abertura ) VALUES (@v1, @v2, @v3, @v4, @v5 )", Con);
                Cmd.Parameters.AddWithValue("@v1", c.NomeCompleto);
                Cmd.Parameters.AddWithValue("@v2", c.Email);
                Cmd.Parameters.AddWithValue("@v3", c.Titulo);
                Cmd.Parameters.AddWithValue("@v4", c.Descricao);
                Cmd.Parameters.AddWithValue("@v5", c.DataAbertura);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


    }
}
