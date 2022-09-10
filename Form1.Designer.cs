
namespace WinFormsApp_Test_1
{
    partial class Super_Futur_Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Super_Futur_Machine));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonhello = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(319, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonhello
            // 
            this.buttonhello.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonhello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonhello.Location = new System.Drawing.Point(285, 153);
            this.buttonhello.Name = "buttonhello";
            this.buttonhello.Size = new System.Drawing.Size(194, 67);
            this.buttonhello.TabIndex = 2;
            this.buttonhello.Text = "Do You Want To Click This Button ?";
            this.buttonhello.UseVisualStyleBackColor = false;
            this.buttonhello.Click += new System.EventHandler(this.buttonhello_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(307, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Or This One ?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Super_Futur_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(781, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonhello);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Super_Futur_Machine";
            this.Text = "Super Futur Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonhello;
        private System.Windows.Forms.Button button1;
    }
}

