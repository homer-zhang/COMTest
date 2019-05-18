namespace COMTest
{
    partial class ComTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_ComList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Rate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DateBit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Open = new System.Windows.Forms.Button();
            this.textBox_DateSend = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DataRecv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_ComList
            // 
            this.comboBox_ComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ComList.FormattingEnabled = true;
            this.comboBox_ComList.Location = new System.Drawing.Point(65, 21);
            this.comboBox_ComList.Name = "comboBox_ComList";
            this.comboBox_ComList.Size = new System.Drawing.Size(100, 20);
            this.comboBox_ComList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口：";
            // 
            // comboBox_Rate
            // 
            this.comboBox_Rate.FormattingEnabled = true;
            this.comboBox_Rate.Location = new System.Drawing.Point(247, 21);
            this.comboBox_Rate.Name = "comboBox_Rate";
            this.comboBox_Rate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Rate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "频率：";
            // 
            // textBox_DateBit
            // 
            this.textBox_DateBit.Location = new System.Drawing.Point(65, 48);
            this.textBox_DateBit.Name = "textBox_DateBit";
            this.textBox_DateBit.Size = new System.Drawing.Size(100, 21);
            this.textBox_DateBit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据位：";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(247, 48);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "打开";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // textBox_DateSend
            // 
            this.textBox_DateSend.Enabled = false;
            this.textBox_DateSend.Location = new System.Drawing.Point(8, 77);
            this.textBox_DateSend.Name = "textBox_DateSend";
            this.textBox_DateSend.Size = new System.Drawing.Size(258, 21);
            this.textBox_DateSend.TabIndex = 7;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(272, 75);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "接收到的数据：";
            // 
            // textBox_DataRecv
            // 
            this.textBox_DataRecv.AcceptsReturn = true;
            this.textBox_DataRecv.AcceptsTab = true;
            this.textBox_DataRecv.Enabled = false;
            this.textBox_DataRecv.Location = new System.Drawing.Point(8, 119);
            this.textBox_DataRecv.Multiline = true;
            this.textBox_DataRecv.Name = "textBox_DataRecv";
            this.textBox_DataRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_DataRecv.Size = new System.Drawing.Size(360, 252);
            this.textBox_DataRecv.TabIndex = 10;
            // 
            // ComTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 373);
            this.Controls.Add(this.textBox_DataRecv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_DateSend);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DateBit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Rate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ComList);
            this.Name = "ComTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM测试工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComTest_FormClosed);
            this.Load += new System.EventHandler(this.ComTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ComList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DateBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.TextBox textBox_DateSend;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DataRecv;
    }
}

