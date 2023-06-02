
namespace SplitExcercise
{
    partial class SplitExcerciseForm
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
            gen = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // gen
            // 
            gen.Location = new System.Drawing.Point(606, 32);
            gen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gen.Name = "gen";
            gen.Size = new System.Drawing.Size(82, 22);
            gen.TabIndex = 0;
            gen.Text = "gen";
            gen.UseVisualStyleBackColor = true;
            gen.Click += gen_Click;
            // 
            // SplitExcerciseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 338);
            Controls.Add(gen);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "SplitExcerciseForm";
            Text = "Form1";
            Load += SplitExcerciseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button gen;
    }
}

