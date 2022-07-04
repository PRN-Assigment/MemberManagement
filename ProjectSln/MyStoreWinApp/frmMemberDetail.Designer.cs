namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            this.lbMemDetailTitile = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMemDetailTitile
            // 
            this.lbMemDetailTitile.AutoSize = true;
            this.lbMemDetailTitile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemDetailTitile.Location = new System.Drawing.Point(116, 9);
            this.lbMemDetailTitile.Name = "lbMemDetailTitile";
            this.lbMemDetailTitile.Size = new System.Drawing.Size(258, 46);
            this.lbMemDetailTitile.TabIndex = 0;
            this.lbMemDetailTitile.Text = "Member Details";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(219, 78);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PlaceholderText = "Member ID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(230, 27);
            this.txtMemberID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(31, 78);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(105, 28);
            this.lbMemberID.TabIndex = 2;
            this.lbMemberID.Text = "MemberID";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(219, 243);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Country";
            this.txtCountry.Size = new System.Drawing.Size(230, 27);
            this.txtCountry.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(219, 211);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "City";
            this.txtCity.Size = new System.Drawing.Size(230, 27);
            this.txtCity.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(219, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(219, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(219, 111);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PlaceholderText = "Member Name";
            this.txtMemberName.Size = new System.Drawing.Size(230, 27);
            this.txtMemberName.TabIndex = 7;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(31, 243);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(82, 28);
            this.lbCountry.TabIndex = 8;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(31, 210);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 28);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "City";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(31, 177);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 28);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(31, 144);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberName.Location = new System.Drawing.Point(31, 111);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(143, 28);
            this.lbMemberName.TabIndex = 12;
            this.lbMemberName.Text = "Member Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemDetailTitile);
            this.Name = "frmMemberDetail";
            this.Text = "frmMemberDetail";
            this.Load += new System.EventHandler(this.frmMemberDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemDetailTitile;
        private TextBox txtMemberID;
        private Label lbMemberID;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemberName;
        private Label lbCountry;
        private Label lbCity;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbMemberName;
        private Button btnSave;
        private Button btnCancel;
    }
}