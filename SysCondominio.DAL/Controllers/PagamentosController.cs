using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCondominio.DAL.Models;
using MySql.Data.MySqlClient;

namespace SysCondominio.DAL.Controllers
{
   public  class PagamentosController : Conexao
    {
        public void Create(Pagamentos p)
        {
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(" INSERT INTO pagamentos (apartamento, taxa_condominio, forma_pagamento, data_pagamento, mes, observacoes) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Apartamento);
                Cmd.Parameters.AddWithValue("@v2", p.TaxaCondominio);
                Cmd.Parameters.AddWithValue("@v3", p.FormaPagamento);
                Cmd.Parameters.AddWithValue("@v4", p.Data);
                Cmd.Parameters.AddWithValue("@v5", p.Mes);
                Cmd.Parameters.AddWithValue("@v6", p.Observacoes);
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
