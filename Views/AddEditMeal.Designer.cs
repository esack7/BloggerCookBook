
namespace BloggerCookBook.Views
{
    partial class AddEditMeal
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
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeRecipeButton = new System.Windows.Forms.Button();
            this.addToMealButton = new System.Windows.Forms.Button();
            this.listOfRecipesLabel = new System.Windows.Forms.Label();
            this.mealsRecipeLabel = new System.Windows.Forms.Label();
            this.mealRecipesDataGridView = new System.Windows.Forms.DataGridView();
            this.listOfRecipesDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addEditMealLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mealRecipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRecipesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(17, 511);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(374, 79);
            this.notesTextBox.TabIndex = 51;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(12, 480);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(68, 28);
            this.notesLabel.TabIndex = 50;
            this.notesLabel.Text = "Notes:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(523, 541);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 49);
            this.saveButton.TabIndex = 49;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(657, 541);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 49);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeRecipeButton
            // 
            this.removeRecipeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRecipeButton.Location = new System.Drawing.Point(338, 377);
            this.removeRecipeButton.Name = "removeRecipeButton";
            this.removeRecipeButton.Size = new System.Drawing.Size(128, 82);
            this.removeRecipeButton.TabIndex = 47;
            this.removeRecipeButton.Text = "Remove Recipe";
            this.removeRecipeButton.UseVisualStyleBackColor = true;
            // 
            // addToMealButton
            // 
            this.addToMealButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToMealButton.Location = new System.Drawing.Point(338, 258);
            this.addToMealButton.Name = "addToMealButton";
            this.addToMealButton.Size = new System.Drawing.Size(128, 82);
            this.addToMealButton.TabIndex = 46;
            this.addToMealButton.Text = "Add to Meal";
            this.addToMealButton.UseVisualStyleBackColor = true;
            // 
            // listOfRecipesLabel
            // 
            this.listOfRecipesLabel.AutoSize = true;
            this.listOfRecipesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfRecipesLabel.Location = new System.Drawing.Point(560, 205);
            this.listOfRecipesLabel.Name = "listOfRecipesLabel";
            this.listOfRecipesLabel.Size = new System.Drawing.Size(134, 28);
            this.listOfRecipesLabel.TabIndex = 45;
            this.listOfRecipesLabel.Text = "List of Recipes";
            // 
            // mealsRecipeLabel
            // 
            this.mealsRecipeLabel.AutoSize = true;
            this.mealsRecipeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealsRecipeLabel.Location = new System.Drawing.Point(74, 208);
            this.mealsRecipeLabel.Name = "mealsRecipeLabel";
            this.mealsRecipeLabel.Size = new System.Drawing.Size(125, 28);
            this.mealsRecipeLabel.TabIndex = 44;
            this.mealsRecipeLabel.Text = "Meal Recipes";
            // 
            // mealRecipesDataGridView
            // 
            this.mealRecipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealRecipesDataGridView.Location = new System.Drawing.Point(9, 239);
            this.mealRecipesDataGridView.Name = "mealRecipesDataGridView";
            this.mealRecipesDataGridView.RowHeadersWidth = 51;
            this.mealRecipesDataGridView.RowTemplate.Height = 24;
            this.mealRecipesDataGridView.Size = new System.Drawing.Size(300, 238);
            this.mealRecipesDataGridView.TabIndex = 43;
            // 
            // listOfRecipesDataGridView
            // 
            this.listOfRecipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRecipesDataGridView.Location = new System.Drawing.Point(488, 239);
            this.listOfRecipesDataGridView.Name = "listOfRecipesDataGridView";
            this.listOfRecipesDataGridView.RowHeadersWidth = 51;
            this.listOfRecipesDataGridView.RowTemplate.Height = 24;
            this.listOfRecipesDataGridView.Size = new System.Drawing.Size(300, 238);
            this.listOfRecipesDataGridView.TabIndex = 42;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 32);
            this.titleLabel.TabIndex = 41;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(79, 73);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(312, 34);
            this.titleTextBox.TabIndex = 40;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(514, 71);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 36);
            this.categoryComboBox.TabIndex = 39;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(442, 74);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(66, 32);
            this.typeLabel.TabIndex = 38;
            this.typeLabel.Text = "Type";
            // 
            // addEditMealLabel
            // 
            this.addEditMealLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEditMealLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditMealLabel.Location = new System.Drawing.Point(0, 0);
            this.addEditMealLabel.Name = "addEditMealLabel";
            this.addEditMealLabel.Size = new System.Drawing.Size(800, 62);
            this.addEditMealLabel.TabIndex = 37;
            this.addEditMealLabel.Text = "Add or Edit Meal";
            this.addEditMealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(83, 143);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(345, 34);
            this.dateTimePicker.TabIndex = 52;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 146);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 32);
            this.dateLabel.TabIndex = 53;
            this.dateLabel.Text = "Date";
            // 
            // AddEditMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeRecipeButton);
            this.Controls.Add(this.addToMealButton);
            this.Controls.Add(this.listOfRecipesLabel);
            this.Controls.Add(this.mealsRecipeLabel);
            this.Controls.Add(this.mealRecipesDataGridView);
            this.Controls.Add(this.listOfRecipesDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addEditMealLabel);
            this.Name = "AddEditMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditMeal";
            ((System.ComponentModel.ISupportInitialize)(this.mealRecipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRecipesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeRecipeButton;
        private System.Windows.Forms.Button addToMealButton;
        private System.Windows.Forms.Label listOfRecipesLabel;
        private System.Windows.Forms.Label mealsRecipeLabel;
        private System.Windows.Forms.DataGridView mealRecipesDataGridView;
        private System.Windows.Forms.DataGridView listOfRecipesDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label addEditMealLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLabel;
    }
}