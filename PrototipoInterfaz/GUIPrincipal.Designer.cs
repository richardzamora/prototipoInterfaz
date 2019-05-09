﻿namespace PrototipoInterfaz
{
    partial class GUIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarParticipantePorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMenorEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarParticipantesToolStripMenuItem,
            this.mostrarInformaciónToolStripMenuItem,
            this.registrarParticipanteToolStripMenuItem,
            this.buscarParticipantePorToolStripMenuItem});
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.participantesToolStripMenuItem.Text = "Participantes";
            // 
            // mostrarParticipantesToolStripMenuItem
            // 
            this.mostrarParticipantesToolStripMenuItem.Name = "mostrarParticipantesToolStripMenuItem";
            this.mostrarParticipantesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mostrarParticipantesToolStripMenuItem.Text = "Mostrar participantes";
            // 
            // mostrarInformaciónToolStripMenuItem
            // 
            this.mostrarInformaciónToolStripMenuItem.Name = "mostrarInformaciónToolStripMenuItem";
            this.mostrarInformaciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mostrarInformaciónToolStripMenuItem.Text = "Mostrar información";
            this.mostrarInformaciónToolStripMenuItem.Click += new System.EventHandler(this.mostrarInformaciónToolStripMenuItem_Click);
            // 
            // registrarParticipanteToolStripMenuItem
            // 
            this.registrarParticipanteToolStripMenuItem.Name = "registrarParticipanteToolStripMenuItem";
            this.registrarParticipanteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registrarParticipanteToolStripMenuItem.Text = "Registrar participante";
            this.registrarParticipanteToolStripMenuItem.Click += new System.EventHandler(this.registrarParticipanteToolStripMenuItem_Click);
            // 
            // buscarParticipantePorToolStripMenuItem
            // 
            this.buscarParticipantePorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorNombreToolStripMenuItem,
            this.bucToolStripMenuItem,
            this.porMenorEdadToolStripMenuItem});
            this.buscarParticipantePorToolStripMenuItem.Name = "buscarParticipantePorToolStripMenuItem";
            this.buscarParticipantePorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.buscarParticipantePorToolStripMenuItem.Text = "Buscar participante por...";
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.buscarPorNombreToolStripMenuItem.Text = "Por nombre";
            // 
            // bucToolStripMenuItem
            // 
            this.bucToolStripMenuItem.Name = "bucToolStripMenuItem";
            this.bucToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bucToolStripMenuItem.Text = "Por mayor estatura";
            // 
            // porMenorEdadToolStripMenuItem
            // 
            this.porMenorEdadToolStripMenuItem.Name = "porMenorEdadToolStripMenuItem";
            this.porMenorEdadToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porMenorEdadToolStripMenuItem.Text = "Por menor edad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(346, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIPrincipal";
            this.Text = "Interfaz Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarParticipantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarParticipantePorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMenorEdadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

