namespace AjandekListaApp
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
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.tBNev = new System.Windows.Forms.TextBox();
            this.tBUzlet = new System.Windows.Forms.TextBox();
            this.cBSajat = new System.Windows.Forms.CheckBox();
            this.lSzoveg1 = new System.Windows.Forms.Label();
            this.lSzoveg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.Location = new System.Drawing.Point(14, 12);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(237, 238);
            this.ajandekListBox.TabIndex = 0;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(288, 190);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(94, 23);
            this.bEnter.TabIndex = 1;
            this.bEnter.Text = "enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // tBNev
            // 
            this.tBNev.Location = new System.Drawing.Point(288, 14);
            this.tBNev.Name = "tBNev";
            this.tBNev.Size = new System.Drawing.Size(100, 20);
            this.tBNev.TabIndex = 2;
            // 
            // tBUzlet
            // 
            this.tBUzlet.Location = new System.Drawing.Point(316, 70);
            this.tBUzlet.Name = "tBUzlet";
            this.tBUzlet.Size = new System.Drawing.Size(100, 20);
            this.tBUzlet.TabIndex = 3;
            // 
            // cBSajat
            // 
            this.cBSajat.AutoSize = true;
            this.cBSajat.Location = new System.Drawing.Point(288, 142);
            this.cBSajat.Name = "cBSajat";
            this.cBSajat.Size = new System.Drawing.Size(94, 17);
            this.cBSajat.TabIndex = 4;
            this.cBSajat.Text = "saját kézétésű";
            this.cBSajat.UseVisualStyleBackColor = true;
            // 
            // lSzoveg1
            // 
            this.lSzoveg1.AutoSize = true;
            this.lSzoveg1.Location = new System.Drawing.Point(257, 17);
            this.lSzoveg1.Name = "lSzoveg1";
            this.lSzoveg1.Size = new System.Drawing.Size(25, 13);
            this.lSzoveg1.TabIndex = 5;
            this.lSzoveg1.Text = "név";
            // 
            // lSzoveg2
            // 
            this.lSzoveg2.AutoSize = true;
            this.lSzoveg2.Location = new System.Drawing.Point(254, 73);
            this.lSzoveg2.Name = "lSzoveg2";
            this.lSzoveg2.Size = new System.Drawing.Size(56, 13);
            this.lSzoveg2.TabIndex = 6;
            this.lSzoveg2.Text = "üzlet neve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSzoveg2);
            this.Controls.Add(this.lSzoveg1);
            this.Controls.Add(this.cBSajat);
            this.Controls.Add(this.tBUzlet);
            this.Controls.Add(this.tBNev);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.ajandekListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekListBox;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox tBNev;
        private System.Windows.Forms.TextBox tBUzlet;
        private System.Windows.Forms.CheckBox cBSajat;
        private System.Windows.Forms.Label lSzoveg1;
        private System.Windows.Forms.Label lSzoveg2;
    }
}

