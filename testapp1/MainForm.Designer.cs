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
            this.mlq = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTQ = new System.Windows.Forms.Label();
            this.lblTQVal = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.rr.SuspendLayout();
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
            this.rr.Controls.Add(this.btnReset);
            this.rr.Controls.Add(this.btnCalc);
            this.rr.Controls.Add(this.tableLayoutPanel1);
            this.rr.Location = new System.Drawing.Point(4, 22);
            this.rr.Name = "rr";
            this.rr.Padding = new System.Windows.Forms.Padding(3);
            this.rr.Size = new System.Drawing.Size(768, 366);
            this.rr.TabIndex = 0;
            this.rr.Text = "Round Robin";
            this.rr.UseVisualStyleBackColor = true;
            // 
            // mlq
            // 
            this.mlq.Location = new System.Drawing.Point(4, 22);
            this.mlq.Name = "mlq";
            this.mlq.Padding = new System.Windows.Forms.Padding(3);
            this.mlq.Size = new System.Drawing.Size(768, 391);
            this.mlq.TabIndex = 1;
            this.mlq.Text = "Multilevel Queue";
            this.mlq.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(262, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(365, 152);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage rr;
        private System.Windows.Forms.TabPage mlq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTQ;
        private System.Windows.Forms.Label lblTQVal;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
    }
}