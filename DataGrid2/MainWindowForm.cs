using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metrics;


namespace DataGrid2
{
    public partial class MainWindowForm : Form
    {
        public List<User> users = new List<User>();

        public Workout maxHangs = new Workout("Max Hangs", 10, 10, 90, 10);
        public Workout repeaters = new Workout("Repeaters", 10, 6, 4, 10);

        public MainWindowForm()
        {

            
            InitializeComponent();

            User user1 = new User(15, "joel");
            User user2 = new User(15, "emily");
            User user3 = new User(15, "kelsey");
            User user4 = new User(15, "donna");
            User user5 = new User(15, "craig");

           
            

            selectUserComboBox.Items.Add(user1.Name);
            selectUserComboBox.Items.Add(user2.Name);
            selectUserComboBox.Items.Add(user3.Name);
            selectUserComboBox.Items.Add(user4.Name);
            selectUserComboBox.Items.Add(user5.Name);

            selectWorkoutValue.Items.Add(maxHangs.WorkoutName);
            selectWorkoutValue.Items.Add(repeaters.WorkoutName);



        }



        private void BeginWorkout_Click(object sender, EventArgs e)
        {
            WorkoutForm form = new WorkoutForm(maxHangs);

            form.Show();
            
        }

        public void AddPeople(List<User> users)
        {
            foreach(User x in users)
            {

                selectUserComboBox.Items.Add(x.Name);

            }
            
        }


        private void selectUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void selectUserComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            
            NewUserForm form = new NewUserForm();
            form.Show();
        }

        private void addWorkoutButton_Click(object sender, EventArgs e)
        {
            CreateWorkoutForm form = new CreateWorkoutForm();
            form.Show();
        }

        private void selectWorkoutValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectWorkoutValue_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
