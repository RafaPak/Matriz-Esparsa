using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApMatrizEsparsa
{
    public partial class frmME : Form
    {
        private Label lbTitulo;

        public frmME()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(50, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(561, 26);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Operações com Matriz Esparsa";
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmME
            // 
            this.ClientSize = new System.Drawing.Size(685, 398);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmME";
            this.Text = "Matriz Esparsa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
