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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            int age = 0;
            bool isAge = int.TryParse(ageValue.Text, out age);
            string name = nameLabel.Text;
            User user = new User(age, name);

        }
    }
}
