namespace _16_ListBoxSelectionMode2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button1;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toRight = new System.Windows.Forms.Button();
            this.toLeft = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("標楷體", 24F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(119, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 324);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Location = new System.Drawing.Point(761, 102);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(350, 324);
            this.listBox2.TabIndex = 1;
            // 
            // toRight
            // 
            this.toRight.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toRight.Location = new System.Drawing.Point(545, 135);
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(119, 94);
            this.toRight.TabIndex = 2;
            this.toRight.Text = "->";
            this.toRight.UseVisualStyleBackColor = true;
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // toLeft
            // 
            this.toLeft.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toLeft.Location = new System.Drawing.Point(545, 294);
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(119, 94);
            this.toLeft.TabIndex = 3;
            this.toLeft.Text = "<-";
            this.toLeft.UseVisualStyleBackColor = true;
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            button1.Location = new System.Drawing.Point(475, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(280, 90);
            button1.TabIndex = 6;
            button1.Text = "農夫過河";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 481);
            this.Controls.Add(button1);
            this.Controls.Add(this.toLeft);
            this.Controls.Add(this.toRight);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button toRight;
        private System.Windows.Forms.Button toLeft;
    }
}

