namespace AlphaMerger
{
    partial class Main
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
            panel1 = new Panel();
            PicBoxResult = new PictureBox();
            MergeBtn = new Button();
            PicboxAlpha = new PictureBox();
            AlphaBtn = new Button();
            PicboxTexture = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicboxAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicboxTexture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(PicBoxResult);
            panel1.Controls.Add(MergeBtn);
            panel1.Controls.Add(PicboxAlpha);
            panel1.Controls.Add(AlphaBtn);
            panel1.Controls.Add(PicboxTexture);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 368);
            panel1.TabIndex = 0;
            // 
            // PicBoxResult
            // 
            PicBoxResult.Location = new Point(187, 25);
            PicBoxResult.Name = "PicBoxResult";
            PicBoxResult.Size = new Size(134, 142);
            PicBoxResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxResult.TabIndex = 5;
            PicBoxResult.TabStop = false;
            // 
            // MergeBtn
            // 
            MergeBtn.Location = new Point(216, 173);
            MergeBtn.Name = "MergeBtn";
            MergeBtn.Size = new Size(75, 23);
            MergeBtn.TabIndex = 4;
            MergeBtn.Text = "Merge";
            MergeBtn.UseVisualStyleBackColor = true;
            MergeBtn.Click += MergeBtn_Click;
            // 
            // PicboxAlpha
            // 
            PicboxAlpha.Location = new Point(356, 25);
            PicboxAlpha.Name = "PicboxAlpha";
            PicboxAlpha.Size = new Size(134, 142);
            PicboxAlpha.SizeMode = PictureBoxSizeMode.StretchImage;
            PicboxAlpha.TabIndex = 3;
            PicboxAlpha.TabStop = false;
            // 
            // AlphaBtn
            // 
            AlphaBtn.Location = new Point(386, 173);
            AlphaBtn.Name = "AlphaBtn";
            AlphaBtn.Size = new Size(75, 23);
            AlphaBtn.TabIndex = 2;
            AlphaBtn.Text = "Alpha";
            AlphaBtn.UseVisualStyleBackColor = true;
            AlphaBtn.Click += AlphaBtn_Click;
            // 
            // PicboxTexture
            // 
            PicboxTexture.Location = new Point(12, 25);
            PicboxTexture.Name = "PicboxTexture";
            PicboxTexture.Size = new Size(134, 142);
            PicboxTexture.SizeMode = PictureBoxSizeMode.StretchImage;
            PicboxTexture.TabIndex = 1;
            PicboxTexture.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(42, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Texture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 368);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlphaMerger";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBoxResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicboxAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicboxTexture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button MergeBtn;
        private PictureBox PicboxAlpha;
        private Button AlphaBtn;
        private PictureBox PicboxTexture;
        private PictureBox PicBoxResult;
    }
}
