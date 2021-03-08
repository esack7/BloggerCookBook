﻿
namespace BloggerCookBook.Views
{
    partial class AddIngedient
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
            this.addToRecipeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addToRecipeLabel
            // 
            this.addToRecipeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addToRecipeLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToRecipeLabel.Location = new System.Drawing.Point(0, 0);
            this.addToRecipeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addToRecipeLabel.Name = "addToRecipeLabel";
            this.addToRecipeLabel.Size = new System.Drawing.Size(600, 50);
            this.addToRecipeLabel.TabIndex = 4;
            this.addToRecipeLabel.Text = "Add To Recipe";
            this.addToRecipeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(94, 94);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(154, 25);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Ingredient Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(248, 93);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(235, 29);
            this.nameTextBox.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(201, 316);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 40);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(323, 316);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 40);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(248, 158);
            this.unitComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(235, 29);
            this.unitComboBox.TabIndex = 29;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(196, 159);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(47, 25);
            this.unitLabel.TabIndex = 28;
            this.unitLabel.Text = "Unit";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(165, 223);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(79, 25);
            this.amountLabel.TabIndex = 31;
            this.amountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(248, 223);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(104, 29);
            this.amountTextBox.TabIndex = 30;
            // 
            // AddIngedient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addToRecipeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddIngedient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIngedient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddIngedient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addToRecipeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}