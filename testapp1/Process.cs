using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace testapp1
{
    public class Process
    {
        string name;
        int priority;
        int burstTime;
        int arrivalTime;
        int remainingTime;
        int waitingTime;

        //Might help is algorithm
        public bool processWaiting { get; set; }
        public bool isFinished { get; set; }

        public int completionTime { get; set; }
        public int turnAroundTime { get; set; }

        public Process(string _name, int _priority, int _burstTime, int _arrivalTime)
        {
            name = _name;
            priority = _priority;
            burstTime = _burstTime;
            arrivalTime = _arrivalTime;
            remainingTime = _burstTime;
            waitingTime = 0;
            isFinished = false;
            processWaiting = true;
        }

        //Getters
        public string getName()
        {
            return name;
        }

        public int getPriority()
        {
            return priority;
        }

        public int getBurstTime()
        {
            return burstTime;
        }

        public int getArrivalTime()
        {
            return arrivalTime;
        }

        public int getRemainingTime()
        {
            return remainingTime;
        }

        public int getWaitingTime()
        {
            return waitingTime;
        }



        //Setters
        //arg: gets exectuted time that needs to be subracted 
        public void setRemainingTime(int executedTime)
        {
            remainingTime -= executedTime;
        }

        //Increment waiting time by 'int waited'
        public void setWaitingTime(int waited)
        {
            waitingTime += waited;
        }


        //Displaying Output for console
        public void print()
        {
            Debug.WriteLine(String.Format("{0,-6} | {1, 15}: {2,-5} | {3,15}: {4,-5} | {5,15}: {6,-5} | {7,15}: {8,-5} | {9,15}: {10, -5}",
                $"{name}",
                "arrivalTime", $"{arrivalTime}",
                "priority:", $"{priority}",
                "burstTime", $"{burstTime}",
                "waitingTime", $" {waitingTime}",
                "remainingTime", $"{remainingTime}"

                ));
            //Console.WriteLine($"{name}:   arrivalTime: {arrivalTime}     priority: {priority}     burstTime: {burstTime}     waitingTime: {waitingTime}     remainingTime: {remainingTime}");
        }

    }

    public class Queue
    {

        public List<Process> qProcess { get; set; }
        public int timeQuantum { get; set; }

        public bool IsActive { get; set; }
        public string QueueString { get; }
          //  get {
            //loop the queueu to display to user
            //} 

        public Queue()
        {
            qProcess = new List<Process>();
        }

        public Queue(int tQ)
        {
            this.timeQuantum = tQ;
            qProcess = new List<Process>();
        }
        public void printQ()
        {
            Console.WriteLine("Q: " + qProcess.Count);
        }

        public bool isEmpty()
        {
            int r = -1;
            qProcess.ForEach(delegate (Process p)
            {
                if (!p.isFinished)
                {
                    r = 1;
                }
            });

            if (r == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //May be add isEmpty, Priority...
    }

    public class MultiLevelQueue
    {
        //List of processes can be done dynamically if needed

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
        
        //High Priority Q with time quantum 3
        public Queue readyQ;

        //Low Priority Q with time qunatum 4
        public Queue readyQ2;


        public void MultiLevelQ(MainForm mainForm, List<Process> processes, ref string seq, int timeQuantum1 = 3, int timeQuantum2 = 4)
        {
            _MainForm = mainForm;

            //High Priority Q with time quantum 3
            readyQ = new Queue(timeQuantum1);

            //Low Priority Q with time qunatum 4
            readyQ2 = new Queue(timeQuantum2);


            //Running alorithm
            while (true)
            {
                //Breaking condition
                bool flag = true;

                //Adding process to respective queue if they have arrived
                processes.ForEach(delegate (Process p)
                {
                    //Arrived Processes
                    if (p.getArrivalTime() <= time)
                    {
                        //High priority
                        if (p.getPriority() == 1)
                        {
                            //If not already on Q and is not finished
                            if (!readyQ.qProcess.Contains(p) && p.isFinished == false)
                            {
                                //1st Pass
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
                                Debug.WriteLine("Added: " + p.getName() + " @ " + time);
                            }
                        }
                        //Same for Low priority Q
                        else if (p.getPriority() == 2)
                        {
                            if (!readyQ2.qProcess.Contains(p) && p.isFinished == false)
                            {
                                if (readyQ2.qProcess.Count > 0)
                                {
                                    if (readyQ2.qProcess[0].getBurstTime() == readyQ2.qProcess[0].getRemainingTime())
                                    {
                                        readyQ2.qProcess.Add(p);
                                    }
                                    else
                                    {
                                        readyQ2.qProcess.Insert(0, p);
                                    }
                                }
                                else
                                {
                                    readyQ2.qProcess.Insert(0, p);
                                }

                                Debug.WriteLine("Added: " + p.getName() + " @2 " + time);
                            }
                        }
                    }
                });

                //Checking if 1st Queue is not empty
                if (!readyQ.isEmpty())
                {
                    //HP Q not to worry about premption.
                    flag = ScheduleTask(readyQ, readyQ.timeQuantum, ref time, ref seq);
                }
                //HP (high priority) Q is empty, we execute LP Q
                else if (readyQ.isEmpty() && !readyQ2.isEmpty())
                {
                    //Have o take care of premption.
                    flag = ScheduleTask2(readyQ2, readyQ2.timeQuantum, ref time, ref seq, processes, readyQ);
                }
                //We only exit if all the tasks are done, taking care of instances when the Q is empty
                else
                {
                    //Checking is all task are completed
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

                if (flag)
                    break;
            }
        }

        //HP schedule
        public bool ScheduleTask(MainForm mainForm, Queue Q, int tQ, ref int time, ref string seq)
        {
            bool flag = true;
            //checking if the process is still not finished
            if (Q.qProcess[0].getRemainingTime() > 0)
            {
                //setting flag as we need to work on the process
                flag = false;

                //Remaining time to execute is greater than TQ
                if (Q.qProcess[0].getRemainingTime() > tQ)
                {
                    time += tQ;
                    mainForm.UpdateMLQUI(time, Q.QueueString());
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
                    Q.qProcess.RemoveAt(0);
                }
                else
                {
                    //return !flag;
                }
            }

            //Utility used while debugging
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

        //For LP Q
        public bool ScheduleTask2(MainForm mainForm, Queue Q, int tQ, ref int time, ref string seq, List<Process> refProcesses, Queue Q1)
        {
            bool flag = true;


            //for (int i = 0; i < Q.qProcess.Count; i++)
            //{

            if (Q.qProcess[0].getRemainingTime() > 0)
            {
                flag = false;

                #region Handle Higher Priority Queue Items
                //Checking to see if the process needs to be prempted.
                for (int i = 0; i < refProcesses.Count; i++)
                {
                    if (refProcesses[i].getPriority() == 1 && !Q1.qProcess.Contains(refProcesses[i]))
                    {
                        if (!refProcesses[i].isFinished)
                        {
                            int execTime = refProcesses[i].getArrivalTime() - time;
                            if (execTime < tQ)
                            {
                                Debug.WriteLine("Found Process that is not in Q1 and could come in  " + execTime);

                                if (Q.qProcess[0].getRemainingTime() > execTime)
                                {
                                    time += execTime;
                                    Q.qProcess[0].setRemainingTime(execTime);
                                    Q.qProcess.Add(Q.qProcess[0]);
                                    Q.qProcess.RemoveAt(0);
                                    return flag;
                                }
                                else if (Q.qProcess[0].getRemainingTime() <= execTime)
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
                                    Q.qProcess.RemoveAt(0);
                                    return flag;
                                }
                            }
                        }
                    }
                }
                #endregion

                //if no premption is necessary
                if (Q.qProcess[0].getRemainingTime() > tQ)
                {
                    time += tQ;
                    Q.qProcess[0].setRemainingTime(tQ);
                    Q.qProcess.Add(Q.qProcess[0]);
                    seq += "->" + Q.qProcess[0].getName();
                    Q.qProcess.RemoveAt(0);
                    //return flag;

                }
                else if (Q.qProcess[0].getRemainingTime() <= tQ)
                {
                    time += Q.qProcess[0].getRemainingTime();
                    Q.qProcess[0].setRemainingTime(Q.qProcess[0].getRemainingTime());
                    Debug.WriteLine("Done with : " + Q.qProcess[0].getName() + " " + time);
                    Q.qProcess[0].isFinished = true;
                    Q.qProcess[0].completionTime = time;
                    Q.qProcess[0].turnAroundTime = time - Q.qProcess[0].getArrivalTime();

                    //Waiting Time: 
                    Q.qProcess[0].setWaitingTime(time - Q.qProcess[0].getBurstTime() - Q.qProcess[0].getArrivalTime());
                    seq += "->" + Q.qProcess[0].getName();
                    Q.qProcess.RemoveAt(0);
                }
                else
                {
                    //return !flag;
                }



                Q.qProcess.ForEach(delegate (Process p)
                {
                    p.print();
                });

                Debug.WriteLine("");
                Debug.WriteLine("");
                Debug.WriteLine("");
                Debug.WriteLine("");
            }

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