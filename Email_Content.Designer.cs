
namespace ANTN2019_Lab5_Nhom1_19520982
{
    partial class Email_Content
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_text = new System.Windows.Forms.RichTextBox();
            this.subject_text = new System.Windows.Forms.RichTextBox();
            this.to_text = new System.Windows.Forms.RichTextBox();
            this.body_text = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // from_text
            // 
            this.from_text.Location = new System.Drawing.Point(202, 12);
            this.from_text.Name = "from_text";
            this.from_text.Size = new System.Drawing.Size(487, 28);
            this.from_text.TabIndex = 3;
            this.from_text.Text = "";
            // 
            // subject_text
            // 
            this.subject_text.Location = new System.Drawing.Point(202, 57);
            this.subject_text.Name = "subject_text";
            this.subject_text.Size = new System.Drawing.Size(487, 28);
            this.subject_text.TabIndex = 4;
            this.subject_text.Text = "";
            // 
            // to_text
            // 
            this.to_text.Location = new System.Drawing.Point(202, 105);
            this.to_text.Name = "to_text";
            this.to_text.Size = new System.Drawing.Size(487, 28);
            this.to_text.TabIndex = 5;
            this.to_text.Text = "";
            // 
            // body_text
            // 
            this.body_text.Location = new System.Drawing.Point(12, 175);
            this.body_text.Name = "body_text";
            this.body_text.Size = new System.Drawing.Size(776, 263);
            this.body_text.TabIndex = 6;
            this.body_text.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Body:";
            // 
            // Email_Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.body_text);
            this.Controls.Add(this.to_text);
            this.Controls.Add(this.subject_text);
            this.Controls.Add(this.from_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Email_Content";
            this.Text = "Email_Content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox from_text;
        private System.Windows.Forms.RichTextBox subject_text;
        private System.Windows.Forms.RichTextBox to_text;
        private System.Windows.Forms.RichTextBox body_text;
        private System.Windows.Forms.Label label4;
    }
}