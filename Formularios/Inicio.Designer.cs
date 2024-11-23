namespace Trabajo_practico
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            label5 = new Label();
            btnCrearCuenta = new Button();
            btnCambiarClave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.Control;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.LawnGreen;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.ControlText;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(textBoxUsuario, "textBoxUsuario");
            textBoxUsuario.Name = "textBoxUsuario";
            // 
            // textBoxContrasena
            // 
            resources.ApplyResources(textBoxContrasena, "textBoxContrasena");
            textBoxContrasena.Name = "textBoxContrasena";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Green;
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.Ivory;
            resources.ApplyResources(btnCrearCuenta, "btnCrearCuenta");
            btnCrearCuenta.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnCambiarClave
            // 
            resources.ApplyResources(btnCambiarClave, "btnCambiarClave");
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.UseVisualStyleBackColor = true;
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCambiarClave);
            Controls.Add(btnCrearCuenta);
            Controls.Add(label5);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "Inicio";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Label label5;
        private Button btnCrearCuenta;
        private Button btnCambiarClave;
    }
}
