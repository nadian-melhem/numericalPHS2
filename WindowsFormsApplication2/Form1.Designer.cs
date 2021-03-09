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
            this.numOfIterations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xZero
            // 
            this.xZero.Location = new System.Drawing.Point(94, 26);
            this.xZero.Name = "xZero";
            this.xZero.Size = new System.Drawing.Size(90, 20);
            this.xZero.TabIndex = 0;
            // 
            // yZero
            // 
            this.yZero.Location = new System.Drawing.Point(94, 74);
            this.yZero.Name = "yZero";
            this.yZero.Size = new System.Drawing.Size(90, 20);
            this.yZero.TabIndex = 1;
           // this.yZero.TextChanged += new System.EventHandler(this.yZero_TextChanged);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(94, 164);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(90, 23);
            this.run.TabIndex = 2;
            this.run.Text = "button1";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // xFinal
            // 
            this.xFinal.Location = new System.Drawing.Point(171, 229);
            this.xFinal.Name = "xFinal";
            this.xFinal.Size = new System.Drawing.Size(90, 20);
            this.xFinal.TabIndex = 3;
            // 
            // yFinal
            // 
            this.yFinal.Location = new System.Drawing.Point(12, 229);
            this.yFinal.Name = "yFinal";
            this.yFinal.Size = new System.Drawing.Size(90, 20);
            this.yFinal.TabIndex = 4;
            // 
            // numOfIterations
            // 
            this.numOfIterations.Location = new System.Drawing.Point(94, 122);
            this.numOfIterations.Name = "numOfIterations";
            this.numOfIterations.Size = new System.Drawing.Size(90, 20);
            this.numOfIterations.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numOfIterations);
            this.Controls.Add(this.yFinal);
            this.Controls.Add(this.xFinal);
            this.Controls.Add(this.run);
            this.Controls.Add(this.yZero);
            this.Controls.Add(this.xZero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xZero;
        private System.Windows.Forms.TextBox yZero;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox xFinal;
        private System.Windows.Forms.TextBox yFinal;
        private System.Windows.Forms.TextBox numOfIterations;
    }
}

