namespace DatabaseManagementStudio
{
    partial class DatabaseForm
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
            this.DeleteDatabaseButton = new System.Windows.Forms.Button();
            this.AddTableTextBox = new System.Windows.Forms.TextBox();
            this.AddTableButton = new System.Windows.Forms.Button();
            this.TablesDiffButton = new System.Windows.Forms.Button();
            this.TablesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteDatabaseButton
            // 
            this.DeleteDatabaseButton.Location = new System.Drawing.Point(713, 12);
            this.DeleteDatabaseButton.Name = "DeleteDatabaseButton";
            this.DeleteDatabaseButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDatabaseButton.TabIndex = 0;
            this.DeleteDatabaseButton.Text = "Видалити";
            this.DeleteDatabaseButton.UseVisualStyleBackColor = true;
            this.DeleteDatabaseButton.Click += new System.EventHandler(this.DeleteDatabaseButton_Click);
            // 
            // AddTableTextBox
            // 
            this.AddTableTextBox.Location = new System.Drawing.Point(12, 15);
            this.AddTableTextBox.Name = "AddTableTextBox";
            this.AddTableTextBox.Size = new System.Drawing.Size(289, 20);
            this.AddTableTextBox.TabIndex = 1;
            // 
            // AddTableButton
            // 
            this.AddTableButton.Location = new System.Drawing.Point(307, 13);
            this.AddTableButton.Name = "AddTableButton";
            this.AddTableButton.Size = new System.Drawing.Size(75, 23);
            this.AddTableButton.TabIndex = 2;
            this.AddTableButton.Text = "Додати";
            this.AddTableButton.UseVisualStyleBackColor = true;
            this.AddTableButton.Click += new System.EventHandler(this.AddTableButton_Click);
            // 
            // TablesDiffButton
            // 
            this.TablesDiffButton.Location = new System.Drawing.Point(388, 12);
            this.TablesDiffButton.Name = "TablesDiffButton";
            this.TablesDiffButton.Size = new System.Drawing.Size(75, 23);
            this.TablesDiffButton.TabIndex = 3;
            this.TablesDiffButton.Text = "Різниця";
            this.TablesDiffButton.UseVisualStyleBackColor = true;
            this.TablesDiffButton.Click += new System.EventHandler(this.TablesDiffButton_Click);
            // 
            // TablesList
            // 
            this.TablesList.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesList.FormattingEnabled = true;
            this.TablesList.ItemHeight = 25;
            this.TablesList.Location = new System.Drawing.Point(12, 56);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(776, 379);
            this.TablesList.TabIndex = 4;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablesList);
            this.Controls.Add(this.TablesDiffButton);
            this.Controls.Add(this.AddTableButton);
            this.Controls.Add(this.AddTableTextBox);
            this.Controls.Add(this.DeleteDatabaseButton);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteDatabaseButton;
        private System.Windows.Forms.TextBox AddTableTextBox;
        private System.Windows.Forms.Button AddTableButton;
        private System.Windows.Forms.Button TablesDiffButton;
        private System.Windows.Forms.ListBox TablesList;
    }
}