namespace UI.Forms
{
    partial class InscribirSocioActividadForm
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
            this.confirmarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actividadesComboBox = new UI.Controls.ActividadesComboBox();
            this.SuspendLayout();
            // 
            // confirmarButton
            // 
            this.confirmarButton.Enabled = false;
            this.confirmarButton.Location = new System.Drawing.Point(154, 105);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(121, 25);
            this.confirmarButton.TabIndex = 0;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad";
            // 
            // actividadesComboBox
            // 
            this.actividadesComboBox.DisplayMember = "Nombre";
            this.actividadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actividadesComboBox.FormattingEnabled = true;
            this.actividadesComboBox.Location = new System.Drawing.Point(69, 17);
            this.actividadesComboBox.Name = "actividadesComboBox";
            this.actividadesComboBox.Size = new System.Drawing.Size(206, 21);
            this.actividadesComboBox.TabIndex = 1;
            this.actividadesComboBox.SelectedIndexChanged += new System.EventHandler(this.actividadesComboBox_SelectedIndexChanged);
            // 
            // InscribirSocioActividadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actividadesComboBox);
            this.Controls.Add(this.confirmarButton);
            this.Name = "InscribirSocioActividadForm";
            this.Text = "Inscribir Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmarButton;
        private Controls.ActividadesComboBox actividadesComboBox;
        private System.Windows.Forms.Label label1;
    }
}