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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        MySqlConnection Con;
        MySqlCommand Cmd;
        MySqlDataAdapter Adpt;
        MySqlDataReader Dr;

        private void AbrirConexao()
        {
            try
            {
                Con = new MySqlConnection("Server=mysql873.umbler.com; Port=41890; Database=dbcondominio; Uid=jardel1995; Pwd=Dinheiro2019;");
                Con.Open();
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
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

                lblMessage.Text = ex.Message;
            }
        }

        private void txtSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        int Count;
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            Count = Count + 1;
            if(Count > 3)
            {
                MessageBox.Show("Fechando o sistema por motivos de segurança...");
                Application.Exit();
            }
            else if(txtUsuario.Text == "" || txtSenha.Text == "")
            {
                lblMessage.Text = "* Inisira o nome de usuário e uma senha. *";
            }
            else
            {
                AbrirConexao();
                Adpt = new MySqlDataAdapter("SELECT * FROM users WHERE usuario= '" + usuario + "' AND senha= '" + senha + "' ", Con);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                FecharConexao();
                if(dt.Rows.Count == 1)
                {
                    frmPrincipal frl = new frmPrincipal();
                    frl.Show();
                    this.Visible = false;
                }
                else
                {
                    lblMessage.Text = " * Nome de usuário ou senha não são válidos *";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }

            }
        }
    }
}
