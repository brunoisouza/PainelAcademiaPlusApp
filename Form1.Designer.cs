namespace PainelAcademiaPlusApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxIMC = new System.Windows.Forms.GroupBox();
            this.numericUpDownAltura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxContCal = new System.Windows.Forms.GroupBox();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.cbAtividade = new System.Windows.Forms.ComboBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.numPesoCalorias = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultadoCalorias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxHidratacao = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultadoHidratacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.groupBoxContCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCalorias)).BeginInit();
            this.groupBoxHidratacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIMC
            // 
            this.groupBoxIMC.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxIMC.Controls.Add(this.numericUpDownAltura);
            this.groupBoxIMC.Controls.Add(this.numericUpDownPeso);
            this.groupBoxIMC.Controls.Add(this.lblResultado);
            this.groupBoxIMC.Controls.Add(this.txtIMC);
            this.groupBoxIMC.Controls.Add(this.lblAltura);
            this.groupBoxIMC.Controls.Add(this.lblPeso);
            this.groupBoxIMC.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIMC.ForeColor = System.Drawing.Color.Red;
            this.groupBoxIMC.Location = new System.Drawing.Point(8, 8);
            this.groupBoxIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxIMC.Name = "groupBoxIMC";
            this.groupBoxIMC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxIMC.Size = new System.Drawing.Size(227, 164);
            this.groupBoxIMC.TabIndex = 0;
            this.groupBoxIMC.TabStop = false;
            this.groupBoxIMC.Text = "IMC";
            // 
            // numericUpDownAltura
            // 
            this.numericUpDownAltura.DecimalPlaces = 2;
            this.numericUpDownAltura.Location = new System.Drawing.Point(83, 62);
            this.numericUpDownAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownAltura.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownAltura.Name = "numericUpDownAltura";
            this.numericUpDownAltura.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownAltura.TabIndex = 2;
            this.numericUpDownAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAltura.ValueChanged += new System.EventHandler(this.numericUpDownAltura_ValueChanged);
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.DecimalPlaces = 2;
            this.numericUpDownPeso.Location = new System.Drawing.Point(83, 33);
            this.numericUpDownPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPeso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownPeso.TabIndex = 1;
            this.numericUpDownPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 100);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(88, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // txtIMC
            // 
            this.txtIMC.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(18, 115);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIMC.Multiline = true;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(187, 40);
            this.txtIMC.TabIndex = 0;
            this.txtIMC.TabStop = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 62);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(61, 15);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(15, 34);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(43, 15);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // groupBoxContCal
            // 
            this.groupBoxContCal.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBoxContCal.Controls.Add(this.numDuracao);
            this.groupBoxContCal.Controls.Add(this.lblAtividade);
            this.groupBoxContCal.Controls.Add(this.cbAtividade);
            this.groupBoxContCal.Controls.Add(this.lblDuracao);
            this.groupBoxContCal.Controls.Add(this.numPesoCalorias);
            this.groupBoxContCal.Controls.Add(this.label1);
            this.groupBoxContCal.Controls.Add(this.txtResultadoCalorias);
            this.groupBoxContCal.Controls.Add(this.label3);
            this.groupBoxContCal.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContCal.ForeColor = System.Drawing.Color.Green;
            this.groupBoxContCal.Location = new System.Drawing.Point(239, 8);
            this.groupBoxContCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxContCal.Name = "groupBoxContCal";
            this.groupBoxContCal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxContCal.Size = new System.Drawing.Size(227, 164);
            this.groupBoxContCal.TabIndex = 7;
            this.groupBoxContCal.TabStop = false;
            this.groupBoxContCal.Text = "Contador Calorias";
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(8, 23);
            this.lblAtividade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(88, 15);
            this.lblAtividade.TabIndex = 9;
            this.lblAtividade.Text = "Atividade";
            // 
            // cbAtividade
            // 
            this.cbAtividade.FormattingEnabled = true;
            this.cbAtividade.Items.AddRange(new object[] {
            "Musculação",
            "Corrida",
            "Bicicleta",
            "Dança"});
            this.cbAtividade.Location = new System.Drawing.Point(97, 23);
            this.cbAtividade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAtividade.Name = "cbAtividade";
            this.cbAtividade.Size = new System.Drawing.Size(121, 21);
            this.cbAtividade.TabIndex = 4;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(8, 51);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(70, 15);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "Duração";
            // 
            // numPesoCalorias
            // 
            this.numPesoCalorias.DecimalPlaces = 2;
            this.numPesoCalorias.Location = new System.Drawing.Point(97, 80);
            this.numPesoCalorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPesoCalorias.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPesoCalorias.Name = "numPesoCalorias";
            this.numPesoCalorias.Size = new System.Drawing.Size(120, 21);
            this.numPesoCalorias.TabIndex = 6;
            this.numPesoCalorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoCalorias.ValueChanged += new System.EventHandler(this.numPesoCalorias_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado";
            // 
            // txtResultadoCalorias
            // 
            this.txtResultadoCalorias.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoCalorias.Location = new System.Drawing.Point(18, 115);
            this.txtResultadoCalorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultadoCalorias.Multiline = true;
            this.txtResultadoCalorias.Name = "txtResultadoCalorias";
            this.txtResultadoCalorias.ReadOnly = true;
            this.txtResultadoCalorias.Size = new System.Drawing.Size(187, 40);
            this.txtResultadoCalorias.TabIndex = 0;
            this.txtResultadoCalorias.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peso";
            // 
            // groupBoxHidratacao
            // 
            this.groupBoxHidratacao.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxHidratacao.Controls.Add(this.numericUpDown2);
            this.groupBoxHidratacao.Controls.Add(this.label2);
            this.groupBoxHidratacao.Controls.Add(this.txtResultadoHidratacao);
            this.groupBoxHidratacao.Controls.Add(this.label5);
            this.groupBoxHidratacao.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHidratacao.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxHidratacao.Location = new System.Drawing.Point(8, 178);
            this.groupBoxHidratacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxHidratacao.Name = "groupBoxHidratacao";
            this.groupBoxHidratacao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxHidratacao.Size = new System.Drawing.Size(227, 164);
            this.groupBoxHidratacao.TabIndex = 7;
            this.groupBoxHidratacao.TabStop = false;
            this.groupBoxHidratacao.Text = "Metas Hidratação";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(79, 53);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(113, 21);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // txtResultadoHidratacao
            // 
            this.txtResultadoHidratacao.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoHidratacao.Location = new System.Drawing.Point(14, 118);
            this.txtResultadoHidratacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultadoHidratacao.Multiline = true;
            this.txtResultadoHidratacao.Name = "txtResultadoHidratacao";
            this.txtResultadoHidratacao.ReadOnly = true;
            this.txtResultadoHidratacao.Size = new System.Drawing.Size(187, 40);
            this.txtResultadoHidratacao.TabIndex = 0;
            this.txtResultadoHidratacao.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Peso";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(239, 178);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(97, 51);
            this.numDuracao.Margin = new System.Windows.Forms.Padding(2);
            this.numDuracao.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(120, 21);
            this.numDuracao.TabIndex = 5;
            this.numDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuracao.ValueChanged += new System.EventHandler(this.numDuracao_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(475, 352);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBoxHidratacao);
            this.Controls.Add(this.groupBoxContCal);
            this.Controls.Add(this.groupBoxIMC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Painel Academia";
            this.groupBoxIMC.ResumeLayout(false);
            this.groupBoxIMC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.groupBoxContCal.ResumeLayout(false);
            this.groupBoxContCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCalorias)).EndInit();
            this.groupBoxHidratacao.ResumeLayout(false);
            this.groupBoxHidratacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.NumericUpDown numericUpDownAltura;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.GroupBox groupBoxContCal;
        private System.Windows.Forms.NumericUpDown numPesoCalorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultadoCalorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.GroupBox groupBoxHidratacao;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultadoHidratacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbAtividade;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.NumericUpDown numDuracao;
    }
}

