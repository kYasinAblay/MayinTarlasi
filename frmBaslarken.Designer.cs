namespace minefield
{
    partial class frmBaslarken
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
			this.btnKolay = new System.Windows.Forms.Button();
			this.btnOrta = new System.Windows.Forms.Button();
			this.btnZor = new System.Windows.Forms.Button();
			this.rchTxtName = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.chboxSee = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnKolay
			// 
			this.btnKolay.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKolay.Location = new System.Drawing.Point(44, 129);
			this.btnKolay.Margin = new System.Windows.Forms.Padding(4);
			this.btnKolay.Name = "btnKolay";
			this.btnKolay.Size = new System.Drawing.Size(125, 59);
			this.btnKolay.TabIndex = 1;
			this.btnKolay.Tag = "0";
			this.btnKolay.Text = "Kolay";
			this.btnKolay.UseVisualStyleBackColor = true;
			this.btnKolay.Click += new System.EventHandler(this.ZorlukButonControl_Click);
			// 
			// btnOrta
			// 
			this.btnOrta.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.btnOrta.Location = new System.Drawing.Point(44, 188);
			this.btnOrta.Margin = new System.Windows.Forms.Padding(4);
			this.btnOrta.Name = "btnOrta";
			this.btnOrta.Size = new System.Drawing.Size(125, 61);
			this.btnOrta.TabIndex = 1;
			this.btnOrta.Tag = "1";
			this.btnOrta.Text = "Orta";
			this.btnOrta.UseVisualStyleBackColor = true;
			this.btnOrta.Click += new System.EventHandler(this.ZorlukButonControl_Click);
			// 
			// btnZor
			// 
			this.btnZor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.btnZor.Location = new System.Drawing.Point(44, 249);
			this.btnZor.Margin = new System.Windows.Forms.Padding(4);
			this.btnZor.Name = "btnZor";
			this.btnZor.Size = new System.Drawing.Size(125, 61);
			this.btnZor.TabIndex = 1;
			this.btnZor.Tag = "2";
			this.btnZor.Text = "Zor";
			this.btnZor.UseVisualStyleBackColor = true;
			this.btnZor.Click += new System.EventHandler(this.ZorlukButonControl_Click);
			// 
			// rchTxtName
			// 
			this.rchTxtName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rchTxtName.Location = new System.Drawing.Point(44, 66);
			this.rchTxtName.Margin = new System.Windows.Forms.Padding(4);
			this.rchTxtName.MaxLength = 11;
			this.rchTxtName.Name = "rchTxtName";
			this.rchTxtName.Size = new System.Drawing.Size(124, 37);
			this.rchTxtName.TabIndex = 2;
			this.rchTxtName.Tag = "";
			this.rchTxtName.Text = "";
			this.toolTip1.SetToolTip(this.rchTxtName, "You Must Fill This Field.");
			this.rchTxtName.TextChanged += new System.EventHandler(this.rchTxtName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(40, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 200;
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			// 
			// chboxSee
			// 
			this.chboxSee.AutoSize = true;
			this.chboxSee.Location = new System.Drawing.Point(115, 25);
			this.chboxSee.Name = "chboxSee";
			this.chboxSee.Size = new System.Drawing.Size(58, 23);
			this.chboxSee.TabIndex = 4;
			this.chboxSee.Text = "See";
			this.chboxSee.UseVisualStyleBackColor = true;
			// 
			// frmBaslarken
			// 
			this.AcceptButton = this.btnKolay;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 336);
			this.ControlBox = false;
			this.Controls.Add(this.chboxSee);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rchTxtName);
			this.Controls.Add(this.btnZor);
			this.Controls.Add(this.btnOrta);
			this.Controls.Add(this.btnKolay);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBaslarken";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBaslarken";
			this.Load += new System.EventHandler(this.frmBaslarken_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaslarken_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnZor;
        private System.Windows.Forms.RichTextBox rchTxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.CheckBox chboxSee;
	}
}