namespace DatabaseManagementStudio
{
    partial class AddColumnForm
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
            this.ColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnTypeDropDown = new System.Windows.Forms.ComboBox();
            this.IsNotNullRadioButton = new System.Windows.Forms.RadioButton();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColumnNameTextBox
            // 
            this.ColumnNameTextBox.Location = new System.Drawing.Point(57, 12);
            this.ColumnNameTextBox.Name = "ColumnNameTextBox";
            this.ColumnNameTextBox.Size = new System.Drawing.Size(275, 20);
            this.ColumnNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип";
            // 
            // ColumnTypeDropDown
            // 
            this.ColumnTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnTypeDropDown.FormattingEnabled = true;
            this.ColumnTypeDropDown.Items.AddRange(new object[] {
            "int",
            "float",
            "char",
            "string",
            "email"});
            this.ColumnTypeDropDown.Location = new System.Drawing.Point(57, 38);
            this.ColumnTypeDropDown.Name = "ColumnTypeDropDown";
            this.ColumnTypeDropDown.Size = new System.Drawing.Size(275, 21);
            this.ColumnTypeDropDown.TabIndex = 3;
            // 
            // IsNotNullRadioButton
            // 
            this.IsNotNullRadioButton.AutoSize = true;
            this.IsNotNullRadioButton.Location = new System.Drawing.Point(15, 65);
            this.IsNotNullRadioButton.Name = "IsNotNullRadioButton";
            this.IsNotNullRadioButton.Size = new System.Drawing.Size(139, 17);
            this.IsNotNullRadioButton.TabIndex = 5;
            this.IsNotNullRadioButton.TabStop = true;
            this.IsNotNullRadioButton.Text = "Обов\'язкове значення";
            this.IsNotNullRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(257, 82);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(75, 23);
            this.AddColumnButton.TabIndex = 6;
            this.AddColumnButton.Text = "Ок";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // AddColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 114);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.IsNotNullRadioButton);
            this.Controls.Add(this.ColumnTypeDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnNameTextBox);
            this.Name = "AddColumnForm";
            this.Text = "Додати новий стовпчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColumnNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColumnTypeDropDown;
        private System.Windows.Forms.RadioButton IsNotNullRadioButton;
        private System.Windows.Forms.Button AddColumnButton;
    }
}