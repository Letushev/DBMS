namespace DatabaseManagementStudio
{
    partial class AddRowForm
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
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddRowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(312, 377);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddRowButton.TabIndex = 0;
            this.AddRowButton.TabStop = false;
            this.AddRowButton.Text = "Ок";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // AddRowLayout
            // 
            this.AddRowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AddRowLayout.Location = new System.Drawing.Point(12, 12);
            this.AddRowLayout.Name = "AddRowLayout";
            this.AddRowLayout.Size = new System.Drawing.Size(375, 359);
            this.AddRowLayout.TabIndex = 1;
            // 
            // AddRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 412);
            this.Controls.Add(this.AddRowLayout);
            this.Controls.Add(this.AddRowButton);
            this.Name = "AddRowForm";
            this.Text = "Додати новий рядок";
            this.Load += new System.EventHandler(this.AddRowForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.FlowLayoutPanel AddRowLayout;
    }
}