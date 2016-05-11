namespace SeriesManagementSystem.UI
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
            this.button_AddSeries = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._seriesGridView = new System.Windows.Forms.DataGridView();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._seriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddSeries
            // 
            this.button_AddSeries.Location = new System.Drawing.Point(12, 12);
            this.button_AddSeries.Name = "button_AddSeries";
            this.button_AddSeries.Size = new System.Drawing.Size(75, 23);
            this.button_AddSeries.TabIndex = 0;
            this.button_AddSeries.Text = "Add";
            this.button_AddSeries.UseVisualStyleBackColor = true;
            this.button_AddSeries.Click += new System.EventHandler(this.ClickAddSeriesButton);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
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
            this._seriesGridView.Location = new System.Drawing.Point(13, 41);
            this._seriesGridView.Name = "_seriesGridView";
            this._seriesGridView.ReadOnly = true;
            this._seriesGridView.RowHeadersWidth = 50;
            this._seriesGridView.RowTemplate.Height = 24;
            this._seriesGridView.Size = new System.Drawing.Size(500, 318);
            this._seriesGridView.TabIndex = 4;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "Modify";
            this.Modify.UseColumnTextForButtonValue = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesIDDataGridViewTextBoxColumn
            // 
            this.seriesIDDataGridViewTextBoxColumn.DataPropertyName = "SeriesID";
            this.seriesIDDataGridViewTextBoxColumn.HeaderText = "SeriesID";
            this.seriesIDDataGridViewTextBoxColumn.Name = "seriesIDDataGridViewTextBoxColumn";
            this.seriesIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // SoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 371);
            this.Controls.Add(this._seriesGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_AddSeries);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 410);
            this.Name = "SoftwareForm";
            this.Text = "Series Management System";
            ((System.ComponentModel.ISupportInitialize)(this._seriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddSeries;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView _seriesGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seriesManagerBindingSource;
        private System.Windows.Forms.BindingSource seriesListBindingSource;
    }
}