namespace CentroSalud.App
{
    partial class InicioSesion
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nombreMed = new System.Windows.Forms.Label();
            this.textBox_nombreMed = new System.Windows.Forms.TextBox();
            this.button_agregarMed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "verificarUsuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(96, 114);
            this.txt_username.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(260, 38);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(525, 122);
            this.txt_password.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(260, 38);
            this.txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "clave";
            // 
            // label_nombreMed
            // 
            this.label_nombreMed.AutoSize = true;
            this.label_nombreMed.Location = new System.Drawing.Point(96, 272);
            this.label_nombreMed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_nombreMed.Name = "label_nombreMed";
            this.label_nombreMed.Size = new System.Drawing.Size(289, 32);
            this.label_nombreMed.TabIndex = 8;
            this.label_nombreMed.Text = "nombre medicamento";
            // 
            // textBox_nombreMed
            // 
            this.textBox_nombreMed.Location = new System.Drawing.Point(96, 317);
            this.textBox_nombreMed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox_nombreMed.Name = "textBox_nombreMed";
            this.textBox_nombreMed.Size = new System.Drawing.Size(260, 38);
            this.textBox_nombreMed.TabIndex = 6;
            // 
            // button_agregarMed
            // 
            this.button_agregarMed.Location = new System.Drawing.Point(525, 317);
            this.button_agregarMed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_agregarMed.Name = "button_agregarMed";
            this.button_agregarMed.Size = new System.Drawing.Size(273, 55);
            this.button_agregarMed.TabIndex = 5;
            this.button_agregarMed.Text = "agregarMed";
            this.button_agregarMed.UseVisualStyleBackColor = true;
            this.button_agregarMed.Click += new System.EventHandler(this.button_agregarMed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "respuestaExiste";
            this.label3.Visible = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_nombreMed);
            this.Controls.Add(this.textBox_nombreMed);
            this.Controls.Add(this.button_agregarMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nombreMed;
        private System.Windows.Forms.TextBox textBox_nombreMed;
        private System.Windows.Forms.Button button_agregarMed;
        private System.Windows.Forms.Label label3;
    }
}