
namespace OBO_Tools
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fxGroupName1 = new System.Windows.Forms.Label();
            this.fxGroupName2 = new System.Windows.Forms.Label();
            this.fxVersion = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Распределение";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(13, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Запросы ИМ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Запросы по дилерам";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dealerRequestBtn);
            // 
            // fxGroupName1
            // 
            this.fxGroupName1.AutoSize = true;
            this.fxGroupName1.Location = new System.Drawing.Point(13, 13);
            this.fxGroupName1.Name = "fxGroupName1";
            this.fxGroupName1.Size = new System.Drawing.Size(74, 20);
            this.fxGroupName1.TabIndex = 3;
            this.fxGroupName1.Text = "OBO Tech";
            // 
            // fxGroupName2
            // 
            this.fxGroupName2.AutoSize = true;
            this.fxGroupName2.Location = new System.Drawing.Point(13, 138);
            this.fxGroupName2.Name = "fxGroupName2";
            this.fxGroupName2.Size = new System.Drawing.Size(113, 20);
            this.fxGroupName2.TabIndex = 4;
            this.fxGroupName2.Text = "OBO Supervisor";
            // 
            // fxVersion
            // 
            this.fxVersion.AutoSize = true;
            this.fxVersion.Location = new System.Drawing.Point(12, 734);
            this.fxVersion.Name = "fxVersion";
            this.fxVersion.Size = new System.Drawing.Size(112, 20);
            this.fxVersion.TabIndex = 5;
            this.fxVersion.Text = "OBO Tools v.0.0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "О программе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.aboutBtn);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 667);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Настройки";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.settingsBtn);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(215, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 755);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 746);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(988, 695);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.fxCodeOfPointBtn);
            this.tabPage2.Controls.Add(this.fxCodeOfPoint);
            this.tabPage2.Controls.Add(this.needAnswerCheckbox);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.fxRequestArea);
            this.tabPage2.Controls.Add(this.fxCheckListLabel);
            this.tabPage2.Controls.Add(this.fxContactsLabel);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.loadContactsBtn);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(11, 691);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(196, 29);
            this.button9.TabIndex = 25;
            this.button9.Text = "Копировать текст";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.copyRtfTextBtn);
            // 
            // fxCodeOfPointBtn
            // 
            this.fxCodeOfPointBtn.Location = new System.Drawing.Point(436, 40);
            this.fxCodeOfPointBtn.Name = "fxCodeOfPointBtn";
            this.fxCodeOfPointBtn.Size = new System.Drawing.Size(196, 29);
            this.fxCodeOfPointBtn.TabIndex = 24;
            this.fxCodeOfPointBtn.Text = "Изменить код точки";
            this.fxCodeOfPointBtn.UseVisualStyleBackColor = true;
            this.fxCodeOfPointBtn.Visible = false;
            this.fxCodeOfPointBtn.Click += new System.EventHandler(this.changeCodeOfPointBtn);
            // 
            // fxCodeOfPoint
            // 
            this.fxCodeOfPoint.Location = new System.Drawing.Point(436, 7);
            this.fxCodeOfPoint.Name = "fxCodeOfPoint";
            this.fxCodeOfPoint.Size = new System.Drawing.Size(196, 27);
            this.fxCodeOfPoint.TabIndex = 23;
            this.fxCodeOfPoint.Visible = false;
            // 
            // needAnswerCheckbox
            // 
            this.needAnswerCheckbox.AutoSize = true;
            this.needAnswerCheckbox.Location = new System.Drawing.Point(783, 40);
            this.needAnswerCheckbox.Name = "needAnswerCheckbox";
            this.needAnswerCheckbox.Size = new System.Drawing.Size(216, 24);
            this.needAnswerCheckbox.TabIndex = 22;
            this.needAnswerCheckbox.Text = "Требуется ответ на запрос";
            this.needAnswerCheckbox.UseVisualStyleBackColor = true;
            this.needAnswerCheckbox.CheckedChanged += new System.EventHandler(this.needAnswerBtn);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(803, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 29);
            this.button7.TabIndex = 21;
            this.button7.Text = "Сформировать запрос";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.getRequestBtn);
            // 
            // fxRequestArea
            // 
            this.fxRequestArea.Location = new System.Drawing.Point(11, 76);
            this.fxRequestArea.Name = "fxRequestArea";
            this.fxRequestArea.Size = new System.Drawing.Size(988, 613);
            this.fxRequestArea.TabIndex = 20;
            this.fxRequestArea.Text = "";
            // 
            // fxCheckListLabel
            // 
            this.fxCheckListLabel.AutoSize = true;
            this.fxCheckListLabel.Location = new System.Drawing.Point(214, 49);
            this.fxCheckListLabel.Name = "fxCheckListLabel";
            this.fxCheckListLabel.Size = new System.Drawing.Size(216, 20);
            this.fxCheckListLabel.TabIndex = 19;
            this.fxCheckListLabel.Text = "Состояние: Файл не загружен";
            // 
            // fxContactsLabel
            // 
            this.fxContactsLabel.AutoSize = true;
            this.fxContactsLabel.Location = new System.Drawing.Point(213, 5);
            this.fxContactsLabel.Name = "fxContactsLabel";
            this.fxContactsLabel.Size = new System.Drawing.Size(216, 20);
            this.fxContactsLabel.TabIndex = 18;
            this.fxContactsLabel.Text = "Состояние: Файл не загружен";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 29);
            this.button6.TabIndex = 17;
            this.button6.Text = "Загрузить чек-лист ТТ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.loadCheckListBtn);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(196, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "Загрузить контакты ТМ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.loadContactsBtn);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1021, 727);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fxVersion);
            this.Controls.Add(this.fxGroupName2);
            this.Controls.Add(this.fxGroupName1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.Text = "OBO Tools";
            this.Load += new System.EventHandler(this.initializeForm);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label fxGroupName1;
        private System.Windows.Forms.Label fxGroupName2;
        private System.Windows.Forms.Label fxVersion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button fxCodeOfPointBtn;
        public System.Windows.Forms.TextBox fxCodeOfPoint;
        public System.Windows.Forms.CheckBox needAnswerCheckbox;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.RichTextBox fxRequestArea;
        public System.Windows.Forms.Label fxCheckListLabel;
        public System.Windows.Forms.Label fxContactsLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

