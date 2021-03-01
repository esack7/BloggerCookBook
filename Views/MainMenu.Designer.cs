
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blogger Cookbook";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipesButton
            // 
            this.recipesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesButton.Location = new System.Drawing.Point(326, 140);
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.Size = new System.Drawing.Size(148, 49);
            this.recipesButton.TabIndex = 6;
            this.recipesButton.Text = "Recipes";
            this.recipesButton.UseVisualStyleBackColor = true;
            this.recipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // mealPlannerButton
            // 
            this.mealPlannerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlannerButton.Location = new System.Drawing.Point(326, 235);
            this.mealPlannerButton.Name = "mealPlannerButton";
            this.mealPlannerButton.Size = new System.Drawing.Size(148, 49);
            this.mealPlannerButton.TabIndex = 7;
            this.mealPlannerButton.Text = "Meal Planner";
            this.mealPlannerButton.UseVisualStyleBackColor = true;
            this.mealPlannerButton.Click += new System.EventHandler(this.mealPlannerButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(326, 331);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(148, 49);
            this.reportsButton.TabIndex = 8;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.mealPlannerButton);
            this.Controls.Add(this.recipesButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recipesButton;
        private System.Windows.Forms.Button mealPlannerButton;
        private System.Windows.Forms.Button reportsButton;
    }
}