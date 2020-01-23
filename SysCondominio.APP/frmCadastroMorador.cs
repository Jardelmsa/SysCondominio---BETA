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
    public partial class frmCadastroMorador : Form
    {
        public frmCadastroMorador()
        {
            InitializeComponent();
        }

        private void frmCadastroMorador_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNomeCompleto.Text=="" || txtCPF.Text=="" || txtRG.Text=="" || txtEmail.Text=="" || txtApartamento.Text=="" || txtTelefone.Text == "")
                {
                    lblMessage.Text = " Por favor, Preencher todos os campos do formulário...";

                }
                else
                {
                    Proprietarios p = new Proprietarios();
                    p.NomeCompleto = txtNomeCompleto.Text;
                    p.CPF = txtCPF.Text;
                    p.RG = txtRG.Text;
                    p.Email = txtEmail.Text;
                    p.Apartamento = Convert.ToInt32(txtApartamento.Text);
                    p.Telefone = txtTelefone.Text;

                    ProprietariosController pc = new ProprietariosController();
                    pc.Create(p);

                    lblMessage.Text = "O Morador '" + txtNomeCompleto.Text + "' Foi Cadastrado com Sucesso!";

                    this.txtNomeCompleto.Text = "";
                    this.txtRG.Text = "";
                    this.txtCPF.Text = "";
                    this.txtApartamento.Text = "";
                    this.txtEmail.Text = "";
                    this.txtTelefone.Text = "";
                    this.txtNomeCompleto.Focus();
                }
            }
            catch (Exception ex )
            {

                throw new Exception(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNomeCompleto.Text = "";
            this.txtRG.Text = "";
            this.txtCPF.Text = "";
            this.txtApartamento.Text = "";
            this.txtEmail.Text = "";
            this.txtTelefone.Text = "";
            this.txtNomeCompleto.Focus();
        }
    }
}
