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
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.buttEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.buttEliminarAct = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosListView = new System.Windows.Forms.ListView();
            this.dniHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellidoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.actividadesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorariosHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costoHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cupoMaxHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profesorHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.profesoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1507, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.darDeBajaToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.CrearSocio);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearActividad,
            this.buttEditar,
            this.buttEliminarAct});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // CrearActividad
            // 
            this.CrearActividad.Name = "CrearActividad";
            this.CrearActividad.Size = new System.Drawing.Size(180, 22);
            this.CrearActividad.Text = "Nueva";
            this.CrearActividad.Click += new System.EventHandler(this.CrearActividad_Click);
            // 
            // buttEditar
            // 
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(180, 22);
            this.buttEditar.Text = "Editar";
            this.buttEditar.Click += new System.EventHandler(this.buttEditar_Click);
            // 
            // buttEliminarAct
            // 
            this.buttEliminarAct.Name = "buttEliminarAct";
            this.buttEliminarAct.Size = new System.Drawing.Size(180, 22);
            this.buttEliminarAct.Text = "Eliminar";
            this.buttEliminarAct.Click += new System.EventHandler(this.buttEliminarAct_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // sociosListView
            // 
            this.sociosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dniHeader,
            this.nombreHeader,
            this.apellidoHeader});
            this.sociosListView.FullRowSelect = true;
            this.sociosListView.HideSelection = false;
            this.sociosListView.Location = new System.Drawing.Point(31, 76);
            this.sociosListView.Name = "sociosListView";
            this.sociosListView.Size = new System.Drawing.Size(235, 201);
            this.sociosListView.TabIndex = 1;
            this.sociosListView.UseCompatibleStateImageBehavior = false;
            this.sociosListView.View = System.Windows.Forms.View.Details;
            // 
            // dniHeader
            // 
            this.dniHeader.Text = "DNI";
            // 
            // nombreHeader
            // 
            this.nombreHeader.Text = "Nombre";
            this.nombreHeader.Width = 71;
            // 
            // apellidoHeader
            // 
            this.apellidoHeader.Text = "Apellido";
            this.apellidoHeader.Width = 100;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataSource = typeof(Negocio.Club);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1507, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // actividadesListView
            // 
            this.actividadesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.HorariosHeader2,
            this.costoHeader2,
            this.cupoMaxHeader2,
            this.profesorHeader2});
            this.actividadesListView.HideSelection = false;
            this.actividadesListView.Location = new System.Drawing.Point(348, 76);
            this.actividadesListView.Name = "actividadesListView";
            this.actividadesListView.Size = new System.Drawing.Size(857, 201);
            this.actividadesListView.TabIndex = 3;
            this.actividadesListView.UseCompatibleStateImageBehavior = false;
            this.actividadesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 173;
            // 
            // HorariosHeader2
            // 
            this.HorariosHeader2.Text = "Horarios";
            this.HorariosHeader2.Width = 261;
            // 
            // costoHeader2
            // 
            this.costoHeader2.Text = "Costo";
            this.costoHeader2.Width = 120;
            // 
            // cupoMaxHeader2
            // 
            this.cupoMaxHeader2.Text = "Cupo máximo";
            this.cupoMaxHeader2.Width = 100;
            // 
            // profesorHeader2
            // 
            this.profesorHeader2.Text = "Profesor";
            this.profesorHeader2.Width = 199;
            // 
            // ClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 565);
            this.Controls.Add(this.actividadesListView);
            this.Controls.Add(this.sociosListView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
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
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearActividad;
        private System.Windows.Forms.ListView sociosListView;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private System.Windows.Forms.ColumnHeader dniHeader;
        private System.Windows.Forms.ColumnHeader nombreHeader;
        private System.Windows.Forms.ColumnHeader apellidoHeader;
        private System.Windows.Forms.ToolStripMenuItem buttEditar;
        private System.Windows.Forms.ToolStripMenuItem buttEliminarAct;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ListView actividadesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader HorariosHeader2;
        private System.Windows.Forms.ColumnHeader costoHeader2;
        private System.Windows.Forms.ColumnHeader profesorHeader2;
        private System.Windows.Forms.ColumnHeader cupoMaxHeader2;
    }
}

