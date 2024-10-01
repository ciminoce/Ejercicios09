namespace Ejercicio03.Windows
{
    partial class frmPuntosAE
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
            txtX = new TextBox();
            label2 = new Label();
            txtY = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnOK = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // txtX
            // 
            txtX.Location = new Point(54, 24);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 56);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "Y:";
            // 
            // txtY
            // 
            txtY.Location = new Point(54, 53);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_36px;
            btnOK.Location = new Point(19, 109);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 56);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_36px;
            btnCancelar.Location = new Point(127, 109);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 56);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPuntosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 205);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtY);
            Controls.Add(label2);
            Controls.Add(txtX);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(262, 244);
            MinimumSize = new Size(262, 244);
            Name = "frmPuntosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPuntosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtX;
        private Label label2;
        private TextBox txtY;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOK;
    }
}