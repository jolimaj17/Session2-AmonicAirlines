namespace Session2
{
    partial class Apply
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.GroupBox();
            this.lblmissing = new System.Windows.Forms.Label();
            this.lblduplicate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblchanges = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session2.Properties.Resources.white_2x;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Please select the text file with the changes";
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(20, 129);
            this.txtfilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(553, 21);
            this.txtfilename.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(584, 119);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 38);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.btnImport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(695, 119);
            this.btnImport.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 38);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.lblmissing);
            this.Results.Controls.Add(this.lblduplicate);
            this.Results.Controls.Add(this.label5);
            this.Results.Controls.Add(this.label4);
            this.Results.Controls.Add(this.lblchanges);
            this.Results.Controls.Add(this.label1);
            this.Results.ForeColor = System.Drawing.Color.White;
            this.Results.Location = new System.Drawing.Point(17, 174);
            this.Results.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Results.Size = new System.Drawing.Size(783, 154);
            this.Results.TabIndex = 23;
            this.Results.TabStop = false;
            this.Results.Text = "Results";
            this.Results.Enter += new System.EventHandler(this.Results_Enter);
            // 
            // lblmissing
            // 
            this.lblmissing.AutoSize = true;
            this.lblmissing.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmissing.ForeColor = System.Drawing.Color.White;
            this.lblmissing.Location = new System.Drawing.Point(313, 113);
            this.lblmissing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmissing.Name = "lblmissing";
            this.lblmissing.Size = new System.Drawing.Size(51, 13);
            this.lblmissing.TabIndex = 28;
            this.lblmissing.Text = "[xxxx]";
            // 
            // lblduplicate
            // 
            this.lblduplicate.AutoSize = true;
            this.lblduplicate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduplicate.ForeColor = System.Drawing.Color.White;
            this.lblduplicate.Location = new System.Drawing.Point(313, 78);
            this.lblduplicate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduplicate.Name = "lblduplicate";
            this.lblduplicate.Size = new System.Drawing.Size(51, 13);
            this.lblduplicate.TabIndex = 27;
            this.lblduplicate.Text = "[xxxx]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Records with missing fields discarded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Duplicate Records Discarded";
            // 
            // lblchanges
            // 
            this.lblchanges.AutoSize = true;
            this.lblchanges.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchanges.ForeColor = System.Drawing.Color.White;
            this.lblchanges.Location = new System.Drawing.Point(313, 43);
            this.lblchanges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblchanges.Name = "lblchanges";
            this.lblchanges.Size = new System.Drawing.Size(51, 13);
            this.lblchanges.TabIndex = 25;
            this.lblchanges.Text = "[xxxx]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Successful Changes Applied:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 83);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Apply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(821, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Apply";
            this.Text = "Apply Schedule Changes";
            this.Load += new System.EventHandler(this.Apply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Results.ResumeLayout(false);
            this.Results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.Label lblmissing;
        private System.Windows.Forms.Label lblduplicate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblchanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}