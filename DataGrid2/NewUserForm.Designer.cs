namespace DataGrid2
{
    partial class NewUserForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.ageValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(39, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(43, 69);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(100, 26);
            this.nameValue.TabIndex = 1;
            this.nameValue.Text = "anon";
            // 
            // ageValue
            // 
            this.ageValue.Location = new System.Drawing.Point(43, 157);
            this.ageValue.Name = "ageValue";
            this.ageValue.Size = new System.Drawing.Size(100, 26);
            this.ageValue.TabIndex = 3;
            this.ageValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age:";
            // 
            // createUserButton
            // 
            this.createUserButton.Enabled = false;
            this.createUserButton.Location = new System.Drawing.Point(43, 206);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(116, 45);
            this.createUserButton.TabIndex = 4;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.ageValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.nameLabel);
            this.Name = "NewUserForm";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUserButton;
        public System.Windows.Forms.TextBox nameValue;
        public System.Windows.Forms.TextBox ageValue;
    }
}