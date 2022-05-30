namespace OGKGlab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FindNN = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.nupdCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 615);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // FindNN
            // 
            this.FindNN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindNN.Location = new System.Drawing.Point(824, 352);
            this.FindNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FindNN.Name = "FindNN";
            this.FindNN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindNN.Size = new System.Drawing.Size(267, 74);
            this.FindNN.TabIndex = 1;
            this.FindNN.Text = "Find NN";
            this.FindNN.UseVisualStyleBackColor = true;
            this.FindNN.Click += new System.EventHandler(this.FindNN_Click);
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Generate.Location = new System.Drawing.Point(824, 435);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(267, 74);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(824, 560);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(267, 74);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // nupdCount
            // 
            this.nupdCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nupdCount.Location = new System.Drawing.Point(825, 520);
            this.nupdCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupdCount.Name = "nupdCount";
            this.nupdCount.Size = new System.Drawing.Size(265, 27);
            this.nupdCount.TabIndex = 4;
            this.nupdCount.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 651);
            this.Controls.Add(this.nupdCount);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.FindNN);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Formakidov Dina";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FindNN;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown nupdCount;
    }
}
