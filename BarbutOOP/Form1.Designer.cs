namespace BarbutOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSayi1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lSayi2 = new System.Windows.Forms.Label();
            this.lbsonuc = new System.Windows.Forms.ListBox();
            this.pbSayi1 = new System.Windows.Forms.PictureBox();
            this.pbSayi2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // lSayi1
            // 
            this.lSayi1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSayi1.AutoSize = true;
            this.lSayi1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSayi1.Location = new System.Drawing.Point(171, 101);
            this.lSayi1.Name = "lSayi1";
            this.lSayi1.Size = new System.Drawing.Size(60, 24);
            this.lSayi1.TabIndex = 0;
            this.lSayi1.Text = "lsayi1";
            this.lSayi1.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(171, 168);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(260, 85);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Zar At";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lSayi2
            // 
            this.lSayi2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSayi2.AutoSize = true;
            this.lSayi2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSayi2.Location = new System.Drawing.Point(339, 101);
            this.lSayi2.Name = "lSayi2";
            this.lSayi2.Size = new System.Drawing.Size(60, 24);
            this.lSayi2.TabIndex = 0;
            this.lSayi2.Text = "lsayi2";
            this.lSayi2.Visible = false;
            // 
            // lbsonuc
            // 
            this.lbsonuc.Cursor = System.Windows.Forms.Cursors.No;
            this.lbsonuc.FormattingEnabled = true;
            this.lbsonuc.ItemHeight = 15;
            this.lbsonuc.Location = new System.Drawing.Point(450, 159);
            this.lbsonuc.Name = "lbsonuc";
            this.lbsonuc.Size = new System.Drawing.Size(120, 94);
            this.lbsonuc.TabIndex = 2;
            // 
            // pbSayi1
            // 
            this.pbSayi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSayi1.Location = new System.Drawing.Point(171, 21);
            this.pbSayi1.Name = "pbSayi1";
            this.pbSayi1.Size = new System.Drawing.Size(80, 80);
            this.pbSayi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSayi1.TabIndex = 3;
            this.pbSayi1.TabStop = false;
            // 
            // pbSayi2
            // 
            this.pbSayi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSayi2.Location = new System.Drawing.Point(331, 21);
            this.pbSayi2.Name = "pbSayi2";
            this.pbSayi2.Size = new System.Drawing.Size(80, 80);
            this.pbSayi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSayi2.TabIndex = 3;
            this.pbSayi2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(189, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pbSayi2);
            this.Controls.Add(this.pbSayi1);
            this.Controls.Add(this.lbsonuc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lSayi2);
            this.Controls.Add(this.lSayi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barbut v0 ~ By Behlul Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lSayi1;
        private Button btn1;
        private Label lSayi2;
        private ListBox lbsonuc;
        private PictureBox pbSayi1;
        private PictureBox pbSayi2;
        private ListView listView1;
    }
}