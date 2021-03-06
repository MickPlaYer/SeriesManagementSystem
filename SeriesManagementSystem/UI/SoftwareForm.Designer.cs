﻿namespace SeriesManagementSystem.UI
{
    partial class SoftwareForm
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
            this.components = new System.ComponentModel.Container();
            this._addSeriesButton = new System.Windows.Forms.Button();
            this._importSeriesButton = new System.Windows.Forms.Button();
            this._seriesGridView = new System.Windows.Forms.DataGridView();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._refreshButton = new System.Windows.Forms.Button();
            this._refreshResultLabel = new System.Windows.Forms.Label();
            this.checkBox_All = new System.Windows.Forms.CheckBox();
            this.checkBox_Following = new System.Windows.Forms.CheckBox();
            this.checkBox_Unfollowing = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._seriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _addSeriesButton
            // 
            this._addSeriesButton.Location = new System.Drawing.Point(12, 12);
            this._addSeriesButton.Name = "_addSeriesButton";
            this._addSeriesButton.Size = new System.Drawing.Size(75, 23);
            this._addSeriesButton.TabIndex = 0;
            this._addSeriesButton.Text = "新增";
            this._addSeriesButton.UseVisualStyleBackColor = true;
            this._addSeriesButton.Click += new System.EventHandler(this.OnAddSeries);
            // 
            // _importSeriesButton
            // 
            this._importSeriesButton.Location = new System.Drawing.Point(93, 12);
            this._importSeriesButton.Name = "_importSeriesButton";
            this._importSeriesButton.Size = new System.Drawing.Size(75, 23);
            this._importSeriesButton.TabIndex = 3;
            this._importSeriesButton.Text = "匯入";
            this._importSeriesButton.UseVisualStyleBackColor = true;
            this._importSeriesButton.Click += new System.EventHandler(this.OnImportSeries);
            // 
            // _seriesGridView
            // 
            this._seriesGridView.AllowUserToAddRows = false;
            this._seriesGridView.AllowUserToDeleteRows = false;
            this._seriesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._seriesGridView.AutoGenerateColumns = false;
            this._seriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._seriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._seriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modify,
            this.Remove,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.seriesIDDataGridViewTextBoxColumn});
            this._seriesGridView.DataSource = this.seriesListBindingSource;
            this._seriesGridView.Location = new System.Drawing.Point(174, 41);
            this._seriesGridView.Name = "_seriesGridView";
            this._seriesGridView.ReadOnly = true;
            this._seriesGridView.RowHeadersWidth = 50;
            this._seriesGridView.RowTemplate.Height = 24;
            this._seriesGridView.Size = new System.Drawing.Size(841, 482);
            this._seriesGridView.TabIndex = 4;
            this._seriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellButtonClick);
            // 
            // Modify
            // 
            this.Modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Modify.FillWeight = 187.5F;
            this.Modify.HeaderText = "";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "修改";
            this.Modify.UseColumnTextForButtonValue = true;
            this.Modify.Width = 120;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "刪除";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 56.25F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "名稱";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 56.25F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "描述";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesIDDataGridViewTextBoxColumn
            // 
            this.seriesIDDataGridViewTextBoxColumn.DataPropertyName = "SeriesID";
            this.seriesIDDataGridViewTextBoxColumn.HeaderText = "SeriesID";
            this.seriesIDDataGridViewTextBoxColumn.Name = "seriesIDDataGridViewTextBoxColumn";
            this.seriesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriesIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // seriesListBindingSource
            // 
            this.seriesListBindingSource.DataMember = "SeriesList";
            this.seriesListBindingSource.DataSource = this.seriesManagerBindingSource;
            // 
            // seriesManagerBindingSource
            // 
            this.seriesManagerBindingSource.DataSource = typeof(SeriesManagementSystem.Domain.SeriesManager);
            // 
            // _refreshButton
            // 
            this._refreshButton.Location = new System.Drawing.Point(174, 12);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(75, 23);
            this._refreshButton.TabIndex = 5;
            this._refreshButton.Text = "更新";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this.OnRefresh);
            // 
            // _refreshResultLabel
            // 
            this._refreshResultLabel.AutoSize = true;
            this._refreshResultLabel.Location = new System.Drawing.Point(255, 17);
            this._refreshResultLabel.Name = "_refreshResultLabel";
            this._refreshResultLabel.Size = new System.Drawing.Size(0, 12);
            this._refreshResultLabel.TabIndex = 6;
            // 
            // checkBox_All
            // 
            this.checkBox_All.AutoSize = true;
            this.checkBox_All.Location = new System.Drawing.Point(12, 67);
            this.checkBox_All.Name = "checkBox_All";
            this.checkBox_All.Size = new System.Drawing.Size(72, 16);
            this.checkBox_All.TabIndex = 7;
            this.checkBox_All.Text = "所有影集";
            this.checkBox_All.UseVisualStyleBackColor = true;
            this.checkBox_All.Click += new System.EventHandler(this.ClickCheckBoxAll);
            // 
            // checkBox_Following
            // 
            this.checkBox_Following.AutoSize = true;
            this.checkBox_Following.Location = new System.Drawing.Point(12, 105);
            this.checkBox_Following.Name = "checkBox_Following";
            this.checkBox_Following.Size = new System.Drawing.Size(96, 16);
            this.checkBox_Following.TabIndex = 8;
            this.checkBox_Following.Text = "已追蹤的影集";
            this.checkBox_Following.UseVisualStyleBackColor = true;
            this.checkBox_Following.Click += new System.EventHandler(this.ClickCheckBoxFollowing);
            // 
            // checkBox_Unfollowing
            // 
            this.checkBox_Unfollowing.AutoSize = true;
            this.checkBox_Unfollowing.Location = new System.Drawing.Point(12, 147);
            this.checkBox_Unfollowing.Name = "checkBox_Unfollowing";
            this.checkBox_Unfollowing.Size = new System.Drawing.Size(84, 16);
            this.checkBox_Unfollowing.TabIndex = 9;
            this.checkBox_Unfollowing.Text = "放棄的影集";
            this.checkBox_Unfollowing.UseVisualStyleBackColor = true;
            this.checkBox_Unfollowing.Click += new System.EventHandler(this.ClickCheckBoxUnfollowing);
            // 
            // SoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 535);
            this.Controls.Add(this.checkBox_Unfollowing);
            this.Controls.Add(this.checkBox_Following);
            this.Controls.Add(this.checkBox_All);
            this.Controls.Add(this._refreshResultLabel);
            this.Controls.Add(this._refreshButton);
            this.Controls.Add(this._seriesGridView);
            this.Controls.Add(this._importSeriesButton);
            this.Controls.Add(this._addSeriesButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 410);
            this.Name = "SoftwareForm";
            this.Text = "Series Management System";
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this._seriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addSeriesButton;
        private System.Windows.Forms.Button _importSeriesButton;
        private System.Windows.Forms.DataGridView _seriesGridView;
        private System.Windows.Forms.BindingSource seriesManagerBindingSource;
        private System.Windows.Forms.BindingSource seriesListBindingSource;
        private System.Windows.Forms.Button _refreshButton;
        private System.Windows.Forms.Label _refreshResultLabel;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox_All;
        private System.Windows.Forms.CheckBox checkBox_Following;
        private System.Windows.Forms.CheckBox checkBox_Unfollowing;
    }
}