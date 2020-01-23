using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SysCondominio.DAL.Models;

namespace SysCondominio.DAL.Controllers
{
    public class UsersController : Conexao
    {
        public void Create(Users u)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("INSERT INTO users (nome, usuario, senha, cpf) VALUES( @v1, @v2, @v3, @v4)", Con);
                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Usuario);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);
                Cmd.Parameters.AddWithValue("@v4", u.CPF);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw  new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Delete(Users u)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("DELETE FROM users WHERE id=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", u.Id);
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

        public void Update(Users u)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("UPDATE users SET nome=@v1, usuario=@v2, senha=@v3, cpf=@v4 WHERE id=@v5", Con);
                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Usuario);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);
                Cmd.Parameters.AddWithValue("@v4", u.CPF);
                Cmd.Parameters.AddWithValue("@v5", u.Id);
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
