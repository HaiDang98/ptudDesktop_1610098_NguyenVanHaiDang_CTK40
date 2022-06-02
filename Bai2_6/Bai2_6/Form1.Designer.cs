namespace Bai2_6
{
    partial class fmSinhVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lvDSSinhVien = new System.Windows.Forms.ListView();
            this.clMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHovaTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sinhVienDataSet = new Bai2_6.SinhVienDataSet();
            this.dsSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSinhVienTableAdapter = new Bai2_6.SinhVienDataSetTableAdapters.dsSinhVienTableAdapter();
            this.sinhVienDataSet1 = new Bai2_6.SinhVienDataSet1();
            this.dsSinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSinhVienTableAdapter1 = new Bai2_6.SinhVienDataSet1TableAdapters.dsSinhVienTableAdapter();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách sinh viên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(528, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 26);
            this.txtID.TabIndex = 2;
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(480, 185);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(378, 26);
            this.txtSearchWord.TabIndex = 2;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(528, 31);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(205, 28);
            this.cbbLop.TabIndex = 3;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(528, 132);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(128, 41);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc Định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(713, 132);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(128, 41);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(894, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lvDSSinhVien
            // 
            this.lvDSSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMSSV,
            this.clHovaTen,
            this.clLop});
            this.lvDSSinhVien.HideSelection = false;
            this.lvDSSinhVien.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.lvDSSinhVien.Location = new System.Drawing.Point(45, 217);
            this.lvDSSinhVien.Name = "lvDSSinhVien";
            this.lvDSSinhVien.Size = new System.Drawing.Size(1164, 210);
            this.lvDSSinhVien.TabIndex = 5;
            this.lvDSSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvDSSinhVien.View = System.Windows.Forms.View.Details;
            this.lvDSSinhVien.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clMSSV
            // 
            this.clMSSV.Text = "MSSV";
            this.clMSSV.Width = 169;
            // 
            // clHovaTen
            // 
            this.clHovaTen.Text = "Họ và Tên";
            this.clHovaTen.Width = 682;
            // 
            // clLop
            // 
            this.clLop.Text = "Lớp";
            this.clLop.Width = 179;
            // 
            // sinhVienDataSet
            // 
            this.sinhVienDataSet.DataSetName = "SinhVienDataSet";
            this.sinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSinhVienBindingSource
            // 
            this.dsSinhVienBindingSource.DataMember = "dsSinhVien";
            this.dsSinhVienBindingSource.DataSource = this.sinhVienDataSet;
            // 
            // dsSinhVienTableAdapter
            // 
            this.dsSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienDataSet1
            // 
            this.sinhVienDataSet1.DataSetName = "SinhVienDataSet1";
            this.sinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSinhVienBindingSource1
            // 
            this.dsSinhVienBindingSource1.DataMember = "dsSinhVien";
            this.dsSinhVienBindingSource1.DataSource = this.sinhVienDataSet1;
            // 
            // dsSinhVienTableAdapter1
            // 
            this.dsSinhVienTableAdapter1.ClearBeforeFill = true;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(528, 102);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(204, 26);
            this.txtHoVaTen.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(988, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tim Kiem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lvDSSinhVien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.txtSearchWord);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmSinhVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVienBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView lvDSSinhVien;
        private System.Windows.Forms.ColumnHeader clMSSV;
        private System.Windows.Forms.ColumnHeader clHovaTen;
        private System.Windows.Forms.ColumnHeader clLop;
        private SinhVienDataSet sinhVienDataSet;
        private System.Windows.Forms.BindingSource dsSinhVienBindingSource;
        private SinhVienDataSetTableAdapters.dsSinhVienTableAdapter dsSinhVienTableAdapter;
        private SinhVienDataSet1 sinhVienDataSet1;
        private System.Windows.Forms.BindingSource dsSinhVienBindingSource1;
        private SinhVienDataSet1TableAdapters.dsSinhVienTableAdapter dsSinhVienTableAdapter1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Button btnSearch;
    }
}

