
namespace Cash_Register_System_CVS
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
            this.butt_paper = new System.Windows.Forms.Button();
            this.butt_sizes = new System.Windows.Forms.Button();
            this.butt_output = new System.Windows.Forms.Button();
            this.butt_generate = new System.Windows.Forms.Button();
            this.txtbox_paperfile = new System.Windows.Forms.TextBox();
            this.txtbox_sizefile = new System.Windows.Forms.TextBox();
            this.txtbox_outputfile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // butt_paper
            // 
            this.butt_paper.Location = new System.Drawing.Point(12, 12);
            this.butt_paper.Name = "butt_paper";
            this.butt_paper.Size = new System.Drawing.Size(75, 23);
            this.butt_paper.TabIndex = 0;
            this.butt_paper.Text = "Paper";
            this.butt_paper.UseVisualStyleBackColor = true;
            this.butt_paper.Click += new System.EventHandler(this.butt_paper_Click);
            // 
            // butt_sizes
            // 
            this.butt_sizes.Location = new System.Drawing.Point(12, 41);
            this.butt_sizes.Name = "butt_sizes";
            this.butt_sizes.Size = new System.Drawing.Size(75, 23);
            this.butt_sizes.TabIndex = 0;
            this.butt_sizes.Text = "Sizes";
            this.butt_sizes.UseVisualStyleBackColor = true;
            this.butt_sizes.Click += new System.EventHandler(this.butt_sizes_Click);
            // 
            // butt_output
            // 
            this.butt_output.Location = new System.Drawing.Point(12, 70);
            this.butt_output.Name = "butt_output";
            this.butt_output.Size = new System.Drawing.Size(75, 23);
            this.butt_output.TabIndex = 0;
            this.butt_output.Text = "Output";
            this.butt_output.UseVisualStyleBackColor = true;
            this.butt_output.Click += new System.EventHandler(this.butt_output_Click);
            // 
            // butt_generate
            // 
            this.butt_generate.Location = new System.Drawing.Point(713, 70);
            this.butt_generate.Name = "butt_generate";
            this.butt_generate.Size = new System.Drawing.Size(75, 23);
            this.butt_generate.TabIndex = 0;
            this.butt_generate.Text = "Generate";
            this.butt_generate.UseVisualStyleBackColor = true;
            this.butt_generate.Click += new System.EventHandler(this.butt_generate_Click);
            // 
            // txtbox_paperfile
            // 
            this.txtbox_paperfile.Location = new System.Drawing.Point(93, 12);
            this.txtbox_paperfile.Name = "txtbox_paperfile";
            this.txtbox_paperfile.Size = new System.Drawing.Size(613, 23);
            this.txtbox_paperfile.TabIndex = 1;
            this.txtbox_paperfile.Text = "none";
            // 
            // txtbox_sizefile
            // 
            this.txtbox_sizefile.Location = new System.Drawing.Point(93, 41);
            this.txtbox_sizefile.Name = "txtbox_sizefile";
            this.txtbox_sizefile.Size = new System.Drawing.Size(613, 23);
            this.txtbox_sizefile.TabIndex = 1;
            this.txtbox_sizefile.Text = "none";
            // 
            // txtbox_outputfile
            // 
            this.txtbox_outputfile.Location = new System.Drawing.Point(93, 70);
            this.txtbox_outputfile.Name = "txtbox_outputfile";
            this.txtbox_outputfile.Size = new System.Drawing.Size(613, 23);
            this.txtbox_outputfile.TabIndex = 1;
            this.txtbox_outputfile.Text = "none";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 101);
            this.Controls.Add(this.txtbox_outputfile);
            this.Controls.Add(this.txtbox_sizefile);
            this.Controls.Add(this.txtbox_paperfile);
            this.Controls.Add(this.butt_generate);
            this.Controls.Add(this.butt_output);
            this.Controls.Add(this.butt_sizes);
            this.Controls.Add(this.butt_paper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_paper;
        private System.Windows.Forms.Button butt_sizes;
        private System.Windows.Forms.Button butt_output;
        private System.Windows.Forms.Button butt_generate;
        private System.Windows.Forms.TextBox txtbox_paperfile;
        private System.Windows.Forms.TextBox txtbox_sizefile;
        private System.Windows.Forms.TextBox txtbox_outputfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

