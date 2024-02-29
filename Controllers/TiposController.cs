using Poc.Crud.Models;
using Poc.Crud.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poc.Crud.Controllers
{
    class TiposController
    {
        public void Carregar(FormPrincipal form, FabricaContext db)
        {
            AtualizarCombotipo(form, db);
        }

        public void AdicionarNovo(FormPrincipal formprincipal,  FormTipo form)
        {
            using (var db = new FabricaContext())
            {
                TipoModel model = new TipoModel();
                model.Nome = form.txtNome.Text;
                db.Tipos.Add(model);
                db.SaveChanges();

                AtualizarCombotipo(formprincipal,  db);

                MessageBox.Show("Tipo criado.");

            }

        }
        public void Alterar(FormPrincipal formprincipal, FormTipo form)
        {
            using (var db = new FabricaContext())
            {
                TipoModel model = formprincipal.cmbxTipoMaquina.SelectedItem as TipoModel;
                model.Nome = form.txtNome.Text;
                db.Tipos.Attach(model);
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                AtualizarCombotipo(formprincipal,db);
                formprincipal.cmbxTipoMaquina.SelectedItem = model;
                MessageBox.Show("Tipo salvo.");

            }

        }
        public void Excluir(FormPrincipal formprincipal)
        {
            using (var db = new FabricaContext())
            {
                var tipomodel = formprincipal.cmbxTipoMaquina.SelectedItem as TipoModel;
                int quantmaq = db.Maquinas.Where(x => x.IdTipo == tipomodel.IdTipo).Count();

                if (quantmaq == 0)
                {
                    TipoModel model = db.Tipos.Find(tipomodel.IdTipo);
                    db.Tipos.Remove(model);
                    db.SaveChanges();
                    AtualizarCombotipo(formprincipal,db);
                    MessageBox.Show("tipo excluido com sucesso");
                }

            }
        }

        private void AtualizarCombotipo(FormPrincipal form,  FabricaContext db)
        {
            form.cmbxTipoMaquina.DataSource = db.Tipos.ToList();
            form.cmbxTipoMaquina.DisplayMember = "Nome";
            form.cmbxTipoMaquina.ValueMember = "IdTipo";
        }
    }
}
