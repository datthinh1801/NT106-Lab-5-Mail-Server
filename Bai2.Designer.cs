
namespace ANTN2019_Lab5_Nhom1_19520982
{
    partial class Bai2
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
            this.label4 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.recent_label = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.RichTextBox();
            this.password_text = new System.Windows.Forms.RichTextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(216, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recent:";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_label.Location = new System.Drawing.Point(125, 106);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(23, 28);
            this.total_label.TabIndex = 4;
            this.total_label.Text = "0";
            // 
            // recent_label
            // 
            this.recent_label.AutoSize = true;
            this.recent_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recent_label.Location = new System.Drawing.Point(351, 106);
            this.recent_label.Name = "recent_label";
            this.recent_label.Size = new System.Drawing.Size(23, 28);
            this.recent_label.TabIndex = 5;
            this.recent_label.Text = "0";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(162, 20);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(481, 31);
            this.email_text.TabIndex = 6;
            this.email_text.Text = "";
            this.email_text.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(162, 66);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(481, 31);
            this.password_text.TabIndex = 7;
            this.password_text.Text = "";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.Location = new System.Drawing.Point(669, 32);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(110, 52);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.email,
            this.from,
            this.time});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 303);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 360;
            // 
            // from
            // 
            this.from.Text = "From";
            this.from.Width = 250;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 180;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.recent_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label recent_label;
        private System.Windows.Forms.RichTextBox email_text;
        private System.Windows.Forms.RichTextBox password_text;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader time;
    }
}