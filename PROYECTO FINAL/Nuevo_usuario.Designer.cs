namespace PROYECTO_FINAL
{
    partial class Nuevo_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.ingresarusuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOBRE DEL USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE";
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(433, 118);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(365, 20);
            this.txtnombreusuario.TabIndex = 7;
            this.txtnombreusuario.TextChanged += new System.EventHandler(this.txtnombreusuario_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(433, 69);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(365, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // ingresarusuario
            // 
            this.ingresarusuario.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.ingresarusuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ingresarusuario.FlatAppearance.BorderSize = 3;
            this.ingresarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarusuario.Location = new System.Drawing.Point(352, 216);
            this.ingresarusuario.Name = "ingresarusuario";
            this.ingresarusuario.Size = new System.Drawing.Size(213, 43);
            this.ingresarusuario.TabIndex = 5;
            this.ingresarusuario.Text = "INGRESAR  NUEVO USUARIO";
            this.ingresarusuario.UseVisualStyleBackColor = true;
            this.ingresarusuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(293, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = " CONTRASEÑA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(433, 157);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(365, 20);
            this.txtcontraseña.TabIndex = 10;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(598, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "VOLVER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // Nuevo_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.cat_dog1;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.ingresarusuario);
            this.Name = "Nuevo_usuario";
            this.Text = "Nuevo_usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button ingresarusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}