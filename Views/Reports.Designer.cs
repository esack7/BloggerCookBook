
namespace BloggerCookBook.Views
{
    partial class Reports
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
            this.reportsLabel = new System.Windows.Forms.Label();
            this.shoppingListRadioButton = new System.Windows.Forms.RadioButton();
            this.topTenRadioButton = new System.Windows.Forms.RadioButton();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportsLabel
            // 
            this.reportsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLabel.Location = new System.Drawing.Point(0, 0);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(800, 62);
            this.reportsLabel.TabIndex = 38;
            this.reportsLabel.Text = "Reports";
            this.reportsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoppingListRadioButton
            // 
            this.shoppingListRadioButton.AutoSize = true;
            this.shoppingListRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListRadioButton.Location = new System.Drawing.Point(99, 65);
            this.shoppingListRadioButton.Name = "shoppingListRadioButton";
            this.shoppingListRadioButton.Size = new System.Drawing.Size(134, 27);
            this.shoppingListRadioButton.TabIndex = 39;
            this.shoppingListRadioButton.TabStop = true;
            this.shoppingListRadioButton.Text = "Shopping List";
            this.shoppingListRadioButton.UseVisualStyleBackColor = true;
            // 
            // topTenRadioButton
            // 
            this.topTenRadioButton.AutoSize = true;
            this.topTenRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTenRadioButton.Location = new System.Drawing.Point(503, 65);
            this.topTenRadioButton.Name = "topTenRadioButton";
            this.topTenRadioButton.Size = new System.Drawing.Size(151, 27);
            this.topTenRadioButton.TabIndex = 40;
            this.topTenRadioButton.TabStop = true;
            this.topTenRadioButton.Text = "Top Ten Recipes";
            this.topTenRadioButton.UseVisualStyleBackColor = true;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(132, 101);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(120, 32);
            this.startDateLabel.TabIndex = 55;
            this.startDateLabel.Text = "Start Date";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(258, 98);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(345, 34);
            this.startDateTimePicker.TabIndex = 54;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(132, 157);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(112, 32);
            this.endDateLabel.TabIndex = 57;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(258, 154);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(345, 34);
            this.endDateTimePicker.TabIndex = 56;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(269, 208);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(128, 49);
            this.generateButton.TabIndex = 58;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(403, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 49);
            this.exitButton.TabIndex = 59;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(12, 274);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(776, 316);
            this.reportTextBox.TabIndex = 60;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.topTenRadioButton);
            this.Controls.Add(this.shoppingListRadioButton);
            this.Controls.Add(this.reportsLabel);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportsLabel;
        private System.Windows.Forms.RadioButton shoppingListRadioButton;
        private System.Windows.Forms.RadioButton topTenRadioButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}