
namespace tidenotes
{
    partial class tidenotes
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
            this.addnote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnote
            // 
            this.addnote.Font = new System.Drawing.Font("Verdana", 12F);
            this.addnote.Location = new System.Drawing.Point(218, 108);
            this.addnote.Name = "addnote";
            this.addnote.Size = new System.Drawing.Size(171, 54);
            this.addnote.TabIndex = 0;
            this.addnote.Text = "Добавить заметку";
            this.addnote.UseVisualStyleBackColor = true;
            this.addnote.Click += new System.EventHandler(this.addnote_Click);
            // 
            // tidenotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tidenotes.Properties.Resources.CP_xZJR7gRU;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.addnote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "tidenotes";
            this.Text = "TideNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addnote;
    }
}

