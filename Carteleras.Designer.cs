namespace Prueba_Intuito
{
    partial class Carteleras
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
            dgvCarteleras = new DataGridView();
            btn_close = new Button();
            btn_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarteleras).BeginInit();
            SuspendLayout();
            // 
            // dgvCarteleras
            // 
            dgvCarteleras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarteleras.Location = new Point(11, 12);
            dgvCarteleras.Name = "dgvCarteleras";
            dgvCarteleras.RowHeadersWidth = 51;
            dgvCarteleras.RowTemplate.Height = 29;
            dgvCarteleras.Size = new Size(776, 361);
            dgvCarteleras.TabIndex = 0;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(11, 395);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(160, 29);
            btn_close.TabIndex = 1;
            btn_close.Text = "Cerrar cartelera";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(885, 76);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(166, 36);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Carteleras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 440);
            Controls.Add(btn_cancel);
            Controls.Add(btn_close);
            Controls.Add(dgvCarteleras);
            Name = "Carteleras";
            Text = "Carteleras";
            Load += Carteleras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarteleras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCarteleras;
        private Button btn_close;
        private Button btn_cancel;
    }
}