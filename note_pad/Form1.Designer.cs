namespace note_pad
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(203, 73);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(203, 161);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "end";
            this.btn_end.UseVisualStyleBackColor = true;
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(203, 214);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(111, 23);
            this.resume.TabIndex = 2;
            this.resume.Text = "btn_resume";
            this.resume.UseVisualStyleBackColor = true;
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(203, 251);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(75, 23);
            this.btnpause.TabIndex = 3;
            this.btnpause.Text = "pause";
            this.btnpause.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button btnpause;
    }
}

