namespace UI.Forms
{
    public partial class ActividadForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.diasHorariosTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.profesorComboBox = new System.Windows.Forms.ComboBox();
            this.cupoMaximoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cupoMaximoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Días y Horarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cupo Máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Profesor a cargo";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(130, 44);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(119, 20);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // diasHorariosTextBox
            // 
            this.diasHorariosTextBox.Location = new System.Drawing.Point(130, 70);
            this.diasHorariosTextBox.Name = "diasHorariosTextBox";
            this.diasHorariosTextBox.Size = new System.Drawing.Size(119, 20);
            this.diasHorariosTextBox.TabIndex = 2;
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(130, 96);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(119, 20);
            this.costoTextBox.TabIndex = 3;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(174, 185);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarButton.TabIndex = 10;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.buttCrearAct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(130, 18);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(119, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // profesorComboBox
            // 
            this.profesorComboBox.FormattingEnabled = true;
            this.profesorComboBox.Location = new System.Drawing.Point(130, 148);
            this.profesorComboBox.Name = "profesorComboBox";
            this.profesorComboBox.Size = new System.Drawing.Size(119, 21);
            this.profesorComboBox.TabIndex = 12;
            // 
            // cupoMaximoNumericUpDown
            // 
            this.cupoMaximoNumericUpDown.Location = new System.Drawing.Point(130, 122);
            this.cupoMaximoNumericUpDown.Name = "cupoMaximoNumericUpDown";
            this.cupoMaximoNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.cupoMaximoNumericUpDown.TabIndex = 13;
            // 
            // ActividadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 228);
            this.Controls.Add(this.cupoMaximoNumericUpDown);
            this.Controls.Add(this.profesorComboBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.diasHorariosTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ActividadForm";
            this.Text = "Nueva Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.cupoMaximoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox diasHorariosTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox profesorComboBox;
        private System.Windows.Forms.NumericUpDown cupoMaximoNumericUpDown;
    }
}