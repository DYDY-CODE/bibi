using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEntreprise
{
    public partial class GestionEntrepriseForm : Form
    {
        #region variable
        private int compteurEnfant = 1;

        #endregion
        public GestionEntrepriseForm()
        {
            InitializeComponent();
        }

        private void GestionEntrepriseForm_Load(object sender, EventArgs e)
        {
            associerImages();
        }

        #region associer image

        private void associerImages()
        {
            nouveauToolStripMenuItem.Image = nouveauToolStripButton.Image;
            ouvrirToolStripMenuItem.Image = ouvrirToolStripButton.Image;
            enregistrerSousToolStripMenuItem.Image = enregistrerToolStripButton.Image;
            couperToolStripMenuItem.Image = couperToolStripButton.Image;
            copierToolStripMenuItem.Image = copierToolStripButton.Image;
            collerToolStripMenuItem.Image = collerToolStripButton.Image;
            //aideSurListesEmployeesToolStripMenuItem.Image = aideToolStripButton.Image;
        }



        #endregion

        #region methode partages

        #region nouveau formulaire enfants

        private void FichierNouveauDocument_Click(object sender, EventArgs e)
        {
            try
            {
                Employes enfant = new Employes();
                enfant.MdiParent = this;
                enfant.TopMost = true;
                enfant.Text = "Client " + compteurEnfant++;
                enfant.Location = new Point(50, 50); // Positionner le formulaire enfant
                enfant.Show();
                this.Refresh(); // Forcer une mise à jour de l'interface
            }
            catch (Exception ex)
            {
                //MessageBox.Show(g.tMessagesErreursStr[(int)ce.CEErreurIndeterminee], "EXception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #endregion
    }
}
