namespace test_one
{
    partial class Form1
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
            this.textBoxOP1 = new System.Windows.Forms.TextBox();
            this.textBoxOP2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOP1
            // 
            this.textBoxOP1.Location = new System.Drawing.Point(85, 144);
            this.textBoxOP1.Name = "textBoxOP1";
            this.textBoxOP1.Size = new System.Drawing.Size(280, 33);
            this.textBoxOP1.TabIndex = 0;
            this.textBoxOP1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOP2
            // 
            this.textBoxOP2.Location = new System.Drawing.Point(85, 239);
            this.textBoxOP2.Name = "textBoxOP2";
            this.textBoxOP2.Size = new System.Drawing.Size(283, 33);
            this.textBoxOP2.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(79, 46);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(81, 33);
            this.labelResult.TabIndex = 2;
            this.labelResult.Tag = "";
            this.labelResult.Text = "结果";
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonadd.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonadd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonadd.Location = new System.Drawing.Point(460, 102);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(109, 108);
            this.buttonadd.TabIndex = 3;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonsub.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonsub.ForeColor = System.Drawing.Color.Yellow;
            this.buttonsub.Location = new System.Drawing.Point(603, 102);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(111, 108);
            this.buttonsub.TabIndex = 4;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = false;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonmul.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonmul.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonmul.Location = new System.Drawing.Point(460, 239);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(109, 108);
            this.buttonmul.TabIndex = 5;
            this.buttonmul.Text = "×";
            this.buttonmul.UseVisualStyleBackColor = false;
            this.buttonmul.Click += new System.EventHandler(this.buttonmul_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttondiv.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttondiv.ForeColor = System.Drawing.Color.Yellow;
            this.buttondiv.Location = new System.Drawing.Point(603, 239);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(111, 108);
            this.buttondiv.TabIndex = 6;
            this.buttondiv.Text = "÷";
            this.buttondiv.UseVisualStyleBackColor = false;
            this.buttondiv.Click += new System.EventHandler(this.buttondiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondiv);
            this.Controls.Add(this.buttonmul);
            this.Controls.Add(this.buttonsub);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxOP2);
            this.Controls.Add(this.textBoxOP1);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOP1;
        private System.Windows.Forms.TextBox textBoxOP2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttonmul;
        private System.Windows.Forms.Button buttondiv;
    }
}

