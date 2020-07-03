namespace minefield
{
    partial class frmMineField
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMineField));
			this.lblfrmName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.mayinPaneli = new System.Windows.Forms.Panel();
			this.lblSkor = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblOyunda = new System.Windows.Forms.Label();
			this.lblPassingTime = new System.Windows.Forms.Label();
			this.lblElapsedTime = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblfrmName
			// 
			this.lblfrmName.AutoSize = true;
			this.lblfrmName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.lblfrmName.Location = new System.Drawing.Point(20, 14);
			this.lblfrmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblfrmName.Name = "lblfrmName";
			this.lblfrmName.Size = new System.Drawing.Size(13, 19);
			this.lblfrmName.TabIndex = 0;
			this.lblfrmName.Text = ".";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.IndianRed;
			this.button1.Location = new System.Drawing.Point(632, 9);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(43, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// mayinPaneli
			// 
			this.mayinPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mayinPaneli.Location = new System.Drawing.Point(15, 118);
			this.mayinPaneli.Name = "mayinPaneli";
			this.mayinPaneli.Size = new System.Drawing.Size(651, 384);
			this.mayinPaneli.TabIndex = 3;
			// 
			// lblSkor
			// 
			this.lblSkor.AutoSize = true;
			this.lblSkor.Location = new System.Drawing.Point(38, 25);
			this.lblSkor.Name = "lblSkor";
			this.lblSkor.Size = new System.Drawing.Size(55, 38);
			this.lblSkor.TabIndex = 7;
			this.lblSkor.Text = "01";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.lblSkor);
			this.panel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F);
			this.panel2.ForeColor = System.Drawing.Color.LimeGreen;
			this.panel2.Location = new System.Drawing.Point(243, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(112, 82);
			this.panel2.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(361, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 82);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("Pirata One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.ForeColor = System.Drawing.Color.Crimson;
			this.lblUserName.Location = new System.Drawing.Point(69, 47);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(0, 51);
			this.lblUserName.TabIndex = 7;
			// 
			// lblOyunda
			// 
			this.lblOyunda.AutoSize = true;
			this.lblOyunda.Location = new System.Drawing.Point(74, 86);
			this.lblOyunda.Name = "lblOyunda";
			this.lblOyunda.Size = new System.Drawing.Size(74, 19);
			this.lblOyunda.TabIndex = 8;
			this.lblOyunda.Text = "Oyunda!";
			// 
			// lblPassingTime
			// 
			this.lblPassingTime.AutoSize = true;
			this.lblPassingTime.Location = new System.Drawing.Point(484, 41);
			this.lblPassingTime.Name = "lblPassingTime";
			this.lblPassingTime.Size = new System.Drawing.Size(98, 19);
			this.lblPassingTime.TabIndex = 9;
			this.lblPassingTime.Text = "Geçen Süre:";
			// 
			// lblElapsedTime
			// 
			this.lblElapsedTime.AutoSize = true;
			this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElapsedTime.Location = new System.Drawing.Point(478, 66);
			this.lblElapsedTime.Name = "lblElapsedTime";
			this.lblElapsedTime.Size = new System.Drawing.Size(0, 31);
			this.lblElapsedTime.TabIndex = 9;
			// 
			// frmMineField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 520);
			this.Controls.Add(this.lblElapsedTime);
			this.Controls.Add(this.lblPassingTime);
			this.Controls.Add(this.lblOyunda);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.mayinPaneli);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblfrmName);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMineField";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ablay\'s MineField";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMineField_FormClosed);
			this.Load += new System.EventHandler(this.frmMineField_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSkor;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblfrmName;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel mayinPaneli;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblOyunda;
		private System.Windows.Forms.Label lblPassingTime;
		private System.Windows.Forms.Label lblElapsedTime;
		private System.Windows.Forms.Timer Timer1;
	}
}

