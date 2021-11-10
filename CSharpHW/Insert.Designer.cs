
namespace CSharpHW
{
    partial class Insert
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNumTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.onHandTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.storehouseTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.dgvNewItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(56, 226);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(79, 49);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "To Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(57, 165);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(79, 49);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "To Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(56, 102);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(79, 49);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "To Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(57, 48);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 38);
            this.back.TabIndex = 5;
            this.back.Text = "Back To Main";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(476, 324);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(69, 43);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Num:";
            // 
            // itemNumTxt
            // 
            this.itemNumTxt.Location = new System.Drawing.Point(281, 46);
            this.itemNumTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemNumTxt.Name = "itemNumTxt";
            this.itemNumTxt.Size = new System.Drawing.Size(108, 20);
            this.itemNumTxt.TabIndex = 11;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(281, 77);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(108, 20);
            this.descriptionTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // onHandTxt
            // 
            this.onHandTxt.Location = new System.Drawing.Point(281, 108);
            this.onHandTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onHandTxt.Name = "onHandTxt";
            this.onHandTxt.Size = new System.Drawing.Size(108, 20);
            this.onHandTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "On Hand:";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(281, 142);
            this.categoryTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(108, 20);
            this.categoryTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category:";
            // 
            // storehouseTxt
            // 
            this.storehouseTxt.Location = new System.Drawing.Point(281, 175);
            this.storehouseTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storehouseTxt.Name = "storehouseTxt";
            this.storehouseTxt.Size = new System.Drawing.Size(108, 20);
            this.storehouseTxt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Storehouse:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(281, 206);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(108, 20);
            this.priceTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(260, 329);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 38);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.hireBtn_Click);
            // 
            // dgvNewItem
            // 
            this.dgvNewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewItem.Location = new System.Drawing.Point(413, 57);
            this.dgvNewItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNewItem.Name = "dgvNewItem";
            this.dgvNewItem.RowHeadersWidth = 62;
            this.dgvNewItem.RowTemplate.Height = 28;
            this.dgvNewItem.Size = new System.Drawing.Size(233, 247);
            this.dgvNewItem.TabIndex = 29;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 389);
            this.Controls.Add(this.dgvNewItem);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.storehouseTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.onHandTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNumTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Insert";
            this.Text = "Insert";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNumTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox onHandTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox storehouseTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dgvNewItem;
    }
}