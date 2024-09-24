namespace Ejercicio01.Windows
{
    partial class frmBuscarRadio
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            nudRadio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudRadio).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(249, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 60);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Image = Properties.Resources.Aceptar;
            btnAceptar.Location = new Point(64, 98);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 60);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "OK";
            btnAceptar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Radio:";
            // 
            // nudRadio
            // 
            nudRadio.Location = new Point(105, 25);
            nudRadio.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudRadio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRadio.Name = "nudRadio";
            nudRadio.Size = new Size(120, 23);
            nudRadio.TabIndex = 7;
            nudRadio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmBuscarRadio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 178);
            Controls.Add(nudRadio);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Name = "frmBuscarRadio";
            Text = "frmBuscarRadio";
            ((System.ComponentModel.ISupportInitialize)nudRadio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
        private NumericUpDown nudRadio;
    }
}