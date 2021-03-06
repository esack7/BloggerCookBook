﻿
namespace BloggerCookBook.Views
{
    partial class AddEditRecipe
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
            this.addEditRecipeLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.listOfIngredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeIngredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeIngredientsLabel = new System.Windows.Forms.Label();
            this.listOfIngredientsLabel = new System.Windows.Forms.Label();
            this.addToRecipeButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.personalTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.webTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.bookTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeATextBox = new System.Windows.Forms.TextBox();
            this.typeBTextBox = new System.Windows.Forms.TextBox();
            this.typeALabel = new System.Windows.Forms.Label();
            this.typeBLabel = new System.Windows.Forms.Label();
            this.createIngredientButton = new System.Windows.Forms.Button();
            this.secretCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listOfIngredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addEditRecipeLabel
            // 
            this.addEditRecipeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEditRecipeLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditRecipeLabel.Location = new System.Drawing.Point(0, 0);
            this.addEditRecipeLabel.Name = "addEditRecipeLabel";
            this.addEditRecipeLabel.Size = new System.Drawing.Size(800, 62);
            this.addEditRecipeLabel.TabIndex = 3;
            this.addEditRecipeLabel.Text = "Add or Edit Recipe";
            this.addEditRecipeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(515, 65);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(273, 36);
            this.categoryComboBox.TabIndex = 15;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(397, 66);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(111, 32);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Category";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(79, 66);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(312, 34);
            this.titleTextBox.TabIndex = 16;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 68);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 32);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title";
            // 
            // listOfIngredientsDataGridView
            // 
            this.listOfIngredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfIngredientsDataGridView.Location = new System.Drawing.Point(488, 144);
            this.listOfIngredientsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfIngredientsDataGridView.Name = "listOfIngredientsDataGridView";
            this.listOfIngredientsDataGridView.RowHeadersVisible = false;
            this.listOfIngredientsDataGridView.RowHeadersWidth = 51;
            this.listOfIngredientsDataGridView.RowTemplate.Height = 24;
            this.listOfIngredientsDataGridView.Size = new System.Drawing.Size(300, 238);
            this.listOfIngredientsDataGridView.TabIndex = 18;
            this.listOfIngredientsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.listOfIngredientsDataGridView_DataBindingComplete);
            // 
            // recipeIngredientsDataGridView
            // 
            this.recipeIngredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeIngredientsDataGridView.Location = new System.Drawing.Point(9, 144);
            this.recipeIngredientsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipeIngredientsDataGridView.Name = "recipeIngredientsDataGridView";
            this.recipeIngredientsDataGridView.RowHeadersWidth = 51;
            this.recipeIngredientsDataGridView.RowTemplate.Height = 24;
            this.recipeIngredientsDataGridView.Size = new System.Drawing.Size(300, 238);
            this.recipeIngredientsDataGridView.TabIndex = 19;
            this.recipeIngredientsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.recipeIngredientsDataGridView_DataBindingComplete);
            // 
            // recipeIngredientsLabel
            // 
            this.recipeIngredientsLabel.AutoSize = true;
            this.recipeIngredientsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeIngredientsLabel.Location = new System.Drawing.Point(75, 113);
            this.recipeIngredientsLabel.Name = "recipeIngredientsLabel";
            this.recipeIngredientsLabel.Size = new System.Drawing.Size(172, 28);
            this.recipeIngredientsLabel.TabIndex = 20;
            this.recipeIngredientsLabel.Text = "Recipe Ingredients";
            // 
            // listOfIngredientsLabel
            // 
            this.listOfIngredientsLabel.AutoSize = true;
            this.listOfIngredientsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfIngredientsLabel.Location = new System.Drawing.Point(560, 110);
            this.listOfIngredientsLabel.Name = "listOfIngredientsLabel";
            this.listOfIngredientsLabel.Size = new System.Drawing.Size(167, 28);
            this.listOfIngredientsLabel.TabIndex = 21;
            this.listOfIngredientsLabel.Text = "List of Ingredients";
            // 
            // addToRecipeButton
            // 
            this.addToRecipeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToRecipeButton.Location = new System.Drawing.Point(339, 162);
            this.addToRecipeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToRecipeButton.Name = "addToRecipeButton";
            this.addToRecipeButton.Size = new System.Drawing.Size(128, 82);
            this.addToRecipeButton.TabIndex = 22;
            this.addToRecipeButton.Text = "Add to Recipe";
            this.addToRecipeButton.UseVisualStyleBackColor = true;
            this.addToRecipeButton.Click += new System.EventHandler(this.addToRecipeButton_Click);
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIngredientButton.Location = new System.Drawing.Point(339, 282);
            this.removeIngredientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(128, 82);
            this.removeIngredientButton.TabIndex = 23;
            this.removeIngredientButton.Text = "Remove Ingredient";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(664, 542);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 49);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(531, 542);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 49);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 396);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(117, 28);
            this.instructionsLabel.TabIndex = 26;
            this.instructionsLabel.Text = "Instructions:";
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Location = new System.Drawing.Point(17, 427);
            this.instructionsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.Size = new System.Drawing.Size(375, 163);
            this.instructionsTextBox.TabIndex = 27;
            // 
            // personalTypeRadioButton
            // 
            this.personalTypeRadioButton.AutoSize = true;
            this.personalTypeRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalTypeRadioButton.Location = new System.Drawing.Point(516, 399);
            this.personalTypeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalTypeRadioButton.Name = "personalTypeRadioButton";
            this.personalTypeRadioButton.Size = new System.Drawing.Size(95, 27);
            this.personalTypeRadioButton.TabIndex = 28;
            this.personalTypeRadioButton.TabStop = true;
            this.personalTypeRadioButton.Text = "Personal";
            this.personalTypeRadioButton.UseVisualStyleBackColor = true;
            this.personalTypeRadioButton.CheckedChanged += new System.EventHandler(this.personalTypeRadioButton_CheckedChanged);
            // 
            // webTypeRadioButton
            // 
            this.webTypeRadioButton.AutoSize = true;
            this.webTypeRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webTypeRadioButton.Location = new System.Drawing.Point(617, 399);
            this.webTypeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webTypeRadioButton.Name = "webTypeRadioButton";
            this.webTypeRadioButton.Size = new System.Drawing.Size(65, 27);
            this.webTypeRadioButton.TabIndex = 29;
            this.webTypeRadioButton.TabStop = true;
            this.webTypeRadioButton.Text = "Web";
            this.webTypeRadioButton.UseVisualStyleBackColor = true;
            this.webTypeRadioButton.CheckedChanged += new System.EventHandler(this.webTypeRadioButton_CheckedChanged);
            // 
            // bookTypeRadioButton
            // 
            this.bookTypeRadioButton.AutoSize = true;
            this.bookTypeRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeRadioButton.Location = new System.Drawing.Point(688, 399);
            this.bookTypeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookTypeRadioButton.Name = "bookTypeRadioButton";
            this.bookTypeRadioButton.Size = new System.Drawing.Size(69, 27);
            this.bookTypeRadioButton.TabIndex = 30;
            this.bookTypeRadioButton.TabStop = true;
            this.bookTypeRadioButton.Text = "Book";
            this.bookTypeRadioButton.UseVisualStyleBackColor = true;
            this.bookTypeRadioButton.CheckedChanged += new System.EventHandler(this.bookTypeRadioButton_CheckedChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(435, 396);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(57, 28);
            this.typeLabel.TabIndex = 31;
            this.typeLabel.Text = "Type:";
            // 
            // typeATextBox
            // 
            this.typeATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeATextBox.Location = new System.Drawing.Point(555, 443);
            this.typeATextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeATextBox.Name = "typeATextBox";
            this.typeATextBox.Size = new System.Drawing.Size(233, 34);
            this.typeATextBox.TabIndex = 32;
            // 
            // typeBTextBox
            // 
            this.typeBTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBTextBox.Location = new System.Drawing.Point(555, 482);
            this.typeBTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeBTextBox.Name = "typeBTextBox";
            this.typeBTextBox.Size = new System.Drawing.Size(233, 34);
            this.typeBTextBox.TabIndex = 33;
            // 
            // typeALabel
            // 
            this.typeALabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeALabel.Location = new System.Drawing.Point(421, 444);
            this.typeALabel.Name = "typeALabel";
            this.typeALabel.Size = new System.Drawing.Size(111, 34);
            this.typeALabel.TabIndex = 34;
            this.typeALabel.Text = "Book";
            this.typeALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeBLabel
            // 
            this.typeBLabel.AutoSize = true;
            this.typeBLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBLabel.Location = new System.Drawing.Point(460, 484);
            this.typeBLabel.Name = "typeBLabel";
            this.typeBLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeBLabel.Size = new System.Drawing.Size(88, 32);
            this.typeBLabel.TabIndex = 35;
            this.typeBLabel.Text = "Author";
            this.typeBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createIngredientButton
            // 
            this.createIngredientButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createIngredientButton.Location = new System.Drawing.Point(757, 111);
            this.createIngredientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createIngredientButton.Name = "createIngredientButton";
            this.createIngredientButton.Size = new System.Drawing.Size(29, 30);
            this.createIngredientButton.TabIndex = 36;
            this.createIngredientButton.Text = "+";
            this.createIngredientButton.UseVisualStyleBackColor = true;
            this.createIngredientButton.Click += new System.EventHandler(this.createIngredientButton_Click);
            // 
            // secretCheckBox
            // 
            this.secretCheckBox.AutoSize = true;
            this.secretCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretCheckBox.Location = new System.Drawing.Point(401, 542);
            this.secretCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secretCheckBox.Name = "secretCheckBox";
            this.secretCheckBox.Size = new System.Drawing.Size(189, 36);
            this.secretCheckBox.TabIndex = 37;
            this.secretCheckBox.Text = "Family Secret?";
            this.secretCheckBox.UseVisualStyleBackColor = true;
            this.secretCheckBox.Visible = false;
            // 
            // AddEditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.secretCheckBox);
            this.Controls.Add(this.createIngredientButton);
            this.Controls.Add(this.typeBLabel);
            this.Controls.Add(this.typeALabel);
            this.Controls.Add(this.typeBTextBox);
            this.Controls.Add(this.typeATextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.bookTypeRadioButton);
            this.Controls.Add(this.webTypeRadioButton);
            this.Controls.Add(this.personalTypeRadioButton);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.addToRecipeButton);
            this.Controls.Add(this.listOfIngredientsLabel);
            this.Controls.Add(this.recipeIngredientsLabel);
            this.Controls.Add(this.recipeIngredientsDataGridView);
            this.Controls.Add(this.listOfIngredientsDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.addEditRecipeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEditRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditRecipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditRecipe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listOfIngredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addEditRecipeLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView listOfIngredientsDataGridView;
        private System.Windows.Forms.DataGridView recipeIngredientsDataGridView;
        private System.Windows.Forms.Label recipeIngredientsLabel;
        private System.Windows.Forms.Label listOfIngredientsLabel;
        private System.Windows.Forms.Button addToRecipeButton;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.RadioButton personalTypeRadioButton;
        private System.Windows.Forms.RadioButton webTypeRadioButton;
        private System.Windows.Forms.RadioButton bookTypeRadioButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeATextBox;
        private System.Windows.Forms.TextBox typeBTextBox;
        private System.Windows.Forms.Label typeALabel;
        private System.Windows.Forms.Label typeBLabel;
        private System.Windows.Forms.Button createIngredientButton;
        private System.Windows.Forms.CheckBox secretCheckBox;
    }
}