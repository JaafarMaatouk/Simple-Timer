namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperationTheTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(344, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // btnOperationTheTimer
            // 
            this.btnOperationTheTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOperationTheTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperationTheTimer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperationTheTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOperationTheTimer.Location = new System.Drawing.Point(31, 232);
            this.btnOperationTheTimer.Name = "btnOperationTheTimer";
            this.btnOperationTheTimer.Size = new System.Drawing.Size(235, 100);
            this.btnOperationTheTimer.TabIndex = 0;
            this.btnOperationTheTimer.Text = "Opertion The Timer";
            this.btnOperationTheTimer.UseVisualStyleBackColor = false;
            this.btnOperationTheTimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStopTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopTimer.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopTimer.Location = new System.Drawing.Point(293, 232);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(223, 100);
            this.btnStopTimer.TabIndex = 1;
            this.btnStopTimer.Text = "Stop The Timer";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimerReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerReset.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimerReset.Location = new System.Drawing.Point(549, 235);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(197, 97);
            this.btnTimerReset.TabIndex = 2;
            this.btnTimerReset.Text = "Timer Reset";
            this.btnTimerReset.UseVisualStyleBackColor = false;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimerReset);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnOperationTheTimer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Timer Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOperationTheTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnTimerReset;
    }
}

