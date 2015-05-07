namespace WindowsFormsApplication1
{
    partial class FormMSMQ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLireTransfert = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLireTransfert
            // 
            this.btnLireTransfert.Location = new System.Drawing.Point(14, 232);
            this.btnLireTransfert.Name = "btnLireTransfert";
            this.btnLireTransfert.Size = new System.Drawing.Size(368, 23);
            this.btnLireTransfert.TabIndex = 0;
            this.btnLireTransfert.Text = "Lire MSMQ a exécuter les transferts";
            this.btnLireTransfert.UseVisualStyleBackColor = true;
            this.btnLireTransfert.Click += new System.EventHandler(this.btnLireTransfert_Click);
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(14, 10);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessages.Size = new System.Drawing.Size(367, 209);
            this.tbMessages.TabIndex = 1;
            // 
            // FormMSMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 267);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.btnLireTransfert);
            this.Name = "FormMSMQ";
            this.Text = "Lire MSMQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLireTransfert;
        private System.Windows.Forms.TextBox tbMessages;
    }
}

