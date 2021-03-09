
namespace BloggerCookBook.Views
{
    partial class MealPlanner
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.mealsDataGridView = new System.Windows.Forms.DataGridView();
            this.mealPlannerLabel = new System.Windows.Forms.Label();
            this.mealPlannerCalendar = new System.Windows.Forms.MonthCalendar();
            this.mealsLabel = new System.Windows.Forms.Label();
            this.viewMealsByLabel = new System.Windows.Forms.Label();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.mealsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(408, 316);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(182, 40);
            this.mainMenuButton.TabIndex = 24;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(494, 179);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 40);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(494, 118);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 40);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(494, 58);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 40);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mealsDataGridView
            // 
            this.mealsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealsDataGridView.Location = new System.Drawing.Point(13, 89);
            this.mealsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mealsDataGridView.Name = "mealsDataGridView";
            this.mealsDataGridView.RowHeadersWidth = 51;
            this.mealsDataGridView.RowTemplate.Height = 24;
            this.mealsDataGridView.Size = new System.Drawing.Size(243, 267);
            this.mealsDataGridView.TabIndex = 16;
            // 
            // mealPlannerLabel
            // 
            this.mealPlannerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealPlannerLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlannerLabel.Location = new System.Drawing.Point(0, 0);
            this.mealPlannerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealPlannerLabel.Name = "mealPlannerLabel";
            this.mealPlannerLabel.Size = new System.Drawing.Size(600, 50);
            this.mealPlannerLabel.TabIndex = 15;
            this.mealPlannerLabel.Text = "Meal Planner";
            this.mealPlannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealPlannerCalendar
            // 
            this.mealPlannerCalendar.Location = new System.Drawing.Point(265, 58);
            this.mealPlannerCalendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mealPlannerCalendar.Name = "mealPlannerCalendar";
            this.mealPlannerCalendar.TabIndex = 25;
            // 
            // mealsLabel
            // 
            this.mealsLabel.AutoSize = true;
            this.mealsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealsLabel.Location = new System.Drawing.Point(9, 58);
            this.mealsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealsLabel.Name = "mealsLabel";
            this.mealsLabel.Size = new System.Drawing.Size(54, 21);
            this.mealsLabel.TabIndex = 26;
            this.mealsLabel.Text = "Meals:";
            // 
            // viewMealsByLabel
            // 
            this.viewMealsByLabel.AutoSize = true;
            this.viewMealsByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMealsByLabel.Location = new System.Drawing.Point(271, 233);
            this.viewMealsByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewMealsByLabel.Name = "viewMealsByLabel";
            this.viewMealsByLabel.Size = new System.Drawing.Size(113, 21);
            this.viewMealsByLabel.TabIndex = 27;
            this.viewMealsByLabel.Text = "View Meals By:";
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayRadioButton.Location = new System.Drawing.Point(274, 266);
            this.dayRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(51, 23);
            this.dayRadioButton.TabIndex = 29;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadioButton.Location = new System.Drawing.Point(274, 292);
            this.weekRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(60, 23);
            this.weekRadioButton.TabIndex = 30;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadioButton.Location = new System.Drawing.Point(274, 319);
            this.monthRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(69, 23);
            this.monthRadioButton.TabIndex = 31;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // MealPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.monthRadioButton);
            this.Controls.Add(this.weekRadioButton);
            this.Controls.Add(this.dayRadioButton);
            this.Controls.Add(this.viewMealsByLabel);
            this.Controls.Add(this.mealsLabel);
            this.Controls.Add(this.mealPlannerCalendar);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mealsDataGridView);
            this.Controls.Add(this.mealPlannerLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MealPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MealPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MealPlanner_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mealsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView mealsDataGridView;
        private System.Windows.Forms.Label mealPlannerLabel;
        private System.Windows.Forms.MonthCalendar mealPlannerCalendar;
        private System.Windows.Forms.Label mealsLabel;
        private System.Windows.Forms.Label viewMealsByLabel;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
    }
}