
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
            this.DRBtn = new System.Windows.Forms.Button();
            this.fxGroupName1 = new System.Windows.Forms.Label();
            this.fxVersion = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DRBtn
            // 
            this.DRBtn.Enabled = false;
            this.DRBtn.Location = new System.Drawing.Point(13, 126);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(196, 29);
            this.DRBtn.TabIndex = 2;
            this.DRBtn.Text = "Запросы по дилерам";
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DealerRequestBtn);
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
            // fxVersion
            // 
            this.fxVersion.AutoSize = true;
            this.fxVersion.Location = new System.Drawing.Point(12, 734);
            this.fxVersion.Name = "fxVersion";
            this.fxVersion.Size = new System.Drawing.Size(112, 20);
            this.fxVersion.TabIndex = 5;
            this.fxVersion.Text = "OBO Tools v.0.0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 702);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Настройки";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SettingsBtn);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(215, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(988, 695);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "OBO Admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Корректировка платежей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PaymentCorrectionBtn);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Счётчик косяков";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "OBO ALL";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fxVersion);
            this.Controls.Add(this.fxGroupName1);
            this.Controls.Add(this.DRBtn);
            this.Name = "MainWindow";
            this.Text = "OBO Tools";
            this.Load += new System.EventHandler(this.InitializeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button DRBtn;
        public System.Windows.Forms.Label fxGroupName1;
        public System.Windows.Forms.Label fxVersion;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label2;
    }
}

