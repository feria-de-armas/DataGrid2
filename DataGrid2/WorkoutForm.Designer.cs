namespace DataGrid2
{
    partial class WorkoutForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IntervalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeanForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeValue = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.IntervalTimeValue = new System.Windows.Forms.TextBox();
            this.workoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IntervalDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntervalColumn,
            this.MeanForce,
            this.MaxForce});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(42, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(395, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // IntervalColumn
            // 
            this.IntervalColumn.HeaderText = "Interval:";
            this.IntervalColumn.MinimumWidth = 8;
            this.IntervalColumn.Name = "IntervalColumn";
            this.IntervalColumn.Width = 101;
            // 
            // MeanForce
            // 
            this.MeanForce.HeaderText = "Mean Force";
            this.MeanForce.MinimumWidth = 8;
            this.MeanForce.Name = "MeanForce";
            this.MeanForce.Width = 130;
            // 
            // MaxForce
            // 
            this.MaxForce.HeaderText = "Max Force";
            this.MaxForce.MinimumWidth = 8;
            this.MaxForce.Name = "MaxForce";
            this.MaxForce.Width = 119;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(622, 282);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(86, 41);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.TextChanged += new System.EventHandler(this.StartButton_Click);
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(622, 341);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(86, 41);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeValue
            // 
            this.TimeValue.Location = new System.Drawing.Point(622, 234);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(100, 26);
            this.TimeValue.TabIndex = 3;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(631, 201);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time";
            // 
            // IntervalTimeValue
            // 
            this.IntervalTimeValue.Location = new System.Drawing.Point(622, 145);
            this.IntervalTimeValue.Name = "IntervalTimeValue";
            this.IntervalTimeValue.Size = new System.Drawing.Size(100, 26);
            this.IntervalTimeValue.TabIndex = 5;
            // 
            // workoutBindingSource
            // 
            this.workoutBindingSource.DataSource = typeof(Metrics.Workout);
            // 
            // IntervalDescription
            // 
            this.IntervalDescription.AutoSize = true;
            this.IntervalDescription.Location = new System.Drawing.Point(622, 106);
            this.IntervalDescription.Name = "IntervalDescription";
            this.IntervalDescription.Size = new System.Drawing.Size(51, 20);
            this.IntervalDescription.TabIndex = 6;
            this.IntervalDescription.Text = "label1";
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntervalDescription);
            this.Controls.Add(this.IntervalTimeValue);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.TimeValue);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkoutForm";
            this.Text = "Workout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeanForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxForce;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimeValue;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox IntervalTimeValue;
        private System.Windows.Forms.BindingSource workoutBindingSource;
        private System.Windows.Forms.Label IntervalDescription;
    }
}

