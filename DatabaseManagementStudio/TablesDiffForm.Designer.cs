namespace DatabaseManagementStudio
{
    partial class TablesDiffForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Table1DropDown = new System.Windows.Forms.ComboBox();
            this.Table2DropDown = new System.Windows.Forms.ComboBox();
            this.FindDiffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблиця 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблиця 2";
            // 
            // Table1DropDown
            // 
            this.Table1DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Table1DropDown.FormattingEnabled = true;
            this.Table1DropDown.Location = new System.Drawing.Point(45, 79);
            this.Table1DropDown.Name = "Table1DropDown";
            this.Table1DropDown.Size = new System.Drawing.Size(190, 21);
            this.Table1DropDown.TabIndex = 2;
            // 
            // Table2DropDown
            // 
            this.Table2DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Table2DropDown.FormattingEnabled = true;
            this.Table2DropDown.Location = new System.Drawing.Point(241, 79);
            this.Table2DropDown.Name = "Table2DropDown";
            this.Table2DropDown.Size = new System.Drawing.Size(193, 21);
            this.Table2DropDown.TabIndex = 3;
            // 
            // FindDiffButton
            // 
            this.FindDiffButton.Location = new System.Drawing.Point(310, 132);
            this.FindDiffButton.Name = "FindDiffButton";
            this.FindDiffButton.Size = new System.Drawing.Size(124, 23);
            this.FindDiffButton.TabIndex = 4;
            this.FindDiffButton.Text = "Знайти різницю";
            this.FindDiffButton.UseVisualStyleBackColor = true;
            this.FindDiffButton.Click += new System.EventHandler(this.FindDiffButton_Click);
            // 
            // TablesDiffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 168);
            this.Controls.Add(this.FindDiffButton);
            this.Controls.Add(this.Table2DropDown);
            this.Controls.Add(this.Table1DropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablesDiffForm";
            this.Text = "Різниця таблиць";
            this.Load += new System.EventHandler(this.TablesDiffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Table1DropDown;
        private System.Windows.Forms.ComboBox Table2DropDown;
        private System.Windows.Forms.Button FindDiffButton;
    }
}