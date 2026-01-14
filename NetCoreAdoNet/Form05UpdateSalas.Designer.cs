namespace NetCoreAdoNet
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            btnUpdateSalas = new Button();
            txtNuevoNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(121, 109);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(200, 244);
            lstSalas.TabIndex = 14;
            // 
            // btnUpdateSalas
            // 
            btnUpdateSalas.Location = new Point(413, 152);
            btnUpdateSalas.Name = "btnUpdateSalas";
            btnUpdateSalas.Size = new Size(140, 32);
            btnUpdateSalas.TabIndex = 13;
            btnUpdateSalas.Text = "Update salas";
            btnUpdateSalas.UseVisualStyleBackColor = true;
            btnUpdateSalas.Click += btnUpdateSalas_Click;
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(397, 109);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(179, 23);
            txtNuevoNombre.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 91);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "Salas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 91);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 10;
            label1.Text = "Nuevo nombre";
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSalas);
            Controls.Add(btnUpdateSalas);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSalas;
        private Button btnUpdateSalas;
        private TextBox txtNuevoNombre;
        private Label label2;
        private Label label1;
    }
}