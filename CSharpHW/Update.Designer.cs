
namespace CSharpHW
{
    partial class Update
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNumTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newPriceTxt = new System.Windows.Forms.TextBox();
            this.dgvNewPrice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(442, 242);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(70, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(27, 27);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 38);
            this.back.TabIndex = 1;
            this.back.Text = "Back To Main";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(26, 81);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(79, 49);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "To Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(27, 144);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(79, 49);
            this.insertBtn.TabIndex = 3;
            this.insertBtn.Text = "To Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(26, 205);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(79, 49);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "To Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Number:";
            // 
            // itemNumTxt
            // 
            this.itemNumTxt.Location = new System.Drawing.Point(257, 91);
            this.itemNumTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemNumTxt.Name = "itemNumTxt";
            this.itemNumTxt.Size = new System.Drawing.Size(93, 20);
            this.itemNumTxt.TabIndex = 7;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(384, 107);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(67, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Price:";
            // 
            // newPriceTxt
            // 
            this.newPriceTxt.Location = new System.Drawing.Point(257, 121);
            this.newPriceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newPriceTxt.Name = "newPriceTxt";
            this.newPriceTxt.Size = new System.Drawing.Size(93, 20);
            this.newPriceTxt.TabIndex = 10;
            // 
            // dgvNewPrice
            // 
            this.dgvNewPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewPrice.Location = new System.Drawing.Point(164, 155);
            this.dgvNewPrice.Name = "dgvNewPrice";
            this.dgvNewPrice.Size = new System.Drawing.Size(254, 83);
            this.dgvNewPrice.TabIndex = 11;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 313);
            this.Controls.Add(this.dgvNewPrice);
            this.Controls.Add(this.newPriceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.itemNumTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exitBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNumTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPriceTxt;
        private System.Windows.Forms.DataGridView dgvNewPrice;
    }
}