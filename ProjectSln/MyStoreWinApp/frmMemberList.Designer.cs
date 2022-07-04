namespace MyStoreWinApp
{
    partial class frmMemberList
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
            this.lbMemListTitle = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchByCity = new System.Windows.Forms.Button();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.btnSearchByCountry = new System.Windows.Forms.Button();
            this.txtSearchCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemListTitle
            // 
            this.lbMemListTitle.AutoSize = true;
            this.lbMemListTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemListTitle.Location = new System.Drawing.Point(292, 9);
            this.lbMemListTitle.Name = "lbMemListTitle";
            this.lbMemListTitle.Size = new System.Drawing.Size(207, 46);
            this.lbMemListTitle.TabIndex = 0;
            this.lbMemListTitle.Text = "Member List";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberName.Location = new System.Drawing.Point(12, 71);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(143, 28);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(174, 72);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PlaceholderText = "MemberName";
            this.txtMemberName.Size = new System.Drawing.Size(216, 27);
            this.txtMemberName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(595, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(247, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 469);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(463, 74);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(12, 121);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 28);
            this.lbCity.TabIndex = 6;
            this.lbCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(174, 121);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "City";
            this.txtCity.Size = new System.Drawing.Size(216, 27);
            this.txtCity.TabIndex = 7;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(463, 120);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(82, 28);
            this.lbCountry.TabIndex = 8;
            this.lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(595, 125);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Country";
            this.txtCountry.Size = new System.Drawing.Size(247, 27);
            this.txtCountry.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(625, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(12, 275);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.Size = new System.Drawing.Size(837, 188);
            this.dgvMemberList.TabIndex = 12;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(12, 180);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(110, 28);
            this.lbMemberID.TabIndex = 13;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberID.Location = new System.Drawing.Point(174, 177);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PlaceholderText = "Member ID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(216, 34);
            this.txtMemberID.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(595, 182);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Incomplete Name Accepted";
            this.txtSearch.Size = new System.Drawing.Size(247, 27);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(256, 469);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(119, 29);
            this.btnSort.TabIndex = 19;
            this.btnSort.Text = "Sort By Name";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(463, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchByCity
            // 
            this.btnSearchByCity.Location = new System.Drawing.Point(12, 240);
            this.btnSearchByCity.Name = "btnSearchByCity";
            this.btnSearchByCity.Size = new System.Drawing.Size(94, 29);
            this.btnSearchByCity.TabIndex = 21;
            this.btnSearchByCity.Text = "Search";
            this.btnSearchByCity.UseVisualStyleBackColor = true;
            this.btnSearchByCity.Click += new System.EventHandler(this.btnSearchByCity_Click);
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Location = new System.Drawing.Point(145, 242);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.PlaceholderText = "Incomplete City Accepted";
            this.txtSearchCity.Size = new System.Drawing.Size(245, 27);
            this.txtSearchCity.TabIndex = 22;
            // 
            // btnSearchByCountry
            // 
            this.btnSearchByCountry.Location = new System.Drawing.Point(463, 241);
            this.btnSearchByCountry.Name = "btnSearchByCountry";
            this.btnSearchByCountry.Size = new System.Drawing.Size(94, 29);
            this.btnSearchByCountry.TabIndex = 23;
            this.btnSearchByCountry.Text = "Search";
            this.btnSearchByCountry.UseVisualStyleBackColor = true;
            this.btnSearchByCountry.Click += new System.EventHandler(this.btnSearchByCountry_Click);
            // 
            // txtSearchCountry
            // 
            this.txtSearchCountry.Location = new System.Drawing.Point(595, 241);
            this.txtSearchCountry.Name = "txtSearchCountry";
            this.txtSearchCountry.PlaceholderText = "Incomplete Country Accepted";
            this.txtSearchCountry.Size = new System.Drawing.Size(247, 27);
            this.txtSearchCountry.TabIndex = 24;
            // 
            // frmMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 530);
            this.Controls.Add(this.txtSearchCountry);
            this.Controls.Add(this.btnSearchByCountry);
            this.Controls.Add(this.txtSearchCity);
            this.Controls.Add(this.btnSearchByCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemListTitle);
            this.Name = "frmMemberList";
            this.Text = "frmMemberList";
            this.Load += new System.EventHandler(this.frmMemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemListTitle;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private Button btnLoad;
        private Label lbEmail;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvMemberList;
        private Label lbMemberID;
        private TextBox txtMemberID;
        private Button btnSave;
        private TextBox txtSearch;
        private Button btnSort;
        private Button btnSearch;
        private Button btnSearchByCity;
        private TextBox txtSearchCity;
        private Button btnSearchByCountry;
        private TextBox txtSearchCountry;
    }
}