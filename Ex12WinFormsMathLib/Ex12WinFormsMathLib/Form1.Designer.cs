namespace Ex12WinFormsMathLib
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
      protected override void Dispose( bool disposing )
      {
         if( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtBox1 = new System.Windows.Forms.TextBox();
         this.button7 = new System.Windows.Forms.Button();
         this.txtBox2 = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.button6 = new System.Windows.Forms.Button();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.txtBox1);
         this.groupBox1.Controls.Add(this.button7);
         this.groupBox1.Controls.Add(this.txtBox2);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(160, 149);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Values";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 66);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(38, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "Num2:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "Num1:";
         // 
         // txtBox1
         // 
         this.txtBox1.Location = new System.Drawing.Point(51, 24);
         this.txtBox1.Name = "txtBox1";
         this.txtBox1.Size = new System.Drawing.Size(100, 20);
         this.txtBox1.TabIndex = 8;
         // 
         // button7
         // 
         this.button7.Location = new System.Drawing.Point(76, 111);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(75, 23);
         this.button7.TabIndex = 9;
         this.button7.Text = "Clear";
         this.button7.UseVisualStyleBackColor = true;
         // 
         // txtBox2
         // 
         this.txtBox2.Location = new System.Drawing.Point(51, 66);
         this.txtBox2.Name = "txtBox2";
         this.txtBox2.Size = new System.Drawing.Size(100, 20);
         this.txtBox2.TabIndex = 3;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.button3);
         this.groupBox2.Controls.Add(this.button4);
         this.groupBox2.Controls.Add(this.button5);
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Location = new System.Drawing.Point(178, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(88, 149);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Operation";
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(6, 111);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 5;
         this.button3.Text = "/";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(6, 82);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(75, 23);
         this.button4.TabIndex = 6;
         this.button4.Text = "*";
         this.button4.UseVisualStyleBackColor = true;
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(6, 53);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(75, 23);
         this.button5.TabIndex = 7;
         this.button5.Text = "-";
         this.button5.UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(6, 24);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "+";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.btnPlus_Click);
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.button6);
         this.groupBox3.Controls.Add(this.listBox1);
         this.groupBox3.Location = new System.Drawing.Point(272, 12);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(200, 149);
         this.groupBox3.TabIndex = 1;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Listbox";
         // 
         // button6
         // 
         this.button6.Location = new System.Drawing.Point(119, 108);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(75, 23);
         this.button6.TabIndex = 8;
         this.button6.Text = "Clear";
         this.button6.UseVisualStyleBackColor = true;
         // 
         // listBox1
         // 
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(7, 20);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(187, 82);
         this.listBox1.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(489, 171);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "MathLib";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtBox1;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.TextBox txtBox2;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}

