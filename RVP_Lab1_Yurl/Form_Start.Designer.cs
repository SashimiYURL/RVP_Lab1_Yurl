namespace RVP_Lab1_Yurl
{
    partial class Form_Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreation = new System.Windows.Forms.Button();
            this.buttonChangePers = new System.Windows.Forms.Button();
            this.buttonDeletion = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddTab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreation
            // 
            this.buttonCreation.Location = new System.Drawing.Point(291, 73);
            this.buttonCreation.Name = "buttonCreation";
            this.buttonCreation.Size = new System.Drawing.Size(186, 56);
            this.buttonCreation.TabIndex = 0;
            this.buttonCreation.Text = "Создать новую запись";
            this.buttonCreation.UseVisualStyleBackColor = true;
            this.buttonCreation.Click += new System.EventHandler(this.buttonCreation_Click);
            // 
            // buttonChangePers
            // 
            this.buttonChangePers.Location = new System.Drawing.Point(326, 158);
            this.buttonChangePers.Name = "buttonChangePers";
            this.buttonChangePers.Size = new System.Drawing.Size(118, 66);
            this.buttonChangePers.TabIndex = 1;
            this.buttonChangePers.Text = "Изменить выбранную";
            this.buttonChangePers.UseVisualStyleBackColor = true;
            this.buttonChangePers.Click += new System.EventHandler(this.buttonChangePers_Click);
            // 
            // buttonDeletion
            // 
            this.buttonDeletion.Location = new System.Drawing.Point(320, 274);
            this.buttonDeletion.Name = "buttonDeletion";
            this.buttonDeletion.Size = new System.Drawing.Size(124, 69);
            this.buttonDeletion.TabIndex = 2;
            this.buttonDeletion.Text = "Удалить выбранную";
            this.buttonDeletion.UseVisualStyleBackColor = true;
            this.buttonDeletion.Click += new System.EventHandler(this.buttonDeletion_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 380);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddTab
            // 
            this.buttonAddTab.Location = new System.Drawing.Point(568, 320);
            this.buttonAddTab.Name = "buttonAddTab";
            this.buttonAddTab.Size = new System.Drawing.Size(105, 66);
            this.buttonAddTab.TabIndex = 5;
            this.buttonAddTab.Text = "Добавить вкладку";
            this.buttonAddTab.UseVisualStyleBackColor = true;
            this.buttonAddTab.Click += new System.EventHandler(this.buttonAddTab_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonDeletion);
            this.Controls.Add(this.buttonChangePers);
            this.Controls.Add(this.buttonCreation);
            this.Name = "Form_Start";
            this.Text = "Form_Start";
            this.Load += new System.EventHandler(this.Form_Start_Load);
            this.Move += new System.EventHandler(this.Form_Start_Move);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreation;
        private System.Windows.Forms.Button buttonChangePers;
        private System.Windows.Forms.Button buttonDeletion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAddTab;
        private System.Windows.Forms.Button button1;
    }
}

