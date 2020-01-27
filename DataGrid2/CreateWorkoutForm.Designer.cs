namespace DataGrid2
{
    partial class CreateWorkoutForm
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
            this.createWorkoutButton = new System.Windows.Forms.Button();
            this.lengthHighValue = new System.Windows.Forms.TextBox();
            this.lengthHighLabel = new System.Windows.Forms.Label();
            this.workoutNameValue = new System.Windows.Forms.TextBox();
            this.workoutNameLabel = new System.Windows.Forms.Label();
            this.lengthLowValue = new System.Windows.Forms.TextBox();
            this.lengthLowLabel = new System.Windows.Forms.Label();
            this.numberOfSetsValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createWorkoutButton
            // 
            this.createWorkoutButton.Enabled = false;
            this.createWorkoutButton.Location = new System.Drawing.Point(28, 373);
            this.createWorkoutButton.Name = "createWorkoutButton";
            this.createWorkoutButton.Size = new System.Drawing.Size(159, 45);
            this.createWorkoutButton.TabIndex = 9;
            this.createWorkoutButton.Text = "Create Workout";
            this.createWorkoutButton.UseVisualStyleBackColor = true;
          
            // 
            // lengthHighValue
            // 
            this.lengthHighValue.Location = new System.Drawing.Point(29, 153);
            this.lengthHighValue.Name = "lengthHighValue";
            this.lengthHighValue.Size = new System.Drawing.Size(100, 26);
            this.lengthHighValue.TabIndex = 8;
            // 
            // lengthHighLabel
            // 
            this.lengthHighLabel.AutoSize = true;
            this.lengthHighLabel.Location = new System.Drawing.Point(25, 120);
            this.lengthHighLabel.Name = "lengthHighLabel";
            this.lengthHighLabel.Size = new System.Drawing.Size(100, 20);
            this.lengthHighLabel.TabIndex = 7;
            this.lengthHighLabel.Text = "Length High:";
           
            // 
            // workoutNameValue
            // 
            this.workoutNameValue.Location = new System.Drawing.Point(29, 65);
            this.workoutNameValue.Name = "workoutNameValue";
            this.workoutNameValue.Size = new System.Drawing.Size(100, 26);
            this.workoutNameValue.TabIndex = 6;
            // 
            // workoutNameLabel
            // 
            this.workoutNameLabel.AutoSize = true;
            this.workoutNameLabel.Location = new System.Drawing.Point(25, 31);
            this.workoutNameLabel.Name = "workoutNameLabel";
            this.workoutNameLabel.Size = new System.Drawing.Size(119, 20);
            this.workoutNameLabel.TabIndex = 5;
            this.workoutNameLabel.Text = "Workout Name:";
         
            // 
            // lengthLowValue
            // 
            this.lengthLowValue.Location = new System.Drawing.Point(28, 228);
            this.lengthLowValue.Name = "lengthLowValue";
            this.lengthLowValue.Size = new System.Drawing.Size(100, 26);
            this.lengthLowValue.TabIndex = 11;
            // 
            // lengthLowLabel
            // 
            this.lengthLowLabel.AutoSize = true;
            this.lengthLowLabel.Location = new System.Drawing.Point(24, 195);
            this.lengthLowLabel.Name = "lengthLowLabel";
            this.lengthLowLabel.Size = new System.Drawing.Size(96, 20);
            this.lengthLowLabel.TabIndex = 10;
            this.lengthLowLabel.Text = "Length Low:";
            // 
            // numberOfSetsValue
            // 
            this.numberOfSetsValue.Location = new System.Drawing.Point(29, 309);
            this.numberOfSetsValue.Name = "numberOfSetsValue";
            this.numberOfSetsValue.Size = new System.Drawing.Size(100, 26);
            this.numberOfSetsValue.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of Sets:";
            // 
            // CreateWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfSetsValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lengthLowValue);
            this.Controls.Add(this.lengthLowLabel);
            this.Controls.Add(this.createWorkoutButton);
            this.Controls.Add(this.lengthHighValue);
            this.Controls.Add(this.lengthHighLabel);
            this.Controls.Add(this.workoutNameValue);
            this.Controls.Add(this.workoutNameLabel);
            this.Name = "CreateWorkoutForm";
            this.Text = "Create Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createWorkoutButton;
        private System.Windows.Forms.TextBox lengthHighValue;
        private System.Windows.Forms.Label lengthHighLabel;
        private System.Windows.Forms.TextBox workoutNameValue;
        private System.Windows.Forms.Label workoutNameLabel;
        private System.Windows.Forms.TextBox lengthLowValue;
        private System.Windows.Forms.Label lengthLowLabel;
        private System.Windows.Forms.TextBox numberOfSetsValue;
        private System.Windows.Forms.Label label2;
    }
}