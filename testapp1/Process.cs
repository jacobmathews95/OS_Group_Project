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
}