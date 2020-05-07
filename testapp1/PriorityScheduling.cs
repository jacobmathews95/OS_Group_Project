using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace testapp1
{
    public class PriorityScheduling
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

        public string FinishProcess
        {
            get
            {
                string finished = "";
                Processes.ForEach(delegate (Process p)
                {
                    if (p.isFinished)
                        finished += p.getName() + " ";
                });

                return finished;
            }
        }

        public int time = 0;
        public Queue readyQ;
        public void PrioritySchedule(MainForm mainForm, List<Process> processes, ref string seq, int timeQuantum = 10)
        {
            processes.ForEach(delegate (Process p)
            {
                p.print();
            });

            Process idle = new Process("p_idle", 0, 99999, 0);
            //processes.Add(idle);
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

                        if (!readyQ.qProcess.Contains(p) && !p.isFinished)
                        {
                            if (readyQ.qProcess.Count > 0)
                            {
                                //Also using this * to attach the old process at the end
                                if (readyQ.qProcess[0].getBurstTime() == readyQ.qProcess[0].getRemainingTime() && readyQ.qProcess.Count > 1)
                                {
                                    readyQ.qProcess.Add(p);
                                }
                                //Attaching in front 
                                else
                                {
                                    readyQ.qProcess.Insert(0, p);
                                }
                            }
                            //Subsiquient Passes
                            else
                            {

                                readyQ.qProcess.Insert(0, p);

                            }


                            Debug.WriteLine(p.getName() + " at: " + time);
                            arrivedProcess.Add(p);

                            //readyQ.qProcess.Add(p);
                        }
                    }
                });
                //Need to consider when two task arrives at same time with different priority.Not completely implemented.
                if (arrivedProcess.Count > 1)
                {
                    for (int i = 0; i < arrivedProcess.Count; i++)
                    {
                        for (int j = 0; j < arrivedProcess.Count; j++)
                        {
                            //processes with same arrival time
                            if (arrivedProcess[i].getArrivalTime() == arrivedProcess[j].getArrivalTime())
                            {
                                Debug.WriteLine("Arrival time same check for priority");
                                if (arrivedProcess[i].getPriority() < arrivedProcess[j].getPriority())
                                {
                                    Debug.WriteLine("Low priority task is ahead in queue");
                                    //break;
                                }
                            }
                        }
                    }
                }

                //if this is the first pass
                //List<Process> filtered = readyQ.qProcess.GroupBy(item => item.getName()).Where(group=> group.All(item=>item.getArrivalTime())).Select

                if (!readyQ.isEmpty())
                {
                    flag = Schedule(mainForm, readyQ, readyQ.timeQuantum, ref time, processes, ref seq);
                }
                else
                {
                    
                    int r = -1;
                    processes.ForEach(delegate (Process p)
                    {
                        if (!p.isFinished)
                        {
                            r = 1;
                        }
                        else
                        {
                            //Console.WriteLine(p.getName() + " done " + time);
                        }
                    });

                    if (r == 1)
                    {
                        flag = false;
                        time++;
                    }

                    else
                    {
                        flag = true;
                        break;
                        Debug.WriteLine("DOne");
                    }


                }


                //time++;
                if (flag)
                    break;
            }

            processes.ForEach(delegate (Process p)
            {
                Debug.WriteLine(p.getName() + " " + p.completionTime + " " + p.turnAroundTime);
            });
        }

        public bool Schedule(MainForm mainForm, Queue Q, int tQ, ref int time, List<Process> refProcesses, ref string seq)
        {
            bool flag = true;

            if (Q.qProcess[0].getRemainingTime() > 0)
            {
                flag = false;

                #region Handle Higher Priority Queue Items
                //Checking to see if the process needs to be prempted.
                for (int i = 0; i < refProcesses.Count; i++)
                {
                    if (refProcesses[i].getPriority() > Q.qProcess[0].getPriority() && !Q.qProcess.Contains(refProcesses[i]) && !refProcesses[i].isFinished)
                    {
                        int execTime = refProcesses[i].getArrivalTime() - time;
                        if (execTime < tQ)
                        {
                            Debug.WriteLine("Found Process that is not in Q1 and could come in  " + execTime);
                            //TODO: can also do this.
                            //return ScheduleTask(mainForm, Q, execTime, ref time, ref seq, Q1);

                            //return CompleteTask(mainForm, Q, execTime, ref seq, Q1);
                            if (Q.qProcess[0].getRemainingTime() > execTime)
                            {
                                time += execTime;
                                //mainForm.UpdateMLQUI(time, Q.qProcess[0].getName(), Q1.QueueString, Q.QueueString, FinishProcess);
                                Q.qProcess[0].setRemainingTime(execTime);
                                Q.qProcess.Add(Q.qProcess[0]);
                                //Q.qProcess.RemoveAt(0);
                                //return flag;
                            }
                            else if (Q.qProcess[0].getRemainingTime() <= execTime)
                            {
                                time += Q.qProcess[0].getRemainingTime();
                                //mainForm.UpdateMLQUI(time, Q.qProcess[0].getName(), Q1.QueueString, Q.QueueString, FinishProcess);
                                Q.qProcess[0].setRemainingTime(Q.qProcess[0].getRemainingTime());
                                Debug.WriteLine("DOne with : " + Q.qProcess[0].getName() + " " + time);
                                Q.qProcess[0].isFinished = true;
                                Q.qProcess[0].completionTime = time;
                                Q.qProcess[0].turnAroundTime = time - Q.qProcess[0].getArrivalTime();

                                //Waiting Time: 
                                Q.qProcess[0].setWaitingTime(time - Q.qProcess[0].getBurstTime() - Q.qProcess[0].getArrivalTime());

                            }
                            mainForm.UpdateRRUI(time, Q.qProcess[0].getName(), Q.QueueString,FinishProcess);
                            seq += "->" + Q.qProcess[0].getName();
                            Q.qProcess.RemoveAt(0);
                            return flag;
                        }
                    }
                }

            }
            #endregion

            //if no premption is necessary
            //ScheduleTask(mainForm, Q, tQ, ref time, ref seq, Q1);
            if (Q.qProcess[0].getRemainingTime() > 0)
            {
                //setting flag as we need to work on the process
                flag = false;

                //Remaining time to execute is greater than TQ
                if (Q.qProcess[0].getRemainingTime() > tQ)
                {
                    time += tQ;
                    mainForm.UpdateRRUI(time, Q.qProcess[0].getName(), Q.QueueString, FinishProcess);
                    Q.qProcess[0].setRemainingTime(tQ);
                    Q.qProcess.Add(Q.qProcess[0]);
                    seq += "->" + Q.qProcess[0].getName();
                    Q.qProcess.RemoveAt(0);
                    //return flag;

                }
                //Remaining time to execute is less than TQ, process almost done.
                else if (Q.qProcess[0].getRemainingTime() <= tQ)
                {
                    time += Q.qProcess[0].getRemainingTime();
                    Q.qProcess[0].setRemainingTime(Q.qProcess[0].getRemainingTime());
                    Debug.WriteLine("DOne with : " + Q.qProcess[0].getName() + " " + time);
                    Q.qProcess[0].isFinished = true;
                    Q.qProcess[0].completionTime = time;
                    Q.qProcess[0].turnAroundTime = time - Q.qProcess[0].getArrivalTime();

                    //Waiting Time: 
                    Q.qProcess[0].setWaitingTime(time - Q.qProcess[0].getBurstTime() - Q.qProcess[0].getArrivalTime());
                    seq += "->" + Q.qProcess[0].getName();
                    mainForm.UpdateRRUI(time, Q.qProcess[0].getName(), Q.QueueString, FinishProcess);
                    Q.qProcess.RemoveAt(0);
                }
            }

            Q.qProcess.ForEach(delegate (Process p)
            {
                p.print();
            });

            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("");
            Debug.WriteLine("");


            return flag;
        }

        public float AverageTAT(List<Process> pro)
        {
            float averageTAT = 0;

            pro.ForEach(delegate (Process p)
            {
                averageTAT += p.turnAroundTime;
            });

            averageTAT /= pro.Count;
            return averageTAT;
        }

        public float AverageWaitingTime(List<Process> pro)
        {
            float averageWT = 0;
            pro.ForEach(delegate (Process p)
            {
                averageWT += p.getWaitingTime();
            });

            averageWT /= pro.Count;
            return averageWT;
        }
    }
}


