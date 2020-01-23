using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysCondominio.DAL.Controllers;
using SysCondominio.DAL.Models;

namespace SysCondominio.APP
{
    public partial class frmConsultarMorador : Form
    {
        public frmConsultarMorador()
        {
            InitializeComponent();
        }

        private void frmConsultarMorador_Load(object sender, EventArgs e)
        {
            this.btnSalvar.Enabled = false;
            this.btnCancelar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.txtNomeCompleto.ReadOnly = false;
            this.txtCPF.ReadOnly = false;
            this.txtRG.ReadOnly = false;
            this.txtTelefone.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.btnEditar.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnCancelar.Enabled = true;
        }



        private void txtApartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNomeCompleto.ReadOnly = true;
            this.txtCPF.ReadOnly = true;
            this.txtRG.ReadOnly = true;
            this.txtTelefone.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.txtNomeCompleto.Text = "";
            this.txtCPF.Text = "";
            this.txtRG.Text = "";
            this.txtTelefone.Text = "";
            this.txtEmail.Text = "";
            this.btnCancelar.Enabled = false;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApartamento.Text == "")
                {
                    lblMessagem1.Text = "* Insira o número do apartamento *";
                }
                else
                {

                    int Apartamento = Convert.ToInt32(txtApartamento.Text);

                    ProprietariosController pc = new ProprietariosController();
                    Proprietarios p = pc.PesquisarPorApartamento(Apartamento);

                    if (p != null)
                    {
                        txtCPF.Text = p.CPF;
                        txtRG.Text = p.RG;
                        txtNomeCompleto.Text = p.NomeCompleto;
                        txtTelefone.Text = p.Telefone;
                        txtEmail.Text = p.Email;
                        this.btnEditar.Enabled = true;
                    }
                    else
                    {
                        lblMessagem1.Text = "Apartamento não encontrado";
                    }

                }
            }
            catch (Exception ex)
            {

                lblMessagem2.Text = ex.Message;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeCompleto.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtEmail.Text == "" ||  txtTelefone.Text == "")
                {
                    lblMessagem1.Text = " Por favor, Preencher todos os campos do formulário...";

                }
                else
                {
                    Proprietarios p = new Proprietarios();
                    p.NomeCompleto = txtNomeCompleto.Text;
                    p.CPF = txtCPF.Text;
                    p.RG = txtRG.Text;
                    p.Email = txtEmail.Text;
                    p.Telefone = txtTelefone.Text;
                    p.Apartamento =Convert.ToInt32(txtApartamento.Text);

                    ProprietariosController pc = new ProprietariosController();
                    pc.Update(p);

                    lblMessagem2.Text = "O Morador do Apartamento  '" + txtApartamento.Text + "' Foi Atualizado com Sucesso!";

                    this.txtNomeCompleto.Text = "";
                    this.txtRG.Text = "";
                    this.txtCPF.Text = "";
                    this.txtEmail.Text = "";
                    this.txtTelefone.Text = "";
                    this.txtNomeCompleto.ReadOnly = true;
                    this.txtCPF.ReadOnly = true;
                    this.txtRG.ReadOnly = true;
                    this.txtTelefone.ReadOnly = true;
                    this.txtEmail.ReadOnly = true;
                    this.btnCancelar.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnSalvar.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
