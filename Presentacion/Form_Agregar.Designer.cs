
namespace Presentacion
{
    partial class Form_Agregar
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
            this.lbl_CodArt = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDescArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.pictureBox_Agregar = new System.Windows.Forms.PictureBox();
            this.btn_Aceptar_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CodArt
            // 
            this.lbl_CodArt.AutoSize = true;
            this.lbl_CodArt.Location = new System.Drawing.Point(85, 83);
            this.lbl_CodArt.Name = "lbl_CodArt";
            this.lbl_CodArt.Size = new System.Drawing.Size(97, 13);
            this.lbl_CodArt.TabIndex = 0;
            this.lbl_CodArt.Text = "Código del Artículo";
            this.lbl_CodArt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(188, 83);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtCodArticulo.TabIndex = 1;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(188, 198);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(188, 124);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtNombreArticulo.TabIndex = 3;
            // 
            // txtDescArticulo
            // 
            this.txtDescArticulo.Location = new System.Drawing.Point(188, 162);
            this.txtDescArticulo.Name = "txtDescArticulo";
            this.txtDescArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtDescArticulo.TabIndex = 4;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(188, 275);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioArticulo.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(188, 235);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(119, 162);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 7;
            this.lbl_Descripcion.Text = "Descripción";
            this.lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(145, 198);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marca";
            this.lbl_Marca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(128, 235);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(54, 13);
            this.lbl_Categoria.TabIndex = 9;
            this.lbl_Categoria.Text = "Categoría";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(145, 275);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 10;
            this.lbl_Precio.Text = "Precio";
            this.lbl_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(138, 124);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 11;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Agregar
            // 
            this.pictureBox_Agregar.Location = new System.Drawing.Point(357, 83);
            this.pictureBox_Agregar.Name = "pictureBox_Agregar";
            this.pictureBox_Agregar.Size = new System.Drawing.Size(311, 271);
            this.pictureBox_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Agregar.TabIndex = 12;
            this.pictureBox_Agregar.TabStop = false;
            // 
            // btn_Aceptar_Agregar
            // 
            this.btn_Aceptar_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar_Agregar.Location = new System.Drawing.Point(107, 388);
            this.btn_Aceptar_Agregar.Name = "btn_Aceptar_Agregar";
            this.btn_Aceptar_Agregar.Size = new System.Drawing.Size(75, 32);
            this.btn_Aceptar_Agregar.TabIndex = 13;
            this.btn_Aceptar_Agregar.Text = "Aceptar";
            this.btn_Aceptar_Agregar.UseVisualStyleBackColor = true;
            this.btn_Aceptar_Agregar.Click += new System.EventHandler(this.btn_Aceptar_Agregar_Click);
            // 
            // btn_Cancelar_Agregar
            // 
            this.btn_Cancelar_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar_Agregar.Location = new System.Drawing.Point(234, 388);
            this.btn_Cancelar_Agregar.Name = "btn_Cancelar_Agregar";
            this.btn_Cancelar_Agregar.Size = new System.Drawing.Size(83, 32);
            this.btn_Cancelar_Agregar.TabIndex = 14;
            this.btn_Cancelar_Agregar.Text = "Cancelar";
            this.btn_Cancelar_Agregar.UseVisualStyleBackColor = true;
            this.btn_Cancelar_Agregar.Click += new System.EventHandler(this.btn_Cancelar_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Url Imagen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(188, 314);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagen.TabIndex = 16;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // Form_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar_Agregar);
            this.Controls.Add(this.btn_Aceptar_Agregar);
            this.Controls.Add(this.pictureBox_Agregar);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.txtDescArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtCodArticulo);
            this.Controls.Add(this.lbl_CodArt);
            this.Name = "Form_Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Artículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Agregar_FormClosing);
            this.Load += new System.EventHandler(this.Form_Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CodArt;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtDescArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.PictureBox pictureBox_Agregar;
        private System.Windows.Forms.Button btn_Aceptar_Agregar;
        private System.Windows.Forms.Button btn_Cancelar_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlImagen;
    }
}