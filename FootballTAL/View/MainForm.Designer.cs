namespace FootballTAL
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.BTNCal = new System.Windows.Forms.Button();
            this.GVFields = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNClear = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CBContinueOnError = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVFields)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // TBPath
            // 
            this.TBPath.BackColor = System.Drawing.SystemColors.Window;
            this.TBPath.Location = new System.Drawing.Point(3, 19);
            this.TBPath.Name = "TBPath";
            this.TBPath.ReadOnly = true;
            this.TBPath.Size = new System.Drawing.Size(273, 20);
            this.TBPath.TabIndex = 2;
            // 
            // BTNCal
            // 
            this.BTNCal.Location = new System.Drawing.Point(162, 207);
            this.BTNCal.Name = "BTNCal";
            this.BTNCal.Size = new System.Drawing.Size(75, 23);
            this.BTNCal.TabIndex = 3;
            this.BTNCal.Text = "Get Result";
            this.BTNCal.UseVisualStyleBackColor = true;
            this.BTNCal.Click += new System.EventHandler(this.BTNCal_Click);
            // 
            // GVFields
            // 
            this.GVFields.AllowUserToAddRows = false;
            this.GVFields.AllowUserToResizeRows = false;
            this.GVFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVFields.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GVFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.Difference});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVFields.DefaultCellStyle = dataGridViewCellStyle5;
            this.GVFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GVFields.EnableHeadersVisualStyles = false;
            this.GVFields.Location = new System.Drawing.Point(3, 48);
            this.GVFields.Name = "GVFields";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GVFields.RowHeadersVisible = false;
            this.GVFields.ShowCellToolTips = false;
            this.GVFields.Size = new System.Drawing.Size(397, 137);
            this.GVFields.TabIndex = 6;
            // 
            // Table
            // 
            this.Table.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table.DataPropertyName = "ClubName";
            this.Table.FillWeight = 78.17259F;
            this.Table.HeaderText = "Club Name";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Difference
            // 
            this.Difference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Difference.DataPropertyName = "DifferenceFA";
            this.Difference.FillWeight = 121.8274F;
            this.Difference.HeaderText = "Smallest Difference";
            this.Difference.Name = "Difference";
            this.Difference.ReadOnly = true;
            this.Difference.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Difference.Width = 140;
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(254, 207);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(50, 23);
            this.BTNClear.TabIndex = 7;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(4, 190);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 8;
            // 
            // CBContinueOnError
            // 
            this.CBContinueOnError.AutoSize = true;
            this.CBContinueOnError.Location = new System.Drawing.Point(7, 210);
            this.CBContinueOnError.Name = "CBContinueOnError";
            this.CBContinueOnError.Size = new System.Drawing.Size(107, 17);
            this.CBContinueOnError.TabIndex = 9;
            this.CBContinueOnError.Text = "Continue on error";
            this.CBContinueOnError.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.CBContinueOnError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.GVFields);
            this.Controls.Add(this.BTNCal);
            this.Controls.Add(this.TBPath);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 278);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 262);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Premier League";
            ((System.ComponentModel.ISupportInitialize)(this.GVFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TBPath;
        public System.Windows.Forms.Button BTNCal;
        public System.Windows.Forms.DataGridView GVFields;
        public System.Windows.Forms.Button BTNClear;
        public System.Windows.Forms.Label ErrorLabel;
        public System.Windows.Forms.CheckBox CBContinueOnError;
        public System.Windows.Forms.DataGridViewTextBoxColumn Table;
        public System.Windows.Forms.DataGridViewTextBoxColumn Difference;
    }
}

