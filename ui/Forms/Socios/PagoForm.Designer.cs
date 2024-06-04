namespace UI.Forms.Socios
{
    partial class PagoForm
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
            this.montoAPagarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montoADebitarTextBox = new System.Windows.Forms.TextBox();
            this.buttConfirmarPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // montoAPagarTextBox
            // 
            this.montoAPagarTextBox.Location = new System.Drawing.Point(151, 59);
            this.montoAPagarTextBox.Name = "montoAPagarTextBox";
            this.montoAPagarTextBox.ReadOnly = true;
            this.montoAPagarTextBox.Size = new System.Drawing.Size(136, 20);
            this.montoAPagarTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto a debitar:";
            // 
            // montoADebitarTextBox
            // 
            this.montoADebitarTextBox.Location = new System.Drawing.Point(151, 146);
            this.montoADebitarTextBox.Name = "montoADebitarTextBox";
            this.montoADebitarTextBox.Size = new System.Drawing.Size(136, 20);
            this.montoADebitarTextBox.TabIndex = 3;
            // 
            // buttConfirmarPago
            // 
            this.buttConfirmarPago.Location = new System.Drawing.Point(281, 205);
            this.buttConfirmarPago.Name = "buttConfirmarPago";
            this.buttConfirmarPago.Size = new System.Drawing.Size(84, 23);
            this.buttConfirmarPago.TabIndex = 4;
            this.buttConfirmarPago.Text = "Registrar pago";
            this.buttConfirmarPago.UseVisualStyleBackColor = true;
            this.buttConfirmarPago.Click += new System.EventHandler(this.buttConfirmarPago_Click);
            // 
            // PagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 240);
            this.Controls.Add(this.buttConfirmarPago);
            this.Controls.Add(this.montoADebitarTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montoAPagarTextBox);
            this.Name = "PagoForm";
            this.Text = "Registrar pago del socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox montoAPagarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montoADebitarTextBox;
        private System.Windows.Forms.Button buttConfirmarPago;
    }
}