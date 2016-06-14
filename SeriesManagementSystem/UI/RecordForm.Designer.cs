namespace SeriesManagementSystem.UI
{
    partial class RecordForm
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
            System.Windows.Forms.Label label;
            this.label_EpisodeName = new System.Windows.Forms.Label();
            this.textBox_Record = new System.Windows.Forms.TextBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_AddTimeStamp = new System.Windows.Forms.CheckBox();
            label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(12, 36);
            label.Name = "label";
            label.Size = new System.Drawing.Size(81, 12);
            label.TabIndex = 1;
            label.Text = "Episode 評論：";
            // 
            // label_EpisodeName
            // 
            this.label_EpisodeName.AutoSize = true;
            this.label_EpisodeName.Location = new System.Drawing.Point(12, 9);
            this.label_EpisodeName.Name = "label_EpisodeName";
            this.label_EpisodeName.Size = new System.Drawing.Size(81, 12);
            this.label_EpisodeName.TabIndex = 0;
            this.label_EpisodeName.Text = "Episode 名稱：";
            // 
            // textBox_Record
            // 
            this.textBox_Record.Location = new System.Drawing.Point(14, 60);
            this.textBox_Record.Multiline = true;
            this.textBox_Record.Name = "textBox_Record";
            this.textBox_Record.Size = new System.Drawing.Size(334, 206);
            this.textBox_Record.TabIndex = 2;
            // 
            // button_Yes
            // 
            this.button_Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Yes.Location = new System.Drawing.Point(273, 272);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 23);
            this.button_Yes.TabIndex = 3;
            this.button_Yes.Text = "確定";
            this.button_Yes.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(192, 272);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_AddTimeStamp
            // 
            this.checkBox_AddTimeStamp.AutoSize = true;
            this.checkBox_AddTimeStamp.Checked = true;
            this.checkBox_AddTimeStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddTimeStamp.Location = new System.Drawing.Point(90, 276);
            this.checkBox_AddTimeStamp.Name = "checkBox_AddTimeStamp";
            this.checkBox_AddTimeStamp.Size = new System.Drawing.Size(96, 16);
            this.checkBox_AddTimeStamp.TabIndex = 5;
            this.checkBox_AddTimeStamp.Text = "加上時間標籤";
            this.checkBox_AddTimeStamp.UseVisualStyleBackColor = true;
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 304);
            this.Controls.Add(this.checkBox_AddTimeStamp);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.textBox_Record);
            this.Controls.Add(label);
            this.Controls.Add(this.label_EpisodeName);
            this.Name = "RecordForm";
            this.Text = "紀錄";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EpisodeName;
        private System.Windows.Forms.TextBox textBox_Record;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox_AddTimeStamp;
    }
}