namespace Mario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.warning = new System.Windows.Forms.PictureBox();
            this.big_m = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.versionID = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_m)).BeginInit();
            this.SuspendLayout();
            // 
            // warning
            // 
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.Image = global::Mario.Properties.Resources.w2;
            this.warning.Location = new System.Drawing.Point(12, 2);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(59, 65);
            this.warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.warning.TabIndex = 1;
            this.warning.TabStop = false;
            // 
            // big_m
            // 
            this.big_m.BackColor = System.Drawing.Color.Transparent;
            this.big_m.Image = global::Mario.Properties.Resources.m1;
            this.big_m.Location = new System.Drawing.Point(53, 63);
            this.big_m.Margin = new System.Windows.Forms.Padding(4);
            this.big_m.Name = "big_m";
            this.big_m.Size = new System.Drawing.Size(104, 100);
            this.big_m.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.big_m.TabIndex = 0;
            this.big_m.TabStop = false;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(164, 101);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(42, 25);
            this.text.TabIndex = 2;
            this.text.Text = "null";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(423, 209);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 34);
            this.cancel.TabIndex = 3;
            this.cancel.TabStop = false;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(305, 209);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 34);
            this.ok.TabIndex = 4;
            this.ok.TabStop = false;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // versionID
            // 
            this.versionID.ActiveLinkColor = System.Drawing.Color.Blue;
            this.versionID.AutoSize = true;
            this.versionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionID.Location = new System.Drawing.Point(12, 209);
            this.versionID.Name = "versionID";
            this.versionID.Size = new System.Drawing.Size(75, 29);
            this.versionID.TabIndex = 5;
            this.versionID.TabStop = true;
            this.versionID.Text = "v1.0.0";
            this.versionID.VisitedLinkColor = System.Drawing.Color.Blue;
            this.versionID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.versionID_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 247);
            this.Controls.Add(this.versionID);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.text);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.big_m);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox big_m;
        private System.Windows.Forms.PictureBox warning;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.LinkLabel versionID;
    }
}

