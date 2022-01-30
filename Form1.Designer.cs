namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output_TB = new System.Windows.Forms.TextBox();
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output:";
            // 
            // Output_TB
            // 
            this.Output_TB.Location = new System.Drawing.Point(265, 162);
            this.Output_TB.Name = "Output_TB";
            this.Output_TB.Size = new System.Drawing.Size(284, 20);
            this.Output_TB.TabIndex = 2;
            // 
            // Input_TB
            // 
            this.Input_TB.Location = new System.Drawing.Point(265, 121);
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.Size = new System.Drawing.Size(284, 20);
            this.Input_TB.TabIndex = 3;
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Location = new System.Drawing.Point(368, 223);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Submit_BTN.TabIndex = 4;
            this.Submit_BTN.Text = " Submit";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.Input_TB);
            this.Controls.Add(this.Output_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output_TB;
        private System.Windows.Forms.TextBox Input_TB;
        private System.Windows.Forms.Button Submit_BTN;
    }
}

