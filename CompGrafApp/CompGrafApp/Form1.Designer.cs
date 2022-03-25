namespace CompGrafApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_primitivas = new System.Windows.Forms.GroupBox();
            this.rb_retas = new System.Windows.Forms.RadioButton();
            this.rb_elipse = new System.Windows.Forms.RadioButton();
            this.rb_circunferencia = new System.Windows.Forms.RadioButton();
            this.pb_quadro = new System.Windows.Forms.PictureBox();
            this.gb_primitivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quadro)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_primitivas
            // 
            this.gb_primitivas.BackColor = System.Drawing.Color.Transparent;
            this.gb_primitivas.Controls.Add(this.rb_circunferencia);
            this.gb_primitivas.Controls.Add(this.rb_elipse);
            this.gb_primitivas.Controls.Add(this.rb_retas);
            this.gb_primitivas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_primitivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_primitivas.ForeColor = System.Drawing.Color.White;
            this.gb_primitivas.Location = new System.Drawing.Point(12, 12);
            this.gb_primitivas.Name = "gb_primitivas";
            this.gb_primitivas.Size = new System.Drawing.Size(166, 103);
            this.gb_primitivas.TabIndex = 0;
            this.gb_primitivas.TabStop = false;
            this.gb_primitivas.Text = "Primitivas Gráficas";
            // 
            // rb_retas
            // 
            this.rb_retas.AutoSize = true;
            this.rb_retas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_retas.ForeColor = System.Drawing.Color.White;
            this.rb_retas.Location = new System.Drawing.Point(21, 20);
            this.rb_retas.Name = "rb_retas";
            this.rb_retas.Size = new System.Drawing.Size(59, 20);
            this.rb_retas.TabIndex = 0;
            this.rb_retas.TabStop = true;
            this.rb_retas.Text = "Reta";
            this.rb_retas.UseVisualStyleBackColor = true;
            // 
            // rb_elipse
            // 
            this.rb_elipse.AutoSize = true;
            this.rb_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_elipse.ForeColor = System.Drawing.Color.White;
            this.rb_elipse.Location = new System.Drawing.Point(21, 66);
            this.rb_elipse.Name = "rb_elipse";
            this.rb_elipse.Size = new System.Drawing.Size(70, 20);
            this.rb_elipse.TabIndex = 1;
            this.rb_elipse.TabStop = true;
            this.rb_elipse.Text = "Elipse";
            this.rb_elipse.UseVisualStyleBackColor = true;
            // 
            // rb_circunferencia
            // 
            this.rb_circunferencia.AutoSize = true;
            this.rb_circunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_circunferencia.ForeColor = System.Drawing.Color.White;
            this.rb_circunferencia.Location = new System.Drawing.Point(21, 43);
            this.rb_circunferencia.Name = "rb_circunferencia";
            this.rb_circunferencia.Size = new System.Drawing.Size(125, 20);
            this.rb_circunferencia.TabIndex = 2;
            this.rb_circunferencia.TabStop = true;
            this.rb_circunferencia.Text = "Circunferência";
            this.rb_circunferencia.UseVisualStyleBackColor = true;
            // 
            // pb_quadro
            // 
            this.pb_quadro.BackColor = System.Drawing.Color.White;
            this.pb_quadro.Location = new System.Drawing.Point(184, 12);
            this.pb_quadro.Name = "pb_quadro";
            this.pb_quadro.Size = new System.Drawing.Size(604, 426);
            this.pb_quadro.TabIndex = 1;
            this.pb_quadro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_primitivas);
            this.Controls.Add(this.pb_quadro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maria Vinicius";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_primitivas.ResumeLayout(false);
            this.gb_primitivas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quadro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_primitivas;
        private System.Windows.Forms.RadioButton rb_circunferencia;
        private System.Windows.Forms.RadioButton rb_elipse;
        private System.Windows.Forms.RadioButton rb_retas;
        private System.Windows.Forms.PictureBox pb_quadro;
    }
}

