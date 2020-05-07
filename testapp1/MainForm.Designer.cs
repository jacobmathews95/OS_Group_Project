namespace testapp1
{
    partial class MainForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.rr = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRRWaitTImeVal = new System.Windows.Forms.Label();
            this.lblRRWaitTIme = new System.Windows.Forms.Label();
            this.lblRRTATVal = new System.Windows.Forms.Label();
            this.lblRRProcesses = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblTQVal = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblTQ = new System.Windows.Forms.Label();
            this.tbl1 = new System.Windows.Forms.DataGridView();
            this.dsInputs = new System.Data.DataSet();
            this.lblRRFPVal = new System.Windows.Forms.Label();
            this.lblRRFP = new System.Windows.Forms.Label();
            this.lblRRWPVal = new System.Windows.Forms.Label();
            this.lblRRWP = new System.Windows.Forms.Label();
            this.lblRRQLVal = new System.Windows.Forms.Label();
            this.lblRRQL = new System.Windows.Forms.Label();
            this.lblRRCPVal = new System.Windows.Forms.Label();
            this.lblRRCP = new System.Windows.Forms.Label();
            this.lblRRCTVal = new System.Windows.Forms.Label();
            this.lblRRCT = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.mlq = new System.Windows.Forms.TabPage();
            this.lblMLQGantt = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMin2 = new System.Windows.Forms.Button();
            this.lblTQ2Val = new System.Windows.Forms.Label();
            this.btnPlus2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMin1 = new System.Windows.Forms.Button();
            this.lblTQ1Val = new System.Windows.Forms.Label();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMLAvgWaitVal = new System.Windows.Forms.Label();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.lblMLTATVal = new System.Windows.Forms.Label();
            this.lblAvgTAT = new System.Windows.Forms.Label();
            this.lblMLWP2Val = new System.Windows.Forms.Label();
            this.lblMLWP2 = new System.Windows.Forms.Label();
            this.tbl2 = new System.Windows.Forms.DataGridView();
            this.lblMLFPVal = new System.Windows.Forms.Label();
            this.lblMLFP = new System.Windows.Forms.Label();
            this.lblMLWP1Val = new System.Windows.Forms.Label();
            this.lblMLWP1 = new System.Windows.Forms.Label();
            this.lblMLQLVal = new System.Windows.Forms.Label();
            this.lblMLQL = new System.Windows.Forms.Label();
            this.lblMLCPVal = new System.Windows.Forms.Label();
            this.lblMLCP = new System.Windows.Forms.Label();
            this.lblMLCTVal = new System.Windows.Forms.Label();
            this.lblMLCT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRRTAT = new System.Windows.Forms.Label();
            this.lblProcessVal = new System.Windows.Forms.Label();
            this.lblCPUUtilVal = new System.Windows.Forms.Label();
            this.lblCPUVal = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.rr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInputs)).BeginInit();
            this.mlq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.rr);
            this.tabMain.Controls.Add(this.mlq);
            this.tabMain.Location = new System.Drawing.Point(16, 15);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1035, 697);
            this.tabMain.TabIndex = 0;
            // 
            // rr
            // 
            this.rr.Controls.Add(this.lblCPUUtilVal);
            this.rr.Controls.Add(this.lblCPUVal);
            this.rr.Controls.Add(this.lblProcessVal);
            this.rr.Controls.Add(this.tableLayoutPanel1);
            this.rr.Controls.Add(this.lblRRWaitTImeVal);
            this.rr.Controls.Add(this.lblRRWaitTIme);
            this.rr.Controls.Add(this.lblRRTATVal);
            this.rr.Controls.Add(this.lblRRTAT);
            this.rr.Controls.Add(this.lblRRProcesses);
            this.rr.Controls.Add(this.btnMinus);
            this.rr.Controls.Add(this.lblTQVal);
            this.rr.Controls.Add(this.btnPlus);
            this.rr.Controls.Add(this.lblTQ);
            this.rr.Controls.Add(this.tbl1);
            this.rr.Controls.Add(this.lblRRFPVal);
            this.rr.Controls.Add(this.lblRRFP);
            this.rr.Controls.Add(this.lblRRWPVal);
            this.rr.Controls.Add(this.lblRRWP);
            this.rr.Controls.Add(this.lblRRQLVal);
            this.rr.Controls.Add(this.lblRRQL);
            this.rr.Controls.Add(this.lblRRCPVal);
            this.rr.Controls.Add(this.lblRRCP);
            this.rr.Controls.Add(this.lblRRCTVal);
            this.rr.Controls.Add(this.lblRRCT);
            this.rr.Controls.Add(this.btnReset);
            this.rr.Controls.Add(this.btnCalc);
            this.rr.Location = new System.Drawing.Point(4, 25);
            this.rr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rr.Name = "rr";
            this.rr.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rr.Size = new System.Drawing.Size(1027, 668);
            this.rr.TabIndex = 0;
            this.rr.Text = "Round Robin";
            this.rr.UseVisualStyleBackColor = true;
            this.rr.Click += new System.EventHandler(this.rr_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 584);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(1016, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 80);
            this.tableLayoutPanel1.TabIndex = 46;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRRWaitTImeVal
            // 
            this.lblRRWaitTImeVal.AutoSize = true;
            this.lblRRWaitTImeVal.Location = new System.Drawing.Point(918, 256);
            this.lblRRWaitTImeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRWaitTImeVal.Name = "lblRRWaitTImeVal";
            this.lblRRWaitTImeVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRWaitTImeVal.TabIndex = 45;
            this.lblRRWaitTImeVal.Text = "0";
            // 
            // lblRRWaitTIme
            // 
            this.lblRRWaitTIme.AutoSize = true;
            this.lblRRWaitTIme.Location = new System.Drawing.Point(884, 219);
            this.lblRRWaitTIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRWaitTIme.Name = "lblRRWaitTIme";
            this.lblRRWaitTIme.Size = new System.Drawing.Size(75, 17);
            this.lblRRWaitTIme.TabIndex = 44;
            this.lblRRWaitTIme.Text = "Wait Time:";
            // 
            // lblRRTATVal
            // 
            this.lblRRTATVal.AutoSize = true;
            this.lblRRTATVal.Location = new System.Drawing.Point(824, 256);
            this.lblRRTATVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRTATVal.Name = "lblRRTATVal";
            this.lblRRTATVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRTATVal.TabIndex = 43;
            this.lblRRTATVal.Text = "0";
            // 
            // lblRRProcesses
            // 
            this.lblRRProcesses.AutoSize = true;
            this.lblRRProcesses.Location = new System.Drawing.Point(685, 219);
            this.lblRRProcesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRProcesses.Name = "lblRRProcesses";
            this.lblRRProcesses.Size = new System.Drawing.Size(74, 17);
            this.lblRRProcesses.TabIndex = 42;
            this.lblRRProcesses.Text = "Processes";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(327, 404);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(61, 28);
            this.btnMinus.TabIndex = 28;
            this.btnMinus.Text = " - ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblTQVal
            // 
            this.lblTQVal.AutoSize = true;
            this.lblTQVal.Location = new System.Drawing.Point(179, 410);
            this.lblTQVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTQVal.Name = "lblTQVal";
            this.lblTQVal.Size = new System.Drawing.Size(24, 17);
            this.lblTQVal.TabIndex = 26;
            this.lblTQVal.Text = "10";
            this.lblTQVal.Click += new System.EventHandler(this.lblTQVal_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(257, 404);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 28);
            this.btnPlus.TabIndex = 27;
            this.btnPlus.Text = " + ";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblTQ
            // 
            this.lblTQ.AutoSize = true;
            this.lblTQ.Location = new System.Drawing.Point(61, 410);
            this.lblTQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTQ.Name = "lblTQ";
            this.lblTQ.Size = new System.Drawing.Size(109, 17);
            this.lblTQ.TabIndex = 25;
            this.lblTQ.Text = "Time Quantum: ";
            // 
            // tbl1
            // 
            this.tbl1.AutoGenerateColumns = false;
            this.tbl1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl1.DataSource = this.dsInputs;
            this.tbl1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl1.Location = new System.Drawing.Point(7, 4);
            this.tbl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbl1.Name = "tbl1";
            this.tbl1.RowHeadersWidth = 49;
            this.tbl1.Size = new System.Drawing.Size(1009, 185);
            this.tbl1.TabIndex = 24;
            // 
            // dsInputs
            // 
            this.dsInputs.DataSetName = "NewDataSet";
            // 
            // lblRRFPVal
            // 
            this.lblRRFPVal.AutoSize = true;
            this.lblRRFPVal.Location = new System.Drawing.Point(211, 484);
            this.lblRRFPVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRFPVal.Name = "lblRRFPVal";
            this.lblRRFPVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRFPVal.TabIndex = 23;
            this.lblRRFPVal.Text = "0";
            // 
            // lblRRFP
            // 
            this.lblRRFP.AutoSize = true;
            this.lblRRFP.Location = new System.Drawing.Point(64, 484);
            this.lblRRFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRFP.Name = "lblRRFP";
            this.lblRRFP.Size = new System.Drawing.Size(139, 17);
            this.lblRRFP.TabIndex = 22;
            this.lblRRFP.Text = "Finished Processes: ";
            // 
            // lblRRWPVal
            // 
            this.lblRRWPVal.AutoSize = true;
            this.lblRRWPVal.Location = new System.Drawing.Point(292, 351);
            this.lblRRWPVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRWPVal.Name = "lblRRWPVal";
            this.lblRRWPVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRWPVal.TabIndex = 21;
            this.lblRRWPVal.Text = "0";
            // 
            // lblRRWP
            // 
            this.lblRRWP.AutoSize = true;
            this.lblRRWP.Location = new System.Drawing.Point(149, 351);
            this.lblRRWP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRWP.Name = "lblRRWP";
            this.lblRRWP.Size = new System.Drawing.Size(133, 17);
            this.lblRRWP.TabIndex = 20;
            this.lblRRWP.Text = "Waiting Processes: ";
            // 
            // lblRRQLVal
            // 
            this.lblRRQLVal.AutoSize = true;
            this.lblRRQLVal.Location = new System.Drawing.Point(159, 535);
            this.lblRRQLVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRQLVal.Name = "lblRRQLVal";
            this.lblRRQLVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRQLVal.TabIndex = 19;
            this.lblRRQLVal.Text = "0";
            // 
            // lblRRQL
            // 
            this.lblRRQL.AutoSize = true;
            this.lblRRQL.Location = new System.Drawing.Point(61, 535);
            this.lblRRQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRQL.Name = "lblRRQL";
            this.lblRRQL.Size = new System.Drawing.Size(102, 17);
            this.lblRRQL.TabIndex = 18;
            this.lblRRQL.Text = "Quantum Left: ";
            // 
            // lblRRCPVal
            // 
            this.lblRRCPVal.AutoSize = true;
            this.lblRRCPVal.Location = new System.Drawing.Point(275, 294);
            this.lblRRCPVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRCPVal.Name = "lblRRCPVal";
            this.lblRRCPVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRCPVal.TabIndex = 17;
            this.lblRRCPVal.Text = "0";
            // 
            // lblRRCP
            // 
            this.lblRRCP.AutoSize = true;
            this.lblRRCP.Location = new System.Drawing.Point(149, 294);
            this.lblRRCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRCP.Name = "lblRRCP";
            this.lblRRCP.Size = new System.Drawing.Size(118, 17);
            this.lblRRCP.TabIndex = 16;
            this.lblRRCP.Text = "Current Process: ";
            // 
            // lblRRCTVal
            // 
            this.lblRRCTVal.AutoSize = true;
            this.lblRRCTVal.Location = new System.Drawing.Point(492, 260);
            this.lblRRCTVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRCTVal.Name = "lblRRCTVal";
            this.lblRRCTVal.Size = new System.Drawing.Size(16, 17);
            this.lblRRCTVal.TabIndex = 9;
            this.lblRRCTVal.Text = "0";
            // 
            // lblRRCT
            // 
            this.lblRRCT.AutoSize = true;
            this.lblRRCT.Location = new System.Drawing.Point(395, 260);
            this.lblRRCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRCT.Name = "lblRRCT";
            this.lblRRCT.Size = new System.Drawing.Size(98, 17);
            this.lblRRCT.TabIndex = 8;
            this.lblRRCT.Text = "Current Time: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(488, 208);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(351, 208);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 28);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.buttonRR_Click);
            // 
            // mlq
            // 
            this.mlq.Controls.Add(this.lblMLQGantt);
            this.mlq.Controls.Add(this.tableLayoutPanel2);
            this.mlq.Controls.Add(this.btnMin2);
            this.mlq.Controls.Add(this.lblTQ2Val);
            this.mlq.Controls.Add(this.btnPlus2);
            this.mlq.Controls.Add(this.label4);
            this.mlq.Controls.Add(this.btnMin1);
            this.mlq.Controls.Add(this.lblTQ1Val);
            this.mlq.Controls.Add(this.btnPlus1);
            this.mlq.Controls.Add(this.label2);
            this.mlq.Controls.Add(this.lblMLAvgWaitVal);
            this.mlq.Controls.Add(this.lblWaitTime);
            this.mlq.Controls.Add(this.lblMLTATVal);
            this.mlq.Controls.Add(this.lblAvgTAT);
            this.mlq.Controls.Add(this.lblMLWP2Val);
            this.mlq.Controls.Add(this.lblMLWP2);
            this.mlq.Controls.Add(this.tbl2);
            this.mlq.Controls.Add(this.lblMLFPVal);
            this.mlq.Controls.Add(this.lblMLFP);
            this.mlq.Controls.Add(this.lblMLWP1Val);
            this.mlq.Controls.Add(this.lblMLWP1);
            this.mlq.Controls.Add(this.lblMLQLVal);
            this.mlq.Controls.Add(this.lblMLQL);
            this.mlq.Controls.Add(this.lblMLCPVal);
            this.mlq.Controls.Add(this.lblMLCP);
            this.mlq.Controls.Add(this.lblMLCTVal);
            this.mlq.Controls.Add(this.lblMLCT);
            this.mlq.Controls.Add(this.button1);
            this.mlq.Controls.Add(this.button2);
            this.mlq.Location = new System.Drawing.Point(4, 25);
            this.mlq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mlq.Name = "mlq";
            this.mlq.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mlq.Size = new System.Drawing.Size(1027, 668);
            this.mlq.TabIndex = 1;
            this.mlq.Text = "Multilevel Queue";
            this.mlq.UseVisualStyleBackColor = true;
            this.mlq.Click += new System.EventHandler(this.mlq_Click);
            // 
            // lblMLQGantt
            // 
            this.lblMLQGantt.Location = new System.Drawing.Point(1, 479);
            this.lblMLQGantt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLQGantt.Name = "lblMLQGantt";
            this.lblMLQGantt.Size = new System.Drawing.Size(1008, 58);
            this.lblMLQGantt.TabIndex = 40;
            this.lblMLQGantt.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 584);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(1016, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 80);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // btnMin2
            // 
            this.btnMin2.Location = new System.Drawing.Point(375, 439);
            this.btnMin2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMin2.Name = "btnMin2";
            this.btnMin2.Size = new System.Drawing.Size(61, 28);
            this.btnMin2.TabIndex = 39;
            this.btnMin2.Text = " - ";
            this.btnMin2.UseVisualStyleBackColor = true;
            this.btnMin2.Click += new System.EventHandler(this.btnMin2_Click);
            // 
            // lblTQ2Val
            // 
            this.lblTQ2Val.AutoSize = true;
            this.lblTQ2Val.Location = new System.Drawing.Point(227, 446);
            this.lblTQ2Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTQ2Val.Name = "lblTQ2Val";
            this.lblTQ2Val.Size = new System.Drawing.Size(16, 17);
            this.lblTQ2Val.TabIndex = 37;
            this.lblTQ2Val.Text = "4";
            // 
            // btnPlus2
            // 
            this.btnPlus2.Location = new System.Drawing.Point(305, 439);
            this.btnPlus2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus2.Name = "btnPlus2";
            this.btnPlus2.Size = new System.Drawing.Size(61, 28);
            this.btnPlus2.TabIndex = 38;
            this.btnPlus2.Text = " + ";
            this.btnPlus2.UseVisualStyleBackColor = true;
            this.btnPlus2.Click += new System.EventHandler(this.btnPlus2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 446);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Time Quantum 2: ";
            // 
            // btnMin1
            // 
            this.btnMin1.Location = new System.Drawing.Point(375, 405);
            this.btnMin1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMin1.Name = "btnMin1";
            this.btnMin1.Size = new System.Drawing.Size(61, 28);
            this.btnMin1.TabIndex = 35;
            this.btnMin1.Text = " - ";
            this.btnMin1.UseVisualStyleBackColor = true;
            this.btnMin1.Click += new System.EventHandler(this.btnMin1_Click);
            // 
            // lblTQ1Val
            // 
            this.lblTQ1Val.AutoSize = true;
            this.lblTQ1Val.Location = new System.Drawing.Point(227, 411);
            this.lblTQ1Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTQ1Val.Name = "lblTQ1Val";
            this.lblTQ1Val.Size = new System.Drawing.Size(16, 17);
            this.lblTQ1Val.TabIndex = 33;
            this.lblTQ1Val.Text = "3";
            // 
            // btnPlus1
            // 
            this.btnPlus1.Location = new System.Drawing.Point(305, 405);
            this.btnPlus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(61, 28);
            this.btnPlus1.TabIndex = 34;
            this.btnPlus1.Text = " + ";
            this.btnPlus1.UseVisualStyleBackColor = true;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Time Quantum 1: ";
            // 
            // lblMLAvgWaitVal
            // 
            this.lblMLAvgWaitVal.AutoSize = true;
            this.lblMLAvgWaitVal.Location = new System.Drawing.Point(704, 400);
            this.lblMLAvgWaitVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLAvgWaitVal.Name = "lblMLAvgWaitVal";
            this.lblMLAvgWaitVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLAvgWaitVal.TabIndex = 31;
            this.lblMLAvgWaitVal.Text = "0";
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.Location = new System.Drawing.Point(589, 400);
            this.lblWaitTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(103, 17);
            this.lblWaitTime.TabIndex = 30;
            this.lblWaitTime.Text = "Avg Wait Time:";
            // 
            // lblMLTATVal
            // 
            this.lblMLTATVal.AutoSize = true;
            this.lblMLTATVal.Location = new System.Drawing.Point(704, 369);
            this.lblMLTATVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLTATVal.Name = "lblMLTATVal";
            this.lblMLTATVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLTATVal.TabIndex = 29;
            this.lblMLTATVal.Text = "0";
            // 
            // lblAvgTAT
            // 
            this.lblAvgTAT.AutoSize = true;
            this.lblAvgTAT.Location = new System.Drawing.Point(625, 369);
            this.lblAvgTAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvgTAT.Name = "lblAvgTAT";
            this.lblAvgTAT.Size = new System.Drawing.Size(67, 17);
            this.lblAvgTAT.TabIndex = 28;
            this.lblAvgTAT.Text = "Avg TAT:";
            // 
            // lblMLWP2Val
            // 
            this.lblMLWP2Val.AutoSize = true;
            this.lblMLWP2Val.Location = new System.Drawing.Point(251, 369);
            this.lblMLWP2Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLWP2Val.Name = "lblMLWP2Val";
            this.lblMLWP2Val.Size = new System.Drawing.Size(16, 17);
            this.lblMLWP2Val.TabIndex = 27;
            this.lblMLWP2Val.Text = "0";
            // 
            // lblMLWP2
            // 
            this.lblMLWP2.AutoSize = true;
            this.lblMLWP2.Location = new System.Drawing.Point(108, 369);
            this.lblMLWP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLWP2.Name = "lblMLWP2";
            this.lblMLWP2.Size = new System.Drawing.Size(122, 17);
            this.lblMLWP2.TabIndex = 26;
            this.lblMLWP2.Text = "Queue 2 Waiting: ";
            // 
            // tbl2
            // 
            this.tbl2.AutoGenerateColumns = false;
            this.tbl2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl2.DataSource = this.dsInputs;
            this.tbl2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl2.Location = new System.Drawing.Point(8, 0);
            this.tbl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbl2.Name = "tbl2";
            this.tbl2.RowHeadersWidth = 49;
            this.tbl2.Size = new System.Drawing.Size(1009, 185);
            this.tbl2.TabIndex = 25;
            // 
            // lblMLFPVal
            // 
            this.lblMLFPVal.AutoSize = true;
            this.lblMLFPVal.Location = new System.Drawing.Point(760, 336);
            this.lblMLFPVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLFPVal.Name = "lblMLFPVal";
            this.lblMLFPVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLFPVal.TabIndex = 15;
            this.lblMLFPVal.Text = "0";
            this.lblMLFPVal.Click += new System.EventHandler(this.lblMLFPVal_Click);
            // 
            // lblMLFP
            // 
            this.lblMLFP.AutoSize = true;
            this.lblMLFP.Location = new System.Drawing.Point(625, 336);
            this.lblMLFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLFP.Name = "lblMLFP";
            this.lblMLFP.Size = new System.Drawing.Size(139, 17);
            this.lblMLFP.TabIndex = 14;
            this.lblMLFP.Text = "Finished Processes: ";
            this.lblMLFP.Click += new System.EventHandler(this.lblMLFP_Click);
            // 
            // lblMLWP1Val
            // 
            this.lblMLWP1Val.AutoSize = true;
            this.lblMLWP1Val.Location = new System.Drawing.Point(251, 336);
            this.lblMLWP1Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLWP1Val.Name = "lblMLWP1Val";
            this.lblMLWP1Val.Size = new System.Drawing.Size(16, 17);
            this.lblMLWP1Val.TabIndex = 13;
            this.lblMLWP1Val.Text = "0";
            // 
            // lblMLWP1
            // 
            this.lblMLWP1.AutoSize = true;
            this.lblMLWP1.Location = new System.Drawing.Point(108, 336);
            this.lblMLWP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLWP1.Name = "lblMLWP1";
            this.lblMLWP1.Size = new System.Drawing.Size(122, 17);
            this.lblMLWP1.TabIndex = 12;
            this.lblMLWP1.Text = "Queue 1 Waiting: ";
            // 
            // lblMLQLVal
            // 
            this.lblMLQLVal.AutoSize = true;
            this.lblMLQLVal.Location = new System.Drawing.Point(723, 299);
            this.lblMLQLVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLQLVal.Name = "lblMLQLVal";
            this.lblMLQLVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLQLVal.TabIndex = 11;
            this.lblMLQLVal.Text = "0";
            // 
            // lblMLQL
            // 
            this.lblMLQL.AutoSize = true;
            this.lblMLQL.Location = new System.Drawing.Point(625, 299);
            this.lblMLQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLQL.Name = "lblMLQL";
            this.lblMLQL.Size = new System.Drawing.Size(102, 17);
            this.lblMLQL.TabIndex = 10;
            this.lblMLQL.Text = "Quantum Left: ";
            // 
            // lblMLCPVal
            // 
            this.lblMLCPVal.AutoSize = true;
            this.lblMLCPVal.Location = new System.Drawing.Point(251, 299);
            this.lblMLCPVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLCPVal.Name = "lblMLCPVal";
            this.lblMLCPVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLCPVal.TabIndex = 9;
            this.lblMLCPVal.Text = "0";
            // 
            // lblMLCP
            // 
            this.lblMLCP.AutoSize = true;
            this.lblMLCP.Location = new System.Drawing.Point(125, 299);
            this.lblMLCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLCP.Name = "lblMLCP";
            this.lblMLCP.Size = new System.Drawing.Size(118, 17);
            this.lblMLCP.TabIndex = 8;
            this.lblMLCP.Text = "Current Process: ";
            // 
            // lblMLCTVal
            // 
            this.lblMLCTVal.AutoSize = true;
            this.lblMLCTVal.Location = new System.Drawing.Point(492, 258);
            this.lblMLCTVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLCTVal.Name = "lblMLCTVal";
            this.lblMLCTVal.Size = new System.Drawing.Size(16, 17);
            this.lblMLCTVal.TabIndex = 7;
            this.lblMLCTVal.Text = "0";
            // 
            // lblMLCT
            // 
            this.lblMLCT.AutoSize = true;
            this.lblMLCT.Location = new System.Drawing.Point(395, 258);
            this.lblMLCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMLCT.Name = "lblMLCT";
            this.lblMLCT.Size = new System.Drawing.Size(98, 17);
            this.lblMLCT.TabIndex = 6;
            this.lblMLCT.Text = "Current Time: ";
            this.lblMLCT.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRRTAT
            // 
            this.lblRRTAT.AutoSize = true;
            this.lblRRTAT.Location = new System.Drawing.Point(815, 219);
            this.lblRRTAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRTAT.Name = "lblRRTAT";
            this.lblRRTAT.Size = new System.Drawing.Size(39, 17);
            this.lblRRTAT.TabIndex = 42;
            this.lblRRTAT.Text = "TAT:";
            // 
            // lblProcessVal
            // 
            this.lblProcessVal.AutoSize = true;
            this.lblProcessVal.Location = new System.Drawing.Point(720, 256);
            this.lblProcessVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessVal.Name = "lblProcessVal";
            this.lblProcessVal.Size = new System.Drawing.Size(0, 17);
            this.lblProcessVal.TabIndex = 47;
            // 
            // lblCPUUtilVal
            // 
            this.lblCPUUtilVal.AutoSize = true;
            this.lblCPUUtilVal.Location = new System.Drawing.Point(422, 535);
            this.lblCPUUtilVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUUtilVal.Name = "lblCPUUtilVal";
            this.lblCPUUtilVal.Size = new System.Drawing.Size(16, 17);
            this.lblCPUUtilVal.TabIndex = 49;
            this.lblCPUUtilVal.Text = "0";
            // 
            // lblCPUVal
            // 
            this.lblCPUVal.AutoSize = true;
            this.lblCPUVal.Location = new System.Drawing.Point(275, 535);
            this.lblCPUVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUVal.Name = "lblCPUVal";
            this.lblCPUVal.Size = new System.Drawing.Size(101, 17);
            this.lblCPUVal.TabIndex = 48;
            this.lblCPUVal.Text = "CPU Utilization";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 726);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabMain.ResumeLayout(false);
            this.rr.ResumeLayout(false);
            this.rr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInputs)).EndInit();
            this.mlq.ResumeLayout(false);
            this.mlq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage rr;
        private System.Windows.Forms.TabPage mlq;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMLCTVal;
        private System.Windows.Forms.Label lblMLCT;
        private System.Windows.Forms.Label lblRRFPVal;
        private System.Windows.Forms.Label lblRRFP;
        private System.Windows.Forms.Label lblRRWPVal;
        private System.Windows.Forms.Label lblRRWP;
        private System.Windows.Forms.Label lblRRQLVal;
        private System.Windows.Forms.Label lblRRQL;
        private System.Windows.Forms.Label lblRRCPVal;
        private System.Windows.Forms.Label lblRRCP;
        private System.Windows.Forms.Label lblRRCTVal;
        private System.Windows.Forms.Label lblRRCT;
        private System.Windows.Forms.Label lblMLFPVal;
        private System.Windows.Forms.Label lblMLFP;
        private System.Windows.Forms.Label lblMLWP1Val;
        private System.Windows.Forms.Label lblMLWP1;
        private System.Windows.Forms.Label lblMLQLVal;
        private System.Windows.Forms.Label lblMLQL;
        private System.Windows.Forms.Label lblMLCPVal;
        private System.Windows.Forms.Label lblMLCP;
        private System.Data.DataSet dsInputs;
        private System.Windows.Forms.DataGridView tbl1;
        private System.Windows.Forms.DataGridView tbl2;
        private System.Windows.Forms.Label lblMLWP2Val;
        private System.Windows.Forms.Label lblMLWP2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblTQVal;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblTQ;
        private System.Windows.Forms.Label lblMLAvgWaitVal;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.Label lblMLTATVal;
        private System.Windows.Forms.Label lblAvgTAT;
        private System.Windows.Forms.Button btnMin2;
        private System.Windows.Forms.Label lblTQ2Val;
        private System.Windows.Forms.Button btnPlus2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMin1;
        private System.Windows.Forms.Label lblTQ1Val;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRRWaitTImeVal;
        private System.Windows.Forms.Label lblRRWaitTIme;
        private System.Windows.Forms.Label lblRRTATVal;
        private System.Windows.Forms.Label lblRRProcesses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMLQGantt;
        private System.Windows.Forms.Label lblRRTAT;
        private System.Windows.Forms.Label lblProcessVal;
        private System.Windows.Forms.Label lblCPUUtilVal;
        private System.Windows.Forms.Label lblCPUVal;
    }
}