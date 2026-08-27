namespace WinFormsJsonParser;

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
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblHeaderSubtitle = new System.Windows.Forms.Label();
        this.lblHeaderTitle = new System.Windows.Forms.Label();
        this.tabMain = new System.Windows.Forms.TabControl();
        this.tabSoccerParser = new System.Windows.Forms.TabPage();
        this.pnlLeft = new System.Windows.Forms.Panel();
        this.btnProcessarJson = new System.Windows.Forms.Button();
        this.txtRawJson = new System.Windows.Forms.TextBox();
        this.lblRawJson = new System.Windows.Forms.Label();
        this.btnCarregarExemplo = new System.Windows.Forms.Button();
        this.btnCarregarUrl = new System.Windows.Forms.Button();
        this.txtUrlJson = new System.Windows.Forms.TextBox();
        this.lblUrlJson = new System.Windows.Forms.Label();
        this.lblLeftTitle = new System.Windows.Forms.Label();
        this.pnlCenter = new System.Windows.Forms.Panel();
        this.txtDadosTimeB = new System.Windows.Forms.TextBox();
        this.lblDadosTimeB = new System.Windows.Forms.Label();
        this.txtDadosTimeA = new System.Windows.Forms.TextBox();
        this.lblDadosTimeA = new System.Windows.Forms.Label();
        this.txtMediaGolsLiga = new System.Windows.Forms.TextBox();
        this.lblMediaGolsLiga = new System.Windows.Forms.Label();
        this.txtData = new System.Windows.Forms.TextBox();
        this.lblData = new System.Windows.Forms.Label();
        this.txtCompeticao = new System.Windows.Forms.TextBox();
        this.lblCompeticao = new System.Windows.Forms.Label();
        this.txtJogo = new System.Windows.Forms.TextBox();
        this.lblJogo = new System.Windows.Forms.Label();
        this.lblCenterTitle = new System.Windows.Forms.Label();
        this.pnlRight = new System.Windows.Forms.Panel();
        this.txtOutputFinal = new System.Windows.Forms.TextBox();
        this.lblOutputFinal = new System.Windows.Forms.Label();
        this.btnGerarProbabilidades = new System.Windows.Forms.Button();
        this.txtNoticias = new System.Windows.Forms.TextBox();
        this.lblNoticias = new System.Windows.Forms.Label();
        this.lblRightTitle = new System.Windows.Forms.Label();
        this.tabOddsCalculator = new System.Windows.Forms.TabPage();
        this.pnlOddsLeft = new System.Windows.Forms.Panel();
        this.btnProcessarOdds = new System.Windows.Forms.Button();
        this.btnCarregarExemploOdds = new System.Windows.Forms.Button();
        this.txtOddsJson = new System.Windows.Forms.TextBox();
        this.lblOddsJson = new System.Windows.Forms.Label();
        this.lblOddsLeftTitle = new System.Windows.Forms.Label();
        this.pnlOddsRight = new System.Windows.Forms.Panel();
        this.txtOddsOutput = new System.Windows.Forms.TextBox();
        this.lblOddsOutput = new System.Windows.Forms.Label();
        this.lblOddsRightTitle = new System.Windows.Forms.Label();
        this.tabAnalysis = new System.Windows.Forms.TabPage();
        this.pnlAnalysisLeft = new System.Windows.Forms.Panel();
        this.btnSalvarAnalise = new System.Windows.Forms.Button();
        this.btnProcessarAnalise = new System.Windows.Forms.Button();
        this.btnCarregarExemploAnalise = new System.Windows.Forms.Button();
        this.txtAnalysisJson = new System.Windows.Forms.TextBox();
        this.lblAnalysisJson = new System.Windows.Forms.Label();
        this.lblAnalysisLeftTitle = new System.Windows.Forms.Label();
        this.pnlAnalysisRight = new System.Windows.Forms.Panel();
        this.txtAnalysisRaciocinio = new System.Windows.Forms.TextBox();
        this.lblAnalysisRaciocinio = new System.Windows.Forms.Label();
        this.txtAnalysisResumoLesoes = new System.Windows.Forms.TextBox();
        this.lblAnalysisResumoLesoes = new System.Windows.Forms.Label();
        this.txtAnalysisOutput = new System.Windows.Forms.TextBox();
        this.lblAnalysisOutput = new System.Windows.Forms.Label();
        this.lblAnalysisRightTitle = new System.Windows.Forms.Label();
        this.tabOddsHistory = new System.Windows.Forms.TabPage();
        this.pnlHistoryLeft = new System.Windows.Forms.Panel();
        this.btnDeleteRecord = new System.Windows.Forms.Button();
        this.dgvHistory = new System.Windows.Forms.DataGridView();
        this.lblHistoryLeftTitle = new System.Windows.Forms.Label();
        this.pnlHistoryRight = new System.Windows.Forms.Panel();
        this.txtHistoryRaciocinio = new System.Windows.Forms.TextBox();
        this.lblHistoryRaciocinio = new System.Windows.Forms.Label();
        this.txtHistoryResumoLesoes = new System.Windows.Forms.TextBox();
        this.lblHistoryResumoLesoes = new System.Windows.Forms.Label();
        this.txtHistoryDetails = new System.Windows.Forms.TextBox();
        this.lblHistoryDetails = new System.Windows.Forms.Label();
        this.lblHistoryRightTitle = new System.Windows.Forms.Label();
        // 
        // Instanciação da Aba 5 (Odd's Realizadas)
        // 
        this.tabRealizedOdds = new System.Windows.Forms.TabPage();
        this.pnlRealizedLeft = new System.Windows.Forms.Panel();
        this.lblRealizedLeftTitle = new System.Windows.Forms.Label();
        this.txtRealizedInput = new System.Windows.Forms.TextBox();
        this.btnSaveRealized = new System.Windows.Forms.Button();
        this.lblFilterDateTitle = new System.Windows.Forms.Label();
        this.chkFilterDate = new System.Windows.Forms.CheckBox();
        this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
        this.lblDayTotal = new System.Windows.Forms.Label();
        this.pnlRealizedRight = new System.Windows.Forms.Panel();
        this.lblRealizedRightTitle = new System.Windows.Forms.Label();
        this.dgvRealized = new System.Windows.Forms.DataGridView();
        this.btnDeleteRealized = new System.Windows.Forms.Button();
        this.lblTotalResultTitle = new System.Windows.Forms.Label();
        this.lblTotalResultValue = new System.Windows.Forms.Label();

        this.pnlHeader.SuspendLayout();
        this.tabMain.SuspendLayout();
        this.tabSoccerParser.SuspendLayout();
        this.pnlLeft.SuspendLayout();
        this.pnlCenter.SuspendLayout();
        this.pnlRight.SuspendLayout();
        this.tabOddsCalculator.SuspendLayout();
        this.pnlOddsLeft.SuspendLayout();
        this.pnlOddsRight.SuspendLayout();
        this.tabAnalysis.SuspendLayout();
        this.pnlAnalysisLeft.SuspendLayout();
        this.pnlAnalysisRight.SuspendLayout();
        this.tabOddsHistory.SuspendLayout();
        this.pnlHistoryLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
        this.pnlHistoryRight.SuspendLayout();
        this.tabRealizedOdds.SuspendLayout();
        this.pnlRealizedLeft.SuspendLayout();
        this.pnlRealizedRight.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRealized)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
        this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
        this.pnlHeader.Controls.Add(this.lblHeaderTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(1200, 70);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblHeaderSubtitle
        // 
        this.lblHeaderSubtitle.AutoSize = true;
        this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblHeaderSubtitle.Location = new System.Drawing.Point(15, 40);
        this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
        this.lblHeaderSubtitle.Size = new System.Drawing.Size(306, 15);
        this.lblHeaderSubtitle.TabIndex = 1;
        this.lblHeaderSubtitle.Text = "Importador de Estatísticas e Gerador Automático de Probabilidades";
        // 
        // lblHeaderTitle
        // 
        this.lblHeaderTitle.AutoSize = true;
        this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
        this.lblHeaderTitle.Location = new System.Drawing.Point(12, 10);
        this.lblHeaderTitle.Name = "lblHeaderTitle";
        this.lblHeaderTitle.Size = new System.Drawing.Size(360, 30);
        this.lblHeaderTitle.TabIndex = 0;
        this.lblHeaderTitle.Text = "SOCCER ANALYTICS & PREDICTIONS";
        // 
        // tabMain
        // 
        this.tabMain.Controls.Add(this.tabSoccerParser);
        this.tabMain.Controls.Add(this.tabOddsCalculator);
        this.tabMain.Controls.Add(this.tabAnalysis);
        this.tabMain.Controls.Add(this.tabOddsHistory);
        this.tabMain.Controls.Add(this.tabRealizedOdds);
        this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
        this.tabMain.ItemSize = new System.Drawing.Size(200, 35);
        this.tabMain.Location = new System.Drawing.Point(0, 70);
        this.tabMain.Name = "tabMain";
        this.tabMain.SelectedIndex = 0;
        this.tabMain.Size = new System.Drawing.Size(1200, 740);
        this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        this.tabMain.TabIndex = 1;
        // 
        // tabSoccerParser
        // 
        this.tabSoccerParser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.tabSoccerParser.Controls.Add(this.pnlLeft);
        this.tabSoccerParser.Controls.Add(this.pnlCenter);
        this.tabSoccerParser.Controls.Add(this.pnlRight);
        this.tabSoccerParser.Location = new System.Drawing.Point(4, 39);
        this.tabSoccerParser.Name = "tabSoccerParser";
        this.tabSoccerParser.Size = new System.Drawing.Size(1192, 697);
        this.tabSoccerParser.TabIndex = 0;
        this.tabSoccerParser.Text = "Mapeador de Estatísticas";
        // 
        // pnlLeft
        // 
        this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlLeft.Controls.Add(this.btnProcessarJson);
        this.pnlLeft.Controls.Add(this.txtRawJson);
        this.pnlLeft.Controls.Add(this.lblRawJson);
        this.pnlLeft.Controls.Add(this.btnCarregarExemplo);
        this.pnlLeft.Controls.Add(this.btnCarregarUrl);
        this.pnlLeft.Controls.Add(this.txtUrlJson);
        this.pnlLeft.Controls.Add(this.lblUrlJson);
        this.pnlLeft.Controls.Add(this.lblLeftTitle);
        this.pnlLeft.Location = new System.Drawing.Point(10, 10);
        this.pnlLeft.Name = "pnlLeft";
        this.pnlLeft.Size = new System.Drawing.Size(375, 675);
        this.pnlLeft.TabIndex = 1;
        // 
        // btnProcessarJson
        // 
        this.btnProcessarJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
        this.btnProcessarJson.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnProcessarJson.FlatAppearance.BorderSize = 0;
        this.btnProcessarJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnProcessarJson.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnProcessarJson.ForeColor = System.Drawing.Color.White;
        this.btnProcessarJson.Location = new System.Drawing.Point(15, 625);
        this.btnProcessarJson.Name = "btnProcessarJson";
        this.btnProcessarJson.Size = new System.Drawing.Size(345, 35);
        this.btnProcessarJson.TabIndex = 7;
        this.btnProcessarJson.Text = "Processar JSON Bruto";
        this.btnProcessarJson.UseVisualStyleBackColor = false;
        // 
        // txtRawJson
        // 
        this.txtRawJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtRawJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtRawJson.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtRawJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
        this.txtRawJson.Location = new System.Drawing.Point(15, 150);
        this.txtRawJson.Multiline = true;
        this.txtRawJson.Name = "txtRawJson";
        this.txtRawJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtRawJson.Size = new System.Drawing.Size(345, 460);
        this.txtRawJson.TabIndex = 6;
        // 
        // lblRawJson
        // 
        this.lblRawJson.AutoSize = true;
        this.lblRawJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblRawJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblRawJson.Location = new System.Drawing.Point(15, 130);
        this.lblRawJson.Name = "lblRawJson";
        this.lblRawJson.Size = new System.Drawing.Size(126, 15);
        this.lblRawJson.TabIndex = 5;
        this.lblRawJson.Text = "Ou cole o JSON abaixo:";
        // 
        // btnCarregarExemplo
        // 
        this.btnCarregarExemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
        this.btnCarregarExemplo.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCarregarExemplo.FlatAppearance.BorderSize = 0;
        this.btnCarregarExemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCarregarExemplo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCarregarExemplo.ForeColor = System.Drawing.Color.White;
        this.btnCarregarExemplo.Location = new System.Drawing.Point(190, 90);
        this.btnCarregarExemplo.Name = "btnCarregarExemplo";
        this.btnCarregarExemplo.Size = new System.Drawing.Size(170, 30);
        this.btnCarregarExemplo.TabIndex = 4;
        this.btnCarregarExemplo.Text = "Carregar Exemplo";
        this.btnCarregarExemplo.UseVisualStyleBackColor = false;
        // 
        // btnCarregarUrl
        // 
        this.btnCarregarUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
        this.btnCarregarUrl.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCarregarUrl.FlatAppearance.BorderSize = 0;
        this.btnCarregarUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCarregarUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCarregarUrl.ForeColor = System.Drawing.Color.White;
        this.btnCarregarUrl.Location = new System.Drawing.Point(15, 90);
        this.btnCarregarUrl.Name = "btnCarregarUrl";
        this.btnCarregarUrl.Size = new System.Drawing.Size(170, 30);
        this.btnCarregarUrl.TabIndex = 3;
        this.btnCarregarUrl.Text = "Carregar URL";
        this.btnCarregarUrl.UseVisualStyleBackColor = false;
        // 
        // txtUrlJson
        // 
        this.txtUrlJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtUrlJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtUrlJson.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtUrlJson.ForeColor = System.Drawing.Color.White;
        this.txtUrlJson.Location = new System.Drawing.Point(15, 55);
        this.txtUrlJson.Name = "txtUrlJson";
        this.txtUrlJson.Size = new System.Drawing.Size(345, 24);
        this.txtUrlJson.TabIndex = 2;
        // 
        // lblUrlJson
        // 
        this.lblUrlJson.AutoSize = true;
        this.lblUrlJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblUrlJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblUrlJson.Location = new System.Drawing.Point(15, 35);
        this.lblUrlJson.Name = "lblUrlJson";
        this.lblUrlJson.Size = new System.Drawing.Size(130, 15);
        this.lblUrlJson.TabIndex = 1;
        this.lblUrlJson.Text = "URL do JSON [URL_JSON]:";
        // 
        // lblLeftTitle
        // 
        this.lblLeftTitle.AutoSize = true;
        this.lblLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblLeftTitle.Location = new System.Drawing.Point(15, 10);
        this.lblLeftTitle.Name = "lblLeftTitle";
        this.lblLeftTitle.Size = new System.Drawing.Size(161, 20);
        this.lblLeftTitle.TabIndex = 0;
        this.lblLeftTitle.Text = "1. ENTRADA DE DADOS";
        // 
        // pnlCenter
        // 
        this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlCenter.Controls.Add(this.txtDadosTimeB);
        this.pnlCenter.Controls.Add(this.lblDadosTimeB);
        this.pnlCenter.Controls.Add(this.txtDadosTimeA);
        this.pnlCenter.Controls.Add(this.lblDadosTimeA);
        this.pnlCenter.Controls.Add(this.txtMediaGolsLiga);
        this.pnlCenter.Controls.Add(this.lblMediaGolsLiga);
        this.pnlCenter.Controls.Add(this.txtData);
        this.pnlCenter.Controls.Add(this.lblData);
        this.pnlCenter.Controls.Add(this.txtCompeticao);
        this.pnlCenter.Controls.Add(this.lblCompeticao);
        this.pnlCenter.Controls.Add(this.txtJogo);
        this.pnlCenter.Controls.Add(this.lblJogo);
        this.pnlCenter.Controls.Add(this.lblCenterTitle);
        this.pnlCenter.Location = new System.Drawing.Point(400, 10);
        this.pnlCenter.Name = "pnlCenter";
        this.pnlCenter.Size = new System.Drawing.Size(375, 675);
        this.pnlCenter.TabIndex = 2;
        // 
        // txtDadosTimeB
        // 
        this.txtDadosTimeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtDadosTimeB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDadosTimeB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtDadosTimeB.ForeColor = System.Drawing.Color.White;
        this.txtDadosTimeB.Location = new System.Drawing.Point(15, 540);
        this.txtDadosTimeB.Multiline = true;
        this.txtDadosTimeB.Name = "txtDadosTimeB";
        this.txtDadosTimeB.Size = new System.Drawing.Size(345, 120);
        this.txtDadosTimeB.TabIndex = 12;
        // 
        // lblDadosTimeB
        // 
        this.lblDadosTimeB.AutoSize = true;
        this.lblDadosTimeB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDadosTimeB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblDadosTimeB.Location = new System.Drawing.Point(15, 520);
        this.lblDadosTimeB.Name = "lblDadosTimeB";
        this.lblDadosTimeB.Size = new System.Drawing.Size(176, 15);
        this.lblDadosTimeB.TabIndex = 11;
        this.lblDadosTimeB.Text = "Dados Time B [DADOS_TIME_B]:";
        // 
        // txtDadosTimeA
        // 
        this.txtDadosTimeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtDadosTimeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDadosTimeA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtDadosTimeA.ForeColor = System.Drawing.Color.White;
        this.txtDadosTimeA.Location = new System.Drawing.Point(15, 385);
        this.txtDadosTimeA.Multiline = true;
        this.txtDadosTimeA.Name = "txtDadosTimeA";
        this.txtDadosTimeA.Size = new System.Drawing.Size(345, 120);
        this.txtDadosTimeA.TabIndex = 10;
        // 
        // lblDadosTimeA
        // 
        this.lblDadosTimeA.AutoSize = true;
        this.lblDadosTimeA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDadosTimeA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblDadosTimeA.Location = new System.Drawing.Point(15, 365);
        this.lblDadosTimeA.Name = "lblDadosTimeA";
        this.lblDadosTimeA.Size = new System.Drawing.Size(177, 15);
        this.lblDadosTimeA.TabIndex = 9;
        this.lblDadosTimeA.Text = "Dados Time A [DADOS_TIME_A]:";
        // 
        // txtMediaGolsLiga
        // 
        this.txtMediaGolsLiga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtMediaGolsLiga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtMediaGolsLiga.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtMediaGolsLiga.ForeColor = System.Drawing.Color.White;
        this.txtMediaGolsLiga.Location = new System.Drawing.Point(15, 315);
        this.txtMediaGolsLiga.Name = "txtMediaGolsLiga";
        this.txtMediaGolsLiga.Size = new System.Drawing.Size(345, 24);
        this.txtMediaGolsLiga.TabIndex = 8;
        this.txtMediaGolsLiga.Text = "2.68";
        // 
        // lblMediaGolsLiga
        // 
        this.lblMediaGolsLiga.AutoSize = true;
        this.lblMediaGolsLiga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblMediaGolsLiga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblMediaGolsLiga.Location = new System.Drawing.Point(15, 295);
        this.lblMediaGolsLiga.Name = "lblMediaGolsLiga";
        this.lblMediaGolsLiga.Size = new System.Drawing.Size(189, 15);
        this.lblMediaGolsLiga.TabIndex = 7;
        this.lblMediaGolsLiga.Text = "Média de Gols Liga [MÉDIA_GOLS_LIGA]:";
        // 
        // txtData
        // 
        this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtData.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtData.ForeColor = System.Drawing.Color.White;
        this.txtData.Location = new System.Drawing.Point(15, 245);
        this.txtData.Name = "txtData";
        this.txtData.Size = new System.Drawing.Size(345, 24);
        this.txtData.TabIndex = 6;
        // 
        // lblData
        // 
        this.lblData.AutoSize = true;
        this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblData.Location = new System.Drawing.Point(15, 225);
        this.lblData.Name = "lblData";
        this.lblData.Size = new System.Drawing.Size(76, 15);
        this.lblData.TabIndex = 5;
        this.lblData.Text = "Data [DATA]:";
        // 
        // txtCompeticao
        // 
        this.txtCompeticao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtCompeticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtCompeticao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtCompeticao.ForeColor = System.Drawing.Color.White;
        this.txtCompeticao.Location = new System.Drawing.Point(15, 175);
        this.txtCompeticao.Name = "txtCompeticao";
        this.txtCompeticao.Size = new System.Drawing.Size(345, 24);
        this.txtCompeticao.TabIndex = 4;
        // 
        // lblCompeticao
        // 
        this.lblCompeticao.AutoSize = true;
        this.lblCompeticao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblCompeticao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblCompeticao.Location = new System.Drawing.Point(15, 155);
        this.lblCompeticao.Name = "lblCompeticao";
        this.lblCompeticao.Size = new System.Drawing.Size(155, 15);
        this.lblCompeticao.TabIndex = 3;
        this.lblCompeticao.Text = "Competição [COMPETIÇÃO]:";
        // 
        // txtJogo
        // 
        this.txtJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtJogo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtJogo.ForeColor = System.Drawing.Color.White;
        this.txtJogo.Location = new System.Drawing.Point(15, 105);
        this.txtJogo.Name = "txtJogo";
        this.txtJogo.Size = new System.Drawing.Size(345, 24);
        this.txtJogo.TabIndex = 2;
        // 
        // lblJogo
        // 
        this.lblJogo.AutoSize = true;
        this.lblJogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblJogo.Location = new System.Drawing.Point(15, 85);
        this.lblJogo.Name = "lblJogo";
        this.lblJogo.Size = new System.Drawing.Size(77, 15);
        this.lblJogo.TabIndex = 1;
        this.lblJogo.Text = "Jogo [JOGO]:";
        // 
        // lblCenterTitle
        // 
        this.lblCenterTitle.AutoSize = true;
        this.lblCenterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblCenterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblCenterTitle.Location = new System.Drawing.Point(15, 10);
        this.lblCenterTitle.Name = "lblCenterTitle";
        this.lblCenterTitle.Size = new System.Drawing.Size(256, 20);
        this.lblCenterTitle.TabIndex = 0;
        this.lblCenterTitle.Text = "2. DADOS ESTATÍSTICOS MA-PEADOS";
        // 
        // pnlRight
        // 
        this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlRight.Controls.Add(this.txtOutputFinal);
        this.pnlRight.Controls.Add(this.lblOutputFinal);
        this.pnlRight.Controls.Add(this.btnGerarProbabilidades);
        this.pnlRight.Controls.Add(this.txtNoticias);
        this.pnlRight.Controls.Add(this.lblNoticias);
        this.pnlRight.Controls.Add(this.lblRightTitle);
        this.pnlRight.Location = new System.Drawing.Point(790, 10);
        this.pnlRight.Name = "pnlRight";
        this.pnlRight.Size = new System.Drawing.Size(390, 675);
        this.pnlRight.TabIndex = 3;
        // 
        // txtOutputFinal
        // 
        this.txtOutputFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtOutputFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtOutputFinal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtOutputFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
        this.txtOutputFinal.Location = new System.Drawing.Point(15, 380);
        this.txtOutputFinal.Multiline = true;
        this.txtOutputFinal.Name = "txtOutputFinal";
        this.txtOutputFinal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtOutputFinal.Size = new System.Drawing.Size(360, 280);
        this.txtOutputFinal.TabIndex = 6;
        // 
        // lblOutputFinal
        // 
        this.lblOutputFinal.AutoSize = true;
        this.lblOutputFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblOutputFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblOutputFinal.Location = new System.Drawing.Point(15, 360);
        this.lblOutputFinal.Name = "lblOutputFinal";
        this.lblOutputFinal.Size = new System.Drawing.Size(95, 15);
        this.lblOutputFinal.TabIndex = 5;
        this.lblOutputFinal.Text = "Resultado Gerado:";
        // 
        // btnGerarProbabilidades
        // 
        this.btnGerarProbabilidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
        this.btnGerarProbabilidades.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnGerarProbabilidades.FlatAppearance.BorderSize = 0;
        this.btnGerarProbabilidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnGerarProbabilidades.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnGerarProbabilidades.ForeColor = System.Drawing.Color.White;
        this.btnGerarProbabilidades.Location = new System.Drawing.Point(15, 305);
        this.btnGerarProbabilidades.Name = "btnGerarProbabilidades";
        this.btnGerarProbabilidades.Size = new System.Drawing.Size(360, 40);
        this.btnGerarProbabilidades.TabIndex = 4;
        this.btnGerarProbabilidades.Text = "Gerar Probabilidades";
        this.btnGerarProbabilidades.UseVisualStyleBackColor = false;
        // 
        // txtNoticias
        // 
        this.txtNoticias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtNoticias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNoticias.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtNoticias.ForeColor = System.Drawing.Color.White;
        this.txtNoticias.Location = new System.Drawing.Point(15, 55);
        this.txtNoticias.Multiline = true;
        this.txtNoticias.Name = "txtNoticias";
        this.txtNoticias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtNoticias.Size = new System.Drawing.Size(360, 235);
        this.txtNoticias.TabIndex = 3;
        // 
        // lblNoticias
        // 
        this.lblNoticias.AutoSize = true;
        this.lblNoticias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblNoticias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblNoticias.Location = new System.Drawing.Point(15, 35);
        this.lblNoticias.Name = "lblNoticias";
        this.lblNoticias.Size = new System.Drawing.Size(222, 15);
        this.lblNoticias.TabIndex = 2;
        this.lblNoticias.Text = "Notícias Relevantes [NOTÍCIAS RELEVANTES]:";
        // 
        // lblRightTitle
        // 
        this.lblRightTitle.AutoSize = true;
        this.lblRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblRightTitle.Location = new System.Drawing.Point(15, 10);
        this.lblRightTitle.Name = "lblRightTitle";
        this.lblRightTitle.Size = new System.Drawing.Size(183, 20);
        this.lblRightTitle.TabIndex = 0;
        this.lblRightTitle.Text = "3. RELATÓRIO E OUTPUT";
        // 
        // tabOddsCalculator
        // 
        this.tabOddsCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.tabOddsCalculator.Controls.Add(this.pnlOddsLeft);
        this.tabOddsCalculator.Controls.Add(this.pnlOddsRight);
        this.tabOddsCalculator.Location = new System.Drawing.Point(4, 39);
        this.tabOddsCalculator.Name = "tabOddsCalculator";
        this.tabOddsCalculator.Size = new System.Drawing.Size(1192, 697);
        this.tabOddsCalculator.TabIndex = 1;
        this.tabOddsCalculator.Text = "Cálculo de ODDs";
        // 
        // pnlOddsLeft
        // 
        this.pnlOddsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlOddsLeft.Controls.Add(this.btnProcessarOdds);
        this.pnlOddsLeft.Controls.Add(this.btnCarregarExemploOdds);
        this.pnlOddsLeft.Controls.Add(this.txtOddsJson);
        this.pnlOddsLeft.Controls.Add(this.lblOddsJson);
        this.pnlOddsLeft.Controls.Add(this.lblOddsLeftTitle);
        this.pnlOddsLeft.Location = new System.Drawing.Point(10, 10);
        this.pnlOddsLeft.Name = "pnlOddsLeft";
        this.pnlOddsLeft.Size = new System.Drawing.Size(575, 675);
        this.pnlOddsLeft.TabIndex = 0;
        // 
        // btnProcessarOdds
        // 
        this.btnProcessarOdds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
        this.btnProcessarOdds.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnProcessarOdds.FlatAppearance.BorderSize = 0;
        this.btnProcessarOdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnProcessarOdds.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnProcessarOdds.ForeColor = System.Drawing.Color.White;
        this.btnProcessarOdds.Location = new System.Drawing.Point(295, 625);
        this.btnProcessarOdds.Name = "btnProcessarOdds";
        this.btnProcessarOdds.Size = new System.Drawing.Size(265, 35);
        this.btnProcessarOdds.TabIndex = 4;
        this.btnProcessarOdds.Text = "Processar e Solicitar ODDs";
        this.btnProcessarOdds.UseVisualStyleBackColor = false;
        // 
        // btnCarregarExemploOdds
        // 
        this.btnCarregarExemploOdds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
        this.btnCarregarExemploOdds.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCarregarExemploOdds.FlatAppearance.BorderSize = 0;
        this.btnCarregarExemploOdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCarregarExemploOdds.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCarregarExemploOdds.ForeColor = System.Drawing.Color.White;
        this.btnCarregarExemploOdds.Location = new System.Drawing.Point(15, 625);
        this.btnCarregarExemploOdds.Name = "btnCarregarExemploOdds";
        this.btnCarregarExemploOdds.Size = new System.Drawing.Size(265, 35);
        this.btnCarregarExemploOdds.TabIndex = 3;
        this.btnCarregarExemploOdds.Text = "Carregar Exemplo";
        this.btnCarregarExemploOdds.UseVisualStyleBackColor = false;
        // 
        // txtOddsJson
        // 
        this.txtOddsJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtOddsJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtOddsJson.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtOddsJson.ForeColor = System.Drawing.Color.White;
        this.txtOddsJson.Location = new System.Drawing.Point(15, 60);
        this.txtOddsJson.Multiline = true;
        this.txtOddsJson.Name = "txtOddsJson";
        this.txtOddsJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtOddsJson.Size = new System.Drawing.Size(545, 545);
        this.txtOddsJson.TabIndex = 2;
        // 
        // lblOddsJson
        // 
        this.lblOddsJson.AutoSize = true;
        this.lblOddsJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblOddsJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblOddsJson.Location = new System.Drawing.Point(15, 40);
        this.lblOddsJson.Name = "lblOddsJson";
        this.lblOddsJson.Size = new System.Drawing.Size(188, 15);
        this.lblOddsJson.TabIndex = 1;
        this.lblOddsJson.Text = "JSON de Mercados Qualificados:";
        // 
        // lblOddsLeftTitle
        // 
        this.lblOddsLeftTitle.AutoSize = true;
        this.lblOddsLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblOddsLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblOddsLeftTitle.Location = new System.Drawing.Point(15, 10);
        this.lblOddsLeftTitle.Name = "lblOddsLeftTitle";
        this.lblOddsLeftTitle.Size = new System.Drawing.Size(262, 20);
        this.lblOddsLeftTitle.TabIndex = 0;
        this.lblOddsLeftTitle.Text = "1. ENTRADA DO JSON DE MERCADOS";
        // 
        // pnlOddsRight
        // 
        this.pnlOddsRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlOddsRight.Controls.Add(this.txtOddsOutput);
        this.pnlOddsRight.Controls.Add(this.lblOddsOutput);
        this.pnlOddsRight.Controls.Add(this.lblOddsRightTitle);
        this.pnlOddsRight.Location = new System.Drawing.Point(600, 10);
        this.pnlOddsRight.Name = "pnlOddsRight";
        this.pnlOddsRight.Size = new System.Drawing.Size(580, 675);
        this.pnlOddsRight.TabIndex = 1;
        // 
        // txtOddsOutput
        // 
        this.txtOddsOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtOddsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtOddsOutput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtOddsOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
        this.txtOddsOutput.Location = new System.Drawing.Point(15, 60);
        this.txtOddsOutput.Multiline = true;
        this.txtOddsOutput.Name = "txtOddsOutput";
        this.txtOddsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtOddsOutput.Size = new System.Drawing.Size(550, 600);
        this.txtOddsOutput.TabIndex = 2;
        // 
        // lblOddsOutput
        // 
        this.lblOddsOutput.AutoSize = true;
        this.lblOddsOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblOddsOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblOddsOutput.Location = new System.Drawing.Point(15, 40);
        this.lblOddsOutput.Name = "lblOddsOutput";
        this.lblOddsOutput.Size = new System.Drawing.Size(149, 15);
        this.lblOddsOutput.TabIndex = 1;
        this.lblOddsOutput.Text = "Saída Formatada de ODDs:";
        // 
        // lblOddsRightTitle
        // 
        this.lblOddsRightTitle.AutoSize = true;
        this.lblOddsRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblOddsRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblOddsRightTitle.Location = new System.Drawing.Point(15, 10);
        this.lblOddsRightTitle.Name = "lblOddsRightTitle";
        this.lblOddsRightTitle.Size = new System.Drawing.Size(206, 20);
        this.lblOddsRightTitle.TabIndex = 0;
        this.lblOddsRightTitle.Text = "2. RESULTADOS DO CÁLCULO";
        // 
        // tabAnalysis
        // 
        this.tabAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.tabAnalysis.Controls.Add(this.pnlAnalysisLeft);
        this.tabAnalysis.Controls.Add(this.pnlAnalysisRight);
        this.tabAnalysis.Location = new System.Drawing.Point(4, 39);
        this.tabAnalysis.Name = "tabAnalysis";
        this.tabAnalysis.Size = new System.Drawing.Size(1192, 697);
        this.tabAnalysis.TabIndex = 2;
        this.tabAnalysis.Text = "Analisa de Resultados";
        // 
        // pnlAnalysisLeft
        // 
        this.pnlAnalysisLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlAnalysisLeft.Controls.Add(this.btnSalvarAnalise);
        this.pnlAnalysisLeft.Controls.Add(this.btnProcessarAnalise);
        this.pnlAnalysisLeft.Controls.Add(this.btnCarregarExemploAnalise);
        this.pnlAnalysisLeft.Controls.Add(this.txtAnalysisJson);
        this.pnlAnalysisLeft.Controls.Add(this.lblAnalysisJson);
        this.pnlAnalysisLeft.Controls.Add(this.lblAnalysisLeftTitle);
        this.pnlAnalysisLeft.Location = new System.Drawing.Point(10, 10);
        this.pnlAnalysisLeft.Name = "pnlAnalysisLeft";
        this.pnlAnalysisLeft.Size = new System.Drawing.Size(575, 675);
        this.pnlAnalysisLeft.TabIndex = 0;
        // 
        // btnSalvarAnalise
        // 
        this.btnSalvarAnalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
        this.btnSalvarAnalise.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSalvarAnalise.FlatAppearance.BorderSize = 0;
        this.btnSalvarAnalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSalvarAnalise.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSalvarAnalise.ForeColor = System.Drawing.Color.White;
        this.btnSalvarAnalise.Location = new System.Drawing.Point(380, 625);
        this.btnSalvarAnalise.Name = "btnSalvarAnalise";
        this.btnSalvarAnalise.Size = new System.Drawing.Size(180, 35);
        this.btnSalvarAnalise.TabIndex = 5;
        this.btnSalvarAnalise.Text = "Salvar Resultados";
        this.btnSalvarAnalise.UseVisualStyleBackColor = false;
        // 
        // btnProcessarAnalise
        // 
        this.btnProcessarAnalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
        this.btnProcessarAnalise.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnProcessarAnalise.FlatAppearance.BorderSize = 0;
        this.btnProcessarAnalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnProcessarAnalise.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnProcessarAnalise.ForeColor = System.Drawing.Color.White;
        this.btnProcessarAnalise.Location = new System.Drawing.Point(195, 625);
        this.btnProcessarAnalise.Name = "btnProcessarAnalise";
        this.btnProcessarAnalise.Size = new System.Drawing.Size(175, 35);
        this.btnProcessarAnalise.TabIndex = 4;
        this.btnProcessarAnalise.Text = "Processar Análise";
        this.btnProcessarAnalise.UseVisualStyleBackColor = false;
        // 
        // btnCarregarExemploAnalise
        // 
        this.btnCarregarExemploAnalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
        this.btnCarregarExemploAnalise.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCarregarExemploAnalise.FlatAppearance.BorderSize = 0;
        this.btnCarregarExemploAnalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCarregarExemploAnalise.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnCarregarExemploAnalise.ForeColor = System.Drawing.Color.White;
        this.btnCarregarExemploAnalise.Location = new System.Drawing.Point(15, 625);
        this.btnCarregarExemploAnalise.Name = "btnCarregarExemploAnalise";
        this.btnCarregarExemploAnalise.Size = new System.Drawing.Size(170, 35);
        this.btnCarregarExemploAnalise.TabIndex = 3;
        this.btnCarregarExemploAnalise.Text = "Carregar Exemplo";
        this.btnCarregarExemploAnalise.UseVisualStyleBackColor = false;
        // 
        // txtAnalysisJson
        // 
        this.txtAnalysisJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtAnalysisJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtAnalysisJson.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtAnalysisJson.ForeColor = System.Drawing.Color.White;
        this.txtAnalysisJson.Location = new System.Drawing.Point(15, 60);
        this.txtAnalysisJson.Multiline = true;
        this.txtAnalysisJson.Name = "txtAnalysisJson";
        this.txtAnalysisJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAnalysisJson.Size = new System.Drawing.Size(545, 545);
        this.txtAnalysisJson.TabIndex = 2;
        // 
        // lblAnalysisJson
        // 
        this.lblAnalysisJson.AutoSize = true;
        this.lblAnalysisJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblAnalysisJson.Location = new System.Drawing.Point(15, 40);
        this.lblAnalysisJson.Name = "lblAnalysisJson";
        this.lblAnalysisJson.Size = new System.Drawing.Size(155, 15);
        this.lblAnalysisJson.TabIndex = 1;
        this.lblAnalysisJson.Text = "JSON de Análise de Partidas:";
        // 
        // lblAnalysisLeftTitle
        // 
        this.lblAnalysisLeftTitle.AutoSize = true;
        this.lblAnalysisLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblAnalysisLeftTitle.Location = new System.Drawing.Point(15, 10);
        this.lblAnalysisLeftTitle.Name = "lblAnalysisLeftTitle";
        this.lblAnalysisLeftTitle.Size = new System.Drawing.Size(183, 20);
        this.lblAnalysisLeftTitle.TabIndex = 0;
        this.lblAnalysisLeftTitle.Text = "1. ENTRADA DA ANÁLISE";
        // 
        // pnlAnalysisRight
        // 
        this.pnlAnalysisRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlAnalysisRight.Controls.Add(this.txtAnalysisRaciocinio);
        this.pnlAnalysisRight.Controls.Add(this.lblAnalysisRaciocinio);
        this.pnlAnalysisRight.Controls.Add(this.txtAnalysisResumoLesoes);
        this.pnlAnalysisRight.Controls.Add(this.lblAnalysisResumoLesoes);
        this.pnlAnalysisRight.Controls.Add(this.txtAnalysisOutput);
        this.pnlAnalysisRight.Controls.Add(this.lblAnalysisOutput);
        this.pnlAnalysisRight.Controls.Add(this.lblAnalysisRightTitle);
        this.pnlAnalysisRight.Location = new System.Drawing.Point(600, 10);
        this.pnlAnalysisRight.Name = "pnlAnalysisRight";
        this.pnlAnalysisRight.Size = new System.Drawing.Size(580, 675);
        this.pnlAnalysisRight.TabIndex = 1;
        // 
        // txtAnalysisRaciocinio
        // 
        this.txtAnalysisRaciocinio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtAnalysisRaciocinio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtAnalysisRaciocinio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtAnalysisRaciocinio.ForeColor = System.Drawing.Color.White;
        this.txtAnalysisRaciocinio.Location = new System.Drawing.Point(15, 500);
        this.txtAnalysisRaciocinio.Multiline = true;
        this.txtAnalysisRaciocinio.Name = "txtAnalysisRaciocinio";
        this.txtAnalysisRaciocinio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAnalysisRaciocinio.Size = new System.Drawing.Size(550, 160);
        this.txtAnalysisRaciocinio.TabIndex = 6;
        // 
        // lblAnalysisRaciocinio
        // 
        this.lblAnalysisRaciocinio.AutoSize = true;
        this.lblAnalysisRaciocinio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisRaciocinio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblAnalysisRaciocinio.Location = new System.Drawing.Point(15, 480);
        this.lblAnalysisRaciocinio.Name = "lblAnalysisRaciocinio";
        this.lblAnalysisRaciocinio.Size = new System.Drawing.Size(139, 15);
        this.lblAnalysisRaciocinio.TabIndex = 5;
        this.lblAnalysisRaciocinio.Text = "Raciocínio [RACIOCINIO]:";
        // 
        // txtAnalysisResumoLesoes
        // 
        this.txtAnalysisResumoLesoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtAnalysisResumoLesoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtAnalysisResumoLesoes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtAnalysisResumoLesoes.ForeColor = System.Drawing.Color.White;
        this.txtAnalysisResumoLesoes.Location = new System.Drawing.Point(15, 345);
        this.txtAnalysisResumoLesoes.Multiline = true;
        this.txtAnalysisResumoLesoes.Name = "txtAnalysisResumoLesoes";
        this.txtAnalysisResumoLesoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAnalysisResumoLesoes.Size = new System.Drawing.Size(550, 120);
        this.txtAnalysisResumoLesoes.TabIndex = 4;
        // 
        // lblAnalysisResumoLesoes
        // 
        this.lblAnalysisResumoLesoes.AutoSize = true;
        this.lblAnalysisResumoLesoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisResumoLesoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblAnalysisResumoLesoes.Location = new System.Drawing.Point(15, 325);
        this.lblAnalysisResumoLesoes.Name = "lblAnalysisResumoLesoes";
        this.lblAnalysisResumoLesoes.Size = new System.Drawing.Size(185, 15);
        this.lblAnalysisResumoLesoes.TabIndex = 3;
        this.lblAnalysisResumoLesoes.Text = "Resumo de Lesões [RESUMO_LESOES]:";
        // 
        // txtAnalysisOutput
        // 
        this.txtAnalysisOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtAnalysisOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtAnalysisOutput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtAnalysisOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
        this.txtAnalysisOutput.Location = new System.Drawing.Point(15, 60);
        this.txtAnalysisOutput.Multiline = true;
        this.txtAnalysisOutput.Name = "txtAnalysisOutput";
        this.txtAnalysisOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAnalysisOutput.Size = new System.Drawing.Size(550, 250);
        this.txtAnalysisOutput.TabIndex = 2;
        // 
        // lblAnalysisOutput
        // 
        this.lblAnalysisOutput.AutoSize = true;
        this.lblAnalysisOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblAnalysisOutput.Location = new System.Drawing.Point(15, 40);
        this.lblAnalysisOutput.Name = "lblAnalysisOutput";
        this.lblAnalysisOutput.Size = new System.Drawing.Size(95, 15);
        this.lblAnalysisOutput.TabIndex = 1;
        this.lblAnalysisOutput.Text = "Resultado Geral:";
        // 
        // lblAnalysisRightTitle
        // 
        this.lblAnalysisRightTitle.AutoSize = true;
        this.lblAnalysisRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblAnalysisRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblAnalysisRightTitle.Location = new System.Drawing.Point(15, 10);
        this.lblAnalysisRightTitle.Name = "lblAnalysisRightTitle";
        this.lblAnalysisRightTitle.Size = new System.Drawing.Size(206, 20);
        this.lblAnalysisRightTitle.TabIndex = 0;
        this.lblAnalysisRightTitle.Text = "2. RESULTADOS FORMATADOS";
        // 
        // tabOddsHistory
        // 
        this.tabOddsHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.tabOddsHistory.Controls.Add(this.pnlHistoryLeft);
        this.tabOddsHistory.Controls.Add(this.pnlHistoryRight);
        this.tabOddsHistory.Location = new System.Drawing.Point(4, 39);
        this.tabOddsHistory.Name = "tabOddsHistory";
        this.tabOddsHistory.Size = new System.Drawing.Size(1192, 697);
        this.tabOddsHistory.TabIndex = 3;
        this.tabOddsHistory.Text = "Probabilidades Realizadas";
        // 
        // pnlHistoryLeft
        // 
        this.pnlHistoryLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlHistoryLeft.Controls.Add(this.btnDeleteRecord);
        this.pnlHistoryLeft.Controls.Add(this.dgvHistory);
        this.pnlHistoryLeft.Controls.Add(this.lblHistoryLeftTitle);
        this.pnlHistoryLeft.Location = new System.Drawing.Point(10, 10);
        this.pnlHistoryLeft.Name = "pnlHistoryLeft";
        this.pnlHistoryLeft.Size = new System.Drawing.Size(575, 675);
        this.pnlHistoryLeft.TabIndex = 0;
        // 
        // btnDeleteRecord
        // 
        this.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
        this.btnDeleteRecord.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnDeleteRecord.FlatAppearance.BorderSize = 0;
        this.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDeleteRecord.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDeleteRecord.ForeColor = System.Drawing.Color.White;
        this.btnDeleteRecord.Location = new System.Drawing.Point(15, 625);
        this.btnDeleteRecord.Name = "btnDeleteRecord";
        this.btnDeleteRecord.Size = new System.Drawing.Size(545, 35);
        this.btnDeleteRecord.TabIndex = 2;
        this.btnDeleteRecord.Text = "Excluir Aposta Selecionada";
        this.btnDeleteRecord.UseVisualStyleBackColor = false;
        // 
        // dgvHistory
        // 
        this.dgvHistory.AllowUserToAddRows = false;
        this.dgvHistory.AllowUserToDeleteRows = false;
        this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
        this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
        this.dgvHistory.Location = new System.Drawing.Point(15, 45);
        this.dgvHistory.MultiSelect = false;
        this.dgvHistory.Name = "dgvHistory";
        this.dgvHistory.ReadOnly = true;
        this.dgvHistory.RowHeadersVisible = false;
        this.dgvHistory.RowTemplate.Height = 25;
        this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHistory.Size = new System.Drawing.Size(545, 560);
        this.dgvHistory.TabIndex = 1;
        // 
        // lblHistoryLeftTitle
        // 
        this.lblHistoryLeftTitle.AutoSize = true;
        this.lblHistoryLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHistoryLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblHistoryLeftTitle.Location = new System.Drawing.Point(15, 10);
        this.lblHistoryLeftTitle.Name = "lblHistoryLeftTitle";
        this.lblHistoryLeftTitle.Size = new System.Drawing.Size(183, 20);
        this.lblHistoryLeftTitle.TabIndex = 0;
        this.lblHistoryLeftTitle.Text = "1. HISTÓRICO DE APOSTAS";
        // 
        // pnlHistoryRight
        // 
        this.pnlHistoryRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlHistoryRight.Controls.Add(this.txtHistoryRaciocinio);
        this.pnlHistoryRight.Controls.Add(this.lblHistoryRaciocinio);
        this.pnlHistoryRight.Controls.Add(this.txtHistoryResumoLesoes);
        this.pnlHistoryRight.Controls.Add(this.lblHistoryResumoLesoes);
        this.pnlHistoryRight.Controls.Add(this.txtHistoryDetails);
        this.pnlHistoryRight.Controls.Add(this.lblHistoryDetails);
        this.pnlHistoryRight.Controls.Add(this.lblHistoryRightTitle);
        this.pnlHistoryRight.Location = new System.Drawing.Point(600, 10);
        this.pnlHistoryRight.Name = "pnlHistoryRight";
        this.pnlHistoryRight.Size = new System.Drawing.Size(580, 675);
        this.pnlHistoryRight.TabIndex = 1;
        // 
        // txtHistoryRaciocinio
        // 
        this.txtHistoryRaciocinio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtHistoryRaciocinio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtHistoryRaciocinio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtHistoryRaciocinio.ForeColor = System.Drawing.Color.White;
        this.txtHistoryRaciocinio.Location = new System.Drawing.Point(15, 500);
        this.txtHistoryRaciocinio.Multiline = true;
        this.txtHistoryRaciocinio.Name = "txtHistoryRaciocinio";
        this.txtHistoryRaciocinio.ReadOnly = true;
        this.txtHistoryRaciocinio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtHistoryRaciocinio.Size = new System.Drawing.Size(550, 160);
        this.txtHistoryRaciocinio.TabIndex = 6;
        // 
        // lblHistoryRaciocinio
        // 
        this.lblHistoryRaciocinio.AutoSize = true;
        this.lblHistoryRaciocinio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHistoryRaciocinio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblHistoryRaciocinio.Location = new System.Drawing.Point(15, 480);
        this.lblHistoryRaciocinio.Name = "lblHistoryRaciocinio";
        this.lblHistoryRaciocinio.Size = new System.Drawing.Size(69, 15);
        this.lblHistoryRaciocinio.TabIndex = 5;
        this.lblHistoryRaciocinio.Text = "Raciocínio:";
        // 
        // txtHistoryResumoLesoes
        // 
        this.txtHistoryResumoLesoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtHistoryResumoLesoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtHistoryResumoLesoes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtHistoryResumoLesoes.ForeColor = System.Drawing.Color.White;
        this.txtHistoryResumoLesoes.Location = new System.Drawing.Point(15, 345);
        this.txtHistoryResumoLesoes.Multiline = true;
        this.txtHistoryResumoLesoes.Name = "txtHistoryResumoLesoes";
        this.txtHistoryResumoLesoes.ReadOnly = true;
        this.txtHistoryResumoLesoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtHistoryResumoLesoes.Size = new System.Drawing.Size(550, 120);
        this.txtHistoryResumoLesoes.TabIndex = 4;
        // 
        // lblHistoryResumoLesoes
        // 
        this.lblHistoryResumoLesoes.AutoSize = true;
        this.lblHistoryResumoLesoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHistoryResumoLesoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblHistoryResumoLesoes.Location = new System.Drawing.Point(15, 325);
        this.lblHistoryResumoLesoes.Name = "lblHistoryResumoLesoes";
        this.lblHistoryResumoLesoes.Size = new System.Drawing.Size(111, 15);
        this.lblHistoryResumoLesoes.TabIndex = 3;
        this.lblHistoryResumoLesoes.Text = "Resumo de Lesões:";
        // 
        // txtHistoryDetails
        // 
        this.txtHistoryDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
        this.txtHistoryDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtHistoryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
        this.txtHistoryDetails.Location = new System.Drawing.Point(15, 60);
        this.txtHistoryDetails.Multiline = true;
        this.txtHistoryDetails.Name = "txtHistoryDetails";
        this.txtHistoryDetails.ReadOnly = true;
        this.txtHistoryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtHistoryDetails.Size = new System.Drawing.Size(550, 250);
        this.txtHistoryDetails.TabIndex = 2;
        // 
        // lblHistoryDetails
        // 
        this.lblHistoryDetails.AutoSize = true;
        this.lblHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHistoryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
        this.lblHistoryDetails.Location = new System.Drawing.Point(15, 40);
        this.lblHistoryDetails.Name = "lblHistoryDetails";
        this.lblHistoryDetails.Size = new System.Drawing.Size(125, 15);
        this.lblHistoryDetails.TabIndex = 1;
        this.lblHistoryDetails.Text = "Resultado Formatado:";
        // 
        // lblHistoryRightTitle
        // 
        this.lblHistoryRightTitle.AutoSize = true;
        this.lblHistoryRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblHistoryRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblHistoryRightTitle.Location = new System.Drawing.Point(15, 10);
        this.lblHistoryRightTitle.Name = "lblHistoryRightTitle";
        this.lblHistoryRightTitle.Size = new System.Drawing.Size(182, 20);
        this.lblHistoryRightTitle.TabIndex = 0;
        this.lblHistoryRightTitle.Text = "2. DETALHES DA APOSTA";
        // 
        // tabRealizedOdds
        // 
        this.tabRealizedOdds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.tabRealizedOdds.Controls.Add(this.pnlRealizedLeft);
        this.tabRealizedOdds.Controls.Add(this.pnlRealizedRight);
        this.tabRealizedOdds.Location = new System.Drawing.Point(4, 39);
        this.tabRealizedOdds.Name = "tabRealizedOdds";
        this.tabRealizedOdds.Size = new System.Drawing.Size(1192, 697);
        this.tabRealizedOdds.TabIndex = 4;
        this.tabRealizedOdds.Text = "Odd\'s Realizadas";
        // 
        // pnlRealizedLeft
        // 
        this.pnlRealizedLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlRealizedLeft.Controls.Add(this.lblRealizedLeftTitle);
        this.pnlRealizedLeft.Controls.Add(this.txtRealizedInput);
        this.pnlRealizedLeft.Controls.Add(this.btnSaveRealized);
        this.pnlRealizedLeft.Controls.Add(this.lblFilterDateTitle);
        this.pnlRealizedLeft.Controls.Add(this.chkFilterDate);
        this.pnlRealizedLeft.Controls.Add(this.dtpFilterDate);
        this.pnlRealizedLeft.Controls.Add(this.lblDayTotal);
        this.pnlRealizedLeft.Location = new System.Drawing.Point(10, 10);
        this.pnlRealizedLeft.Name = "pnlRealizedLeft";
        this.pnlRealizedLeft.Size = new System.Drawing.Size(400, 675);
        this.pnlRealizedLeft.TabIndex = 0;
        // 
        // lblRealizedLeftTitle
        // 
        this.lblRealizedLeftTitle.AutoSize = true;
        this.lblRealizedLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblRealizedLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblRealizedLeftTitle.Location = new System.Drawing.Point(15, 10);
        this.lblRealizedLeftTitle.Name = "lblRealizedLeftTitle";
        this.lblRealizedLeftTitle.Size = new System.Drawing.Size(193, 20);
        this.lblRealizedLeftTitle.TabIndex = 0;
        this.lblRealizedLeftTitle.Text = "1. CADASTRAR ODD\'S";
        // 
        // txtRealizedInput
        // 
        this.txtRealizedInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
        this.txtRealizedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtRealizedInput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtRealizedInput.ForeColor = System.Drawing.Color.White;
        this.txtRealizedInput.Location = new System.Drawing.Point(15, 45);
        this.txtRealizedInput.Multiline = true;
        this.txtRealizedInput.Name = "txtRealizedInput";
        this.txtRealizedInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtRealizedInput.Size = new System.Drawing.Size(370, 360);
        this.txtRealizedInput.TabIndex = 1;
        // 
        // btnSaveRealized
        // 
        this.btnSaveRealized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
        this.btnSaveRealized.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSaveRealized.FlatAppearance.BorderSize = 0;
        this.btnSaveRealized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveRealized.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSaveRealized.ForeColor = System.Drawing.Color.White;
        this.btnSaveRealized.Location = new System.Drawing.Point(15, 415);
        this.btnSaveRealized.Name = "btnSaveRealized";
        this.btnSaveRealized.Size = new System.Drawing.Size(370, 35);
        this.btnSaveRealized.TabIndex = 4;
        this.btnSaveRealized.Text = "Cadastrar Apostas";
        this.btnSaveRealized.UseVisualStyleBackColor = false;
        // 
        // lblFilterDateTitle
        // 
        this.lblFilterDateTitle.AutoSize = true;
        this.lblFilterDateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblFilterDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblFilterDateTitle.Location = new System.Drawing.Point(15, 475);
        this.lblFilterDateTitle.Name = "lblFilterDateTitle";
        this.lblFilterDateTitle.Size = new System.Drawing.Size(147, 19);
        this.lblFilterDateTitle.TabIndex = 5;
        this.lblFilterDateTitle.Text = "FILTRAR HISTÓRICO";
        // 
        // chkFilterDate
        // 
        this.chkFilterDate.AutoSize = true;
        this.chkFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.chkFilterDate.ForeColor = System.Drawing.Color.White;
        this.chkFilterDate.Location = new System.Drawing.Point(15, 510);
        this.chkFilterDate.Name = "chkFilterDate";
        this.chkFilterDate.Size = new System.Drawing.Size(155, 21);
        this.chkFilterDate.TabIndex = 6;
        this.chkFilterDate.Text = "Ativar Filtro de Data";
        this.chkFilterDate.UseVisualStyleBackColor = true;
        // 
        // dtpFilterDate
        // 
        this.dtpFilterDate.CalendarForeColor = System.Drawing.Color.White;
        this.dtpFilterDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
        this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFilterDate.Location = new System.Drawing.Point(200, 507);
        this.dtpFilterDate.Name = "dtpFilterDate";
        this.dtpFilterDate.Size = new System.Drawing.Size(185, 24);
        this.dtpFilterDate.TabIndex = 7;
        // 
        // lblDayTotal
        // 
        this.lblDayTotal.AutoSize = false;
        this.lblDayTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblDayTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
        this.lblDayTotal.Location = new System.Drawing.Point(15, 550);
        this.lblDayTotal.Name = "lblDayTotal";
        this.lblDayTotal.Size = new System.Drawing.Size(370, 90);
        this.lblDayTotal.TabIndex = 8;
        this.lblDayTotal.Text = "Total de Apostas no dia --/--/----: 0 aposta(s) (R$ 0,00 apostados)\r\n  • Sucesso: 0 aposta(s) (R$ 0,00)\r\n  • Perda: 0 aposta(s) (R$ 0,00)";
        // 
        // pnlRealizedRight
        // 
        this.pnlRealizedRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
        this.pnlRealizedRight.Controls.Add(this.lblRealizedRightTitle);
        this.pnlRealizedRight.Controls.Add(this.dgvRealized);
        this.pnlRealizedRight.Controls.Add(this.btnDeleteRealized);
        this.pnlRealizedRight.Controls.Add(this.lblTotalResultTitle);
        this.pnlRealizedRight.Controls.Add(this.lblTotalResultValue);
        this.pnlRealizedRight.Location = new System.Drawing.Point(420, 10);
        this.pnlRealizedRight.Name = "pnlRealizedRight";
        this.pnlRealizedRight.Size = new System.Drawing.Size(760, 675);
        this.pnlRealizedRight.TabIndex = 1;
        // 
        // lblRealizedRightTitle
        // 
        this.lblRealizedRightTitle.AutoSize = true;
        this.lblRealizedRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblRealizedRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
        this.lblRealizedRightTitle.Location = new System.Drawing.Point(15, 10);
        this.lblRealizedRightTitle.Name = "lblRealizedRightTitle";
        this.lblRealizedRightTitle.Size = new System.Drawing.Size(232, 20);
        this.lblRealizedRightTitle.TabIndex = 0;
        this.lblRealizedRightTitle.Text = "2. GRADE DE ODD\'S REALIZADAS";
        // 
        // dgvRealized
        // 
        this.dgvRealized.AllowUserToAddRows = false;
        this.dgvRealized.AllowUserToDeleteRows = false;
        this.dgvRealized.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
        this.dgvRealized.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvRealized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRealized.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
        this.dgvRealized.Location = new System.Drawing.Point(15, 45);
        this.dgvRealized.MultiSelect = false;
        this.dgvRealized.Name = "dgvRealized";
        this.dgvRealized.ReadOnly = true;
        this.dgvRealized.RowHeadersVisible = false;
        this.dgvRealized.RowTemplate.Height = 25;
        this.dgvRealized.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRealized.Size = new System.Drawing.Size(730, 560);
        this.dgvRealized.TabIndex = 1;
        // 
        // btnDeleteRealized
        // 
        this.btnDeleteRealized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
        this.btnDeleteRealized.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnDeleteRealized.FlatAppearance.BorderSize = 0;
        this.btnDeleteRealized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDeleteRealized.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDeleteRealized.ForeColor = System.Drawing.Color.White;
        this.btnDeleteRealized.Location = new System.Drawing.Point(15, 625);
        this.btnDeleteRealized.Name = "btnDeleteRealized";
        this.btnDeleteRealized.Size = new System.Drawing.Size(350, 35);
        this.btnDeleteRealized.TabIndex = 2;
        this.btnDeleteRealized.Text = "Excluir Aposta Selecionada";
        this.btnDeleteRealized.UseVisualStyleBackColor = false;
        // 
        // lblTotalResultTitle
        // 
        this.lblTotalResultTitle.AutoSize = true;
        this.lblTotalResultTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTotalResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblTotalResultTitle.Location = new System.Drawing.Point(400, 630);
        this.lblTotalResultTitle.Name = "lblTotalResultTitle";
        this.lblTotalResultTitle.Size = new System.Drawing.Size(95, 25);
        this.lblTotalResultTitle.TabIndex = 3;
        this.lblTotalResultTitle.Text = "Total R$:";
        // 
        // lblTotalResultValue
        // 
        this.lblTotalResultValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTotalResultValue.ForeColor = System.Drawing.Color.White;
        this.lblTotalResultValue.Location = new System.Drawing.Point(510, 630);
        this.lblTotalResultValue.Name = "lblTotalResultValue";
        this.lblTotalResultValue.Size = new System.Drawing.Size(230, 25);
        this.lblTotalResultValue.TabIndex = 4;
        this.lblTotalResultValue.Text = "R$ 0,00";
        this.lblTotalResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
        this.ClientSize = new System.Drawing.Size(1200, 810);
        this.Controls.Add(this.tabMain);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Soccer Analytics & Probabilities Generator";
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.tabMain.ResumeLayout(false);
        this.tabSoccerParser.ResumeLayout(false);
        this.pnlLeft.ResumeLayout(false);
        this.pnlLeft.PerformLayout();
        this.pnlCenter.ResumeLayout(false);
        this.pnlCenter.PerformLayout();
        this.pnlRight.ResumeLayout(false);
        this.pnlRight.PerformLayout();
        this.tabOddsCalculator.ResumeLayout(false);
        this.pnlOddsLeft.ResumeLayout(false);
        this.pnlOddsLeft.PerformLayout();
        this.pnlOddsRight.ResumeLayout(false);
        this.pnlOddsRight.PerformLayout();
        this.tabAnalysis.ResumeLayout(false);
        this.pnlAnalysisLeft.ResumeLayout(false);
        this.pnlAnalysisLeft.PerformLayout();
        this.pnlAnalysisRight.ResumeLayout(false);
        this.pnlAnalysisRight.PerformLayout();
        this.tabOddsHistory.ResumeLayout(false);
        this.pnlHistoryLeft.ResumeLayout(false);
        this.pnlHistoryLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
        this.pnlHistoryRight.ResumeLayout(false);
        this.pnlHistoryRight.PerformLayout();
        this.tabRealizedOdds.ResumeLayout(false);
        this.pnlRealizedLeft.ResumeLayout(false);
        this.pnlRealizedLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRealized)).EndInit();
        this.pnlRealizedRight.ResumeLayout(false);
        this.pnlRealizedRight.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblHeaderTitle;
    private System.Windows.Forms.Label lblHeaderSubtitle;
    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tabSoccerParser;
    private System.Windows.Forms.TabPage tabOddsCalculator;
    private System.Windows.Forms.TabPage tabAnalysis;
    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Label lblLeftTitle;
    private System.Windows.Forms.Label lblUrlJson;
    private System.Windows.Forms.TextBox txtUrlJson;
    private System.Windows.Forms.Button btnCarregarUrl;
    private System.Windows.Forms.Button btnCarregarExemplo;
    private System.Windows.Forms.Label lblRawJson;
    private System.Windows.Forms.TextBox txtRawJson;
    private System.Windows.Forms.Button btnProcessarJson;
    private System.Windows.Forms.Panel pnlCenter;
    private System.Windows.Forms.Label lblCenterTitle;
    private System.Windows.Forms.Label lblJogo;
    private System.Windows.Forms.TextBox txtJogo;
    private System.Windows.Forms.Label lblCompeticao;
    private System.Windows.Forms.TextBox txtCompeticao;
    private System.Windows.Forms.Label lblData;
    private System.Windows.Forms.TextBox txtData;
    private System.Windows.Forms.Label lblMediaGolsLiga;
    private System.Windows.Forms.TextBox txtMediaGolsLiga;
    private System.Windows.Forms.Label lblDadosTimeA;
    private System.Windows.Forms.TextBox txtDadosTimeA;
    private System.Windows.Forms.Label lblDadosTimeB;
    private System.Windows.Forms.TextBox txtDadosTimeB;
    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.Label lblRightTitle;
    private System.Windows.Forms.Label lblNoticias;
    private System.Windows.Forms.TextBox txtNoticias;
    private System.Windows.Forms.Button btnGerarProbabilidades;
    private System.Windows.Forms.Label lblOutputFinal;
    private System.Windows.Forms.TextBox txtOutputFinal;
    
    // Controles da aba de Cálculo de ODDs
    private System.Windows.Forms.Panel pnlOddsLeft;
    private System.Windows.Forms.Label lblOddsLeftTitle;
    private System.Windows.Forms.Label lblOddsJson;
    private System.Windows.Forms.TextBox txtOddsJson;
    private System.Windows.Forms.Button btnCarregarExemploOdds;
    private System.Windows.Forms.Button btnProcessarOdds;
    private System.Windows.Forms.Panel pnlOddsRight;
    private System.Windows.Forms.Label lblOddsRightTitle;
    private System.Windows.Forms.Label lblOddsOutput;
    private System.Windows.Forms.TextBox txtOddsOutput;

    // Controles da aba de Analisa de Resultados
    private System.Windows.Forms.Panel pnlAnalysisLeft;
    private System.Windows.Forms.Label lblAnalysisLeftTitle;
    private System.Windows.Forms.Label lblAnalysisJson;
    private System.Windows.Forms.TextBox txtAnalysisJson;
    private System.Windows.Forms.Button btnCarregarExemploAnalise;
    private System.Windows.Forms.Button btnProcessarAnalise;
    private System.Windows.Forms.Button btnSalvarAnalise;
    private System.Windows.Forms.Panel pnlAnalysisRight;
    private System.Windows.Forms.Label lblAnalysisRightTitle;
    private System.Windows.Forms.Label lblAnalysisOutput;
    private System.Windows.Forms.TextBox txtAnalysisOutput;
    private System.Windows.Forms.Label lblAnalysisResumoLesoes;
    private System.Windows.Forms.TextBox txtAnalysisResumoLesoes;
    private System.Windows.Forms.Label lblAnalysisRaciocinio;
    private System.Windows.Forms.TextBox txtAnalysisRaciocinio;

    // Controles da aba de Histórico de Apostas
    private System.Windows.Forms.TabPage tabOddsHistory;
    private System.Windows.Forms.Panel pnlHistoryLeft;
    private System.Windows.Forms.Label lblHistoryLeftTitle;
    private System.Windows.Forms.DataGridView dgvHistory;
    private System.Windows.Forms.Button btnDeleteRecord;
    private System.Windows.Forms.Panel pnlHistoryRight;
    private System.Windows.Forms.Label lblHistoryRightTitle;
    private System.Windows.Forms.Label lblHistoryDetails;
    private System.Windows.Forms.TextBox txtHistoryDetails;
    private System.Windows.Forms.Label lblHistoryResumoLesoes;
    private System.Windows.Forms.TextBox txtHistoryResumoLesoes;
    private System.Windows.Forms.Label lblHistoryRaciocinio;
    private System.Windows.Forms.TextBox txtHistoryRaciocinio;

    // Controles da aba de Odd's Realizadas (Aba 5)
    private System.Windows.Forms.TabPage tabRealizedOdds;
    private System.Windows.Forms.Panel pnlRealizedLeft;
    private System.Windows.Forms.Label lblRealizedLeftTitle;
    private System.Windows.Forms.TextBox txtRealizedInput;
    private System.Windows.Forms.Button btnSaveRealized;
    private System.Windows.Forms.Label lblFilterDateTitle;
    private System.Windows.Forms.CheckBox chkFilterDate;
    private System.Windows.Forms.DateTimePicker dtpFilterDate;
    private System.Windows.Forms.Label lblDayTotal;
    private System.Windows.Forms.Panel pnlRealizedRight;
    private System.Windows.Forms.Label lblRealizedRightTitle;
    private System.Windows.Forms.DataGridView dgvRealized;
    private System.Windows.Forms.Button btnDeleteRealized;
    private System.Windows.Forms.Label lblTotalResultTitle;
    private System.Windows.Forms.Label lblTotalResultValue;
}
