namespace UI.Forms
{
    public partial class ProfesorForm
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.crearSocioButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(84, 48);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(159, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(84, 80);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(159, 20);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(84, 16);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(159, 20);
            this.dniTextBox.TabIndex = 0;
            // 
            // crearSocioButton
            // 
            this.crearSocioButton.Location = new System.Drawing.Point(168, 151);
            this.crearSocioButton.Name = "crearSocioButton";
            this.crearSocioButton.Size = new System.Drawing.Size(75, 23);
            this.crearSocioButton.TabIndex = 4;
            this.crearSocioButton.Text = "Confirmar";
            this.crearSocioButton.UseVisualStyleBackColor = true;
            this.crearSocioButton.Click += new System.EventHandler(this.crearSocioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Especialidad";
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.Location = new System.Drawing.Point(84, 116);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.Size = new System.Drawing.Size(159, 20);
            this.especialidadTextBox.TabIndex = 3;
            // 
            // ProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crearSocioButton);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.especialidadTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "ProfesorForm";
            this.Text = "Nuevo Profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Button crearSocioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox especialidadTextBox;
    }
}