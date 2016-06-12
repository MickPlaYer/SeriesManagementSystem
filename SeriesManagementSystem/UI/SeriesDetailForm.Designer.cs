namespace SeriesManagementSystem.UI
{
    partial class SeriesDetailForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.label_SeriesName = new System.Windows.Forms.Label();
            this.tableLayoutPanel_SeriesDetail = new System.Windows.Forms.TableLayoutPanel();
            this.label_EpisodeNum = new System.Windows.Forms.Label();
            this.tabControl_Series = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_SeriesDetail.SuspendLayout();
            this.tabControl_Series.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 64);
            label1.TabIndex = 0;
            label1.Text = "影集名稱：";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 64);
            label2.TabIndex = 2;
            label2.Text = "影集集數：";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SeriesName
            // 
            this.label_SeriesName.AutoSize = true;
            this.label_SeriesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SeriesName.Location = new System.Drawing.Point(127, 0);
            this.label_SeriesName.Name = "label_SeriesName";
            this.label_SeriesName.Size = new System.Drawing.Size(119, 64);
            this.label_SeriesName.TabIndex = 1;
            this.label_SeriesName.Text = "SeriesName";
            this.label_SeriesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_SeriesDetail
            // 
            this.tableLayoutPanel_SeriesDetail.ColumnCount = 2;
            this.tableLayoutPanel_SeriesDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SeriesDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SeriesDetail.Controls.Add(this.label_EpisodeNum, 1, 1);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(this.label_SeriesName, 1, 0);
            this.tableLayoutPanel_SeriesDetail.Location = new System.Drawing.Point(15, 17);
            this.tableLayoutPanel_SeriesDetail.Name = "tableLayoutPanel_SeriesDetail";
            this.tableLayoutPanel_SeriesDetail.RowCount = 2;
            this.tableLayoutPanel_SeriesDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SeriesDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SeriesDetail.Size = new System.Drawing.Size(249, 128);
            this.tableLayoutPanel_SeriesDetail.TabIndex = 2;
            // 
            // label_EpisodeNum
            // 
            this.label_EpisodeNum.AutoSize = true;
            this.label_EpisodeNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EpisodeNum.Location = new System.Drawing.Point(127, 64);
            this.label_EpisodeNum.Name = "label_EpisodeNum";
            this.label_EpisodeNum.Size = new System.Drawing.Size(119, 64);
            this.label_EpisodeNum.TabIndex = 3;
            this.label_EpisodeNum.Text = "EpisodeNumber";
            this.label_EpisodeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_Series
            // 
            this.tabControl_Series.Controls.Add(this.tabPage1);
            this.tabControl_Series.Controls.Add(this.tabPage2);
            this.tabControl_Series.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl_Series.Location = new System.Drawing.Point(50, 44);
            this.tabControl_Series.Name = "tabControl_Series";
            this.tabControl_Series.SelectedIndex = 0;
            this.tabControl_Series.Size = new System.Drawing.Size(290, 229);
            this.tabControl_Series.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel_SeriesDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本資訊";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "各集資訊";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SeriesDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 333);
            this.Controls.Add(this.tabControl_Series);
            this.Name = "SeriesDetailForm";
            this.Text = "SeriesDetailForm";
            this.tableLayoutPanel_SeriesDetail.ResumeLayout(false);
            this.tableLayoutPanel_SeriesDetail.PerformLayout();
            this.tabControl_Series.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_SeriesName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SeriesDetail;
        private System.Windows.Forms.Label label_EpisodeNum;
        private System.Windows.Forms.TabControl tabControl_Series;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}