namespace SeriesManagementSystem.UI
{
    partial class CommandForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.Label label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tableLayoutPanel_info = new System.Windows.Forms.TableLayoutPanel();
            this.label_EpisodeDes = new System.Windows.Forms.Label();
            this.label_EpisodeName = new System.Windows.Forms.Label();
            this.label_SeriesName = new System.Windows.Forms.Label();
            this.groupBox_Commands = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_CommandLeft = new System.Windows.Forms.Button();
            this.label_CommandNum = new System.Windows.Forms.Label();
            this.button_CommandRight = new System.Windows.Forms.Button();
            this.label_Command = new System.Windows.Forms.Label();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel_info.SuspendLayout();
            this.groupBox_Commands.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(this.tableLayoutPanel_info, 0, 0);
            tableLayoutPanel.Controls.Add(this.groupBox_Commands, 0, 1);
            tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Size = new System.Drawing.Size(460, 337);
            tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_info
            // 
            this.tableLayoutPanel_info.ColumnCount = 2;
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_info.Controls.Add(this.label_EpisodeDes, 1, 2);
            this.tableLayoutPanel_info.Controls.Add(this.label_EpisodeName, 1, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label_SeriesName, 1, 0);
            this.tableLayoutPanel_info.Controls.Add(label, 0, 0);
            this.tableLayoutPanel_info.Controls.Add(label1, 0, 1);
            this.tableLayoutPanel_info.Controls.Add(label2, 0, 2);
            this.tableLayoutPanel_info.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_info.Name = "tableLayoutPanel_info";
            this.tableLayoutPanel_info.RowCount = 3;
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_info.Size = new System.Drawing.Size(180, 76);
            this.tableLayoutPanel_info.TabIndex = 1;
            // 
            // label_EpisodeDes
            // 
            this.label_EpisodeDes.AutoSize = true;
            this.label_EpisodeDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EpisodeDes.Location = new System.Drawing.Point(108, 56);
            this.label_EpisodeDes.Name = "label_EpisodeDes";
            this.label_EpisodeDes.Size = new System.Drawing.Size(69, 20);
            this.label_EpisodeDes.TabIndex = 4;
            this.label_EpisodeDes.Text = "EpisodeDes";
            // 
            // label_EpisodeName
            // 
            this.label_EpisodeName.AutoSize = true;
            this.label_EpisodeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EpisodeName.Location = new System.Drawing.Point(108, 28);
            this.label_EpisodeName.Name = "label_EpisodeName";
            this.label_EpisodeName.Size = new System.Drawing.Size(69, 28);
            this.label_EpisodeName.TabIndex = 3;
            this.label_EpisodeName.Text = "EpisodeName";
            // 
            // label_SeriesName
            // 
            this.label_SeriesName.AutoSize = true;
            this.label_SeriesName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SeriesName.Location = new System.Drawing.Point(108, 0);
            this.label_SeriesName.Name = "label_SeriesName";
            this.label_SeriesName.Size = new System.Drawing.Size(69, 28);
            this.label_SeriesName.TabIndex = 2;
            this.label_SeriesName.Text = "SeriesName";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.Location = new System.Drawing.Point(3, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(99, 28);
            label.TabIndex = 0;
            label.Text = "影集名稱：";
            label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 28);
            label1.TabIndex = 1;
            label1.Text = "Episode 名稱：";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Episode 描述：";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox_Commands
            // 
            this.groupBox_Commands.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Commands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Commands.Location = new System.Drawing.Point(3, 85);
            this.groupBox_Commands.Name = "groupBox_Commands";
            this.groupBox_Commands.Size = new System.Drawing.Size(454, 249);
            this.groupBox_Commands.TabIndex = 2;
            this.groupBox_Commands.TabStop = false;
            this.groupBox_Commands.Text = "評論";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Command, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 222);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.button_CommandLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_CommandNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_CommandRight, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 24);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_CommandLeft
            // 
            this.button_CommandLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CommandLeft.Location = new System.Drawing.Point(74, 3);
            this.button_CommandLeft.Name = "button_CommandLeft";
            this.button_CommandLeft.Size = new System.Drawing.Size(75, 18);
            this.button_CommandLeft.TabIndex = 2;
            this.button_CommandLeft.Text = "<";
            this.button_CommandLeft.UseVisualStyleBackColor = true;
            this.button_CommandLeft.Click += new System.EventHandler(this.ReduceCommandCount);
            // 
            // label_CommandNum
            // 
            this.label_CommandNum.AutoSize = true;
            this.label_CommandNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CommandNum.Location = new System.Drawing.Point(155, 0);
            this.label_CommandNum.Name = "label_CommandNum";
            this.label_CommandNum.Size = new System.Drawing.Size(124, 24);
            this.label_CommandNum.TabIndex = 0;
            this.label_CommandNum.Text = "CommandNum";
            this.label_CommandNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CommandRight
            // 
            this.button_CommandRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CommandRight.Location = new System.Drawing.Point(285, 3);
            this.button_CommandRight.Name = "button_CommandRight";
            this.button_CommandRight.Size = new System.Drawing.Size(75, 18);
            this.button_CommandRight.TabIndex = 1;
            this.button_CommandRight.Text = ">";
            this.button_CommandRight.UseVisualStyleBackColor = true;
            this.button_CommandRight.Click += new System.EventHandler(this.AddCommandCount);
            // 
            // label_Command
            // 
            this.label_Command.AutoSize = true;
            this.label_Command.Location = new System.Drawing.Point(3, 30);
            this.label_Command.Name = "label_Command";
            this.label_Command.Size = new System.Drawing.Size(54, 12);
            this.label_Command.TabIndex = 1;
            this.label_Command.Text = "Command";
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CommandForm";
            this.Text = "CommandForm";
            tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel_info.ResumeLayout(false);
            this.tableLayoutPanel_info.PerformLayout();
            this.groupBox_Commands.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_info;
        private System.Windows.Forms.Label label_EpisodeDes;
        private System.Windows.Forms.Label label_EpisodeName;
        private System.Windows.Forms.Label label_SeriesName;
        private System.Windows.Forms.GroupBox groupBox_Commands;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_CommandLeft;
        private System.Windows.Forms.Label label_CommandNum;
        private System.Windows.Forms.Button button_CommandRight;
        private System.Windows.Forms.Label label_Command;

    }
}