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
            this.rb_dda = new System.Windows.Forms.RadioButton();
            this.rb_bresenham = new System.Windows.Forms.RadioButton();
            this.rb_eqreta = new System.Windows.Forms.RadioButton();
            this.pb_quadro = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_primitivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quadro)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_primitivas
            // 
            this.gb_primitivas.BackColor = System.Drawing.Color.Transparent;
            this.gb_primitivas.Controls.Add(this.rb_dda);
            this.gb_primitivas.Controls.Add(this.rb_bresenham);
            this.gb_primitivas.Controls.Add(this.rb_eqreta);
            this.gb_primitivas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_primitivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_primitivas.ForeColor = System.Drawing.Color.White;
            this.gb_primitivas.Location = new System.Drawing.Point(9, 12);
            this.gb_primitivas.Name = "gb_primitivas";
            this.gb_primitivas.Size = new System.Drawing.Size(190, 103);
            this.gb_primitivas.TabIndex = 0;
            this.gb_primitivas.TabStop = false;
            this.gb_primitivas.Text = "Retas";
            // 
            // rb_dda
            // 
            this.rb_dda.AutoSize = true;
            this.rb_dda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_dda.ForeColor = System.Drawing.Color.White;
            this.rb_dda.Location = new System.Drawing.Point(21, 43);
            this.rb_dda.Name = "rb_dda";
            this.rb_dda.Size = new System.Drawing.Size(53, 19);
            this.rb_dda.TabIndex = 2;
            this.rb_dda.TabStop = true;
            this.rb_dda.Text = "DDA";
            this.rb_dda.UseVisualStyleBackColor = true;
            // 
            // rb_bresenham
            // 
            this.rb_bresenham.AutoSize = true;
            this.rb_bresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_bresenham.ForeColor = System.Drawing.Color.White;
            this.rb_bresenham.Location = new System.Drawing.Point(21, 66);
            this.rb_bresenham.Name = "rb_bresenham";
            this.rb_bresenham.Size = new System.Drawing.Size(98, 19);
            this.rb_bresenham.TabIndex = 1;
            this.rb_bresenham.TabStop = true;
            this.rb_bresenham.Text = "Bresenham";
            this.rb_bresenham.UseVisualStyleBackColor = true;
            // 
            // rb_eqreta
            // 
            this.rb_eqreta.AutoSize = true;
            this.rb_eqreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eqreta.ForeColor = System.Drawing.Color.White;
            this.rb_eqreta.Location = new System.Drawing.Point(21, 20);
            this.rb_eqreta.Name = "rb_eqreta";
            this.rb_eqreta.Size = new System.Drawing.Size(169, 19);
            this.rb_eqreta.TabIndex = 0;
            this.rb_eqreta.TabStop = true;
            this.rb_eqreta.Text = "Equação Real da Reta";
            this.rb_eqreta.UseVisualStyleBackColor = true;
            this.rb_eqreta.CheckedChanged += new System.EventHandler(this.rb_retas_CheckedChanged);
            // 
            // pb_quadro
            // 
            this.pb_quadro.BackColor = System.Drawing.Color.White;
            this.pb_quadro.Location = new System.Drawing.Point(208, 12);
            this.pb_quadro.Name = "pb_quadro";
            this.pb_quadro.Size = new System.Drawing.Size(610, 444);
            this.pb_quadro.TabIndex = 1;
            this.pb_quadro.TabStop = false;
            this.pb_quadro.Click += new System.EventHandler(this.pb_quadro_Click);
            this.pb_quadro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_clicou);
            this.pb_quadro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_pressionado);
            this.pb_quadro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_soltou);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 468);
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
        private System.Windows.Forms.RadioButton rb_dda;
        private System.Windows.Forms.RadioButton rb_bresenham;
        private System.Windows.Forms.RadioButton rb_eqreta;
        private System.Windows.Forms.PictureBox pb_quadro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

