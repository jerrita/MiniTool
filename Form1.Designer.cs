
namespace MiniTool
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
            this.labelVtShow = new System.Windows.Forms.Label();
            this.btnVtSwitcher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVtShow
            // 
            this.labelVtShow.AutoSize = true;
            this.labelVtShow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelVtShow.Location = new System.Drawing.Point(184, 34);
            this.labelVtShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVtShow.Name = "labelVtShow";
            this.labelVtShow.Size = new System.Drawing.Size(39, 20);
            this.labelVtShow.TabIndex = 0;
            this.labelVtShow.Text = "未知";
            // 
            // btnVtSwitcher
            // 
            this.btnVtSwitcher.Location = new System.Drawing.Point(259, 30);
            this.btnVtSwitcher.Margin = new System.Windows.Forms.Padding(2);
            this.btnVtSwitcher.Name = "btnVtSwitcher";
            this.btnVtSwitcher.Size = new System.Drawing.Size(92, 28);
            this.btnVtSwitcher.TabIndex = 1;
            this.btnVtSwitcher.Text = "切换";
            this.btnVtSwitcher.UseVisualStyleBackColor = true;
            this.btnVtSwitcher.Click += new System.EventHandler(this.BtnVtSwitcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hyperv启动状态：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVtSwitcher);
            this.Controls.Add(this.labelVtShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MiniTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVtShow;
        private System.Windows.Forms.Button btnVtSwitcher;
        private System.Windows.Forms.Label label1;
    }
}

