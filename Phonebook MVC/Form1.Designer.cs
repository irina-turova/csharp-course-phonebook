namespace Phonebook_MVC
{
    partial class PhonebookForm
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
            this.gbFiltering = new System.Windows.Forms.GroupBox();
            this.btFilterBirthMonth = new System.Windows.Forms.Button();
            this.btFilterPhoneNumber = new System.Windows.Forms.Button();
            this.btFilterName = new System.Windows.Forms.Button();
            this.gbPhonebook = new System.Windows.Forms.GroupBox();
            this.dgvPhonebook = new System.Windows.Forms.DataGridView();
            this.gbFiltering.SuspendLayout();
            this.gbPhonebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPhonebook)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltering
            // 
            this.gbFiltering.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltering.Controls.Add(this.btFilterBirthMonth);
            this.gbFiltering.Controls.Add(this.btFilterPhoneNumber);
            this.gbFiltering.Controls.Add(this.btFilterName);
            this.gbFiltering.Location = new System.Drawing.Point(732, 12);
            this.gbFiltering.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gbFiltering.Size = new System.Drawing.Size(190, 495);
            this.gbFiltering.TabIndex = 1;
            this.gbFiltering.TabStop = false;
            this.gbFiltering.Text = "Фильтрация";
            // 
            // btFilterBirthMonth
            // 
            this.btFilterBirthMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFilterBirthMonth.Location = new System.Drawing.Point(10, 72);
            this.btFilterBirthMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btFilterBirthMonth.Name = "btFilterBirthMonth";
            this.btFilterBirthMonth.Size = new System.Drawing.Size(170, 23);
            this.btFilterBirthMonth.TabIndex = 2;
            this.btFilterBirthMonth.Text = "По месяцу рождения";
            this.btFilterBirthMonth.UseVisualStyleBackColor = true;
            this.btFilterBirthMonth.Click += new System.EventHandler(this.btFilterBirthMonth_Click);
            // 
            // btFilterPhoneNumber
            // 
            this.btFilterPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFilterPhoneNumber.Location = new System.Drawing.Point(10, 49);
            this.btFilterPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btFilterPhoneNumber.Name = "btFilterPhoneNumber";
            this.btFilterPhoneNumber.Size = new System.Drawing.Size(170, 23);
            this.btFilterPhoneNumber.TabIndex = 1;
            this.btFilterPhoneNumber.Text = "По номеру телефона";
            this.btFilterPhoneNumber.UseVisualStyleBackColor = true;
            this.btFilterPhoneNumber.Click += new System.EventHandler(this.btFilterPhoneNumber_Click);
            // 
            // btFilterName
            // 
            this.btFilterName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFilterName.Location = new System.Drawing.Point(10, 26);
            this.btFilterName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btFilterName.Name = "btFilterName";
            this.btFilterName.Size = new System.Drawing.Size(170, 23);
            this.btFilterName.TabIndex = 0;
            this.btFilterName.Text = "По имени";
            this.btFilterName.UseVisualStyleBackColor = true;
            this.btFilterName.Click += new System.EventHandler(this.btFilterName_Click);
            // 
            // gbPhonebook
            // 
            this.gbPhonebook.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.gbPhonebook.Controls.Add(this.dgvPhonebook);
            this.gbPhonebook.Location = new System.Drawing.Point(12, 12);
            this.gbPhonebook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPhonebook.Name = "gbPhonebook";
            this.gbPhonebook.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gbPhonebook.Size = new System.Drawing.Size(710, 495);
            this.gbPhonebook.TabIndex = 2;
            this.gbPhonebook.TabStop = false;
            this.gbPhonebook.Text = "Телефонный справочник";
            // 
            // dgvPhonebook
            // 
            this.dgvPhonebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhonebook.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhonebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhonebook.Location = new System.Drawing.Point(10, 26);
            this.dgvPhonebook.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dgvPhonebook.Name = "dgvPhonebook";
            this.dgvPhonebook.Size = new System.Drawing.Size(690, 459);
            this.dgvPhonebook.TabIndex = 0;
            // 
            // PhonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.gbPhonebook);
            this.Controls.Add(this.gbFiltering);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PhonebookForm";
            this.Text = "Телефонная книга";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhonebookForm_FormClosing);
            this.Load += new System.EventHandler(this.PhonebookForm_Load);
            this.gbFiltering.ResumeLayout(false);
            this.gbPhonebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvPhonebook)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltering;
        private System.Windows.Forms.GroupBox gbPhonebook;
        private System.Windows.Forms.Button btFilterBirthMonth;
        private System.Windows.Forms.Button btFilterPhoneNumber;
        private System.Windows.Forms.Button btFilterName;
        private System.Windows.Forms.DataGridView dgvPhonebook;
    }
}