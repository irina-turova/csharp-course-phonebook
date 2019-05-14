using System.ComponentModel;

namespace Phonebook_MVC
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btFilter = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.lbHint = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gbFilter.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btFilter);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.lbHint);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(10, 10);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFilter.Size = new System.Drawing.Size(913, 70);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Настройка фильтрации";
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(302, 22);
            this.btFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(125, 23);
            this.btFilter.TabIndex = 2;
            this.btFilter.Text = "Отфильтровать";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(178, 22);
            this.tbFilterValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(100, 23);
            this.tbFilterValue.TabIndex = 1;
            // 
            // lbHint
            // 
            this.lbHint.Location = new System.Drawing.Point(6, 27);
            this.lbHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(167, 23);
            this.lbHint.TabIndex = 0;
            this.lbHint.Text = "label1";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.dgvResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(10, 80);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResult.Size = new System.Drawing.Size(913, 429);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат фильтрации";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(4, 19);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(905, 407);
            this.dgvResult.TabIndex = 0;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FilterForm";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Text = "Фильтрация по ";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvResult)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox gbResult;
    }
}