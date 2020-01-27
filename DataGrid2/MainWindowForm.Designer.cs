using Metrics;
namespace DataGrid2

{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.selectWorkoutLabel = new System.Windows.Forms.Label();
            this.selectWorkoutValue = new System.Windows.Forms.ComboBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.addWorkoutButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.beginWorkout = new System.Windows.Forms.Button();
            this.selectUserComboBox = new System.Windows.Forms.ComboBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Location = new System.Drawing.Point(56, 77);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(92, 20);
            this.selectUserLabel.TabIndex = 1;
            this.selectUserLabel.Text = "Select User";
            // 
            // selectWorkoutLabel
            // 
            this.selectWorkoutLabel.AutoSize = true;
            this.selectWorkoutLabel.Location = new System.Drawing.Point(56, 161);
            this.selectWorkoutLabel.Name = "selectWorkoutLabel";
            this.selectWorkoutLabel.Size = new System.Drawing.Size(118, 20);
            this.selectWorkoutLabel.TabIndex = 3;
            this.selectWorkoutLabel.Text = "Select Workout";
            // 
            // selectWorkoutValue
            // 
            this.selectWorkoutValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutBindingSource, "WorkoutName", true));
            this.selectWorkoutValue.DisplayMember = "User.Name";
            this.selectWorkoutValue.FormattingEnabled = true;
            this.selectWorkoutValue.Location = new System.Drawing.Point(32, 184);
            this.selectWorkoutValue.Name = "selectWorkoutValue";
            this.selectWorkoutValue.Size = new System.Drawing.Size(184, 28);
            this.selectWorkoutValue.TabIndex = 2;
            this.selectWorkoutValue.Text = "<select a workout>";
            this.selectWorkoutValue.SelectedIndexChanged += new System.EventHandler(this.selectWorkoutValue_SelectedIndexChanged_1);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(232, 94);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(129, 38);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // addWorkoutButton
            // 
            this.addWorkoutButton.Location = new System.Drawing.Point(232, 178);
            this.addWorkoutButton.Name = "addWorkoutButton";
            this.addWorkoutButton.Size = new System.Drawing.Size(129, 39);
            this.addWorkoutButton.TabIndex = 5;
            this.addWorkoutButton.Text = "Add Workout";
            this.addWorkoutButton.UseVisualStyleBackColor = true;
            this.addWorkoutButton.Click += new System.EventHandler(this.addWorkoutButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(25, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(371, 37);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Welcome To Strain Desk";
            // 
            // beginWorkout
            // 
            this.beginWorkout.Location = new System.Drawing.Point(60, 245);
            this.beginWorkout.Name = "beginWorkout";
            this.beginWorkout.Size = new System.Drawing.Size(301, 44);
            this.beginWorkout.TabIndex = 7;
            this.beginWorkout.Text = "Begin Workout";
            this.beginWorkout.UseVisualStyleBackColor = true;
            this.beginWorkout.Click += new System.EventHandler(this.BeginWorkout_Click);
            // 
            // selectUserComboBox
            // 
            this.selectUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never, "\"fuck\""));
            this.selectUserComboBox.FormattingEnabled = true;
            this.selectUserComboBox.Location = new System.Drawing.Point(32, 100);
            this.selectUserComboBox.Name = "selectUserComboBox";
            this.selectUserComboBox.Size = new System.Drawing.Size(184, 28);
            this.selectUserComboBox.TabIndex = 0;
            this.selectUserComboBox.TabStop = false;
            this.selectUserComboBox.Tag = "Name";
            this.selectUserComboBox.Text = "<select a user>";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Metrics.User);
            // 
            // workoutBindingSource
            // 
            this.workoutBindingSource.DataSource = typeof(Metrics.Workout);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beginWorkout);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.addWorkoutButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.selectWorkoutLabel);
            this.Controls.Add(this.selectWorkoutValue);
            this.Controls.Add(this.selectUserLabel);
            this.Controls.Add(this.selectUserComboBox);
            this.Name = "MainWindowForm";
            this.Text = "Strain Desk Home";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectUserLabel;
        private System.Windows.Forms.Label selectWorkoutLabel;
        private System.Windows.Forms.ComboBox selectWorkoutValue;

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button addWorkoutButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button beginWorkout;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        internal System.Windows.Forms.ComboBox selectUserComboBox;
        private System.Windows.Forms.BindingSource workoutBindingSource;
    }
}