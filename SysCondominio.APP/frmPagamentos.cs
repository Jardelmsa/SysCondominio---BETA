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
using SysCondominio.DAL.Controllers;
using SysCondominio.DAL.Models;
using SysCondominio.APP.Properties;

namespace SysCondominio.APP
{
    public partial class frmPagamentos : Form
    {
        public frmPagamentos()
        {
            InitializeComponent();
        }

        private void CarregarComboApartamento()
        {
            try
            {


                MySqlConnection Con = new MySqlConnection("Server=mysql873.umbler.com; Port=41890; Database=dbcondominio; Uid=jardel1995; Pwd=Dinheiro2019;");
                Con.Open();

                MySqlCommand Cmd = new MySqlCommand("SELECT * FROM proprietarios", Con);
                DataSet ds = new DataSet();

                MySqlDataAdapter adpt = new MySqlDataAdapter(Cmd);
                adpt.Fill(ds);
                cbxApartamento.DataSource = ds.Tables[0];
                cbxApartamento.DisplayMember = "apartamento";
                cbxApartamento.ValueMember = "apartamento";
                Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void frmPagamentos_Load(object sender, EventArgs e)
        {
            CarregarComboApartamento();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTaxa.Text == "")
                {
                    lblMessagem.Text = "Por favor, Preencha todos os campos";
                }
                else
                {
                    Pagamentos p = new Pagamentos();
                    p.Apartamento = Convert.ToInt32(cbxApartamento.Text);
                    p.TaxaCondominio = Convert.ToDecimal(txtTaxa.Text);
                    p.FormaPagamento = cbxFormaPagamento.Text;
                    p.Data = Convert.ToDateTime(dtpDataPagamento.Text);
                    p.Mes = cbxMes.Text;
                    p.Observacoes = txtObservacoes.Text;

                    PagamentosController pc = new PagamentosController();
                    pc.Create(p);

                    lblMessagem.Text = "Pagamento Cadastrado com sucesso!";

                    txtObservacoes.Text = "";
                    txtTaxa.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtObservacoes.Text = "";
            txtTaxa.Text = "";
        }
    }
}
