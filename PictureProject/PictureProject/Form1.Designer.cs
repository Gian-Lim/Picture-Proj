namespace PictureProject
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
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCmb = new System.Windows.Forms.ComboBox();
            this.itemTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPictureBox.Location = new System.Drawing.Point(85, 73);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(202, 211);
            this.ItemPictureBox.TabIndex = 0;
            this.ItemPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proof:";
            // 
            // itemCmb
            // 
            this.itemCmb.FormattingEnabled = true;
            this.itemCmb.Location = new System.Drawing.Point(24, 305);
            this.itemCmb.Name = "itemCmb";
            this.itemCmb.Size = new System.Drawing.Size(320, 21);
            this.itemCmb.TabIndex = 2;
            // 
            // itemTxt
            // 
            this.itemTxt.Location = new System.Drawing.Point(24, 341);
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(320, 20);
            this.itemTxt.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(242, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 32);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 434);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.itemTxt);
            this.Controls.Add(this.itemCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemPictureBox);
            this.Name = "Form1";
            this.Text = "Proof Form";
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemCmb;
        private System.Windows.Forms.TextBox itemTxt;
        private System.Windows.Forms.Button addBtn;
    }
}

