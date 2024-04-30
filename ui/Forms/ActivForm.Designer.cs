namespace UI
{
    partial class ActivForm
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
            this.cupoMaximoTextBox = new System.Windows.Forms.TextBox();
            this.buttCrearAct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Días y Horarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cupo Máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Profesor a cargo";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(177, 117);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // diasHorariosTextBox
            // 
            this.diasHorariosTextBox.Location = new System.Drawing.Point(177, 176);
            this.diasHorariosTextBox.Name = "diasHorariosTextBox";
            this.diasHorariosTextBox.Size = new System.Drawing.Size(100, 20);
            this.diasHorariosTextBox.TabIndex = 2;
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(177, 229);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 3;
            // 
            // cupoMaximoTextBox
            // 
            this.cupoMaximoTextBox.Location = new System.Drawing.Point(177, 286);
            this.cupoMaximoTextBox.Name = "cupoMaximoTextBox";
            this.cupoMaximoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cupoMaximoTextBox.TabIndex = 4;
            // 
            // buttCrearAct
            // 
            this.buttCrearAct.Location = new System.Drawing.Point(296, 404);
            this.buttCrearAct.Name = "buttCrearAct";
            this.buttCrearAct.Size = new System.Drawing.Size(75, 23);
            this.buttCrearAct.TabIndex = 10;
            this.buttCrearAct.Text = "Crear";
            this.buttCrearAct.UseVisualStyleBackColor = true;
            this.buttCrearAct.Click += new System.EventHandler(this.buttCrearAct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(177, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // ActivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttCrearAct);
            this.Controls.Add(this.cupoMaximoTextBox);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.diasHorariosTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ActivForm";
            this.Text = "Nueva Actividad";
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
        private System.Windows.Forms.TextBox cupoMaximoTextBox;
        private System.Windows.Forms.Button buttCrearAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}