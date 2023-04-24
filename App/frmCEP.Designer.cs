namespace agoravai
{
    partial class frmCEP
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
            this.btnSair = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLogradouroexc = new System.Windows.Forms.TextBox();
            this.btnbuscacepbd = new System.Windows.Forms.Button();
            this.txtcepbd = new System.Windows.Forms.MaskedTextBox();
            this.btnImporta = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btncep = new System.Windows.Forms.MaskedTextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtIbge = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtSiafi = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnloc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(383, 461);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.btnLimpar2);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtLogradouroexc);
            this.tabPage2.Controls.Add(this.btnbuscacepbd);
            this.tabPage2.Controls.Add(this.txtcepbd);
            this.tabPage2.Controls.Add(this.btnImporta);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnExportar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Importar/Exportar/Deletar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(114, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLogradouroexc
            // 
            this.txtLogradouroexc.Location = new System.Drawing.Point(114, 205);
            this.txtLogradouroexc.Name = "txtLogradouroexc";
            this.txtLogradouroexc.ReadOnly = true;
            this.txtLogradouroexc.Size = new System.Drawing.Size(226, 20);
            this.txtLogradouroexc.TabIndex = 5;
            // 
            // btnbuscacepbd
            // 
            this.btnbuscacepbd.Location = new System.Drawing.Point(7, 231);
            this.btnbuscacepbd.Name = "btnbuscacepbd";
            this.btnbuscacepbd.Size = new System.Drawing.Size(101, 23);
            this.btnbuscacepbd.TabIndex = 4;
            this.btnbuscacepbd.Text = "BUSCAR CEP";
            this.btnbuscacepbd.UseVisualStyleBackColor = true;
            this.btnbuscacepbd.Click += new System.EventHandler(this.btnbuscacepbd_Click);
            // 
            // txtcepbd
            // 
            this.txtcepbd.Location = new System.Drawing.Point(8, 205);
            this.txtcepbd.Mask = "00000-000";
            this.txtcepbd.Name = "txtcepbd";
            this.txtcepbd.Size = new System.Drawing.Size(100, 20);
            this.txtcepbd.TabIndex = 3;
            this.txtcepbd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnImporta
            // 
            this.btnImporta.Location = new System.Drawing.Point(174, 95);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(101, 23);
            this.btnImporta.TabIndex = 2;
            this.btnImporta.Text = "IMPORTAR";
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(6, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Deletar Dados do BD:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Importar Todos Dados para o BD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Exportar Todos os Dados do BD:";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(174, 42);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(101, 23);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btncep);
            this.tabPage1.Controls.Add(this.txtLocalidade);
            this.tabPage1.Controls.Add(this.txtUf);
            this.tabPage1.Controls.Add(this.txtLogradouro);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtIbge);
            this.tabPage1.Controls.Add(this.txtGia);
            this.tabPage1.Controls.Add(this.txtDdd);
            this.tabPage1.Controls.Add(this.txtSiafi);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnloc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta/Api";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(16, 29);
            this.btncep.Mask = "00000-000";
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(100, 20);
            this.btncep.TabIndex = 6;
            this.btncep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(87, 106);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.ReadOnly = true;
            this.txtLocalidade.Size = new System.Drawing.Size(228, 20);
            this.txtLocalidade.TabIndex = 1;
            this.txtLocalidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(87, 141);
            this.txtUf.Name = "txtUf";
            this.txtUf.ReadOnly = true;
            this.txtUf.Size = new System.Drawing.Size(228, 20);
            this.txtUf.TabIndex = 1;
            this.txtUf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(87, 177);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.Size = new System.Drawing.Size(228, 20);
            this.txtLogradouro.TabIndex = 1;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(87, 213);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(228, 20);
            this.txtComplemento.TabIndex = 1;
            this.txtComplemento.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 248);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(228, 20);
            this.txtBairro.TabIndex = 1;
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtIbge
            // 
            this.txtIbge.Location = new System.Drawing.Point(87, 284);
            this.txtIbge.Name = "txtIbge";
            this.txtIbge.ReadOnly = true;
            this.txtIbge.Size = new System.Drawing.Size(228, 20);
            this.txtIbge.TabIndex = 1;
            this.txtIbge.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(87, 319);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(228, 20);
            this.txtGia.TabIndex = 1;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(87, 355);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.ReadOnly = true;
            this.txtDdd.Size = new System.Drawing.Size(228, 20);
            this.txtDdd.TabIndex = 1;
            this.txtDdd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSiafi
            // 
            this.txtSiafi.Location = new System.Drawing.Point(87, 391);
            this.txtSiafi.Name = "txtSiafi";
            this.txtSiafi.ReadOnly = true;
            this.txtSiafi.Size = new System.Drawing.Size(228, 20);
            this.txtSiafi.TabIndex = 1;
            this.txtSiafi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(16, 426);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(299, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "LIMPAR PESQUISA";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Siafi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "DDD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "GIA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "IBGE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Complemento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logradouro:";
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(15, 55);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(300, 22);
            this.btnloc.TabIndex = 2;
            this.btnloc.Text = "CONSULTAR CEP";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(113, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dados Retorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localidade:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 483);
            this.tabControl1.TabIndex = 7;
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Location = new System.Drawing.Point(8, 260);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(332, 23);
            this.btnLimpar2.TabIndex = 7;
            this.btnLimpar2.Text = "LIMPAR PESQUISA";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(193, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 10);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(6, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 10);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(6, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 10);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(6, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(335, 10);
            this.panel6.TabIndex = 11;
            // 
            // frmCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Name = "frmCEP";
            this.Text = "Consulta CEP";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox txtcepbd;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox btncep;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtIbge;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtSiafi;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLogradouroexc;
        private System.Windows.Forms.Button btnbuscacepbd;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}

