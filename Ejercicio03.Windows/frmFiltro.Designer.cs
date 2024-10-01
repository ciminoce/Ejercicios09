namespace Ejercicio03.Windows
{
    partial class frmFiltro
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
            btnOK = new Button();
            label1 = new Label();
            cboCuadrantes = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_36px;
            btnCancelar.Location = new Point(197, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 56);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_36px;
            btnOK.Location = new Point(89, 89);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 56);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 5;
            label1.Text = "Seleccione cuadrante:";
            // 
            // cboCuadrantes
            // 
            cboCuadrantes.FormattingEnabled = true;
            cboCuadrantes.Location = new Point(167, 39);
            cboCuadrantes.Name = "cboCuadrantes";
            cboCuadrantes.Size = new Size(121, 23);
            cboCuadrantes.TabIndex = 6;
            // 
            // frmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 190);
            ControlBox = false;
            Controls.Add(cboCuadrantes);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            MaximumSize = new Size(375, 229);
            MinimumSize = new Size(375, 229);
            Name = "frmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFiltro";
            Load += frmFiltro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private Label label1;
        private ComboBox cboCuadrantes;
    }
}