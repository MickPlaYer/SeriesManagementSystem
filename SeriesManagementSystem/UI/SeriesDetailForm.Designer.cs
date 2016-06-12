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
            System.Windows.Forms.Label label3;
            this.label_SeriesName = new System.Windows.Forms.Label();
            this.tableLayoutPanel_SeriesDetail = new System.Windows.Forms.TableLayoutPanel();
            this.label_SeriesDes = new System.Windows.Forms.Label();
            this.label_EpisodeNum = new System.Windows.Forms.Label();
            this.tabControl_Series = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Episodes = new System.Windows.Forms.DataGridView();
            this.Column_EpisodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EpisodeDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_EpsiodeCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_SeriesDetail.SuspendLayout();
            this.tabControl_Series.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Episodes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 50);
            label1.TabIndex = 0;
            label1.Text = "名稱：";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 50);
            label2.TabIndex = 2;
            label2.Text = "集數：";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 62);
            label3.TabIndex = 4;
            label3.Text = "描述：";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SeriesName
            // 
            this.label_SeriesName.AutoSize = true;
            this.label_SeriesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SeriesName.Location = new System.Drawing.Point(103, 0);
            this.label_SeriesName.Name = "label_SeriesName";
            this.label_SeriesName.Size = new System.Drawing.Size(143, 50);
            this.label_SeriesName.TabIndex = 1;
            this.label_SeriesName.Text = "SeriesName";
            this.label_SeriesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_SeriesDetail
            // 
            this.tableLayoutPanel_SeriesDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_SeriesDetail.ColumnCount = 2;
            this.tableLayoutPanel_SeriesDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_SeriesDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_SeriesDetail.Controls.Add(this.label_SeriesDes, 1, 2);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(this.label_EpisodeNum, 1, 1);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel_SeriesDetail.Controls.Add(this.label_SeriesName, 1, 0);
            this.tableLayoutPanel_SeriesDetail.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel_SeriesDetail.Name = "tableLayoutPanel_SeriesDetail";
            this.tableLayoutPanel_SeriesDetail.RowCount = 3;
            this.tableLayoutPanel_SeriesDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_SeriesDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_SeriesDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_SeriesDetail.Size = new System.Drawing.Size(249, 162);
            this.tableLayoutPanel_SeriesDetail.TabIndex = 2;
            // 
            // label_SeriesDes
            // 
            this.label_SeriesDes.AutoSize = true;
            this.label_SeriesDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SeriesDes.Location = new System.Drawing.Point(103, 100);
            this.label_SeriesDes.Name = "label_SeriesDes";
            this.label_SeriesDes.Size = new System.Drawing.Size(143, 62);
            this.label_SeriesDes.TabIndex = 4;
            this.label_SeriesDes.Text = "SeriesDescription";
            this.label_SeriesDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_EpisodeNum
            // 
            this.label_EpisodeNum.AutoSize = true;
            this.label_EpisodeNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EpisodeNum.Location = new System.Drawing.Point(103, 50);
            this.label_EpisodeNum.Name = "label_EpisodeNum";
            this.label_EpisodeNum.Size = new System.Drawing.Size(143, 50);
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
            this.tabControl_Series.Size = new System.Drawing.Size(463, 229);
            this.tabControl_Series.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel_SeriesDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本資訊";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Episodes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "各集資訊";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Episodes
            // 
            this.dataGridView_Episodes.AllowUserToAddRows = false;
            this.dataGridView_Episodes.AllowUserToDeleteRows = false;
            this.dataGridView_Episodes.AllowUserToResizeColumns = false;
            this.dataGridView_Episodes.AllowUserToResizeRows = false;
            this.dataGridView_Episodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Episodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_EpisodeName,
            this.Column_EpisodeDes,
            this.Column_EpsiodeCommand});
            this.dataGridView_Episodes.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Episodes.Name = "dataGridView_Episodes";
            this.dataGridView_Episodes.RowHeadersVisible = false;
            this.dataGridView_Episodes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Episodes.RowTemplate.Height = 24;
            this.dataGridView_Episodes.ShowEditingIcon = false;
            this.dataGridView_Episodes.Size = new System.Drawing.Size(443, 188);
            this.dataGridView_Episodes.TabIndex = 4;
            // 
            // Column_EpisodeName
            // 
            this.Column_EpisodeName.HeaderText = "名稱";
            this.Column_EpisodeName.Name = "Column_EpisodeName";
            // 
            // Column_EpisodeDes
            // 
            this.Column_EpisodeDes.HeaderText = "簡述";
            this.Column_EpisodeDes.Name = "Column_EpisodeDes";
            // 
            // Column_EpsiodeCommand
            // 
            this.Column_EpsiodeCommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_EpsiodeCommand.HeaderText = "評論";
            this.Column_EpsiodeCommand.Name = "Column_EpsiodeCommand";
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
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Episodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_SeriesName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SeriesDetail;
        private System.Windows.Forms.Label label_EpisodeNum;
        private System.Windows.Forms.TabControl tabControl_Series;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_SeriesDes;
        private System.Windows.Forms.DataGridView dataGridView_Episodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EpisodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EpisodeDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_EpsiodeCommand;

    }
}