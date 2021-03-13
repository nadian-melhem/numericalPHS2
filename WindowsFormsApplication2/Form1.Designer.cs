namespace WindowsFormsApplication2
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
            this.xZero = new System.Windows.Forms.TextBox();
            this.yZero = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.xFinal = new System.Windows.Forms.TextBox();
            this.yFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xZero
            // 
            this.xZero.Location = new System.Drawing.Point(238, 28);
            this.xZero.Name = "xZero";
            this.xZero.Size = new System.Drawing.Size(90, 20);
            this.xZero.TabIndex = 0;
            // 
            // yZero
            // 
            this.yZero.Location = new System.Drawing.Point(238, 73);
            this.yZero.Name = "yZero";
            this.yZero.Size = new System.Drawing.Size(90, 20);
            this.yZero.TabIndex = 1;
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.DarkGreen;
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.ForeColor = System.Drawing.SystemColors.ControlText;
            this.run.Location = new System.Drawing.Point(238, 119);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(90, 23);
            this.run.TabIndex = 2;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // xFinal
            // 
            this.xFinal.Location = new System.Drawing.Point(238, 162);
            this.xFinal.Name = "xFinal";
            this.xFinal.Size = new System.Drawing.Size(90, 20);
            this.xFinal.TabIndex = 3;
            // 
            // yFinal
            // 
            this.yFinal.Location = new System.Drawing.Point(238, 204);
            this.yFinal.Name = "yFinal";
            this.yFinal.Size = new System.Drawing.Size(90, 20);
            this.yFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please  Enter the value of xZero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please  Enter the value of yZero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Value of xFinal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Value of yFinal ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 242);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yFinal);
            this.Controls.Add(this.xFinal);
            this.Controls.Add(this.run);
            this.Controls.Add(this.yZero);
            this.Controls.Add(this.xZero);
            this.Name = "Form1";
            this.Text = "Q2 Solution";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xZero;
        private System.Windows.Forms.TextBox yZero;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox xFinal;
        private System.Windows.Forms.TextBox yFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

