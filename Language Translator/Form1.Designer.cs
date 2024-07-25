namespace Language_Translator
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnItalian = new System.Windows.Forms.Button();
            this.btnMaori = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(42, 22);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(338, 20);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(18, 63);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(389, 34);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItalian
            // 
            this.btnItalian.Location = new System.Drawing.Point(24, 120);
            this.btnItalian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItalian.Name = "btnItalian";
            this.btnItalian.Size = new System.Drawing.Size(112, 35);
            this.btnItalian.TabIndex = 2;
            this.btnItalian.Text = "Italian";
            this.btnItalian.UseVisualStyleBackColor = true;
            this.btnItalian.Click += new System.EventHandler(this.btnItalian_Click);
            // 
            // btnMaori
            // 
            this.btnMaori.Location = new System.Drawing.Point(158, 120);
            this.btnMaori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaori.Name = "btnMaori";
            this.btnMaori.Size = new System.Drawing.Size(112, 35);
            this.btnMaori.TabIndex = 3;
            this.btnMaori.Text = "Maori";
            this.btnMaori.UseVisualStyleBackColor = true;
            this.btnMaori.Click += new System.EventHandler(this.btnMaori_Click);
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(291, 120);
            this.btnGerman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(112, 35);
            this.btnGerman.TabIndex = 4;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 180);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnMaori);
            this.Controls.Add(this.btnItalian);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.instructionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Good Morning in 3 Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnMaori;
        private System.Windows.Forms.Button btnGerman;
    }
}

