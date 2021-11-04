
namespace CSharpHW
{
    partial class Select
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
            this.exitSelectBtn = new System.Windows.Forms.Button();
            this.backFromSelectBtn = new System.Windows.Forms.Button();
            this.toUpdateBtn = new System.Windows.Forms.Button();
            this.toInsertBtn = new System.Windows.Forms.Button();
            this.toDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNumTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemDetailsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // exitSelectBtn
            // 
            this.exitSelectBtn.Location = new System.Drawing.Point(672, 364);
            this.exitSelectBtn.Name = "exitSelectBtn";
            this.exitSelectBtn.Size = new System.Drawing.Size(91, 51);
            this.exitSelectBtn.TabIndex = 0;
            this.exitSelectBtn.Text = "Exit";
            this.exitSelectBtn.UseVisualStyleBackColor = true;
            this.exitSelectBtn.Click += new System.EventHandler(this.exitSelectBtn_Click);
            // 
            // backFromSelectBtn
            // 
            this.backFromSelectBtn.Location = new System.Drawing.Point(96, 78);
            this.backFromSelectBtn.Name = "backFromSelectBtn";
            this.backFromSelectBtn.Size = new System.Drawing.Size(104, 46);
            this.backFromSelectBtn.TabIndex = 1;
            this.backFromSelectBtn.Text = "Back to Main";
            this.backFromSelectBtn.UseVisualStyleBackColor = true;
            // 
            // toUpdateBtn
            // 
            this.toUpdateBtn.Location = new System.Drawing.Point(96, 138);
            this.toUpdateBtn.Name = "toUpdateBtn";
            this.toUpdateBtn.Size = new System.Drawing.Size(103, 50);
            this.toUpdateBtn.TabIndex = 2;
            this.toUpdateBtn.Text = "To Update";
            this.toUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // toInsertBtn
            // 
            this.toInsertBtn.Location = new System.Drawing.Point(97, 207);
            this.toInsertBtn.Name = "toInsertBtn";
            this.toInsertBtn.Size = new System.Drawing.Size(103, 50);
            this.toInsertBtn.TabIndex = 3;
            this.toInsertBtn.Text = "To Insert";
            this.toInsertBtn.UseVisualStyleBackColor = true;
            // 
            // toDeleteBtn
            // 
            this.toDeleteBtn.Location = new System.Drawing.Point(97, 278);
            this.toDeleteBtn.Name = "toDeleteBtn";
            this.toDeleteBtn.Size = new System.Drawing.Size(103, 50);
            this.toDeleteBtn.TabIndex = 4;
            this.toDeleteBtn.Text = "To Delete";
            this.toDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Number: ";
            // 
            // itemNumTxt
            // 
            this.itemNumTxt.Location = new System.Drawing.Point(361, 86);
            this.itemNumTxt.Name = "itemNumTxt";
            this.itemNumTxt.Size = new System.Drawing.Size(99, 20);
            this.itemNumTxt.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(502, 78);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(69, 27);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(365, 123);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(35, 13);
            this.itemNameLbl.TabIndex = 9;
            this.itemNameLbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Detailed Order Report";
            // 
            // itemDetailsDGV
            // 
            this.itemDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDetailsDGV.Location = new System.Drawing.Point(258, 175);
            this.itemDetailsDGV.Name = "itemDetailsDGV";
            this.itemDetailsDGV.Size = new System.Drawing.Size(368, 168);
            this.itemDetailsDGV.TabIndex = 11;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemDetailsDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.itemNumTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDeleteBtn);
            this.Controls.Add(this.toInsertBtn);
            this.Controls.Add(this.toUpdateBtn);
            this.Controls.Add(this.backFromSelectBtn);
            this.Controls.Add(this.exitSelectBtn);
            this.Name = "Select";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitSelectBtn;
        private System.Windows.Forms.Button backFromSelectBtn;
        private System.Windows.Forms.Button toUpdateBtn;
        private System.Windows.Forms.Button toInsertBtn;
        private System.Windows.Forms.Button toDeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNumTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView itemDetailsDGV;
    }
}