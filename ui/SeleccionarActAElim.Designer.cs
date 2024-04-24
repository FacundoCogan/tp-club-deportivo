namespace UI
{
    partial class SeleccionarActAElim
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
            this.label1 = new System.Windows.Forms.Label();
            this.elimComboBox = new System.Windows.Forms.ComboBox();
            this.buttConfirmElim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione actividad a eliminar:";
            // 
            // elimComboBox
            // 
            this.elimComboBox.FormattingEnabled = true;
            this.elimComboBox.Location = new System.Drawing.Point(187, 93);
            this.elimComboBox.Name = "elimComboBox";
            this.elimComboBox.Size = new System.Drawing.Size(209, 21);
            this.elimComboBox.TabIndex = 1;
            // 
            // buttConfirmElim
            // 
            this.buttConfirmElim.Location = new System.Drawing.Point(446, 171);
            this.buttConfirmElim.Name = "buttConfirmElim";
            this.buttConfirmElim.Size = new System.Drawing.Size(75, 23);
            this.buttConfirmElim.TabIndex = 2;
            this.buttConfirmElim.Text = "Eliminar";
            this.buttConfirmElim.UseVisualStyleBackColor = true;
            this.buttConfirmElim.Click += new System.EventHandler(this.buttConfirmElim_Click);
            // 
            // SeleccionarActAElim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 218);
            this.Controls.Add(this.buttConfirmElim);
            this.Controls.Add(this.elimComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarActAElim";
            this.Text = "Seleccionar actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox elimComboBox;
        private System.Windows.Forms.Button buttConfirmElim;
    }
}