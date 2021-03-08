
namespace BloggerCookBook.Views
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.recipesButton = new System.Windows.Forms.Button();
            this.mealPlannerButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blogger Cookbook";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipesButton
            // 
            this.recipesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesButton.Location = new System.Drawing.Point(244, 91);
            this.recipesButton.Margin = new System.Windows.Forms.Padding(2);
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.Size = new System.Drawing.Size(111, 40);
            this.recipesButton.TabIndex = 6;
            this.recipesButton.Text = "Recipes";
            this.recipesButton.UseVisualStyleBackColor = true;
            this.recipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // mealPlannerButton
            // 
            this.mealPlannerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlannerButton.Location = new System.Drawing.Point(244, 152);
            this.mealPlannerButton.Margin = new System.Windows.Forms.Padding(2);
            this.mealPlannerButton.Name = "mealPlannerButton";
            this.mealPlannerButton.Size = new System.Drawing.Size(111, 40);
            this.mealPlannerButton.TabIndex = 7;
            this.mealPlannerButton.Text = "Meal Planner";
            this.mealPlannerButton.UseVisualStyleBackColor = true;
            this.mealPlannerButton.Click += new System.EventHandler(this.mealPlannerButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(244, 215);
            this.reportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(111, 40);
            this.reportsButton.TabIndex = 8;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(166, 276);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(111, 40);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(304, 276);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.mealPlannerButton);
            this.Controls.Add(this.recipesButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recipesButton;
        private System.Windows.Forms.Button mealPlannerButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
    }
}