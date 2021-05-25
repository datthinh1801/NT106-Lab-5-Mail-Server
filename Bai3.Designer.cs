
namespace ANTN2019_Lab5_Nhom1_19520982
{
    partial class Bai3
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.rtbTo = new System.Windows.Forms.RichTextBox();
            this.rtbSubject = new System.Windows.Forms.RichTextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(62, 25);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(38, 15);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "From:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(62, 66);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(22, 15);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "To:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(509, 26);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(60, 15);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(62, 113);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(49, 15);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Subject:";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Location = new System.Drawing.Point(62, 159);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(37, 15);
            this.lbBody.TabIndex = 4;
            this.lbBody.Text = "Body:";
            // 
            // rtbFrom
            // 
            this.rtbFrom.Location = new System.Drawing.Point(127, 22);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(318, 28);
            this.rtbFrom.TabIndex = 5;
            this.rtbFrom.Text = "";
            // 
            // rtbTo
            // 
            this.rtbTo.Location = new System.Drawing.Point(127, 63);
            this.rtbTo.Name = "rtbTo";
            this.rtbTo.Size = new System.Drawing.Size(318, 29);
            this.rtbTo.TabIndex = 6;
            this.rtbTo.Text = "";
            // 
            // rtbSubject
            // 
            this.rtbSubject.Location = new System.Drawing.Point(127, 110);
            this.rtbSubject.Name = "rtbSubject";
            this.rtbSubject.Size = new System.Drawing.Size(633, 28);
            this.rtbSubject.TabIndex = 8;
            this.rtbSubject.Text = "";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(127, 156);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(633, 264);
            this.rtbBody.TabIndex = 9;
            this.rtbBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(298, 459);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(175, 41);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbPassword
            // 
            this.rtbPassword.Location = new System.Drawing.Point(584, 25);
            this.rtbPassword.Name = "rtbPassword";
            this.rtbPassword.PasswordChar = '*';
            this.rtbPassword.Size = new System.Drawing.Size(176, 23);
            this.rtbPassword.TabIndex = 11;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.rtbPassword);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.rtbSubject);
            this.Controls.Add(this.rtbTo);
            this.Controls.Add(this.rtbFrom);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.RichTextBox rtbFrom;
        private System.Windows.Forms.RichTextBox rtbTo;
        private System.Windows.Forms.RichTextBox rtbSubject;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox rtbPassword;
    }
}