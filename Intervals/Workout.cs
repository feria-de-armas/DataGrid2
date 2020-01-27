using System;
using System.Collections.Generic;
using System.Text;

namespace Metrics
{
    public class Workout
    {
        public List<Interval> intervals = new List<Interval>();
        public string WorkoutName { get; set; }
        public int WarmUp { get; set; }
        public int LoadHangBoard { get; set; }
        public int Rest { get; set; }
        public int RemainingSets { get; set; }
        public Workout()
        {
            WorkoutName = "Strain Your Digits";
            WarmUp = 10;
            LoadHangBoard = 10;
            Rest = 60;
            RemainingSets = 10;

        }
        public Workout(string workoutName, int warmUp, int loadHangBoard, int rest, int remainingSets)
        {
            WorkoutName = workoutName;
            WarmUp = warmUp;
            LoadHangBoard = loadHangBoard;
            Rest = rest;
            RemainingSets = remainingSets;

        }


    }
}
