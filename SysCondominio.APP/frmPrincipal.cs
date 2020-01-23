using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCondominio.APP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private Form _obj;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastroProprietario_Click(object sender, EventArgs e)
        {
            
            _obj = new frmCadastroMorador
            {
                TopLevel = false,
                Dock = DockStyle.None
                
                
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _obj = new frmPagamentos
            {
                TopLevel = false,
                Dock = DockStyle.None


            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            _obj = new frmConsultarMorador
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void cadastrarMoradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmCadastroMorador
            {
                TopLevel = false,
                Dock = DockStyle.None


            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void cadastrarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmPagamentos
            {
                TopLevel = false,
                Dock = DockStyle.None


            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void consultarMoradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmConsultarMorador
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDeMoradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmCadastroMorador
            {
                TopLevel = false,
                Dock = DockStyle.None


            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void cadastroDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmPagamentos
            {
                TopLevel = false,
                Dock = DockStyle.None


            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void consultarMoradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmConsultarMorador
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmSobre
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }

        private void relatóriosDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _obj = new frmRelatorioPagamento
            {
                TopLevel = false,
                Dock = DockStyle.None
            };
            panel2.Controls.Add(_obj);
            _obj.Show();
        }
    }
}

