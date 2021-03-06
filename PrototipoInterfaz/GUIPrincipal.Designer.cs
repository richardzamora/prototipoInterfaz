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

            this.menuPrincipal = new System.Windows.Forms.MenuStrip();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();

            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarParticipanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarParticipantePorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMenorEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.porInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();

            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.SuspendLayout();
            // 
            // menuPrincipal
            // 

            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(336, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuStrip1";
            this.menuPrincipal.Size = new System.Drawing.Size(346, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
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
            this.mostrarParticipantesToolStripMenuItem.Click += new System.EventHandler(this.mostrarParticipantesToolStripMenuItem_Click);
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
            this.bucToolStripMenuItem,
            this.porMenorEdadToolStripMenuItem,
            this.porInformaciónToolStripMenuItem});
            this.buscarParticipantePorToolStripMenuItem.Name = "buscarParticipantePorToolStripMenuItem";
            this.buscarParticipantePorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.buscarParticipantePorToolStripMenuItem.Text = "Buscar participante por...";
            // 
            // bucToolStripMenuItem
            // 
            this.bucToolStripMenuItem.Name = "bucToolStripMenuItem";
            this.bucToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bucToolStripMenuItem.Text = "Por mayor estatura";
            this.bucToolStripMenuItem.Click += new System.EventHandler(this.bucToolStripMenuItem_Click);
            // 
            // porMenorEdadToolStripMenuItem
            // 
            this.porMenorEdadToolStripMenuItem.Name = "porMenorEdadToolStripMenuItem";
            this.porMenorEdadToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porMenorEdadToolStripMenuItem.Text = "Por menor edad";
            this.porMenorEdadToolStripMenuItem.Click += new System.EventHandler(this.porMenorEdadToolStripMenuItem_Click);
            // 
            // porInformaciónToolStripMenuItem
            // 
            this.porInformaciónToolStripMenuItem.Name = "porInformaciónToolStripMenuItem";
            this.porInformaciónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porInformaciónToolStripMenuItem.Text = "Por información";
            this.porInformaciónToolStripMenuItem.Click += new System.EventHandler(this.porInformaciónToolStripMenuItem_Click);
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

            this.ClientSize = new System.Drawing.Size(336, 382);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "GUIPrincipal";
            this.Text = "Interfaz Principal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();

            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(346, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "GUIPrincipal";
            this.Text = "Interfaz Principal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarParticipantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarParticipanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarParticipantePorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMenorEdadToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem porInformaciónToolStripMenuItem;

        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

