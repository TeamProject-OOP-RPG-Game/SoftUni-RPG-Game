namespace Tekken101
{
    using Tekken101.Engine;
    partial class TheGame
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
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(81, 440);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(151, 49);
            this.Left.TabIndex = 0;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(402, 440);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(153, 48);
            this.Right.TabIndex = 1;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Name = "TheGame";
            this.Text = "RPG Game";
            this.Load += new System.EventHandler(this.TheGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
    }
}

