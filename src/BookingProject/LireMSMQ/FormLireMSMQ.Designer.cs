namespace LireMSMQ
{
    partial class FormLireMSMQ
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
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.btnCreationMSMQ = new System.Windows.Forms.Button();
            this.btnLireMSMQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(533, 249);
            this.textBoxMessages.TabIndex = 0;
            // 
            // btnCreationMSMQ
            // 
            this.btnCreationMSMQ.Location = new System.Drawing.Point(12, 267);
            this.btnCreationMSMQ.Name = "btnCreationMSMQ";
            this.btnCreationMSMQ.Size = new System.Drawing.Size(132, 23);
            this.btnCreationMSMQ.TabIndex = 1;
            this.btnCreationMSMQ.Text = "Test Insertion MSMQ";
            this.btnCreationMSMQ.UseVisualStyleBackColor = true;
            this.btnCreationMSMQ.Click += new System.EventHandler(this.btnCreationMSMQ_Click);
            // 
            // btnLireMSMQ
            // 
            this.btnLireMSMQ.Location = new System.Drawing.Point(376, 267);
            this.btnLireMSMQ.Name = "btnLireMSMQ";
            this.btnLireMSMQ.Size = new System.Drawing.Size(169, 23);
            this.btnLireMSMQ.TabIndex = 2;
            this.btnLireMSMQ.Text = "Lire MSMQ";
            this.btnLireMSMQ.UseVisualStyleBackColor = true;
            this.btnLireMSMQ.Click += new System.EventHandler(this.btnLireMSMQ_Click);
            // 
            // FormLireMSMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 326);
            this.Controls.Add(this.btnLireMSMQ);
            this.Controls.Add(this.btnCreationMSMQ);
            this.Controls.Add(this.textBoxMessages);
            this.Name = "FormLireMSMQ";
            this.Text = "Lire MSMQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button btnCreationMSMQ;
        private System.Windows.Forms.Button btnLireMSMQ;
    }
}

