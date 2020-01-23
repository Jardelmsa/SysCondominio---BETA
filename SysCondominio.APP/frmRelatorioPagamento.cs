using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SysCondominio.APP
{
    public partial class frmRelatorioPagamento : Form
    {
        public frmRelatorioPagamento()
        {
            InitializeComponent();
        }
        MySqlConnection Con;
        MySqlDataAdapter Adpt;
        MySqlCommand Cmd;
        private void AbrirConexao()
        {
            try
            {
                Con = new MySqlConnection("Server=mysql873.umbler.com; Port=41890; Database=dbcondominio; Uid=jardel1995; Pwd=Dinheiro2019;          ");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void FecharConexao()
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

        private void frmRelatorioPagamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscarApartamento.Text == "")
                {
                    lblMessagem1.Text = " * Informe o número do Apartamento * !";
                }
                else
                {
                    AbrirConexao();
                    DataTable dt = new DataTable();
                    Adpt = new MySqlDataAdapter("SELECT apartamento, taxa_condominio, data_pagamento, mes FROM pagamentos WHERE apartamento= '" + Convert.ToInt32(txtBuscarApartamento.Text) + "'  ", Con);
                    Adpt.Fill(dt);
                    dgvApartamentoNumero.DataSource = dt;

                    if (dt==null)
                    {
                        lblMessagem1.Text = "Não Constam registro de pagamentos para o apartamento informado";
                    }
                }
            }
            catch (Exception ex)
            {

                lblMessagem1.Text = ex.Message;
            }
            finally
            {
                FecharConexao();
            }
        }

        private void btnBuscarPorMes_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (cbxMes.Text == "")
                {
                    lblMessagem2.Text = "* Por favor Selecione o Mês para realizar a consulta";
                }
                else
                {
                    AbrirConexao();
                    DataTable dts = new DataTable();
                    Adpt = new MySqlDataAdapter("SELECT apartamento, taxa_condominio, forma_pagamento, data_pagamento FROM pagamentos WHERE mes= '" +cbxMes.Text + "' ", Con);
                    Adpt.Fill(dts);
                    dgvPagamentoMes.DataSource = dts;

                    if (dts == null)
                    {
                        lblMessagem2.Text = "Não Foram encontrados registro de pagamentos no mês informado.";
                    }
                }               
            }
            catch (Exception ex)
            {

                lblMessagem2.Text = ex.Message;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
