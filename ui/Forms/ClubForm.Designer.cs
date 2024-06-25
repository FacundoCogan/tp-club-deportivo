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
            this.registrarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarParaTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelSocios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelActividades = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProfesores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOrdenes = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
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
            this.verSociosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verSociosToolStripMenuItem.Text = "Ver listado";
            this.verSociosToolStripMenuItem.Click += new System.EventHandler(this.verSociosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.CrearSocio);
            // 
            // registrarPagoToolStripMenuItem
            // 
            this.registrarPagoToolStripMenuItem.Name = "registrarPagoToolStripMenuItem";
            this.registrarPagoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.registrarPagoToolStripMenuItem.Text = "Registrar pago";
            this.registrarPagoToolStripMenuItem.Click += new System.EventHandler(this.registrarPagoToolStripMenuItem_Click);
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
            this.generarParaTodosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarParaTodosToolStripMenuItem.Text = "Generar todas";
            this.generarParaTodosToolStripMenuItem.Click += new System.EventHandler(this.generarParaTodosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socios";
            // 
            // labelSocios
            // 
            this.labelSocios.AutoSize = true;
            this.labelSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSocios.Location = new System.Drawing.Point(278, 62);
            this.labelSocios.Name = "labelSocios";
            this.labelSocios.Size = new System.Drawing.Size(36, 37);
            this.labelSocios.TabIndex = 1;
            this.labelSocios.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actividades";
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividades.Location = new System.Drawing.Point(278, 109);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(36, 37);
            this.labelActividades.TabIndex = 1;
            this.labelActividades.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profesores";
            // 
            // labelProfesores
            // 
            this.labelProfesores.AutoSize = true;
            this.labelProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesores.Location = new System.Drawing.Point(278, 157);
            this.labelProfesores.Name = "labelProfesores";
            this.labelProfesores.Size = new System.Drawing.Size(36, 37);
            this.labelProfesores.TabIndex = 1;
            this.labelProfesores.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ordenes sin pagar";
            // 
            // labelOrdenes
            // 
            this.labelOrdenes.AutoSize = true;
            this.labelOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenes.Location = new System.Drawing.Point(278, 204);
            this.labelOrdenes.Name = "labelOrdenes";
            this.labelOrdenes.Size = new System.Drawing.Size(36, 37);
            this.labelOrdenes.TabIndex = 1;
            this.labelOrdenes.Text = "0";
            // 
            // ClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 272);
            this.Controls.Add(this.labelOrdenes);
            this.Controls.Add(this.labelProfesores);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.labelSocios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClubForm";
            this.Text = "Club";
            this.Load += new System.EventHandler(this.ClubForm_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProfesores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOrdenes;
    }
}

