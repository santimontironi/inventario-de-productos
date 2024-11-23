namespace Trabajo_practico.Formularios
{
    partial class CambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarClave));
            label1 = new Label();
            textBoxClaveNueva = new TextBox();
            btnEnviarClaveNueva = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 72);
            label1.Name = "label1";
            label1.Size = new Size(591, 62);
            label1.TabIndex = 0;
            label1.Text = "Ingreso de nueva contraseña";
            // 
            // textBoxClaveNueva
            // 
            textBoxClaveNueva.Location = new Point(358, 225);
            textBoxClaveNueva.Name = "textBoxClaveNueva";
            textBoxClaveNueva.PasswordChar = '*';
            textBoxClaveNueva.Size = new Size(114, 23);
            textBoxClaveNueva.TabIndex = 1;
            // 
            // btnEnviarClaveNueva
            // 
            btnEnviarClaveNueva.BackColor = Color.FromArgb(128, 255, 128);
            btnEnviarClaveNueva.Cursor = Cursors.Hand;
            btnEnviarClaveNueva.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarClaveNueva.ForeColor = SystemColors.ControlText;
            btnEnviarClaveNueva.Location = new Point(304, 266);
            btnEnviarClaveNueva.Name = "btnEnviarClaveNueva";
            btnEnviarClaveNueva.Size = new Size(201, 66);
            btnEnviarClaveNueva.TabIndex = 2;
            btnEnviarClaveNueva.Text = "Cambiar contraseña";
            btnEnviarClaveNueva.UseVisualStyleBackColor = false;
            btnEnviarClaveNueva.Click += btnEnviarClaveNueva_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 25);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 3;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 225);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña nueva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 170);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre de usuario";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(358, 170);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(114, 23);
            textBoxUsuario.TabIndex = 6;
            // 
            // CambiarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 480);
            Controls.Add(textBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnEnviarClaveNueva);
            Controls.Add(textBoxClaveNueva);
            Controls.Add(label1);
            Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "CambiarClave";
            Text = "CambiarClave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxClaveNueva;
        private Button btnEnviarClaveNueva;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsuario;
    }
}