namespace Ejercicio_7
{
    partial class FRMPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPrincipal));
            this.BTNParticipante1 = new System.Windows.Forms.Button();
            this.BTNParticipante2 = new System.Windows.Forms.Button();
            this.BTNParticipante3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.LBLPorcentaje1 = new System.Windows.Forms.Label();
            this.LBLPorcentaje2 = new System.Windows.Forms.Label();
            this.LBLPorcentaje3 = new System.Windows.Forms.Label();
            this.LBLNombre1 = new System.Windows.Forms.Label();
            this.LBLVotos1 = new System.Windows.Forms.Label();
            this.LBLNombre2 = new System.Windows.Forms.Label();
            this.LBLVotos2 = new System.Windows.Forms.Label();
            this.LBLNombre3 = new System.Windows.Forms.Label();
            this.LBLVotos3 = new System.Windows.Forms.Label();
            this.LBLTotalVotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNParticipante1
            // 
            this.BTNParticipante1.Location = new System.Drawing.Point(76, 383);
            this.BTNParticipante1.Name = "BTNParticipante1";
            this.BTNParticipante1.Size = new System.Drawing.Size(89, 29);
            this.BTNParticipante1.TabIndex = 0;
            this.BTNParticipante1.Text = "+1";
            this.BTNParticipante1.UseVisualStyleBackColor = true;
            this.BTNParticipante1.Click += new System.EventHandler(this.BTNParticipante1_Click);
            // 
            // BTNParticipante2
            // 
            this.BTNParticipante2.Location = new System.Drawing.Point(327, 383);
            this.BTNParticipante2.Name = "BTNParticipante2";
            this.BTNParticipante2.Size = new System.Drawing.Size(80, 29);
            this.BTNParticipante2.TabIndex = 1;
            this.BTNParticipante2.Text = "+1";
            this.BTNParticipante2.UseVisualStyleBackColor = true;
            this.BTNParticipante2.Click += new System.EventHandler(this.BTNParticipante2_Click);
            // 
            // BTNParticipante3
            // 
            this.BTNParticipante3.Location = new System.Drawing.Point(586, 383);
            this.BTNParticipante3.Name = "BTNParticipante3";
            this.BTNParticipante3.Size = new System.Drawing.Size(85, 29);
            this.BTNParticipante3.TabIndex = 2;
            this.BTNParticipante3.Text = "+1";
            this.BTNParticipante3.UseVisualStyleBackColor = true;
            this.BTNParticipante3.Click += new System.EventHandler(this.BTNParticipante3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(49, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(291, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(549, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitulo.Location = new System.Drawing.Point(149, 9);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(437, 60);
            this.LBLTitulo.TabIndex = 6;
            this.LBLTitulo.Text = "Sistema de Elecciones";
            this.LBLTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLPorcentaje1
            // 
            this.LBLPorcentaje1.AutoSize = true;
            this.LBLPorcentaje1.Location = new System.Drawing.Point(45, 99);
            this.LBLPorcentaje1.Name = "LBLPorcentaje1";
            this.LBLPorcentaje1.Size = new System.Drawing.Size(23, 20);
            this.LBLPorcentaje1.TabIndex = 7;
            this.LBLPorcentaje1.Text = "%";
            // 
            // LBLPorcentaje2
            // 
            this.LBLPorcentaje2.AutoSize = true;
            this.LBLPorcentaje2.Location = new System.Drawing.Point(287, 99);
            this.LBLPorcentaje2.Name = "LBLPorcentaje2";
            this.LBLPorcentaje2.Size = new System.Drawing.Size(23, 20);
            this.LBLPorcentaje2.TabIndex = 8;
            this.LBLPorcentaje2.Text = "%";
            // 
            // LBLPorcentaje3
            // 
            this.LBLPorcentaje3.AutoSize = true;
            this.LBLPorcentaje3.Location = new System.Drawing.Point(597, 99);
            this.LBLPorcentaje3.Name = "LBLPorcentaje3";
            this.LBLPorcentaje3.Size = new System.Drawing.Size(23, 20);
            this.LBLPorcentaje3.TabIndex = 9;
            this.LBLPorcentaje3.Text = "%";
            // 
            // LBLNombre1
            // 
            this.LBLNombre1.AutoSize = true;
            this.LBLNombre1.Location = new System.Drawing.Point(45, 315);
            this.LBLNombre1.Name = "LBLNombre1";
            this.LBLNombre1.Size = new System.Drawing.Size(102, 20);
            this.LBLNombre1.TabIndex = 10;
            this.LBLNombre1.Text = "Participante1";
            // 
            // LBLVotos1
            // 
            this.LBLVotos1.AutoSize = true;
            this.LBLVotos1.Location = new System.Drawing.Point(45, 349);
            this.LBLVotos1.Name = "LBLVotos1";
            this.LBLVotos1.Size = new System.Drawing.Size(68, 20);
            this.LBLVotos1.TabIndex = 11;
            this.LBLVotos1.Text = "Votos: 0";
            // 
            // LBLNombre2
            // 
            this.LBLNombre2.AutoSize = true;
            this.LBLNombre2.Location = new System.Drawing.Point(287, 315);
            this.LBLNombre2.Name = "LBLNombre2";
            this.LBLNombre2.Size = new System.Drawing.Size(102, 20);
            this.LBLNombre2.TabIndex = 12;
            this.LBLNombre2.Text = "Participante2";
            // 
            // LBLVotos2
            // 
            this.LBLVotos2.AutoSize = true;
            this.LBLVotos2.Location = new System.Drawing.Point(287, 349);
            this.LBLVotos2.Name = "LBLVotos2";
            this.LBLVotos2.Size = new System.Drawing.Size(68, 20);
            this.LBLVotos2.TabIndex = 13;
            this.LBLVotos2.Text = "Votos: 0";
            // 
            // LBLNombre3
            // 
            this.LBLNombre3.AutoSize = true;
            this.LBLNombre3.Location = new System.Drawing.Point(546, 315);
            this.LBLNombre3.Name = "LBLNombre3";
            this.LBLNombre3.Size = new System.Drawing.Size(102, 20);
            this.LBLNombre3.TabIndex = 14;
            this.LBLNombre3.Text = "Participante3";
            // 
            // LBLVotos3
            // 
            this.LBLVotos3.AutoSize = true;
            this.LBLVotos3.Location = new System.Drawing.Point(546, 349);
            this.LBLVotos3.Name = "LBLVotos3";
            this.LBLVotos3.Size = new System.Drawing.Size(60, 20);
            this.LBLVotos3.TabIndex = 15;
            this.LBLVotos3.Text = "Voto: 0";
            // 
            // LBLTotalVotos
            // 
            this.LBLTotalVotos.AutoSize = true;
            this.LBLTotalVotos.Location = new System.Drawing.Point(532, 472);
            this.LBLTotalVotos.Name = "LBLTotalVotos";
            this.LBLTotalVotos.Size = new System.Drawing.Size(129, 20);
            this.LBLTotalVotos.TabIndex = 16;
            this.LBLTotalVotos.Text = "Total de Votos: 0";
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(751, 521);
            this.Controls.Add(this.LBLTotalVotos);
            this.Controls.Add(this.LBLVotos3);
            this.Controls.Add(this.LBLNombre3);
            this.Controls.Add(this.LBLVotos2);
            this.Controls.Add(this.LBLNombre2);
            this.Controls.Add(this.LBLVotos1);
            this.Controls.Add(this.LBLNombre1);
            this.Controls.Add(this.LBLPorcentaje3);
            this.Controls.Add(this.LBLPorcentaje2);
            this.Controls.Add(this.LBLPorcentaje1);
            this.Controls.Add(this.LBLTitulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNParticipante3);
            this.Controls.Add(this.BTNParticipante2);
            this.Controls.Add(this.BTNParticipante1);
            this.Name = "FRMPrincipal";
            this.Text = "Sistema de Elecciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNParticipante1;
        private System.Windows.Forms.Button BTNParticipante2;
        private System.Windows.Forms.Button BTNParticipante3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.Label LBLPorcentaje1;
        private System.Windows.Forms.Label LBLPorcentaje2;
        private System.Windows.Forms.Label LBLPorcentaje3;
        private System.Windows.Forms.Label LBLNombre1;
        private System.Windows.Forms.Label LBLVotos1;
        private System.Windows.Forms.Label LBLNombre2;
        private System.Windows.Forms.Label LBLVotos2;
        private System.Windows.Forms.Label LBLNombre3;
        private System.Windows.Forms.Label LBLVotos3;
        private System.Windows.Forms.Label LBLTotalVotos;
    }
}

