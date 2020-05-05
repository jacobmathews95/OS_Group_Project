﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testapp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MakeDataSet();
            tbl1.AutoGenerateColumns = true;
            tbl1.DataSource = dsInputs; // dataset
            tbl1.DataMember = "RR"; // table name you need to show
        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void lblMLFP_Click(object sender, EventArgs e) //MULTILEVEL FINISHED PROCESSES LABEL
        {

        }

        private void lblMLFPVal_Click(object sender, EventArgs e) // MULTILEVEL FINISHED PROCESSES VALUE LABEL
        {

        }

        private void rr_Click(object sender, EventArgs e)
        {
            
        }



        // Create a DataSet with two tables and populate it.
        private void MakeDataSet()
        {

            // Create two DataTables.
            DataTable tRR = new DataTable("RR");
            DataTable tMLQ = new DataTable("MLQ");

            // Create column definitions
            DataColumn cPID = new DataColumn("pid", typeof(string));
            DataColumn cBurst = new DataColumn("brust",typeof(int));
            DataColumn cPriority = new DataColumn("priority", typeof(int));
            DataColumn cArrival = new DataColumn("arrival", typeof(int));

            DataColumn tPID = new DataColumn("pid", typeof(string));
            DataColumn tBurst = new DataColumn("brust", typeof(int));
            DataColumn tPriority = new DataColumn("priority", typeof(int));
            DataColumn tArrival = new DataColumn("arrival", typeof(int));

            // Add columns to first table
            tRR.Columns.Add(cPID);
            tRR.Columns.Add(cBurst);
            tRR.Columns.Add(cPriority);
            tRR.Columns.Add(cArrival);

            // Add columns to second table
            tMLQ.Columns.Add(tPID);
            tMLQ.Columns.Add(tBurst);
            tMLQ.Columns.Add(tPriority);
            tMLQ.Columns.Add(tArrival);

            // Add the tables to the DataSet.
            dsInputs.Tables.Add(tRR);
            dsInputs.Tables.Add(tMLQ);


            DataRow dr1 = tRR.NewRow();
            dr1["pid"] = "P1";
            tRR.Rows.Add(dr1);
            tRR.Rows[0][1] = 15;
            tRR.Rows[0][2] = 40;
            tRR.Rows[0][3] = 0;

            DataRow dr2 = tRR.NewRow();
            dr2["pid"] = "P2";
            tRR.Rows.Add(dr2);
            tRR.Rows[1][1] = 25;
            tRR.Rows[1][2] = 30;
            tRR.Rows[1][3] = 25;

            DataRow dr3 = tRR.NewRow();
            dr3["pid"] = "P3";
            tRR.Rows.Add(dr3);
            tRR.Rows[2][1] = 20;
            tRR.Rows[2][2] = 30;
            tRR.Rows[2][3] = 30;

            DataRow dr4 = tRR.NewRow();
            dr4["pid"] = "P4";
            tRR.Rows.Add(dr4);
            tRR.Rows[3][1] = 15;
            tRR.Rows[3][2] = 35;
            tRR.Rows[3][3] = 50;

            DataRow dr5 = tRR.NewRow();
            dr5["pid"] = "P5";
            tRR.Rows.Add(dr5);
            tRR.Rows[4][1] = 15;
            tRR.Rows[4][2] = 5;
            tRR.Rows[4][3] = 100;

            DataRow dr6 = tRR.NewRow();
            dr6["pid"] = "P6";
            tRR.Rows.Add(dr6);
            tRR.Rows[5][1] = 10;
            tRR.Rows[5][2] = 10;
            tRR.Rows[5][3] = 105;


        }





    }
}
