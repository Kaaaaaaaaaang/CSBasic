﻿namespace Chapter6_FormPrac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form 디자이너에서 생성한 코드
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMessageBox1 = new System.Windows.Forms.Button();
            this.btnMessageBox2 = new System.Windows.Forms.Button();
            this.btnMessageBox3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox1
            // 
            this.btnMessageBox1.Location = new System.Drawing.Point(13, 13);
            this.btnMessageBox1.Name = "btnMessageBox1";
            this.btnMessageBox1.Size = new System.Drawing.Size(173, 38);
            this.btnMessageBox1.TabIndex = 0;
            this.btnMessageBox1.Text = "메세지 박스 보기";
            this.btnMessageBox1.UseVisualStyleBackColor = true;
            this.btnMessageBox1.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // btnMessageBox2
            // 
            this.btnMessageBox2.Location = new System.Drawing.Point(13, 57);
            this.btnMessageBox2.Name = "btnMessageBox2";
            this.btnMessageBox2.Size = new System.Drawing.Size(173, 38);
            this.btnMessageBox2.TabIndex = 1;
            this.btnMessageBox2.Text = "메세지 박스 보기";
            this.btnMessageBox2.UseVisualStyleBackColor = true;
            this.btnMessageBox2.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // btnMessageBox3
            // 
            this.btnMessageBox3.Location = new System.Drawing.Point(13, 101);
            this.btnMessageBox3.Name = "btnMessageBox3";
            this.btnMessageBox3.Size = new System.Drawing.Size(173, 38);
            this.btnMessageBox3.TabIndex = 2;
            this.btnMessageBox3.Text = "메세지 박스 보기";
            this.btnMessageBox3.UseVisualStyleBackColor = true;
            this.btnMessageBox3.Click += new System.EventHandler(this.btnMessageBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ClientSize = new System.Drawing.Size(349, 157);
            this.Controls.Add(this.btnMessageBox3);
            this.Controls.Add(this.btnMessageBox2);
            this.Controls.Add(this.btnMessageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox1;
        private System.Windows.Forms.Button btnMessageBox2;
        private System.Windows.Forms.Button btnMessageBox3;
    }
}