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
            this.lblMLWPVal = new System.Windows.Forms.Label();
            this.lblMLWP = new System.Windows.Forms.Label();
            this.lblMLQLVal = new System.Windows.Forms.Label();
            this.lblMLQL = new System.Windows.Forms.Label();
            this.lblMLCPVal = new System.Windows.Forms.Label();
            this.lblMLCP = new System.Windows.Forms.Label();
            this.lblMLCTVal = new System.Windows.Forms.Label();
            this.lblMLCT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTQ = new System.Windows.Forms.Label();
            this.lblTQVal = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dsInputs = new System.Data.DataSet();
            this.tbl1 = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.rr.SuspendLayout();
            this.mlq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.rr);
            this.tabMain.Controls.Add(this.mlq);
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
            this.mlq.Controls.Add(this.lblMLFPVal);
            this.mlq.Controls.Add(this.lblMLFP);
            this.mlq.Controls.Add(this.lblMLWPVal);
            this.mlq.Controls.Add(this.lblMLWP);
            this.mlq.Controls.Add(this.lblMLQLVal);
            this.mlq.Controls.Add(this.lblMLQL);
            this.mlq.Controls.Add(this.lblMLCPVal);
            this.mlq.Controls.Add(this.lblMLCP);
            this.mlq.Controls.Add(this.lblMLCTVal);
            this.mlq.Controls.Add(this.lblMLCT);
            this.mlq.Controls.Add(this.button1);
            this.mlq.Controls.Add(this.button2);
            this.mlq.Controls.Add(this.tableLayoutPanel2);
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
            // lblMLWPVal
            // 
            this.lblMLWPVal.AutoSize = true;
            this.lblMLWPVal.Location = new System.Drawing.Point(201, 289);
            this.lblMLWPVal.Name = "lblMLWPVal";
            this.lblMLWPVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLWPVal.TabIndex = 13;
            this.lblMLWPVal.Text = "[value]";
            // 
            // lblMLWP
            // 
            this.lblMLWP.AutoSize = true;
            this.lblMLWP.Location = new System.Drawing.Point(94, 289);
            this.lblMLWP.Name = "lblMLWP";
            this.lblMLWP.Size = new System.Drawing.Size(101, 13);
            this.lblMLWP.TabIndex = 12;
            this.lblMLWP.Text = "Waiting Processes: ";
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
            this.lblMLCTVal.Location = new System.Drawing.Point(370, 191);
            this.lblMLCTVal.Name = "lblMLCTVal";
            this.lblMLCTVal.Size = new System.Drawing.Size(39, 13);
            this.lblMLCTVal.TabIndex = 7;
            this.lblMLCTVal.Text = "[value]";
            // 
            // lblMLCT
            // 
            this.lblMLCT.AutoSize = true;
            this.lblMLCT.Location = new System.Drawing.Point(297, 191);
            this.lblMLCT.Name = "lblMLCT";
            this.lblMLCT.Size = new System.Drawing.Size(73, 13);
            this.lblMLCT.TabIndex = 6;
            this.lblMLCT.Text = "Current Time: ";
            this.lblMLCT.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 124);
            this.tableLayoutPanel2.TabIndex = 3;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.Label lblMLWPVal;
        private System.Windows.Forms.Label lblMLWP;
        private System.Windows.Forms.Label lblMLQLVal;
        private System.Windows.Forms.Label lblMLQL;
        private System.Windows.Forms.Label lblMLCPVal;
        private System.Windows.Forms.Label lblMLCP;
        private System.Data.DataSet dsInputs;
        private System.Windows.Forms.DataGridView tbl1;
    }
}