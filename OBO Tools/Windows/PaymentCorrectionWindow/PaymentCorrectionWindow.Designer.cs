﻿
namespace OBO_Tools.Windows.PaymentCorrectionWindow
{
    partial class PaymentCorrectionWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTNumber = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BCVariantCLB = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.correctNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.correctFS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.incorrectFS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullCorrectionCLB = new System.Windows.Forms.CheckedListBox();
            this.reparationCLB = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.decision = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cashComment = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.invoiceComment = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.correctionSum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Основная информация о ТТ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Номер ТТ (TTXXXXXXXXX):";
            // 
            // TTNumber
            // 
            this.TTNumber.Location = new System.Drawing.Point(247, 91);
            this.TTNumber.Name = "TTNumber";
            this.TTNumber.Size = new System.Drawing.Size(191, 27);
            this.TTNumber.TabIndex = 40;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(247, 145);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(191, 27);
            this.contact.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Контактный номер/почта";
            // 
            // BCVariantCLB
            // 
            this.BCVariantCLB.FormattingEnabled = true;
            this.BCVariantCLB.Items.AddRange(new object[] {
            "SMS",
            "Звонок",
            "E-Mail",
            "Соц.сеть",
            "XXX"});
            this.BCVariantCLB.Location = new System.Drawing.Point(247, 198);
            this.BCVariantCLB.Name = "BCVariantCLB";
            this.BCVariantCLB.Size = new System.Drawing.Size(191, 114);
            this.BCVariantCLB.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Способ ОС:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Информация по платежу:";
            // 
            // correctNumber
            // 
            this.correctNumber.Location = new System.Drawing.Point(496, 91);
            this.correctNumber.Name = "correctNumber";
            this.correctNumber.Size = new System.Drawing.Size(191, 27);
            this.correctNumber.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Корректный номер телефона:";
            // 
            // correctFS
            // 
            this.correctFS.Location = new System.Drawing.Point(496, 145);
            this.correctFS.Name = "correctFS";
            this.correctFS.Size = new System.Drawing.Size(191, 27);
            this.correctFS.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Л/С корректного номера:";
            // 
            // incorrectFS
            // 
            this.incorrectFS.Location = new System.Drawing.Point(496, 199);
            this.incorrectFS.Name = "incorrectFS";
            this.incorrectFS.Size = new System.Drawing.Size(191, 27);
            this.incorrectFS.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Л/С ошибочного номера:";
            // 
            // paymentSum
            // 
            this.paymentSum.Location = new System.Drawing.Point(496, 253);
            this.paymentSum.Name = "paymentSum";
            this.paymentSum.Size = new System.Drawing.Size(191, 27);
            this.paymentSum.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Сумма платежа:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(758, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Параметры корректировки:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(758, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Корректировка в полном объёме?";
            // 
            // fullCorrectionCLB
            // 
            this.fullCorrectionCLB.FormattingEnabled = true;
            this.fullCorrectionCLB.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.fullCorrectionCLB.Location = new System.Drawing.Point(758, 91);
            this.fullCorrectionCLB.Name = "fullCorrectionCLB";
            this.fullCorrectionCLB.Size = new System.Drawing.Size(155, 48);
            this.fullCorrectionCLB.TabIndex = 56;
            // 
            // reparationCLB
            // 
            this.reparationCLB.FormattingEnabled = true;
            this.reparationCLB.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.reparationCLB.Location = new System.Drawing.Point(758, 169);
            this.reparationCLB.Name = "reparationCLB";
            this.reparationCLB.Size = new System.Drawing.Size(155, 48);
            this.reparationCLB.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(758, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Предоставляется компенсация?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(987, 29);
            this.button3.TabIndex = 64;
            this.button3.Text = "Копировать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Решение:";
            // 
            // decision
            // 
            this.decision.Location = new System.Drawing.Point(247, 447);
            this.decision.Name = "decision";
            this.decision.Size = new System.Drawing.Size(987, 49);
            this.decision.TabIndex = 62;
            this.decision.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 612);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(987, 29);
            this.button4.TabIndex = 67;
            this.button4.Text = "Копировать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Комментарий для кассы:";
            // 
            // cashComment
            // 
            this.cashComment.Location = new System.Drawing.Point(247, 557);
            this.cashComment.Name = "cashComment";
            this.cashComment.Size = new System.Drawing.Size(987, 49);
            this.cashComment.TabIndex = 65;
            this.cashComment.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(987, 29);
            this.button2.TabIndex = 70;
            this.button2.Text = "Копировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 644);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 20);
            this.label13.TabIndex = 69;
            this.label13.Text = "Комментарий для компенсации в InVoice:";
            // 
            // invoiceComment
            // 
            this.invoiceComment.Location = new System.Drawing.Point(247, 667);
            this.invoiceComment.Name = "invoiceComment";
            this.invoiceComment.Size = new System.Drawing.Size(987, 49);
            this.invoiceComment.TabIndex = 68;
            this.invoiceComment.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(247, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(987, 102);
            this.button5.TabIndex = 71;
            this.button5.Text = "Сделать заебись!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GetInfoBtn);
            // 
            // correctionSum
            // 
            this.correctionSum.Location = new System.Drawing.Point(758, 253);
            this.correctionSum.Name = "correctionSum";
            this.correctionSum.Size = new System.Drawing.Size(191, 27);
            this.correctionSum.TabIndex = 73;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(758, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 20);
            this.label16.TabIndex = 72;
            this.label16.Text = "Сумма корректировки:";
            // 
            // PaymentCorrectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.correctionSum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.invoiceComment);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cashComment);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.decision);
            this.Controls.Add(this.reparationCLB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fullCorrectionCLB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.paymentSum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.incorrectFS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correctFS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.correctNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BCVariantCLB);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TTNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PaymentCorrectionWindow";
            this.Text = "OBO Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TTNumber;
        public System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox BCVariantCLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox correctNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox correctFS;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox incorrectFS;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox paymentSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.CheckedListBox fullCorrectionCLB;
        public System.Windows.Forms.CheckedListBox reparationCLB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.RichTextBox decision;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.RichTextBox cashComment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.RichTextBox invoiceComment;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox correctionSum;
        private System.Windows.Forms.Label label16;
    }
}