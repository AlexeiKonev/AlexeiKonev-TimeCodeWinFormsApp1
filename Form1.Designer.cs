namespace TimeCodeWinFormsApp1
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
            btnBrowseInput = new Button();
            btnBrowseOutput = new Button();
            btnGo = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.Location = new Point(438, 155);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(140, 23);
            btnBrowseInput.TabIndex = 0;
            btnBrowseInput.Text = "btnBrowseInput";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Location = new Point(438, 219);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(140, 23);
            btnBrowseOutput.TabIndex = 1;
            btnBrowseOutput.Text = "btnBrowseOutput";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(438, 285);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 2;
            btnGo.Text = "btnGo";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(293, 155);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(293, 219);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(100, 23);
            txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnGo);
            Controls.Add(btnBrowseOutput);
            Controls.Add(btnBrowseInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseInput;
        private Button btnBrowseOutput;
        private Button btnGo;
        private TextBox txtInput;
        private TextBox txtOutput;
    }
}
