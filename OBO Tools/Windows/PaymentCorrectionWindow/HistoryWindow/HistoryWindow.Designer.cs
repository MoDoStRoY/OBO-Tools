
namespace OBO_Tools.Windows.PaymentCorrectionWindow.HistoryWindow
{
    partial class HistoryWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.HistoryDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltersCLB = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // HistoryDGV
            // 
            this.HistoryDGV.AllowUserToAddRows = false;
            this.HistoryDGV.AllowUserToDeleteRows = false;
            this.HistoryDGV.AllowUserToResizeColumns = false;
            this.HistoryDGV.AllowUserToResizeRows = false;
            this.HistoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.HistoryDGV.Location = new System.Drawing.Point(246, 12);
            this.HistoryDGV.Name = "HistoryDGV";
            this.HistoryDGV.ReadOnly = true;
            this.HistoryDGV.RowHeadersVisible = false;
            this.HistoryDGV.RowHeadersWidth = 51;
            this.HistoryDGV.RowTemplate.Height = 29;
            this.HistoryDGV.Size = new System.Drawing.Size(988, 739);
            this.HistoryDGV.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма платежа";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата и время";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Сумма корректировки";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Отказ в корректировке";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Решение на 1 линии";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "WD/CRM";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Поиск по истории ТТ:";
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(12, 68);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(228, 27);
            this.SearchTB.TabIndex = 41;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(12, 102);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(228, 29);
            this.Button2.TabIndex = 42;
            this.Button2.Text = "Поиск";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.SearchBtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Фильтры:";
            // 
            // FiltersCLB
            // 
            this.FiltersCLB.FormattingEnabled = true;
            this.FiltersCLB.Items.AddRange(new object[] {
            "Отказ",
            "Решение",
            "WD",
            "CRM"});
            this.FiltersCLB.Location = new System.Drawing.Point(12, 162);
            this.FiltersCLB.Name = "FiltersCLB";
            this.FiltersCLB.Size = new System.Drawing.Size(228, 92);
            this.FiltersCLB.TabIndex = 44;
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.FiltersCLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryDGV);
            this.Controls.Add(this.button1);
            this.Name = "HistoryWindow";
            this.Text = "HistoryWindow";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView HistoryDGV;
        public System.Windows.Forms.TextBox SearchTB;
        public System.Windows.Forms.CheckedListBox FiltersCLB;
    }
}