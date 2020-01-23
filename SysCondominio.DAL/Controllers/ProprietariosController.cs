using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SysCondominio.DAL.Models;

namespace SysCondominio.DAL.Controllers
{
    public class ProprietariosController : Conexao
    {
        public void Create(Proprietarios p)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("INSERT INTO proprietarios (cpf, rg, nome_completo, telefone, email, apartamento) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.CPF);
                Cmd.Parameters.AddWithValue("@v2", p.RG);
                Cmd.Parameters.AddWithValue("@v3", p.NomeCompleto);
                Cmd.Parameters.AddWithValue("@v4", p.Telefone);
                Cmd.Parameters.AddWithValue("@v5", p.Email);
                Cmd.Parameters.AddWithValue("@v6", p.Apartamento);
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

        public void Update(Proprietarios p)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("UPDATE proprietarios SET cpf=@v1, rg=@v2, nome_completo=@v3, telefone=@v4, email=@v5 WHERE apartamento=@v6", Con);
                Cmd.Parameters.AddWithValue("@v1", p.CPF);
                Cmd.Parameters.AddWithValue("@v2", p.RG);
                Cmd.Parameters.AddWithValue("@v3", p.NomeCompleto);
                Cmd.Parameters.AddWithValue("@v4", p.Telefone);
                Cmd.Parameters.AddWithValue("@v5", p.Email);
                Cmd.Parameters.AddWithValue("@v6", p.Apartamento);
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

        public Proprietarios PesquisarPorApartamento(int Apartamento)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand("SELECT * FROM proprietarios WHERE apartamento=@v1 ", Con);
                Cmd.Parameters.AddWithValue("@v1", Apartamento);
                Dr = Cmd.ExecuteReader();

                Proprietarios p = null;

                if (Dr.Read())
                {
                    p = new Proprietarios();

                    p.Id = Convert.ToInt32(Dr["id"]);
                    p.CPF = Convert.ToString(Dr["cpf"]);
                    p.RG = Convert.ToString(Dr["rg"]);
                    p.NomeCompleto = Convert.ToString(Dr["nome_completo"]);
                    p.Telefone = Convert.ToString(Dr["telefone"]);
                    p.Email = Convert.ToString(Dr["email"]);

                }
                return p;
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
