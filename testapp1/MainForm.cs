using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace testapp1
{
    public partial class MainForm : Form
    {
        private DataTable tRR;
        private DataTable tMLQ;
        private MultiLevelQueue mlqAlgo;
        private PriorityScheduling priorityAlgo;

        public MainForm()
        {
            InitializeComponent();
            MakeDataSet();
            tbl1.AutoGenerateColumns = true;
            tbl1.DataSource = dsInputs; // dataset
            tbl1.DataMember = "RR"; // table name you need to show

            tbl2.AutoGenerateColumns = true;
            tbl2.DataSource = dsInputs; // dataset
            tbl2.DataMember = "MLQ"; // table name you need to show

            priorityAlgo = new PriorityScheduling();
            for (int i = 0; i < tRR.Rows.Count; i++)
                priorityAlgo.Processes.Add(new Process(tRR.Rows[i].Field<string>(0), tRR.Rows[i].Field<int>(2), tRR.Rows[i].Field<int>(1), tRR.Rows[i].Field<int>(3)));

            mlqAlgo = new MultiLevelQueue();
            for (int i = 0; i < tMLQ.Rows.Count; i++) //Should it be until count
                mlqAlgo.Processes.Add(new Process(tMLQ.Rows[i].Field<string>(0), tMLQ.Rows[i].Field<int>(2), tMLQ.Rows[i].Field<int>(1), tMLQ.Rows[i].Field<int>(3)));
      
            mlqAlgo.Processes.ForEach(delegate (Process p)
            {
                p.print();
            });
            //Process idle = new Process("p_idle", 999, 99999, 0);
           
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
            tRR = new DataTable("RR");
            tMLQ = new DataTable("MLQ");

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

            #region Add RR Data
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
            #endregion

            #region Add MLQ Data
            DataRow r1 = tMLQ.NewRow();
            r1["pid"] = "P1";
            tMLQ.Rows.Add(r1);
            tMLQ.Rows[0][1] = 12;
            tMLQ.Rows[0][2] = 1;
            tMLQ.Rows[0][3] = 0;

            DataRow r2 = tMLQ.NewRow();
            r2["pid"] = "P2";
            tMLQ.Rows.Add(r2);
            tMLQ.Rows[1][1] = 8;
            tMLQ.Rows[1][2] = 2;
            tMLQ.Rows[1][3] = 4;

            DataRow r3 = tMLQ.NewRow();
            r3["pid"] = "P3";
            tMLQ.Rows.Add(r3);
            tMLQ.Rows[2][1] = 6;
            tMLQ.Rows[2][2] = 1;
            tMLQ.Rows[2][3] = 5;

            DataRow r4 = tMLQ.NewRow();
            r4["pid"] = "P4";
            tMLQ.Rows.Add(r4);
            tMLQ.Rows[3][1] = 5;
            tMLQ.Rows[3][2] = 2;
            tMLQ.Rows[3][3] = 12;

            DataRow r5 = tMLQ.NewRow();
            r5["pid"] = "P5";
            tMLQ.Rows.Add(r5);
            tMLQ.Rows[4][1] = 10;
            tMLQ.Rows[4][2] = 2;
            tMLQ.Rows[4][3] = 18;

            #endregion

        }
        
        private void buttonRR_Click(object sender, EventArgs e)
        {
            String seq = "";
            priorityAlgo.PrioritySchedule(this, priorityAlgo.Processes, ref seq);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            priorityAlgo.Processes.ForEach(delegate (Process p)
            {
                p.print();
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //onclick for MLQ


            //idle.print();
            String seq = "";

            mlqAlgo.MultiLevelQ(this, mlqAlgo.Processes, ref seq);


            //RoundRobinA(q1);
            //Average TAT

            mlqAlgo.Processes.ForEach(delegate (Process p)
            {
                p.print();

                //Console.WriteLine(p.getName() + " " + p.completionTime + "  " + p.turnAroundTime);
                //tat += p.turnAroundTime;
            });


            Debug.WriteLine("AVG: TAT          = " + mlqAlgo.AverageTAT(mlqAlgo.Processes));
            Debug.WriteLine("AVG: Waiting Time = " + mlqAlgo.AverageWaitingTime(mlqAlgo.Processes));

            Debug.WriteLine(seq);

            lblMLTATVal.Text = mlqAlgo.AverageTAT(mlqAlgo.Processes).ToString();
            lblMLAvgWaitVal.Text = mlqAlgo.AverageWaitingTime(mlqAlgo.Processes).ToString();



        }


        public void UpdateMLQUI(int currentTime, 
            string currentProcess, 
            string q1ProcessesWaiting, 
            string q2ProcessesWaiting, 
            string finishedProcesses)
        {
            lblMLCTVal.Text = currentTime.ToString();
            lblMLCPVal.Text = currentProcess;
            lblMLWP1Val.Text = q1ProcessesWaiting;
            lblMLWP2Val.Text = q2ProcessesWaiting;
            lblMLFPVal.Text = finishedProcesses;
        }

    }
}
