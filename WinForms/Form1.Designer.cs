namespace WinForms
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
            this.buttonAsyncException = new System.Windows.Forms.Button();
            this.buttonException = new System.Windows.Forms.Button();
            this.buttonThreadException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAsyncException
            // 
            this.buttonAsyncException.Location = new System.Drawing.Point(12, 12);
            this.buttonAsyncException.Name = "buttonAsyncException";
            this.buttonAsyncException.Size = new System.Drawing.Size(75, 48);
            this.buttonAsyncException.TabIndex = 0;
            this.buttonAsyncException.Text = "Async Exception";
            this.buttonAsyncException.UseVisualStyleBackColor = true;
            this.buttonAsyncException.Click += new System.EventHandler(this.buttonAsyncException_Click);
            // 
            // buttonException
            // 
            this.buttonException.Location = new System.Drawing.Point(93, 12);
            this.buttonException.Name = "buttonException";
            this.buttonException.Size = new System.Drawing.Size(75, 48);
            this.buttonException.TabIndex = 1;
            this.buttonException.Text = "Exception";
            this.buttonException.UseVisualStyleBackColor = true;
            this.buttonException.Click += new System.EventHandler(this.buttonException_Click);
            // 
            // buttonThreadException
            // 
            this.buttonThreadException.Location = new System.Drawing.Point(174, 12);
            this.buttonThreadException.Name = "buttonThreadException";
            this.buttonThreadException.Size = new System.Drawing.Size(75, 48);
            this.buttonThreadException.TabIndex = 2;
            this.buttonThreadException.Text = "Thread Exception";
            this.buttonThreadException.UseVisualStyleBackColor = true;
            this.buttonThreadException.Click += new System.EventHandler(this.buttonThreadException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonThreadException);
            this.Controls.Add(this.buttonException);
            this.Controls.Add(this.buttonAsyncException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAsyncException;
        private System.Windows.Forms.Button buttonException;
        private System.Windows.Forms.Button buttonThreadException;
    }
}

