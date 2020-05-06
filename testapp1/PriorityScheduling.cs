using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace testapp1
{
    class PriorityScheduling
    {
        private MainForm _MainForm;

        private List<Process> _processes;
        private List<Int64> _gantt;

        public List<Process> Processes
        {
            get
            {
                if (_processes == null)
                    _processes = new List<Process>();
                return _processes;
            }
        }

        public List<Int64> Gantt
        {
            get
            {
                if (_gantt == null)
                    _gantt = new List<Int64>();
                return _gantt;
            }
        }

        public int time = 0;
        public Queue readyQ;
        public void PrioritySchedule(MainForm mainForm, List<Process> processes, ref string seq, int timeQuantum = 10 )
        {
            processes.ForEach(delegate (Process p)
            {
                p.print();
            });

            Process idle = new Process("p_idle", 0, 99999, 0);
            readyQ = new Queue(timeQuantum);

            while (true)
            {
                //using to break loop 
                bool flag = true;
                List<Process> arrivedProcess = new List<Process>();
                processes.ForEach(delegate (Process p)
                {
                    if (p.getArrivalTime() <= time)
                    {
                        
                        if (!readyQ.qProcess.Contains(p))
                        {
                            Debug.WriteLine(p.getName() + " at: " + time);
                            arrivedProcess.Add(p);
                            
                            readyQ.qProcess.Add(p);
                        }
                    }
                });

                //Need to consider when two task arrives at same time with different priority.
                arrivedProcess.ForEach(delegate (Process p)
                {

                    //if this is the first pass
                    //List<Process> filtered = readyQ.qProcess.GroupBy(item => item.getName()).Where(group=> group.All(item=>item.getArrivalTime())).Select

                    arrivedProcess =  arrivedProcess.OrderBy(o => o.getPriority()).ToList();
                    foreach (var item in arrivedProcess)
                    {
                        item.print();
                    }
                });

                time++;
                if (flag && time > 200)
                    break;
            }
        }
    }
}
