
namespace test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(65, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(243, 129);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(191, 22);
            this.Number2.TabIndex = 2;
            this.Number2.TextChanged += new System.EventHandler(this.Number2_TextChanged);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(243, 62);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(191, 22);
            this.Number1.TabIndex = 3;
            this.Number1.TextChanged += new System.EventHandler(this.Number1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(65, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(244, 298);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(190, 22);
            this.Result.TabIndex = 9;
            this.Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.Location = new System.Drawing.Point(85, 217);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(219, 217);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(346, 217);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "*";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(474, 217);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "/";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 378);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Máy tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

