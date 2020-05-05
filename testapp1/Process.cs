using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp1
{
    class Process
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
            Console.WriteLine(String.Format("{0,-6} | {1, 15}: {2,-5} | {3,15}: {4,-5} | {5,15}: {6,-5} | {7,15}: {8,-5} | {9,15}: {10, -5}",
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

    static void notMain(string[] args)
    {

        //List of processes can be done dynamically if needed
        List<Process> processes = new List<Process>();

        processes.Add(new Process("p1", 1, 12, 0));
        processes.Add(new Process("p2", 2, 8, 4));
        processes.Add(new Process("p3", 1, 6, 5));
        processes.Add(new Process("p4", 2, 5, 12));
        processes.Add(new Process("p5", 2, 10, 18));

        //Q1
        //processes.Add(new Process("p1", 40, 15, 0));
        //processes.Add(new Process("p2", 30, 25, 25));
        //processes.Add(new Process("p3", 30, 20, 30));
        //processes.Add(new Process("p4", 35, 15, 50));
        //processes.Add(new Process("p5", 5, 15, 100));
        //processes.Add(new Process("p6", 10, 10, 105));

        processes.ForEach(delegate (Process p)
        {
            p.print();
        });
        Process idle = new Process("p_idle", 999, 99999, 0);

        idle.print();

        Queue q1 = new Queue();
        Queue q2 = new Queue();
        q1.timeQuantum = 3;
        q2.timeQuantum = 4;

        q1.IsActive = true;
        List<int> completionTime = new List<int>();
        List<int> arrival = new List<int>();

        processes.ForEach(delegate (Process p)
        {
            //if(p.getPriority() == 1)
            q1.qProcess.Add(p);
            arrival.Add(p.getArrivalTime());
        });

        int time = 0;
        int tQ = q1.timeQuantum;

        Queue readyQ = new Queue();
        Queue readyQ2 = new Queue();
        List<int> arrivalT = new List<int>();
        List<int> arrivalT2 = new List<int>();
        String seq = "";


        //processes.ForEach(delegate (Process p)
        //{
        //    if (p.getPriority() == 1)
        //        readyQ.qProcess.Add(p);
        //    else if (p.getPriority() == 2)
        //        readyQ2.qProcess.Add(p);

        //});


        //Copy of arrival time : from process list
        //readyQ.qProcess.ForEach(delegate (Process p)
        //{
        //    arrivalT.Add(p.getArrivalTime());
        //});
        //readyQ2.qProcess.ForEach(delegate (Process p)
        //{
        //    arrivalT2.Add(p.getArrivalTime());
        //});
        

        while (true)
        {
            Boolean finished = true;

            finished = RoundRobinA(q1, arrival, ref time, ref tQ, ref seq, readyQ.qProcess[0].getPriority());
            //finished = RoundRobinA(readyQ2, arrivalT, ref time, ref tQ, ref seq, readyQ.qProcess[0].getPriority());

            if (finished)
            {
                break;
            }
        }

        processes.ForEach(delegate (Process p)
        {
            p.print();
        });
    }

    public static bool RoundRobinA(Queue q1, List<int> arrivalT, ref int time, ref int tQ, ref string seq, int priority = 1)
    {
        //int time = 0;
        //int tQ = q1.timeQuantum;

        //Queue readyQ = new Queue();
        //Queue readyQ2 = new Queue();
        //List<int> arrivalT = new List<int>();
        //String seq = "";

        //Copy of arrival time : from process list
        q1.qProcess.ForEach(delegate (Process p)
        {
            arrivalT.Add(p.getArrivalTime());
        });

        if (priority == 1)
        {
            while (true)
            {
                Boolean flag = true;
                for (int i = 0; i < q1.qProcess.Count; i++)
                {
                    //Process Arriving before qunatum time
                    if (arrivalT[i] <= time)
                    {
                        //If process gets completed in it's first loop
                        if (arrivalT[i] <= tQ)
                        {
                            //Checking to see if process is completed or not
                            if (q1.qProcess[i].getRemainingTime() > 0)
                            {
                                flag = false;
                                updateProcess(q1.qProcess[i], arrivalT, i, ref time, ref tQ, ref seq);
                            }
                        }
                        //if process needs to be executed again or 
                        else if (arrivalT[i] > tQ)
                        {

                            // is any have less arrival time 
                            // the coming process then execute them 
                            for (int j = 0; j < q1.qProcess.Count; j++)
                            {
                                // compare and executing the processes that are following the first arrivals. 
                                if (arrivalT[j] < arrivalT[i])
                                {
                                    if (q1.qProcess[j].getRemainingTime() > 0)
                                    {
                                        flag = false;
                                        updateProcess(q1.qProcess[j], arrivalT, j, ref time, ref tQ, ref seq);
                                    }
                                }
                            }
                            // now updating process added back to queue (executed once )
                            if (q1.qProcess[i].getRemainingTime() > 0)
                            {
                                flag = false;
                                updateProcess(q1.qProcess[i], arrivalT, i, ref time, ref tQ, ref seq);
                            }
                        }
                    }

                    // if no process is come on thse critical 
                    else if (arrivalT[i] > time)
                    {
                        //seq += "->"; //+ q1.qProcess[j].getName();
                        time++;
                        i--;
                        Console.WriteLine("Line: " + q1.qProcess[i].getName());
                    }
                }

                // for exit the while loop 
                if (flag)
                {

                    break;
                }
            }
        }
        //optional priority may be needed for Multilevel Queue.
        else if (priority == 2)
        {
            while (true)
            {
                Boolean flag = true;
                for (int i = 0; i < q1.qProcess.Count; i++)
                {
                    //Process Arriving before qunatum time
                    if (arrivalT[i] <= time)
                    {
                        //If process gets completed in it's first loop
                        if (arrivalT[i] <= tQ)
                        {
                            //Checking to see if process is completed or not
                            if (q1.qProcess[i].getRemainingTime() > 0)
                            {
                                flag = false;
                                updateProcess(q1.qProcess[i], arrivalT, i, ref time, ref tQ, ref seq);
                            }
                        }
                        //if process needs to be executed again or 
                        else if (arrivalT[i] > tQ)
                        {

                            // is any have less arrival time 
                            // the coming process then execute them 
                            for (int j = 0; j < q1.qProcess.Count; j++)
                            {
                                // compare and executing the processes that are following the first arrivals. 
                                if (arrivalT[j] < arrivalT[i])
                                {
                                    if (q1.qProcess[j].getRemainingTime() > 0)
                                    {
                                        flag = false;
                                        updateProcess(q1.qProcess[j], arrivalT, j, ref time, ref tQ, ref seq);
                                    }
                                }
                            }
                            // now updating process added back to queue (executed once )
                            if (q1.qProcess[i].getRemainingTime() > 0)
                            {
                                flag = false;
                                updateProcess(q1.qProcess[i], arrivalT, i, ref time, ref tQ, ref seq);
                            }
                        }
                    }

                    // if no process is come on thse critical 
                    else if (arrivalT[i] > time)
                    {
                        //seq += "->"; //+ q1.qProcess[j].getName();
                        time++;
                        i--;
                        Console.WriteLine("Line: " + q1.qProcess[i].getName());
                    }
                }

                // for exit the while loop 
                if (flag)
                {

                    break;
                }
            }
        }

        Console.WriteLine(seq);
        return true;

    }

    public static void updateProcess(Process p, List<int> arrivalT, int i, ref int time, ref int tQ, ref string seq)
    {
        if (p.getRemainingTime() > tQ)
        {

            // make decrease the b time 
            time = time + tQ;
            p.setRemainingTime(tQ);
            arrivalT[i] = arrivalT[i] + tQ;
            seq += "->" + p.getName();
            //
        }
        else
        {

            // for last time 
            time += p.getRemainingTime();

            // store comp time 
            //comp[i] = time - a[i];

            // store wait time 
            p.setWaitingTime(time - p.getBurstTime() - p.getArrivalTime());
            p.setRemainingTime(p.getRemainingTime());
            p.isFinished = true;
            Console.WriteLine("Completed: " + p.getName() + " @: " + time);

            // add sequence 
            seq += "->" + p.getName();
        }
    }
}