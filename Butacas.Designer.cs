namespace Prueba_Intuito
{
    partial class Butacas
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
            dgv_butacas = new DataGridView();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_butacas).BeginInit();
            SuspendLayout();
            // 
            // dgv_butacas
            // 
            dgv_butacas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_butacas.Location = new Point(12, 12);
            dgv_butacas.Name = "dgv_butacas";
            dgv_butacas.RowHeadersWidth = 51;
            dgv_butacas.RowTemplate.Height = 29;
            dgv_butacas.Size = new Size(797, 379);
            dgv_butacas.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(865, 53);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(128, 45);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Butacas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 464);
            Controls.Add(btn_cancelar);
            Controls.Add(dgv_butacas);
            Name = "Butacas";
            Text = "Butacas";
            ((System.ComponentModel.ISupportInitialize)dgv_butacas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_butacas;
        private Button btn_cancelar;
    }
}