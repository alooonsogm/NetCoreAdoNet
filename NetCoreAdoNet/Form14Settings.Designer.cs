namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            pictureBox2 = new PictureBox();
            lblConexion = new Label();
            btnLeerSettings = new Button();
            pictureBox3 = new PictureBox();
            btnLeerHelper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(417, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 149);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(102, 189);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 15);
            lblConexion.TabIndex = 2;
            lblConexion.Text = "lblConexion";
            // 
            // btnLeerSettings
            // 
            btnLeerSettings.Location = new Point(102, 81);
            btnLeerSettings.Name = "btnLeerSettings";
            btnLeerSettings.Size = new Size(159, 39);
            btnLeerSettings.TabIndex = 3;
            btnLeerSettings.Text = "Leer Settings";
            btnLeerSettings.UseVisualStyleBackColor = true;
            btnLeerSettings.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(102, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 149);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnLeerHelper
            // 
            btnLeerHelper.Location = new Point(333, 81);
            btnLeerHelper.Name = "btnLeerHelper";
            btnLeerHelper.Size = new Size(175, 39);
            btnLeerHelper.TabIndex = 5;
            btnLeerHelper.Text = "Leer Helper Configuration";
            btnLeerHelper.UseVisualStyleBackColor = true;
            btnLeerHelper.Click += btnLeerHelper_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeerHelper);
            Controls.Add(pictureBox3);
            Controls.Add(btnLeerSettings);
            Controls.Add(lblConexion);
            Controls.Add(pictureBox2);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblConexion;
        private Button btnLeerSettings;
        private PictureBox pictureBox3;
        private Button btnLeerHelper;
    }
}