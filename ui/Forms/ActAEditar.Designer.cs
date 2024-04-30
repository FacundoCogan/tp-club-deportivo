namespace UI
{
    partial class ActAEditar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.dyhTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.cmTextBox = new System.Windows.Forms.TextBox();
            this.buttConfirmEdit = new System.Windows.Forms.Button();
            this.profComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días y horarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cupo máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Profesor";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(217, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(220, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(217, 128);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(220, 20);
            this.descTextBox.TabIndex = 7;
            // 
            // dyhTextBox
            // 
            this.dyhTextBox.Location = new System.Drawing.Point(217, 182);
            this.dyhTextBox.Name = "dyhTextBox";
            this.dyhTextBox.Size = new System.Drawing.Size(220, 20);
            this.dyhTextBox.TabIndex = 8;
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(217, 237);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(220, 20);
            this.costoTextBox.TabIndex = 9;
            // 
            // cmTextBox
            // 
            this.cmTextBox.Location = new System.Drawing.Point(217, 297);
            this.cmTextBox.Name = "cmTextBox";
            this.cmTextBox.Size = new System.Drawing.Size(220, 20);
            this.cmTextBox.TabIndex = 10;
            // 
            // buttConfirmEdit
            // 
            this.buttConfirmEdit.Location = new System.Drawing.Point(478, 398);
            this.buttConfirmEdit.Name = "buttConfirmEdit";
            this.buttConfirmEdit.Size = new System.Drawing.Size(95, 28);
            this.buttConfirmEdit.TabIndex = 12;
            this.buttConfirmEdit.Text = "Guardar";
            this.buttConfirmEdit.UseVisualStyleBackColor = true;
            this.buttConfirmEdit.Click += new System.EventHandler(this.buttConfirmEdit_Click);
            // 
            // profComboBox
            // 
            this.profComboBox.FormattingEnabled = true;
            this.profComboBox.Location = new System.Drawing.Point(217, 354);
            this.profComboBox.Name = "profComboBox";
            this.profComboBox.Size = new System.Drawing.Size(220, 21);
            this.profComboBox.TabIndex = 13;
            // 
            // ActAEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.profComboBox);
            this.Controls.Add(this.buttConfirmEdit);
            this.Controls.Add(this.cmTextBox);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.dyhTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActAEditar";
            this.Text = "Actividad a editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox dyhTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.TextBox cmTextBox;
        private System.Windows.Forms.Button buttConfirmEdit;
        private System.Windows.Forms.ComboBox profComboBox;
    }
}