namespace Assignment_5._4
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
            this.laShow = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btBinary = new System.Windows.Forms.Button();
            this.btDisBinary = new System.Windows.Forms.Button();
            this.btXML = new System.Windows.Forms.Button();
            this.btDesXML = new System.Windows.Forms.Button();
            this.btJSON = new System.Windows.Forms.Button();
            this.btDesJSON = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laShow
            // 
            this.laShow.AutoSize = true;
            this.laShow.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShow.Location = new System.Drawing.Point(289, 9);
            this.laShow.Name = "laShow";
            this.laShow.Size = new System.Drawing.Size(198, 42);
            this.laShow.TabIndex = 0;
            this.laShow.Text = "Serializable";
            this.laShow.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(397, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(397, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 28);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(397, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 28);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btBinary
            // 
            this.btBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBinary.Location = new System.Drawing.Point(157, 257);
            this.btBinary.Name = "btBinary";
            this.btBinary.Size = new System.Drawing.Size(137, 49);
            this.btBinary.TabIndex = 8;
            this.btBinary.Text = "Binary Serialize";
            this.btBinary.UseVisualStyleBackColor = true;
            this.btBinary.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDisBinary
            // 
            this.btDisBinary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisBinary.Location = new System.Drawing.Point(343, 257);
            this.btDisBinary.Name = "btDisBinary";
            this.btDisBinary.Size = new System.Drawing.Size(137, 49);
            this.btDisBinary.TabIndex = 9;
            this.btDisBinary.Text = "Binary Deserialize";
            this.btDisBinary.UseVisualStyleBackColor = true;
            this.btDisBinary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXML
            // 
            this.btXML.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXML.Location = new System.Drawing.Point(157, 322);
            this.btXML.Name = "btXML";
            this.btXML.Size = new System.Drawing.Size(137, 49);
            this.btXML.TabIndex = 10;
            this.btXML.Text = "XML Serialize";
            this.btXML.UseVisualStyleBackColor = true;
            this.btXML.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDesXML
            // 
            this.btDesXML.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesXML.Location = new System.Drawing.Point(343, 322);
            this.btDesXML.Name = "btDesXML";
            this.btDesXML.Size = new System.Drawing.Size(137, 49);
            this.btDesXML.TabIndex = 11;
            this.btDesXML.Text = "XML Deserialize";
            this.btDesXML.UseVisualStyleBackColor = true;
            this.btDesXML.Click += new System.EventHandler(this.btDesXML_Click);
            // 
            // btJSON
            // 
            this.btJSON.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJSON.Location = new System.Drawing.Point(157, 394);
            this.btJSON.Name = "btJSON";
            this.btJSON.Size = new System.Drawing.Size(137, 49);
            this.btJSON.TabIndex = 12;
            this.btJSON.Text = "JSON Serialize";
            this.btJSON.UseVisualStyleBackColor = true;
            this.btJSON.Click += new System.EventHandler(this.button5_Click);
            // 
            // btDesJSON
            // 
            this.btDesJSON.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesJSON.Location = new System.Drawing.Point(343, 394);
            this.btDesJSON.Name = "btDesJSON";
            this.btDesJSON.Size = new System.Drawing.Size(137, 49);
            this.btDesJSON.TabIndex = 13;
            this.btDesJSON.Text = "JSON Deserialize";
            this.btDesJSON.UseVisualStyleBackColor = true;
            this.btDesJSON.Click += new System.EventHandler(this.btDesJSON_Click);
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(582, 322);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(137, 49);
            this.btCreate.TabIndex = 14;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btDesJSON);
            this.Controls.Add(this.btJSON);
            this.Controls.Add(this.btDesXML);
            this.Controls.Add(this.btXML);
            this.Controls.Add(this.btDisBinary);
            this.Controls.Add(this.btBinary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laShow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBinary;
        private System.Windows.Forms.Button btDisBinary;
        private System.Windows.Forms.Button btXML;
        private System.Windows.Forms.Button btDesXML;
        private System.Windows.Forms.Button btJSON;
        private System.Windows.Forms.Button btDesJSON;
        private System.Windows.Forms.Button btCreate;
    }
}

