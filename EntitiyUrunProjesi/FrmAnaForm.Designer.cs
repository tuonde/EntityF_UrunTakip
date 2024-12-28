namespace EntitiyUrunProjesi
{
    partial class FrmAnaForm
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
            this.btnKtgr = new System.Windows.Forms.Button();
            this.btnUrn = new System.Windows.Forms.Button();
            this.btnIststk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKtgr
            // 
            this.btnKtgr.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKtgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKtgr.ForeColor = System.Drawing.Color.White;
            this.btnKtgr.Location = new System.Drawing.Point(12, 12);
            this.btnKtgr.Name = "btnKtgr";
            this.btnKtgr.Size = new System.Drawing.Size(180, 180);
            this.btnKtgr.TabIndex = 0;
            this.btnKtgr.Text = "KATEGORİ İŞLEMLERİ";
            this.btnKtgr.UseVisualStyleBackColor = false;
            this.btnKtgr.Click += new System.EventHandler(this.btnKtgr_Click);
            // 
            // btnUrn
            // 
            this.btnUrn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrn.ForeColor = System.Drawing.Color.White;
            this.btnUrn.Location = new System.Drawing.Point(198, 12);
            this.btnUrn.Name = "btnUrn";
            this.btnUrn.Size = new System.Drawing.Size(180, 180);
            this.btnUrn.TabIndex = 1;
            this.btnUrn.Text = "ÜRÜN İŞLEMLERİ";
            this.btnUrn.UseVisualStyleBackColor = false;
            this.btnUrn.Click += new System.EventHandler(this.btnUrn_Click);
            // 
            // btnIststk
            // 
            this.btnIststk.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIststk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIststk.ForeColor = System.Drawing.Color.White;
            this.btnIststk.Location = new System.Drawing.Point(384, 12);
            this.btnIststk.Name = "btnIststk";
            this.btnIststk.Size = new System.Drawing.Size(180, 180);
            this.btnIststk.TabIndex = 2;
            this.btnIststk.Text = "İSTATİSTİKLER";
            this.btnIststk.UseVisualStyleBackColor = false;
            this.btnIststk.Click += new System.EventHandler(this.btnIststk_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(577, 211);
            this.Controls.Add(this.btnIststk);
            this.Controls.Add(this.btnUrn);
            this.Controls.Add(this.btnKtgr);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKtgr;
        private System.Windows.Forms.Button btnUrn;
        private System.Windows.Forms.Button btnIststk;
    }
}