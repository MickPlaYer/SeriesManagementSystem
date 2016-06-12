namespace SeriesManagementSystem.UI
{
    partial class AddDataForm
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
            System.Windows.Forms.Label label_SeriesName;
            this.label_SeriesDes = new System.Windows.Forms.Label();
            this.textBox_SeriesName = new System.Windows.Forms.TextBox();
            this.textBox_SeriesDesc = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            label_SeriesName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_SeriesName
            // 
            label_SeriesName.AutoSize = true;
            label_SeriesName.Location = new System.Drawing.Point(12, 15);
            label_SeriesName.Name = "label_SeriesName";
            label_SeriesName.Size = new System.Drawing.Size(65, 12);
            label_SeriesName.TabIndex = 0;
            label_SeriesName.Text = "影集名稱：";
            // 
            // label_SeriesDes
            // 
            this.label_SeriesDes.AutoSize = true;
            this.label_SeriesDes.Location = new System.Drawing.Point(12, 54);
            this.label_SeriesDes.Name = "label_SeriesDes";
            this.label_SeriesDes.Size = new System.Drawing.Size(65, 12);
            this.label_SeriesDes.TabIndex = 1;
            this.label_SeriesDes.Text = "影集描述：";
            // 
            // textBox_SeriesName
            // 
            this.textBox_SeriesName.Location = new System.Drawing.Point(83, 12);
            this.textBox_SeriesName.Name = "textBox_SeriesName";
            this.textBox_SeriesName.Size = new System.Drawing.Size(248, 22);
            this.textBox_SeriesName.TabIndex = 2;
            this.textBox_SeriesName.TextChanged += new System.EventHandler(this.ChangeTextBoxSeriesName);
            // 
            // textBox_SeriesDes
            // 
            this.textBox_SeriesDesc.Location = new System.Drawing.Point(83, 54);
            this.textBox_SeriesDesc.Multiline = true;
            this.textBox_SeriesDesc.Name = "textBox_SeriesDes";
            this.textBox_SeriesDesc.Size = new System.Drawing.Size(248, 126);
            this.textBox_SeriesDesc.TabIndex = 3;
            this.textBox_SeriesDesc.TextChanged += new System.EventHandler(this.ChangeTextBoxSeriesDescription);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(245, 197);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(86, 35);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.ClickButtonCancel);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(153, 197);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(86, 35);
            this.button_Confirm.TabIndex = 5;
            this.button_Confirm.Text = "確定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.ClickButtonConfirm);
            // 
            // SeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 244);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_SeriesDesc);
            this.Controls.Add(this.textBox_SeriesName);
            this.Controls.Add(this.label_SeriesDes);
            this.Controls.Add(label_SeriesName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SeriesForm";
            this.Text = "SeriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SeriesDes;
        private System.Windows.Forms.TextBox textBox_SeriesName;
        private System.Windows.Forms.TextBox textBox_SeriesDesc;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Confirm;
    }
}