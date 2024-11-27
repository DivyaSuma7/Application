namespace Application
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A valid passwordmust meet these requirements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 - it must be 8 characters long";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "2- it must have at least one uppercase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "3- it must have at least one lower case letter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "4- it must have at least one numeric digit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ener a password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(365, 486);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 30);
            this.passwordTextBox.TabIndex = 6;
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.Location = new System.Drawing.Point(301, 573);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(164, 63);
            this.checkPasswordButton.TabIndex = 7;
            this.checkPasswordButton.Text = "Check Password";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(583, 573);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 43);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.Button clearButton;
    }
}

