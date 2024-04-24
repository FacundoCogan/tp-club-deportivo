namespace UI
{
    partial class SeleccionarActForm
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
            this.buttEditAct = new System.Windows.Forms.Button();
            this.actComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione actividad a editar:";
            // 
            // buttEditAct
            // 
            this.buttEditAct.Location = new System.Drawing.Point(375, 88);
            this.buttEditAct.Name = "buttEditAct";
            this.buttEditAct.Size = new System.Drawing.Size(55, 29);
            this.buttEditAct.TabIndex = 2;
            this.buttEditAct.Text = "Editar";
            this.buttEditAct.UseVisualStyleBackColor = true;
            this.buttEditAct.Click += new System.EventHandler(this.buttEditAct_Click);
            // 
            // actComboBox
            // 
            this.actComboBox.FormattingEnabled = true;
            this.actComboBox.Location = new System.Drawing.Point(165, 49);
            this.actComboBox.Name = "actComboBox";
            this.actComboBox.Size = new System.Drawing.Size(181, 21);
            this.actComboBox.TabIndex = 3;
            // 
            // SeleccionarActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 129);
            this.Controls.Add(this.actComboBox);
            this.Controls.Add(this.buttEditAct);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarActForm";
            this.Text = "Seleccionar actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttEditAct;
        private System.Windows.Forms.ComboBox actComboBox;
    }
}