
namespace Presentacion
{
    partial class Form_Detalles
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
            this.txt_Detalles = new System.Windows.Forms.TextBox();
            this.pictureBox_Detalles = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Detalles
            // 
            this.txt_Detalles.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Detalles.Location = new System.Drawing.Point(12, 12);
            this.txt_Detalles.Multiline = true;
            this.txt_Detalles.Name = "txt_Detalles";
            this.txt_Detalles.ReadOnly = true;
            this.txt_Detalles.Size = new System.Drawing.Size(429, 338);
            this.txt_Detalles.TabIndex = 0;
            // 
            // pictureBox_Detalles
            // 
            this.pictureBox_Detalles.Location = new System.Drawing.Point(620, 271);
            this.pictureBox_Detalles.Name = "pictureBox_Detalles";
            this.pictureBox_Detalles.Size = new System.Drawing.Size(168, 167);
            this.pictureBox_Detalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Detalles.TabIndex = 1;
            this.pictureBox_Detalles.TabStop = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(174, 384);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(84, 32);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Form_Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.pictureBox_Detalles);
            this.Controls.Add(this.txt_Detalles);
            this.Name = "Form_Detalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Artículo";
            this.Load += new System.EventHandler(this.Form_Detalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Detalles;
        private System.Windows.Forms.PictureBox pictureBox_Detalles;
        private System.Windows.Forms.Button btn_Volver;
    }
}