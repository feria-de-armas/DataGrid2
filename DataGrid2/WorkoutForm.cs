using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metrics;


namespace DataGrid2
{
    public partial class WorkoutForm : Form
    {
        private DateTime _start;
    
        public int IntervalSeconds { get; set; }

        public Workout Workout = new Workout();

        public bool Next = false;

        public int lap = 0;

        public WorkoutForm(Workout workout)
        {
            InitializeComponent();
            Workout = workout;
            WarmUp();
     


        }
        public void Switch()
        {
           
            dataGridView1.Rows.Add(lap, 10, 10) ;
            if (Next)
            {
                if (lap >= Workout.RemainingSets)
                {
                    timer1.Stop();
                }
                else if (lap % 2 == 0)
                {
                    Interval();
                }
                else
                {
                    Rest();
                }
            }
        }
        public void WarmUp()
        {
            IntervalDescription.Text = "Warm Up - Time Remaining";
            IntervalSeconds = Workout.WarmUp;
        }
    
        public void Interval()
        {
            IntervalDescription.Text = "Load Hangboard - Time Remaining";
            IntervalSeconds = Workout.LoadHangBoard;
        }
        public void Rest()
        {
            IntervalDescription.Text = "Rest - Time Remaining";
            IntervalSeconds = Workout.Rest;
        }
    

        private object GetTimeString(object elapsed)
        {
            string result = string.Empty;
            return result;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _start = DateTime.Now;
            timer1.Start();

        }
        private void StopButton_Click(object sender, EventArgs e)
        {
          
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan duration = DateTime.Now - _start;
            TimeValue.Text = duration.ToString();
            if (IntervalSeconds >=1) 
            { 
                IntervalSeconds--;
                IntervalTimeValue.Text = IntervalSeconds.ToString();
            }
            else
            {
                Next = true;
                lap++;
                Switch();
            }
            
            

        }

     
    }
}
