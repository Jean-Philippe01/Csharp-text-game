namespace game {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.outputTB = new System.Windows.Forms.TextBox();
            this.NBtn = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.SBtn = new System.Windows.Forms.Button();
            this.WBtn = new System.Windows.Forms.Button();
            this.LookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(12, 12);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(502, 187);
            this.outputTB.TabIndex = 0;
            // 
            // NBtn
            // 
            this.NBtn.Location = new System.Drawing.Point(365, 216);
            this.NBtn.Name = "NBtn";
            this.NBtn.Size = new System.Drawing.Size(75, 23);
            this.NBtn.TabIndex = 2;
            this.NBtn.Text = "N";
            this.NBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NBtn.UseVisualStyleBackColor = true;
            // 
            // EBtn
            // 
            this.EBtn.Location = new System.Drawing.Point(415, 245);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(75, 23);
            this.EBtn.TabIndex = 3;
            this.EBtn.Text = "E";
            this.EBtn.UseVisualStyleBackColor = true;
            this.EBtn.Click += new System.EventHandler(this.EBtn_Click);
            // 
            // SBtn
            // 
            this.SBtn.Location = new System.Drawing.Point(365, 274);
            this.SBtn.Name = "SBtn";
            this.SBtn.Size = new System.Drawing.Size(75, 23);
            this.SBtn.TabIndex = 4;
            this.SBtn.Text = "S";
            this.SBtn.UseVisualStyleBackColor = true;
            this.SBtn.Click += new System.EventHandler(this.SBtn_Click);
            // 
            // WBtn
            // 
            this.WBtn.Location = new System.Drawing.Point(316, 245);
            this.WBtn.Name = "WBtn";
            this.WBtn.Size = new System.Drawing.Size(75, 23);
            this.WBtn.TabIndex = 5;
            this.WBtn.Text = "W";
            this.WBtn.UseVisualStyleBackColor = true;
            this.WBtn.Click += new System.EventHandler(this.WBtn_Click);
            // 
            // LookBtn
            // 
            this.LookBtn.Location = new System.Drawing.Point(45, 245);
            this.LookBtn.Name = "LookBtn";
            this.LookBtn.Size = new System.Drawing.Size(75, 23);
            this.LookBtn.TabIndex = 6;
            this.LookBtn.Text = "Look";
            this.LookBtn.UseVisualStyleBackColor = true;
            this.LookBtn.Click += new System.EventHandler(this.LookBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 319);
            this.Controls.Add(this.LookBtn);
            this.Controls.Add(this.WBtn);
            this.Controls.Add(this.SBtn);
            this.Controls.Add(this.EBtn);
            this.Controls.Add(this.NBtn);
            this.Controls.Add(this.outputTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Button NBtn;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Button SBtn;
        private System.Windows.Forms.Button WBtn;
        private System.Windows.Forms.Button LookBtn;
    }
}

