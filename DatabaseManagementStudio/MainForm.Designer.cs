namespace DatabaseManagementStudio
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DatabasesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddDatabaseButton = new System.Windows.Forms.Button();
            this.NewDatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бази даних";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatabasesTableLayout
            // 
            this.DatabasesTableLayout.ColumnCount = 3;
            this.DatabasesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DatabasesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DatabasesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DatabasesTableLayout.Location = new System.Drawing.Point(12, 78);
            this.DatabasesTableLayout.Name = "DatabasesTableLayout";
            this.DatabasesTableLayout.RowCount = 2;
            this.DatabasesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatabasesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatabasesTableLayout.Size = new System.Drawing.Size(776, 292);
            this.DatabasesTableLayout.TabIndex = 1;
            // 
            // AddDatabaseButton
            // 
            this.AddDatabaseButton.AutoSize = true;
            this.AddDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDatabaseButton.Location = new System.Drawing.Point(685, 398);
            this.AddDatabaseButton.Name = "AddDatabaseButton";
            this.AddDatabaseButton.Size = new System.Drawing.Size(103, 23);
            this.AddDatabaseButton.TabIndex = 2;
            this.AddDatabaseButton.Text = "Створити";
            this.AddDatabaseButton.UseVisualStyleBackColor = true;
            this.AddDatabaseButton.Click += new System.EventHandler(this.AddDatabaseButton_Click);
            // 
            // NewDatabaseNameTextbox
            // 
            this.NewDatabaseNameTextbox.Location = new System.Drawing.Point(12, 400);
            this.NewDatabaseNameTextbox.Name = "NewDatabaseNameTextbox";
            this.NewDatabaseNameTextbox.Size = new System.Drawing.Size(667, 20);
            this.NewDatabaseNameTextbox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewDatabaseNameTextbox);
            this.Controls.Add(this.AddDatabaseButton);
            this.Controls.Add(this.DatabasesTableLayout);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Database Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel DatabasesTableLayout;
        private System.Windows.Forms.Button AddDatabaseButton;
        private System.Windows.Forms.TextBox NewDatabaseNameTextbox;
    }
}

