
namespace OBO_Tools.Windows.DealerRequest
{
    partial class DealerRequestWindow
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
            this.button9 = new System.Windows.Forms.Button();
            this.fxCodeOfPointBtn = new System.Windows.Forms.Button();
            this.fxCodeOfPoint = new System.Windows.Forms.TextBox();
            this.needAnswerCheckbox = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.fxRequestArea = new System.Windows.Forms.RichTextBox();
            this.fxCheckListLabel = new System.Windows.Forms.Label();
            this.fxContactsLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(246, 698);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(196, 29);
            this.button9.TabIndex = 35;
            this.button9.Text = "Копировать текст";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // fxCodeOfPointBtn
            // 
            this.fxCodeOfPointBtn.Location = new System.Drawing.Point(671, 47);
            this.fxCodeOfPointBtn.Name = "fxCodeOfPointBtn";
            this.fxCodeOfPointBtn.Size = new System.Drawing.Size(196, 29);
            this.fxCodeOfPointBtn.TabIndex = 34;
            this.fxCodeOfPointBtn.Text = "Изменить код точки";
            this.fxCodeOfPointBtn.UseVisualStyleBackColor = true;
            this.fxCodeOfPointBtn.Visible = false;
            // 
            // fxCodeOfPoint
            // 
            this.fxCodeOfPoint.Location = new System.Drawing.Point(671, 14);
            this.fxCodeOfPoint.Name = "fxCodeOfPoint";
            this.fxCodeOfPoint.Size = new System.Drawing.Size(196, 27);
            this.fxCodeOfPoint.TabIndex = 33;
            this.fxCodeOfPoint.Visible = false;
            // 
            // needAnswerCheckbox
            // 
            this.needAnswerCheckbox.AutoSize = true;
            this.needAnswerCheckbox.Location = new System.Drawing.Point(1018, 47);
            this.needAnswerCheckbox.Name = "needAnswerCheckbox";
            this.needAnswerCheckbox.Size = new System.Drawing.Size(216, 24);
            this.needAnswerCheckbox.TabIndex = 32;
            this.needAnswerCheckbox.Text = "Требуется ответ на запрос";
            this.needAnswerCheckbox.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1038, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 29);
            this.button7.TabIndex = 31;
            this.button7.Text = "Сформировать запрос";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // fxRequestArea
            // 
            this.fxRequestArea.Location = new System.Drawing.Point(246, 83);
            this.fxRequestArea.Name = "fxRequestArea";
            this.fxRequestArea.Size = new System.Drawing.Size(988, 613);
            this.fxRequestArea.TabIndex = 30;
            this.fxRequestArea.Text = "";
            // 
            // fxCheckListLabel
            // 
            this.fxCheckListLabel.AutoSize = true;
            this.fxCheckListLabel.Location = new System.Drawing.Point(449, 56);
            this.fxCheckListLabel.Name = "fxCheckListLabel";
            this.fxCheckListLabel.Size = new System.Drawing.Size(216, 20);
            this.fxCheckListLabel.TabIndex = 29;
            this.fxCheckListLabel.Text = "Состояние: Файл не загружен";
            // 
            // fxContactsLabel
            // 
            this.fxContactsLabel.AutoSize = true;
            this.fxContactsLabel.Location = new System.Drawing.Point(448, 12);
            this.fxContactsLabel.Name = "fxContactsLabel";
            this.fxContactsLabel.Size = new System.Drawing.Size(216, 20);
            this.fxContactsLabel.TabIndex = 28;
            this.fxContactsLabel.Text = "Состояние: Файл не загружен";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 29);
            this.button6.TabIndex = 27;
            this.button6.Text = "Загрузить чек-лист ТТ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(246, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(196, 29);
            this.button8.TabIndex = 26;
            this.button8.Text = "Загрузить контакты ТМ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // DealerRequestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.fxCodeOfPointBtn);
            this.Controls.Add(this.fxCodeOfPoint);
            this.Controls.Add(this.needAnswerCheckbox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.fxRequestArea);
            this.Controls.Add(this.fxCheckListLabel);
            this.Controls.Add(this.fxContactsLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Name = "DealerRequestWindow";
            this.Text = "OBO Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button fxCodeOfPointBtn;
        public System.Windows.Forms.TextBox fxCodeOfPoint;
        public System.Windows.Forms.CheckBox needAnswerCheckbox;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.RichTextBox fxRequestArea;
        public System.Windows.Forms.Label fxCheckListLabel;
        public System.Windows.Forms.Label fxContactsLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
    }
}