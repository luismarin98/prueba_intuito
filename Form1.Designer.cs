namespace Prueba_Intuito
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            lbl_verify = new Label();
            VeryConn = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            btn_carteleras = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 49);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(280, 37);
            button1.TabIndex = 0;
            button1.Text = "Mostrar reservas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_verify
            // 
            lbl_verify.AutoSize = true;
            lbl_verify.Location = new Point(10, 7);
            lbl_verify.Name = "lbl_verify";
            lbl_verify.Size = new Size(0, 15);
            lbl_verify.TabIndex = 1;
            // 
            // VeryConn
            // 
            VeryConn.Tick += VeryConn_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(60, 303);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(187, 26);
            button2.TabIndex = 2;
            button2.Text = "Cerrar programa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_carteleras
            // 
            btn_carteleras.Location = new Point(10, 100);
            btn_carteleras.Margin = new Padding(3, 2, 3, 2);
            btn_carteleras.Name = "btn_carteleras";
            btn_carteleras.Size = new Size(280, 37);
            btn_carteleras.TabIndex = 3;
            btn_carteleras.Text = "Mostrar cartelera";
            btn_carteleras.UseVisualStyleBackColor = true;
            btn_carteleras.Click += btn_carteleras_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 338);
            Controls.Add(btn_carteleras);
            Controls.Add(button2);
            Controls.Add(lbl_verify);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbl_verify;
        private System.Windows.Forms.Timer VeryConn;
        private Button button2;
        private Button btn_carteleras;
    }
}