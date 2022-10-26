
namespace _8_queens_puzzle
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
            this.btn_Cal = new System.Windows.Forms.Button();
            this.lst_ans = new System.Windows.Forms.ListBox();
            this.lbl_ans = new System.Windows.Forms.Label();
            this.txt_intput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cal
            // 
            this.btn_Cal.Location = new System.Drawing.Point(12, 12);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(172, 56);
            this.btn_Cal.TabIndex = 0;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // lst_ans
            // 
            this.lst_ans.FormattingEnabled = true;
            this.lst_ans.HorizontalScrollbar = true;
            this.lst_ans.ItemHeight = 19;
            this.lst_ans.Location = new System.Drawing.Point(12, 113);
            this.lst_ans.Name = "lst_ans";
            this.lst_ans.Size = new System.Drawing.Size(172, 232);
            this.lst_ans.TabIndex = 1;
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.Location = new System.Drawing.Point(12, 82);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(61, 19);
            this.lbl_ans.TabIndex = 2;
            this.lbl_ans.Text = "Answer";
            // 
            // txt_intput
            // 
            this.txt_intput.Location = new System.Drawing.Point(190, 41);
            this.txt_intput.Name = "txt_intput";
            this.txt_intput.Size = new System.Drawing.Size(74, 27);
            this.txt_intput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 432);
            this.Controls.Add(this.txt_intput);
            this.Controls.Add(this.lbl_ans);
            this.Controls.Add(this.lst_ans);
            this.Controls.Add(this.btn_Cal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.ListBox lst_ans;
        private System.Windows.Forms.Label lbl_ans;
        private System.Windows.Forms.TextBox txt_intput;
    }
}

