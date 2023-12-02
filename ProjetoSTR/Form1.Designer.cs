namespace ProjetoSTR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            tabPage2 = new TabPage();
            textBoxTeste = new TextBox();
            groupBox10 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            numericUpDownQtdePacotes = new NumericUpDown();
            numericUpDownQtdePacotesMesmaArea = new NumericUpDown();
            textBoxLong = new TextBox();
            textBoxLat = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            groupBox8 = new GroupBox();
            formsPlotMdulo2 = new ScottPlot.FormsPlot();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            btAnalisarUnidade = new Button();
            comboBoxListaUnidadesGeradoras = new ComboBox();
            groupBox5 = new GroupBox();
            formsPlot4 = new ScottPlot.FormsPlot();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            groupBox7 = new GroupBox();
            textboxBuffer = new TextBox();
            formsPlot3 = new ScottPlot.FormsPlot();
            formsPlot2 = new ScottPlot.FormsPlot();
            formsPlot1 = new ScottPlot.FormsPlot();
            groupBox2 = new GroupBox();
            buttonPararEnvioV1 = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            listViewMod1UnidGeradora = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            buttonIniciarMod1Iniciar = new Button();
            groupBox1 = new GroupBox();
            buttonAdicionar = new Button();
            numericUpDownMod1Curto = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownMod1FreqEnvio = new NumericUpDown();
            numericUpDownMod1Corrente = new NumericUpDown();
            numericUpDownMod1CodUnidGen = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdePacotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdePacotesMesmaArea).BeginInit();
            groupBox8.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1Curto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1FreqEnvio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1Corrente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1CodUnidGen).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(textBoxTeste);
            tabPage2.Controls.Add(groupBox10);
            tabPage2.Controls.Add(groupBox8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1111, 728);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Módulo 2";
            // 
            // textBoxTeste
            // 
            textBoxTeste.Location = new Point(679, 536);
            textBoxTeste.Multiline = true;
            textBoxTeste.Name = "textBoxTeste";
            textBoxTeste.ScrollBars = ScrollBars.Both;
            textBoxTeste.Size = new Size(367, 138);
            textBoxTeste.TabIndex = 5;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(button3);
            groupBox10.Controls.Add(button1);
            groupBox10.Controls.Add(numericUpDownQtdePacotes);
            groupBox10.Controls.Add(numericUpDownQtdePacotesMesmaArea);
            groupBox10.Controls.Add(textBoxLong);
            groupBox10.Controls.Add(textBoxLat);
            groupBox10.Controls.Add(label6);
            groupBox10.Controls.Add(label8);
            groupBox10.Controls.Add(label5);
            groupBox10.Controls.Add(label7);
            groupBox10.Location = new Point(11, 527);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(582, 198);
            groupBox10.TabIndex = 4;
            groupBox10.TabStop = false;
            groupBox10.Text = "groupBox10";
            // 
            // button3
            // 
            button3.Location = new Point(431, 123);
            button3.Name = "button3";
            button3.Size = new Size(131, 53);
            button3.TabIndex = 9;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(431, 31);
            button1.Name = "button1";
            button1.Size = new Size(131, 53);
            button1.TabIndex = 8;
            button1.Text = "Plotar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownQtdePacotes
            // 
            numericUpDownQtdePacotes.Location = new Point(253, 31);
            numericUpDownQtdePacotes.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownQtdePacotes.Name = "numericUpDownQtdePacotes";
            numericUpDownQtdePacotes.Size = new Size(142, 27);
            numericUpDownQtdePacotes.TabIndex = 5;
            numericUpDownQtdePacotes.Value = new decimal(new int[] { 30000, 0, 0, 0 });
            // 
            // numericUpDownQtdePacotesMesmaArea
            // 
            numericUpDownQtdePacotesMesmaArea.Location = new Point(253, 70);
            numericUpDownQtdePacotesMesmaArea.Name = "numericUpDownQtdePacotesMesmaArea";
            numericUpDownQtdePacotesMesmaArea.Size = new Size(142, 27);
            numericUpDownQtdePacotesMesmaArea.TabIndex = 6;
            numericUpDownQtdePacotesMesmaArea.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // textBoxLong
            // 
            textBoxLong.Location = new Point(115, 148);
            textBoxLong.Name = "textBoxLong";
            textBoxLong.Size = new Size(280, 27);
            textBoxLong.TabIndex = 7;
            textBoxLong.Text = "-3,3203";
            // 
            // textBoxLat
            // 
            textBoxLat.Location = new Point(115, 109);
            textBoxLat.Name = "textBoxLat";
            textBoxLat.Size = new Size(280, 27);
            textBoxLat.TabIndex = 6;
            textBoxLat.Text = "21,9321";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 64);
            label6.Name = "label6";
            label6.Size = new Size(231, 20);
            label6.TabIndex = 1;
            label6.Text = "Quantidade pacotes mesma área:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 148);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 3;
            label8.Text = "Longitude:";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 31);
            label5.Name = "label5";
            label5.Size = new Size(202, 20);
            label5.TabIndex = 0;
            label5.Text = "Quantidade total de pacotes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 109);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 2;
            label7.Text = "Latitude:";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(formsPlotMdulo2);
            groupBox8.Location = new Point(8, 7);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1095, 514);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "groupBox8";
            // 
            // formsPlotMdulo2
            // 
            formsPlotMdulo2.Dock = DockStyle.Fill;
            formsPlotMdulo2.Location = new Point(3, 23);
            formsPlotMdulo2.Margin = new Padding(5, 4, 5, 4);
            formsPlotMdulo2.Name = "formsPlotMdulo2";
            formsPlotMdulo2.Size = new Size(1089, 488);
            formsPlotMdulo2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1111, 728);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Módulo 1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(9, 8);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(702, 712);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btAnalisarUnidade);
            groupBox6.Controls.Add(comboBoxListaUnidadesGeradoras);
            groupBox6.Location = new Point(9, 544);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(687, 161);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Plotar Unidade";
            // 
            // btAnalisarUnidade
            // 
            btAnalisarUnidade.Enabled = false;
            btAnalisarUnidade.Location = new Point(19, 84);
            btAnalisarUnidade.Name = "btAnalisarUnidade";
            btAnalisarUnidade.Size = new Size(115, 29);
            btAnalisarUnidade.TabIndex = 1;
            btAnalisarUnidade.Text = "Analisar";
            btAnalisarUnidade.UseVisualStyleBackColor = true;
            btAnalisarUnidade.Click += btAnalisarUnidade_Click;
            // 
            // comboBoxListaUnidadesGeradoras
            // 
            comboBoxListaUnidadesGeradoras.FormattingEnabled = true;
            comboBoxListaUnidadesGeradoras.Location = new Point(20, 40);
            comboBoxListaUnidadesGeradoras.Name = "comboBoxListaUnidadesGeradoras";
            comboBoxListaUnidadesGeradoras.Size = new Size(247, 28);
            comboBoxListaUnidadesGeradoras.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(formsPlot4);
            groupBox5.Controls.Add(listView1);
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(formsPlot3);
            groupBox5.Controls.Add(formsPlot2);
            groupBox5.Controls.Add(formsPlot1);
            groupBox5.Location = new Point(6, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(690, 538);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dados de Corrente";
            // 
            // formsPlot4
            // 
            formsPlot4.Location = new Point(289, 287);
            formsPlot4.Margin = new Padding(5, 4, 5, 4);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(280, 250);
            formsPlot4.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5 });
            listView1.Location = new Point(597, 119);
            listView1.Name = "listView1";
            listView1.Size = new Size(118, 363);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Unidades";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textboxBuffer);
            groupBox7.Location = new Point(577, 15);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(107, 98);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Buffer size";
            // 
            // textboxBuffer
            // 
            textboxBuffer.BackColor = Color.WhiteSmoke;
            textboxBuffer.BorderStyle = BorderStyle.None;
            textboxBuffer.ForeColor = SystemColors.WindowFrame;
            textboxBuffer.Location = new Point(9, 41);
            textboxBuffer.Name = "textboxBuffer";
            textboxBuffer.Size = new Size(92, 20);
            textboxBuffer.TabIndex = 0;
            textboxBuffer.Text = "0";
            textboxBuffer.TextAlign = HorizontalAlignment.Center;
            // 
            // formsPlot3
            // 
            formsPlot3.Location = new Point(8, 288);
            formsPlot3.Margin = new Padding(5, 4, 5, 4);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(280, 250);
            formsPlot3.TabIndex = 2;
            // 
            // formsPlot2
            // 
            formsPlot2.Location = new Point(289, 38);
            formsPlot2.Margin = new Padding(5, 4, 5, 4);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(280, 250);
            formsPlot2.TabIndex = 1;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(8, 38);
            formsPlot1.Margin = new Padding(5, 4, 5, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(280, 250);
            formsPlot1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonPararEnvioV1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(buttonIniciarMod1Iniciar);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(718, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(385, 712);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gerenciador de Pacotes";
            // 
            // buttonPararEnvioV1
            // 
            buttonPararEnvioV1.Location = new Point(190, 613);
            buttonPararEnvioV1.Margin = new Padding(3, 4, 3, 4);
            buttonPararEnvioV1.Name = "buttonPararEnvioV1";
            buttonPararEnvioV1.Size = new Size(144, 75);
            buttonPararEnvioV1.TabIndex = 2;
            buttonPararEnvioV1.Text = "Parar";
            buttonPararEnvioV1.UseVisualStyleBackColor = true;
            buttonPararEnvioV1.Click += buttonPararEnvioV1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(listViewMod1UnidGeradora);
            groupBox3.Location = new Point(18, 296);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(361, 287);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Unidades Geradoras";
            // 
            // button2
            // 
            button2.Location = new Point(254, 242);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 2;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listViewMod1UnidGeradora
            // 
            listViewMod1UnidGeradora.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewMod1UnidGeradora.Location = new Point(7, 29);
            listViewMod1UnidGeradora.Margin = new Padding(3, 4, 3, 4);
            listViewMod1UnidGeradora.Name = "listViewMod1UnidGeradora";
            listViewMod1UnidGeradora.Size = new Size(348, 205);
            listViewMod1UnidGeradora.TabIndex = 0;
            listViewMod1UnidGeradora.UseCompatibleStateImageBehavior = false;
            listViewMod1UnidGeradora.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cód. und. geradora";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Freq (ms)";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "I original";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "I curto";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonIniciarMod1Iniciar
            // 
            buttonIniciarMod1Iniciar.Location = new Point(35, 613);
            buttonIniciarMod1Iniciar.Margin = new Padding(3, 4, 3, 4);
            buttonIniciarMod1Iniciar.Name = "buttonIniciarMod1Iniciar";
            buttonIniciarMod1Iniciar.Size = new Size(144, 75);
            buttonIniciarMod1Iniciar.TabIndex = 1;
            buttonIniciarMod1Iniciar.Text = "Iniciar";
            buttonIniciarMod1Iniciar.UseVisualStyleBackColor = true;
            buttonIniciarMod1Iniciar.Click += buttonIniciarMod1Iniciar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdicionar);
            groupBox1.Controls.Add(numericUpDownMod1Curto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownMod1FreqEnvio);
            groupBox1.Controls.Add(numericUpDownMod1Corrente);
            groupBox1.Controls.Add(numericUpDownMod1CodUnidGen);
            groupBox1.Location = new Point(18, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(361, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gerador de Pacotes";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(7, 196);
            buttonAdicionar.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(348, 45);
            buttonAdicionar.TabIndex = 8;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // numericUpDownMod1Curto
            // 
            numericUpDownMod1Curto.Location = new Point(114, 149);
            numericUpDownMod1Curto.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMod1Curto.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownMod1Curto.Name = "numericUpDownMod1Curto";
            numericUpDownMod1Curto.Size = new Size(225, 27);
            numericUpDownMod1Curto.TabIndex = 7;
            numericUpDownMod1Curto.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(7, 149);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Valor curto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(7, 111);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "Valor corrente RMS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(7, 72);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "Freq. envio (ms):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 3;
            label1.Text = "Código unidade geradora:";
            // 
            // numericUpDownMod1FreqEnvio
            // 
            numericUpDownMod1FreqEnvio.Location = new Point(146, 72);
            numericUpDownMod1FreqEnvio.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMod1FreqEnvio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownMod1FreqEnvio.Name = "numericUpDownMod1FreqEnvio";
            numericUpDownMod1FreqEnvio.Size = new Size(193, 27);
            numericUpDownMod1FreqEnvio.TabIndex = 2;
            numericUpDownMod1FreqEnvio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownMod1Corrente
            // 
            numericUpDownMod1Corrente.Location = new Point(163, 111);
            numericUpDownMod1Corrente.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMod1Corrente.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownMod1Corrente.Name = "numericUpDownMod1Corrente";
            numericUpDownMod1Corrente.Size = new Size(176, 27);
            numericUpDownMod1Corrente.TabIndex = 1;
            numericUpDownMod1Corrente.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownMod1CodUnidGen
            // 
            numericUpDownMod1CodUnidGen.Enabled = false;
            numericUpDownMod1CodUnidGen.Location = new Point(202, 33);
            numericUpDownMod1CodUnidGen.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMod1CodUnidGen.Name = "numericUpDownMod1CodUnidGen";
            numericUpDownMod1CodUnidGen.Size = new Size(137, 27);
            numericUpDownMod1CodUnidGen.TabIndex = 0;
            numericUpDownMod1CodUnidGen.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1119, 761);
            tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 761);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdePacotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQtdePacotesMesmaArea).EndInit();
            groupBox8.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1Curto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1FreqEnvio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1Corrente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMod1CodUnidGen).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TabPage tabPage2;
        private TextBox textBoxTeste;
        private GroupBox groupBox10;
        private Button button3;
        private Button button1;
        private NumericUpDown numericUpDownQtdePacotes;
        private NumericUpDown numericUpDownQtdePacotesMesmaArea;
        private TextBox textBoxLong;
        private TextBox textBoxLat;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label7;
        private GroupBox groupBox8;
        private ScottPlot.FormsPlot formsPlotMdulo2;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Button btAnalisarUnidade;
        private ComboBox comboBoxListaUnidadesGeradoras;
        private GroupBox groupBox5;
        private ScottPlot.FormsPlot formsPlot4;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox7;
        private TextBox textboxBuffer;
        private ScottPlot.FormsPlot formsPlot3;
        private ScottPlot.FormsPlot formsPlot2;
        private ScottPlot.FormsPlot formsPlot1;
        private GroupBox groupBox2;
        private Button buttonPararEnvioV1;
        private GroupBox groupBox3;
        private Button button2;
        private ListView listViewMod1UnidGeradora;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonIniciarMod1Iniciar;
        private GroupBox groupBox1;
        private Button buttonAdicionar;
        private NumericUpDown numericUpDownMod1Curto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownMod1FreqEnvio;
        private NumericUpDown numericUpDownMod1Corrente;
        private NumericUpDown numericUpDownMod1CodUnidGen;
        private TabControl tabControl1;
    }
}