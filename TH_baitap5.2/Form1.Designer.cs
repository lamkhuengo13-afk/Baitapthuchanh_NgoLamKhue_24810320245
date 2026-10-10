namespace TH_baitap5._2
{
    partial class Form1
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
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            txtTongTien = new TextBox();
            txtChietKhau = new TextBox();
            txtThanhTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(188, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 0;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(54, 63);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(150, 104);
            lstAvailableServices.TabIndex = 1;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(243, 63);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(150, 104);
            lstSelectedServices.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(54, 187);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 3;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(168, 187);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(284, 187);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 29);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(211, 249);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 6;
            // 
            // txtChietKhau
            // 
            txtChietKhau.Location = new Point(268, 291);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(125, 27);
            txtChietKhau.TabIndex = 7;
            txtChietKhau.Text = "0";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(217, 332);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(125, 27);
            txtThanhTien.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 252);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 9;
            label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 294);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 10;
            label2.Text = "Tỷ lệ chiết khấu %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 339);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 11;
            label3.Text = "Thành tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 20);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 12;
            label4.Text = "Danh sách dịch vụ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtThanhTien);
            Controls.Add(txtChietKhau);
            Controls.Add(txtTongTien);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private TextBox txtTongTien;
        private TextBox txtChietKhau;
        private TextBox txtThanhTien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
