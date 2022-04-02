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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_eqtrig = new System.Windows.Forms.RadioButton();
            this.rb_pontomedio = new System.Windows.Forms.RadioButton();
            this.rb_eqcirc = new System.Windows.Forms.RadioButton();
            this.gb_elipse = new System.Windows.Forms.GroupBox();
            this.rb_elipse = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_translacao = new System.Windows.Forms.Button();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_poligonos = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_rotacao = new System.Windows.Forms.Button();
            this.tb_angulo = new System.Windows.Forms.TextBox();
            this.lb_angulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_origem = new System.Windows.Forms.RadioButton();
            this.rb_centro = new System.Windows.Forms.RadioButton();
            this.cb_transf = new System.Windows.Forms.ComboBox();
            this.cb_trans = new System.Windows.Forms.ComboBox();
            this.tb_y2 = new System.Windows.Forms.TextBox();
            this.lb_y = new System.Windows.Forms.Label();
            this.tb_x2 = new System.Windows.Forms.TextBox();
            this.lb_x = new System.Windows.Forms.Label();
            this.gb_primitivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quadro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_elipse.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_primitivas
            // 
            this.gb_primitivas.BackColor = System.Drawing.Color.Transparent;
            this.gb_primitivas.Controls.Add(this.rb_dda);
            this.gb_primitivas.Controls.Add(this.rb_bresenham);
            this.gb_primitivas.Controls.Add(this.rb_eqreta);
            this.gb_primitivas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_primitivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_primitivas.ForeColor = System.Drawing.Color.Black;
            this.gb_primitivas.Location = new System.Drawing.Point(6, 20);
            this.gb_primitivas.Name = "gb_primitivas";
            this.gb_primitivas.Size = new System.Drawing.Size(198, 98);
            this.gb_primitivas.TabIndex = 0;
            this.gb_primitivas.TabStop = false;
            this.gb_primitivas.Text = "Retas";
            this.gb_primitivas.Enter += new System.EventHandler(this.gb_primitivas_Enter);
            // 
            // rb_dda
            // 
            this.rb_dda.AutoSize = true;
            this.rb_dda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_dda.ForeColor = System.Drawing.Color.Black;
            this.rb_dda.Location = new System.Drawing.Point(21, 43);
            this.rb_dda.Name = "rb_dda";
            this.rb_dda.Size = new System.Drawing.Size(50, 19);
            this.rb_dda.TabIndex = 2;
            this.rb_dda.TabStop = true;
            this.rb_dda.Text = "DDA";
            this.rb_dda.UseVisualStyleBackColor = true;
            // 
            // rb_bresenham
            // 
            this.rb_bresenham.AutoSize = true;
            this.rb_bresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_bresenham.ForeColor = System.Drawing.Color.Black;
            this.rb_bresenham.Location = new System.Drawing.Point(21, 66);
            this.rb_bresenham.Name = "rb_bresenham";
            this.rb_bresenham.Size = new System.Drawing.Size(89, 19);
            this.rb_bresenham.TabIndex = 1;
            this.rb_bresenham.TabStop = true;
            this.rb_bresenham.Text = "Bresenham";
            this.rb_bresenham.UseVisualStyleBackColor = true;
            // 
            // rb_eqreta
            // 
            this.rb_eqreta.AutoSize = true;
            this.rb_eqreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eqreta.ForeColor = System.Drawing.Color.Black;
            this.rb_eqreta.Location = new System.Drawing.Point(21, 20);
            this.rb_eqreta.Name = "rb_eqreta";
            this.rb_eqreta.Size = new System.Drawing.Size(149, 19);
            this.rb_eqreta.TabIndex = 0;
            this.rb_eqreta.TabStop = true;
            this.rb_eqreta.Text = "Equação Real da Reta";
            this.rb_eqreta.UseVisualStyleBackColor = true;
            this.rb_eqreta.CheckedChanged += new System.EventHandler(this.rb_retas_CheckedChanged);
            // 
            // pb_quadro
            // 
            this.pb_quadro.BackColor = System.Drawing.Color.White;
            this.pb_quadro.Location = new System.Drawing.Point(229, 24);
            this.pb_quadro.Name = "pb_quadro";
            this.pb_quadro.Size = new System.Drawing.Size(702, 466);
            this.pb_quadro.TabIndex = 1;
            this.pb_quadro.TabStop = false;
            this.pb_quadro.Click += new System.EventHandler(this.pb_quadro_Click);
            this.pb_quadro.DoubleClick += new System.EventHandler(this.pb_quadro_DoubleClick);
            this.pb_quadro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_quadro_MouseClick);
            this.pb_quadro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_pressionou);
            this.pb_quadro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_arrastando);
            this.pb_quadro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_soltou);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_eqtrig);
            this.groupBox1.Controls.Add(this.rb_pontomedio);
            this.groupBox1.Controls.Add(this.rb_eqcirc);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circunferência";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_eqtrig
            // 
            this.rb_eqtrig.AutoSize = true;
            this.rb_eqtrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eqtrig.ForeColor = System.Drawing.Color.Black;
            this.rb_eqtrig.Location = new System.Drawing.Point(21, 43);
            this.rb_eqtrig.Name = "rb_eqtrig";
            this.rb_eqtrig.Size = new System.Drawing.Size(102, 19);
            this.rb_eqtrig.TabIndex = 2;
            this.rb_eqtrig.TabStop = true;
            this.rb_eqtrig.Text = "Trigonometria";
            this.rb_eqtrig.UseVisualStyleBackColor = true;
            this.rb_eqtrig.CheckedChanged += new System.EventHandler(this.eq_trig_CheckedChanged);
            // 
            // rb_pontomedio
            // 
            this.rb_pontomedio.AutoSize = true;
            this.rb_pontomedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pontomedio.ForeColor = System.Drawing.Color.Black;
            this.rb_pontomedio.Location = new System.Drawing.Point(21, 66);
            this.rb_pontomedio.Name = "rb_pontomedio";
            this.rb_pontomedio.Size = new System.Drawing.Size(95, 19);
            this.rb_pontomedio.TabIndex = 1;
            this.rb_pontomedio.TabStop = true;
            this.rb_pontomedio.Text = "Ponto Médio";
            this.rb_pontomedio.UseVisualStyleBackColor = true;
            // 
            // rb_eqcirc
            // 
            this.rb_eqcirc.AutoSize = true;
            this.rb_eqcirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eqcirc.ForeColor = System.Drawing.Color.Black;
            this.rb_eqcirc.Location = new System.Drawing.Point(21, 20);
            this.rb_eqcirc.Name = "rb_eqcirc";
            this.rb_eqcirc.Size = new System.Drawing.Size(142, 19);
            this.rb_eqcirc.TabIndex = 0;
            this.rb_eqcirc.TabStop = true;
            this.rb_eqcirc.Text = "Eq. da Circunferência";
            this.rb_eqcirc.UseVisualStyleBackColor = true;
            this.rb_eqcirc.CheckedChanged += new System.EventHandler(this.rb_eqcirc_CheckedChanged);
            // 
            // gb_elipse
            // 
            this.gb_elipse.BackColor = System.Drawing.Color.Transparent;
            this.gb_elipse.Controls.Add(this.rb_elipse);
            this.gb_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_elipse.ForeColor = System.Drawing.Color.Black;
            this.gb_elipse.Location = new System.Drawing.Point(6, 233);
            this.gb_elipse.Name = "gb_elipse";
            this.gb_elipse.Size = new System.Drawing.Size(198, 51);
            this.gb_elipse.TabIndex = 4;
            this.gb_elipse.TabStop = false;
            this.gb_elipse.Text = "Elipse";
            this.gb_elipse.Enter += new System.EventHandler(this.gb_elipse_Enter);
            // 
            // rb_elipse
            // 
            this.rb_elipse.AutoSize = true;
            this.rb_elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_elipse.ForeColor = System.Drawing.Color.Black;
            this.rb_elipse.Location = new System.Drawing.Point(21, 20);
            this.rb_elipse.Name = "rb_elipse";
            this.rb_elipse.Size = new System.Drawing.Size(95, 19);
            this.rb_elipse.TabIndex = 0;
            this.rb_elipse.TabStop = true;
            this.rb_elipse.Text = "Ponto Médio";
            this.rb_elipse.UseVisualStyleBackColor = true;
            this.rb_elipse.CheckedChanged += new System.EventHandler(this.rb_elipse_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 488);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_primitivas);
            this.tabPage1.Controls.Add(this.gb_elipse);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primitivas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lv_poligonos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(214, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polígonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cb_transf);
            this.panel1.Controls.Add(this.tb_y);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_translacao);
            this.panel1.Controls.Add(this.tb_x);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 125);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(29, 63);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(47, 20);
            this.tb_y.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y:";
            // 
            // bt_translacao
            // 
            this.bt_translacao.Location = new System.Drawing.Point(18, 94);
            this.bt_translacao.Name = "bt_translacao";
            this.bt_translacao.Size = new System.Drawing.Size(62, 23);
            this.bt_translacao.TabIndex = 12;
            this.bt_translacao.Text = "Aplicar";
            this.bt_translacao.UseVisualStyleBackColor = true;
            this.bt_translacao.Click += new System.EventHandler(this.bt_translacao_Click);
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(29, 39);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(47, 20);
            this.tb_x.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "X:";
            // 
            // lv_poligonos
            // 
            this.lv_poligonos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.cx,
            this.cy});
            this.lv_poligonos.FullRowSelect = true;
            this.lv_poligonos.HideSelection = false;
            this.lv_poligonos.Location = new System.Drawing.Point(8, 19);
            this.lv_poligonos.MultiSelect = false;
            this.lv_poligonos.Name = "lv_poligonos";
            this.lv_poligonos.Size = new System.Drawing.Size(198, 107);
            this.lv_poligonos.TabIndex = 6;
            this.lv_poligonos.UseCompatibleStateImageBehavior = false;
            this.lv_poligonos.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "Polígono";
            this.index.Width = 57;
            // 
            // cx
            // 
            this.cx.Text = "CentroX";
            // 
            // cy
            // 
            this.cy.Text = "CentroY";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tb_y2);
            this.panel2.Controls.Add(this.cb_trans);
            this.panel2.Controls.Add(this.bt_rotacao);
            this.panel2.Controls.Add(this.lb_y);
            this.panel2.Controls.Add(this.tb_angulo);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.lb_angulo);
            this.panel2.Controls.Add(this.tb_x2);
            this.panel2.Controls.Add(this.lb_x);
            this.panel2.Location = new System.Drawing.Point(8, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 143);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bt_rotacao
            // 
            this.bt_rotacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_rotacao.Location = new System.Drawing.Point(67, 113);
            this.bt_rotacao.Name = "bt_rotacao";
            this.bt_rotacao.Size = new System.Drawing.Size(62, 23);
            this.bt_rotacao.TabIndex = 12;
            this.bt_rotacao.Text = "Aplicar";
            this.bt_rotacao.UseVisualStyleBackColor = true;
            this.bt_rotacao.Click += new System.EventHandler(this.bt_rotacao_Click);
            // 
            // tb_angulo
            // 
            this.tb_angulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_angulo.Location = new System.Drawing.Point(127, 51);
            this.tb_angulo.Name = "tb_angulo";
            this.tb_angulo.Size = new System.Drawing.Size(47, 20);
            this.tb_angulo.TabIndex = 7;
            // 
            // lb_angulo
            // 
            this.lb_angulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_angulo.AutoSize = true;
            this.lb_angulo.Location = new System.Drawing.Point(127, 35);
            this.lb_angulo.Name = "lb_angulo";
            this.lb_angulo.Size = new System.Drawing.Size(40, 13);
            this.lb_angulo.TabIndex = 9;
            this.lb_angulo.Text = "Ângulo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rb_centro);
            this.groupBox2.Controls.Add(this.rb_origem);
            this.groupBox2.Location = new System.Drawing.Point(10, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Em relação";
            // 
            // rb_origem
            // 
            this.rb_origem.AutoSize = true;
            this.rb_origem.Checked = true;
            this.rb_origem.Location = new System.Drawing.Point(6, 42);
            this.rb_origem.Name = "rb_origem";
            this.rb_origem.Size = new System.Drawing.Size(56, 17);
            this.rb_origem.TabIndex = 6;
            this.rb_origem.TabStop = true;
            this.rb_origem.Text = "origem";
            this.rb_origem.UseVisualStyleBackColor = true;
            this.rb_origem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_centro
            // 
            this.rb_centro.AutoSize = true;
            this.rb_centro.Location = new System.Drawing.Point(6, 19);
            this.rb_centro.Name = "rb_centro";
            this.rb_centro.Size = new System.Drawing.Size(55, 17);
            this.rb_centro.TabIndex = 16;
            this.rb_centro.Text = "centro";
            this.rb_centro.UseVisualStyleBackColor = true;
            // 
            // cb_transf
            // 
            this.cb_transf.FormattingEnabled = true;
            this.cb_transf.Items.AddRange(new object[] {
            "Translação"});
            this.cb_transf.Location = new System.Drawing.Point(14, 9);
            this.cb_transf.Name = "cb_transf";
            this.cb_transf.Size = new System.Drawing.Size(91, 21);
            this.cb_transf.TabIndex = 16;
            // 
            // cb_trans
            // 
            this.cb_trans.FormattingEnabled = true;
            this.cb_trans.Items.AddRange(new object[] {
            "Rotação",
            "Escala"});
            this.cb_trans.Location = new System.Drawing.Point(10, 7);
            this.cb_trans.Name = "cb_trans";
            this.cb_trans.Size = new System.Drawing.Size(91, 21);
            this.cb_trans.TabIndex = 6;
            this.cb_trans.SelectedIndexChanged += new System.EventHandler(this.cb_trans_SelectedIndexChanged);
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(127, 66);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(47, 20);
            this.tb_y2.TabIndex = 19;
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Location = new System.Drawing.Point(109, 69);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(17, 13);
            this.lb_y.TabIndex = 20;
            this.lb_y.Text = "Y:";
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(127, 42);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(47, 20);
            this.tb_x2.TabIndex = 17;
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(109, 45);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(17, 13);
            this.lb_x.TabIndex = 18;
            this.lb_x.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(943, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pb_quadro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maria - Vinicius";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_primitivas.ResumeLayout(false);
            this.gb_primitivas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quadro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_elipse.ResumeLayout(false);
            this.gb_elipse.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_primitivas;
        private System.Windows.Forms.RadioButton rb_dda;
        private System.Windows.Forms.RadioButton rb_bresenham;
        private System.Windows.Forms.RadioButton rb_eqreta;
        private System.Windows.Forms.PictureBox pb_quadro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_eqtrig;
        private System.Windows.Forms.RadioButton rb_pontomedio;
        private System.Windows.Forms.RadioButton rb_eqcirc;
        private System.Windows.Forms.GroupBox gb_elipse;
        private System.Windows.Forms.RadioButton rb_elipse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lv_poligonos;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader cx;
        private System.Windows.Forms.ColumnHeader cy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_translacao;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_rotacao;
        private System.Windows.Forms.TextBox tb_angulo;
        private System.Windows.Forms.Label lb_angulo;
        private System.Windows.Forms.RadioButton rb_centro;
        private System.Windows.Forms.RadioButton rb_origem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_transf;
        private System.Windows.Forms.ComboBox cb_trans;
        private System.Windows.Forms.TextBox tb_y2;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.TextBox tb_x2;
        private System.Windows.Forms.Label lb_x;
    }
}

