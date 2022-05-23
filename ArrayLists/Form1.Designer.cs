
namespace ArrayLists
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
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.tbxStudentN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 15;
            this.lbxStudentList.Location = new System.Drawing.Point(31, 68);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(122, 214);
            this.lbxStudentList.TabIndex = 0;
            this.lbxStudentList.SelectedIndexChanged += new System.EventHandler(this.lbxStudentList_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(515, 113);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(31, 299);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Çıkar";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Location = new System.Drawing.Point(317, 83);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(73, 15);
            this.lbStudentName.TabIndex = 4;
            this.lbStudentName.Text = "Öğrenci Adı:";
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(31, 39);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(84, 15);
            this.lblStudentList.TabIndex = 5;
            this.lblStudentList.Text = "Öğrenci Listesi";
            this.lblStudentList.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbxStudentN
            // 
            this.tbxStudentN.Location = new System.Drawing.Point(396, 80);
            this.tbxStudentN.Name = "tbxStudentN";
            this.tbxStudentN.Size = new System.Drawing.Size(194, 23);
            this.tbxStudentN.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxStudentN);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbxStudentList);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.TextBox tbxStudentN;
    }
}

