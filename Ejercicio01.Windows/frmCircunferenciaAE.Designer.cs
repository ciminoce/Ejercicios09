namespace Ejercicio01.Windows
{
    partial class frmCircunferenciaAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtRadio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Radio:";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(93, 26);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Image = Properties.Resources.Aceptar;
            btnAceptar.Location = new Point(37, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 60);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "OK";
            btnAceptar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(222, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 60);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCircunferenciaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 187);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtRadio);
            Controls.Add(label1);
            MaximumSize = new Size(392, 226);
            MinimumSize = new Size(392, 226);
            Name = "frmCircunferenciaAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCircunferenciaAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadio;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}