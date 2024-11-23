namespace Trabajo_practico.Formularios
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxApellido = new TextBox();
            label4 = new Label();
            textBoxUsuario = new TextBox();
            label6 = new Label();
            textBoxClave = new TextBox();
            btnCrearUsuario = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 37);
            label2.Name = "label2";
            label2.Size = new Size(425, 62);
            label2.TabIndex = 1;
            label2.Text = "Registro de usuarios";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(355, 155);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(130, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 210);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellido.Location = new Point(355, 210);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(128, 27);
            textBoxApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, 265);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 5;
            label4.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsuario.Location = new Point(355, 268);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(128, 27);
            textBoxUsuario.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(242, 317);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 8;
            label6.Text = "Clave";
            // 
            // textBoxClave
            // 
            textBoxClave.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxClave.Location = new Point(355, 320);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.PasswordChar = '*';
            textBoxClave.Size = new Size(128, 27);
            textBoxClave.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Cursor = Cursors.Hand;
            btnCrearUsuario.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.Location = new Point(307, 375);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(133, 35);
            btnCrearUsuario.TabIndex = 10;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 37);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 35);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // RegistroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(803, 480);
            Controls.Add(btnVolver);
            Controls.Add(btnCrearUsuario);
            Controls.Add(textBoxClave);
            Controls.Add(label6);
            Controls.Add(textBoxUsuario);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RegistroUsuarios";
            Text = "RegistroUsuarios";
            Load += RegistroUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label4;
        private TextBox textBoxUsuario;
        private Label label6;
        private TextBox textBoxClave;
        private Button btnCrearUsuario;
        private Button btnVolver;
    }
}