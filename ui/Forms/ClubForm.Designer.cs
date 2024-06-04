using Negocio.Modelos;

namespace UI
{
    partial class ClubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarParaTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.ordenDePagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1507, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSociosToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.registrarPagoToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // verSociosToolStripMenuItem
            // 
            this.verSociosToolStripMenuItem.Name = "verSociosToolStripMenuItem";
            this.verSociosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verSociosToolStripMenuItem.Text = "Ver listado";
            this.verSociosToolStripMenuItem.Click += new System.EventHandler(this.verSociosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.CrearSocio);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verActividadesToolStripMenuItem,
            this.CrearActividad});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // verActividadesToolStripMenuItem
            // 
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.verActividadesToolStripMenuItem.Text = "Ver listado";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // CrearActividad
            // 
            this.CrearActividad.Name = "CrearActividad";
            this.CrearActividad.Size = new System.Drawing.Size(128, 22);
            this.CrearActividad.Text = "Nueva";
            this.CrearActividad.Click += new System.EventHandler(this.CrearActividad_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProfesoresToolStripMenuItem,
            this.nuevoProfesorToolStripMenuItem1});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // verProfesoresToolStripMenuItem
            // 
            this.verProfesoresToolStripMenuItem.Name = "verProfesoresToolStripMenuItem";
            this.verProfesoresToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.verProfesoresToolStripMenuItem.Text = "Ver listado";
            this.verProfesoresToolStripMenuItem.Click += new System.EventHandler(this.verProfesoresToolStripMenuItem_Click);
            // 
            // nuevoProfesorToolStripMenuItem1
            // 
            this.nuevoProfesorToolStripMenuItem1.Name = "nuevoProfesorToolStripMenuItem1";
            this.nuevoProfesorToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.nuevoProfesorToolStripMenuItem1.Text = "Nuevo";
            this.nuevoProfesorToolStripMenuItem1.Click += new System.EventHandler(this.nuevoProfesorToolStripMenuItem1_Click);
            // 
            // ordenDePagoToolStripMenuItem
            // 
            this.ordenDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarParaTodosToolStripMenuItem});
            this.ordenDePagoToolStripMenuItem.Name = "ordenDePagoToolStripMenuItem";
            this.ordenDePagoToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.ordenDePagoToolStripMenuItem.Text = "Órdenes de pago";
            // 
            // generarParaTodosToolStripMenuItem
            // 
            this.generarParaTodosToolStripMenuItem.Name = "generarParaTodosToolStripMenuItem";
            this.generarParaTodosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.generarParaTodosToolStripMenuItem.Text = "Generar todas";
            this.generarParaTodosToolStripMenuItem.Click += new System.EventHandler(this.generarParaTodosToolStripMenuItem_Click);
            // 
            // registrarPagoToolStripMenuItem
            // 
            this.registrarPagoToolStripMenuItem.Name = "registrarPagoToolStripMenuItem";
            this.registrarPagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPagoToolStripMenuItem.Text = "Registrar pago";
            this.registrarPagoToolStripMenuItem.Click += new System.EventHandler(this.registrarPagoToolStripMenuItem_Click);
            // 
            // ClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 565);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClubForm";
            this.Text = "Club";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearActividad;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private System.Windows.Forms.ToolStripMenuItem verSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProfesorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarParaTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoToolStripMenuItem;
    }
}

