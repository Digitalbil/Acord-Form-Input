namespace AcordFormInputs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountOfInputs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFormCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count Of Inputs:";
            // 
            // labelCountOfInputs
            // 
            this.labelCountOfInputs.AutoSize = true;
            this.labelCountOfInputs.Location = new System.Drawing.Point(333, 58);
            this.labelCountOfInputs.Name = "labelCountOfInputs";
            this.labelCountOfInputs.Size = new System.Drawing.Size(13, 15);
            this.labelCountOfInputs.TabIndex = 2;
            this.labelCountOfInputs.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form Name:";
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Location = new System.Drawing.Point(333, 93);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(13, 15);
            this.labelFormName.TabIndex = 4;
            this.labelFormName.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Count Of Forms:";
            // 
            // labelFormCount
            // 
            this.labelFormCount.AutoSize = true;
            this.labelFormCount.Location = new System.Drawing.Point(333, 32);
            this.labelFormCount.Name = "labelFormCount";
            this.labelFormCount.Size = new System.Drawing.Size(13, 15);
            this.labelFormCount.TabIndex = 6;
            this.labelFormCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFormCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCountOfInputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label labelCountOfInputs;
        private Label label2;
        private Label labelFormName;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label3;
        private Label labelFormCount;
    }
}