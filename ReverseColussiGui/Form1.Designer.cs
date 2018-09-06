namespace ReverseColussiGui
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
            this.tbox_Pattern = new System.Windows.Forms.TextBox();
            this.rtbox_Source = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_findAll = new System.Windows.Forms.Button();
            this.lview_Index = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbox_Pattern
            // 
            this.tbox_Pattern.Location = new System.Drawing.Point(12, 40);
            this.tbox_Pattern.Name = "tbox_Pattern";
            this.tbox_Pattern.Size = new System.Drawing.Size(588, 20);
            this.tbox_Pattern.TabIndex = 0;
            // 
            // rtbox_Source
            // 
            this.rtbox_Source.Location = new System.Drawing.Point(12, 102);
            this.rtbox_Source.Name = "rtbox_Source";
            this.rtbox_Source.Size = new System.Drawing.Size(588, 151);
            this.rtbox_Source.TabIndex = 1;
            this.rtbox_Source.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source";
            // 
            // btn_findAll
            // 
            this.btn_findAll.Location = new System.Drawing.Point(12, 259);
            this.btn_findAll.Name = "btn_findAll";
            this.btn_findAll.Size = new System.Drawing.Size(588, 23);
            this.btn_findAll.TabIndex = 4;
            this.btn_findAll.Text = "findAll";
            this.btn_findAll.UseVisualStyleBackColor = true;
            this.btn_findAll.Click += new System.EventHandler(this.btn_findAll_Click);
            // 
            // lview_Index
            // 
            this.lview_Index.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lview_Index.Location = new System.Drawing.Point(630, 102);
            this.lview_Index.Name = "lview_Index";
            this.lview_Index.Size = new System.Drawing.Size(190, 151);
            this.lview_Index.TabIndex = 5;
            this.lview_Index.UseCompatibleStateImageBehavior = false;
            this.lview_Index.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bulunan Index";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lview_Index);
            this.Controls.Add(this.btn_findAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbox_Source);
            this.Controls.Add(this.tbox_Pattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Pattern;
        private System.Windows.Forms.RichTextBox rtbox_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_findAll;
        private System.Windows.Forms.ListView lview_Index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

