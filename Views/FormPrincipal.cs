using Org.BouncyCastle.Asn1.X509;
using Poc.Crud.Controllers;
using Poc.Crud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poc.Crud.Views
{
    public partial class FormPrincipal : Form
    {
        internal TiposController TipoController { get => new TiposController(); }

        public FormPrincipal()
        {
            InitializeComponent();

            using (var db = new FabricaContext())
            {
                TipoController.Carregar(this, db);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var form = new FormTipo()) {
                form.Text = "Adição de tipo";
                if (form.ShowDialog() == DialogResult.OK) 
                {
                    TipoController.AdicionarNovo(this, form);
                }
            }
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var form = new FormTipo())
            {
                form.Text = "Alteração de tipo";
                form.txtNome.Text = cmbxTipoMaquina.Text;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TipoController.Alterar(this, form);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o tipo selecionado", "",
                          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TipoController.Excluir(this);
            }
            else
            {
                MessageBox.Show("Não é possivel excluir um tipo com maquinas associadas.");
            }
        }

        private void btnNovaMaq_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarMaq_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirMaq_Click(object sender, EventArgs e)
        {

        }
    }
}
