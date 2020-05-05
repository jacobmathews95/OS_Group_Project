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
            this.lblTQ = new System.Windows.Forms.Label();
            this.lblTQVal = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dsInputs = new System.Data.DataSet();
            this.tbl1 = new System.Windows.Forms.DataGridView();
            this.tbl2 = new System.Windows.Forms.DataGridView();
            this.lblMLWP2Val = new System.Windows.Forms.Label();
            this.lblMLWP2 = new System.Windows.Forms.Label();
            this.rrGantt = new System.Windows.Forms.TabPage();
            this.mlqGantt = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.rr.SuspendLayout();
            this.mlq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.rr);
            this.tabMain.Controls.Add(this.mlq);
            this.tabMain.Controls.Add(this.rrGantt);
            this.tabMain.Controls.Add(this.mlqGantt);
            this.tabMain.Location = new System.Drawing.Point(12, 37);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(776, 392);
            this.tabMain.TabIndex = 0;
            // 
            // rr
            // 
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
            this.rr.Location = new System.Drawing.Point(4, 22);
            this.rr.Name = "rr";
            this.rr.Padding = new System.Windows.Forms.Padding(3);
            this.rr.Size = new System.Drawing.Size(768, 366);
            this.rr.TabIndex = 0;
            this.rr.Text = "Round Robin";
            this.rr.UseVisualStyleBackColor = true;
            this.rr.Click += new System.EventHandler(this.rr_Click);
            // 
            // lblRRFPVal
            // 
            this.lblRRFPVal.AutoSize = true;
            this.lblRRFPVal.Location = new System.Drawing.Point(597, 285);
            this.lblRRFPVal.Name = "lblRRFPVal";
            this.lblRRFPVal.Size = new System.Drawing.Size(39, 13);
            this.lblRRFPVal.TabIndex = 23;
            this.lblRRFPVal.Text = "[value]";
            // 
            // lblRRFP
            // 
            this.lblRRFP.AutoSize = true;
            this.lblRRFP.Location = new System.Drawing.Point(487, 285);
            this.lblRRFP.Name = "lblRRFP";
            this.lblRRFP.Size = new System.Drawing.Size(104, 13);
            this.lblRRFP.TabIndex = 22;
            this.lblRRFP.Text = "Finished Processes: ";
            // 
            // lblRRWPVal
            // 
            this.lblRRWPVal.AutoSize = true;
            this.lblRRWPVal.Location = new System.Drawing.Point(219, 285);
            this.lblRRWPVal.Name = "lblRRWPVal";
            this.lblRRWPVal.Size = new System.Drawing.Size(39, 13);
            this.lblRRWPVal.TabIndex = 21;
            this.lblRRWPVal.Text = "[value]";
            // 
            // lblRRWP
            // 
            this.lblRRWP.AutoSize = true;
            this.lblRRWP.Location = new System.Drawing.Point(112, 285);
            this.lblRRWP.Name = "lblRRWP";
            this.lblRRWP.Size = new System.Drawing.Size(101, 13);
            this.lblRRWP.TabIndex = 20;
            this.lblRRWP.Text = "Waiting Processes: ";
            // 
            // lblRRQLVal
            // 
            this.lblRRQLVal.AutoSize = true;
            this.lblRRQLVal.Location = new System.Drawing.Point(560, 239);
            this.lblRRQLVal.Name = "lblRRQLVal";
            this.lblRRQLVal.Size = new System.Drawing.Size(39, 13);
            this.lblRRQLVal.TabIndex = 19;
            this.lblRRQLVal.Text = "[value]";
            // 
            // lblRRQL
            // 
            this.lblRRQL.AutoSize = true;
            this.lblRRQL.Location = new System.Drawing.Point(487, 239);
            this.lblRRQL.Name = "lblRRQL";
            this.lblRRQL.Size = new System.Drawing.Size(77, 13);
            this.lblRRQL.TabIndex = 18;
            this.lblRRQL.Text = "Quantum Left: ";
            // 
            // lblRRCPVal
            // 
            this.lblRRCPVal.AutoSize = true;
            this.lblRRCPVal.Location = new System.Drawing.Point(206, 239);
            this.lblRRCPVal.Name = "lblRRCPVal";
            this.lblRRCPVal.Size = new System.Drawing.Size(39, 13);
            this.lblRRCPVal.TabIndex = 17;
            this.lblRRCPVal.Text = "[value]";
            // 
            // lblRRCP
            // 
            this.lblRRCP.AutoSize = true;
            this.lblRRCP.Location = new System.Drawing.Point(112, 239);
            this.lblRRCP.Name = "lblRRCP";
            this.lblRRCP.Size = new System.Drawing.Size(88, 13);
            this.lblRRCP.TabIndex = 16;
            this.lblRRCP.Text = "Current Process: ";
            // 
            // lblRRCTVal
            // 
            this.lblRRCTVal.AutoSize = true;
            this.lblRRCTVal.Location = new System.Drawing.Point(369, 211);
            this.lblRRCTVal.Name = "lblRRCTVal";
            this.lblRRCTVal.Size = new System.Drawing.Size(39, 13);
            this.lblRRCTVal.TabIndex = 9;
            this.lblRRCTVal.Text = "[value]";
            // 
            // lblRRCT
            // 
            this.lblRRCT.AutoSize = true;
            this.lblRRCT.Location = new System.Drawing.Point(296, 211);
            this.lblRRCT.Name = "lblRRCT";
            this.lblRRCT.Size = new System.Drawing.Size(73, 13);
            this.lblRRCT.TabIndex = 8;
            this.lblRRCT.Text = "Current Time: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(366, 169);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(263, 169);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // mlq
            // 
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
            this.mlq.Location = new System.Drawing.Point(4, 22);
            this.mlq.Name = "mlq";
            this.mlq.Padding = new System.Windows.Forms.Padding(3);
            this.mlq.Size = new System.Drawing.Size(768, 366);
            this.mlq.TabIndex = 1;
            this.mlq.Text = "Multilevel Queue";
            this.mlq.UseVisualStyleBackColor = true;
            // 
            // lblMLFPVal
            // 
            this.lblMLFPVal.AutoSize = true;
            this.lblMLFPVal.Location = new System.Drawing.Point(579, 289);
            this.lblMLFPVal.Name = "lblMLFPVal";
            this.lblMLFPVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLFPVal.TabIndex = 15;
            this.lblMLFPVal.Text = "[value]";
            this.lblMLFPVal.Click += new System.EventHandler(this.lblMLFPVal_Click);
            // 
            // lblMLFP
            // 
            this.lblMLFP.AutoSize = true;
            this.lblMLFP.Location = new System.Drawing.Point(469, 289);
            this.lblMLFP.Name = "lblMLFP";
            this.lblMLFP.Size = new System.Drawing.Size(104, 13);
            this.lblMLFP.TabIndex = 14;
            this.lblMLFP.Text = "Finished Processes: ";
            this.lblMLFP.Click += new System.EventHandler(this.lblMLFP_Click);
            // 
            // lblMLWP1Val
            // 
            this.lblMLWP1Val.AutoSize = true;
            this.lblMLWP1Val.Location = new System.Drawing.Point(188, 276);
            this.lblMLWP1Val.Name = "lblMLWP1Val";
            this.lblMLWP1Val.Size = new System.Drawing.Size(39, 13);
            this.lblMLWP1Val.TabIndex = 13;
            this.lblMLWP1Val.Text = "[value]";
            // 
            // lblMLWP1
            // 
            this.lblMLWP1.AutoSize = true;
            this.lblMLWP1.Location = new System.Drawing.Point(81, 276);
            this.lblMLWP1.Name = "lblMLWP1";
            this.lblMLWP1.Size = new System.Drawing.Size(93, 13);
            this.lblMLWP1.TabIndex = 12;
            this.lblMLWP1.Text = "Queue 1 Waiting: ";
            // 
            // lblMLQLVal
            // 
            this.lblMLQLVal.AutoSize = true;
            this.lblMLQLVal.Location = new System.Drawing.Point(542, 243);
            this.lblMLQLVal.Name = "lblMLQLVal";
            this.lblMLQLVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLQLVal.TabIndex = 11;
            this.lblMLQLVal.Text = "[value]";
            // 
            // lblMLQL
            // 
            this.lblMLQL.AutoSize = true;
            this.lblMLQL.Location = new System.Drawing.Point(469, 243);
            this.lblMLQL.Name = "lblMLQL";
            this.lblMLQL.Size = new System.Drawing.Size(77, 13);
            this.lblMLQL.TabIndex = 10;
            this.lblMLQL.Text = "Quantum Left: ";
            // 
            // lblMLCPVal
            // 
            this.lblMLCPVal.AutoSize = true;
            this.lblMLCPVal.Location = new System.Drawing.Point(188, 243);
            this.lblMLCPVal.Name = "lblMLCPVal";
            this.lblMLCPVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLCPVal.TabIndex = 9;
            this.lblMLCPVal.Text = "[value]";
            // 
            // lblMLCP
            // 
            this.lblMLCP.AutoSize = true;
            this.lblMLCP.Location = new System.Drawing.Point(94, 243);
            this.lblMLCP.Name = "lblMLCP";
            this.lblMLCP.Size = new System.Drawing.Size(88, 13);
            this.lblMLCP.TabIndex = 8;
            this.lblMLCP.Text = "Current Process: ";
            // 
            // lblMLCTVal
            // 
            this.lblMLCTVal.AutoSize = true;
            this.lblMLCTVal.Location = new System.Drawing.Point(369, 210);
            this.lblMLCTVal.Name = "lblMLCTVal";
            this.lblMLCTVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLCTVal.TabIndex = 7;
            this.lblMLCTVal.Text = "[value]";
            // 
            // lblMLCT
            // 
            this.lblMLCT.AutoSize = true;
            this.lblMLCT.Location = new System.Drawing.Point(296, 210);
            this.lblMLCT.Name = "lblMLCT";
            this.lblMLCT.Size = new System.Drawing.Size(73, 13);
            this.lblMLCT.TabIndex = 6;
            this.lblMLCT.Text = "Current Time: ";
            this.lblMLCT.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTQ
            // 
            this.lblTQ.AutoSize = true;
            this.lblTQ.Location = new System.Drawing.Point(13, 13);
            this.lblTQ.Name = "lblTQ";
            this.lblTQ.Size = new System.Drawing.Size(119, 13);
            this.lblTQ.TabIndex = 1;
            this.lblTQ.Text = "Current Time Quantum: ";
            // 
            // lblTQVal
            // 
            this.lblTQVal.AutoSize = true;
            this.lblTQVal.Location = new System.Drawing.Point(128, 13);
            this.lblTQVal.Name = "lblTQVal";
            this.lblTQVal.Size = new System.Drawing.Size(40, 13);
            this.lblTQVal.TabIndex = 2;
            this.lblTQVal.Text = "[Value]";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(239, 8);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = " - ";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(187, 8);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = " + ";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // dsInputs
            // 
            this.dsInputs.DataSetName = "NewDataSet";
            // 
            // tbl1
            // 
            this.tbl1.AutoGenerateColumns = false;
            this.tbl1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl1.DataSource = this.dsInputs;
            this.tbl1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl1.Location = new System.Drawing.Point(5, 3);
            this.tbl1.Name = "tbl1";
            this.tbl1.Size = new System.Drawing.Size(757, 150);
            this.tbl1.TabIndex = 24;
            // 
            // tbl2
            // 
            this.tbl2.AutoGenerateColumns = false;
            this.tbl2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl2.DataSource = this.dsInputs;
            this.tbl2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbl2.Location = new System.Drawing.Point(6, 0);
            this.tbl2.Name = "tbl2";
            this.tbl2.Size = new System.Drawing.Size(757, 150);
            this.tbl2.TabIndex = 25;
            // 
            // lblMLWP2Val
            // 
            this.lblMLWP2Val.AutoSize = true;
            this.lblMLWP2Val.Location = new System.Drawing.Point(188, 300);
            this.lblMLWP2Val.Name = "lblMLWP2Val";
            this.lblMLWP2Val.Size = new System.Drawing.Size(39, 13);
            this.lblMLWP2Val.TabIndex = 27;
            this.lblMLWP2Val.Text = "[value]";
            // 
            // lblMLWP2
            // 
            this.lblMLWP2.AutoSize = true;
            this.lblMLWP2.Location = new System.Drawing.Point(81, 300);
            this.lblMLWP2.Name = "lblMLWP2";
            this.lblMLWP2.Size = new System.Drawing.Size(93, 13);
            this.lblMLWP2.TabIndex = 26;
            this.lblMLWP2.Text = "Queue 2 Waiting: ";
            // 
            // rrGantt
            // 
            this.rrGantt.Location = new System.Drawing.Point(4, 22);
            this.rrGantt.Name = "rrGantt";
            this.rrGantt.Padding = new System.Windows.Forms.Padding(3);
            this.rrGantt.Size = new System.Drawing.Size(768, 366);
            this.rrGantt.TabIndex = 2;
            this.rrGantt.Text = "Round Robin Gantt Chart";
            this.rrGantt.UseVisualStyleBackColor = true;
            // 
            // mlqGantt
            // 
            this.mlqGantt.Location = new System.Drawing.Point(4, 22);
            this.mlqGantt.Name = "mlqGantt";
            this.mlqGantt.Padding = new System.Windows.Forms.Padding(3);
            this.mlqGantt.Size = new System.Drawing.Size(768, 366);
            this.mlqGantt.TabIndex = 3;
            this.mlqGantt.Text = "Multilevel Queue Gantt Chart";
            this.mlqGantt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblTQVal);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblTQ);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabMain.ResumeLayout(false);
            this.rr.ResumeLayout(false);
            this.rr.PerformLayout();
            this.mlq.ResumeLayout(false);
            this.mlq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage rr;
        private System.Windows.Forms.TabPage mlq;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTQ;
        private System.Windows.Forms.Label lblTQVal;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
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
        private System.Windows.Forms.TabPage rrGantt;
        private System.Windows.Forms.TabPage mlqGantt;
    }
}