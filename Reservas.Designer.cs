namespace Prueba_Intuito
{
    partial class Reservas
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
            dgv_reservas = new DataGridView();
            btn_cancel = new Button();
            btn_close = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgv_reservas).BeginInit();
            SuspendLayout();
            // 
            // dgv_reservas
            // 
            dgv_reservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reservas.Location = new Point(10, 9);
            dgv_reservas.Margin = new Padding(3, 2, 3, 2);
            dgv_reservas.Name = "dgv_reservas";
            dgv_reservas.RowHeadersWidth = 51;
            dgv_reservas.RowTemplate.Height = 29;
            dgv_reservas.Size = new Size(721, 308);
            dgv_reservas.TabIndex = 0;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(811, 96);
            btn_cancel.Margin = new Padding(3, 2, 3, 2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(145, 29);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(856, 304);
            btn_close.Margin = new Padding(3, 2, 3, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(123, 26);
            btn_close.TabIndex = 2;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Timer
            // 
            Timer.Interval = 10000;
            Timer.Tick += Timer_Tick;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 339);
            Controls.Add(btn_close);
            Controls.Add(btn_cancel);
            Controls.Add(dgv_reservas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas";
            Load += Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_reservas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_reservas;
        private Button btn_cancel;
        private Button btn_close;
        private System.Windows.Forms.Timer Timer;
    }
}