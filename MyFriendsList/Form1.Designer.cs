
namespace MyFriendsList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.btn_addFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addFive = new System.Windows.Forms.Button();
            this.btn_SortAsc = new System.Windows.Forms.Button();
            this.btn_SortDesc = new System.Windows.Forms.Button();
            this.btn_clearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 404);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Location = new System.Drawing.Point(400, 12);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(340, 22);
            this.txt_newFriend.TabIndex = 1;
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Location = new System.Drawing.Point(400, 58);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Size = new System.Drawing.Size(93, 41);
            this.btn_addFriend.TabIndex = 2;
            this.btn_addFriend.Text = "Add Friend";
            this.btn_addFriend.UseVisualStyleBackColor = true;
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_addFive
            // 
            this.btn_addFive.Location = new System.Drawing.Point(405, 115);
            this.btn_addFive.Name = "btn_addFive";
            this.btn_addFive.Size = new System.Drawing.Size(87, 55);
            this.btn_addFive.TabIndex = 4;
            this.btn_addFive.Text = "Add 5 friends";
            this.btn_addFive.UseVisualStyleBackColor = true;
            this.btn_addFive.Click += new System.EventHandler(this.btn_addFive_Click);
            // 
            // btn_SortAsc
            // 
            this.btn_SortAsc.Location = new System.Drawing.Point(405, 363);
            this.btn_SortAsc.Name = "btn_SortAsc";
            this.btn_SortAsc.Size = new System.Drawing.Size(87, 53);
            this.btn_SortAsc.TabIndex = 5;
            this.btn_SortAsc.Text = "A => Z";
            this.btn_SortAsc.UseVisualStyleBackColor = true;
            this.btn_SortAsc.Click += new System.EventHandler(this.btn_SortAsc_Click);
            // 
            // btn_SortDesc
            // 
            this.btn_SortDesc.Location = new System.Drawing.Point(532, 363);
            this.btn_SortDesc.Name = "btn_SortDesc";
            this.btn_SortDesc.Size = new System.Drawing.Size(100, 53);
            this.btn_SortDesc.TabIndex = 6;
            this.btn_SortDesc.Text = "Z => A";
            this.btn_SortDesc.UseVisualStyleBackColor = true;
            this.btn_SortDesc.Click += new System.EventHandler(this.btn_SortDesc_Click);
            // 
            // btn_clearList
            // 
            this.btn_clearList.Location = new System.Drawing.Point(665, 363);
            this.btn_clearList.Name = "btn_clearList";
            this.btn_clearList.Size = new System.Drawing.Size(168, 53);
            this.btn_clearList.TabIndex = 7;
            this.btn_clearList.Text = "Clear";
            this.btn_clearList.UseVisualStyleBackColor = true;
            this.btn_clearList.Click += new System.EventHandler(this.btn_clearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 530);
            this.Controls.Add(this.btn_clearList);
            this.Controls.Add(this.btn_SortDesc);
            this.Controls.Add(this.btn_SortAsc);
            this.Controls.Add(this.btn_addFive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Friends";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Button btn_addFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addFive;
        private System.Windows.Forms.Button btn_SortAsc;
        private System.Windows.Forms.Button btn_SortDesc;
        private System.Windows.Forms.Button btn_clearList;
    }
}

