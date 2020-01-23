using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysCondominio.DAL.Models;
using SysCondominio.DAL.Controllers;

namespace SysCondominio.APP
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            this.dtpData.Value = DateTime.Now;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtNomeCompleto.Text =="" || txtEmail.Text =="" || txtTitulo.Text =="" || txtDescricao.Text == "")
                {
                    lblMessage.Text = "Por favor, Preencha Todos os campos do formulário...";
                    txtNomeCompleto.Focus();
                }
                else
                {
                    Contato c = new Contato();
                    c.NomeCompleto = txtNomeCompleto.Text;
                    c.Email = txtEmail.Text;
                    c.Titulo = txtTitulo.Text;
                    c.Descricao = txtDescricao.Text;
                    c.DataAbertura = dtpData.Value;
                    ContatoController cc = new ContatoController();
                    cc.Create(c);

                    lblMessage.Text = "Solicitação enviada com sucesso, em até 24 horas você terá um retorno.";
                    this.txtNomeCompleto.Text = "";
                    this.txtEmail.Text = "";
                    this.txtTitulo.Text = "";
                    this.txtDescricao.Text = "";
                }

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }
    }
}
