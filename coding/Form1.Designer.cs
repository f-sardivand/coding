namespace coding
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
            this.btn_Source = new System.Windows.Forms.Button();
            this.btn_Destination = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_Source
            // 
            this.btn_Source.Location = new System.Drawing.Point(52, 74);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(120, 50);
            this.btn_Source.TabIndex = 0;
            this.btn_Source.Text = "source";
            this.btn_Source.UseVisualStyleBackColor = true;
            // 
            // btn_Destination
            // 
            this.btn_Destination.Location = new System.Drawing.Point(52, 156);
            this.btn_Destination.Name = "btn_Destination";
            this.btn_Destination.Size = new System.Drawing.Size(120, 47);
            this.btn_Destination.TabIndex = 1;
            this.btn_Destination.Text = "destination";
            this.btn_Destination.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(52, 254);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 47);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(199, 74);
            this.txt_Source.Multiline = true;
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(561, 50);
            this.txt_Source.TabIndex = 3;
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(199, 156);
            this.txt_Destination.Multiline = true;
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(561, 50);
            this.txt_Destination.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Destination);
            this.Controls.Add(this.btn_Source);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.Button btn_Destination;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

