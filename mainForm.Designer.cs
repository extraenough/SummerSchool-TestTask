namespace SummerSchool_TestTask
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlstrpStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splcMain = new System.Windows.Forms.SplitContainer();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.pbxCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMain)).BeginInit();
            this.splcMain.Panel1.SuspendLayout();
            this.splcMain.Panel2.SuspendLayout();
            this.splcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.паузаToolStripMenuItem.Text = "Пауза";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlstrpStatus
            // 
            this.tlstrpStatus.Name = "tlstrpStatus";
            this.tlstrpStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // splcMain
            // 
            this.splcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcMain.Location = new System.Drawing.Point(0, 24);
            this.splcMain.Name = "splcMain";
            // 
            // splcMain.Panel1
            // 
            this.splcMain.Panel1.Controls.Add(this.rtbHistory);
            // 
            // splcMain.Panel2
            // 
            this.splcMain.Panel2.Controls.Add(this.pbxCanvas);
            this.splcMain.Size = new System.Drawing.Size(372, 247);
            this.splcMain.SplitterDistance = 124;
            this.splcMain.TabIndex = 3;
            // 
            // rtbHistory
            // 
            this.rtbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistory.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.rtbHistory.Location = new System.Drawing.Point(0, 0);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.ReadOnly = true;
            this.rtbHistory.Size = new System.Drawing.Size(124, 247);
            this.rtbHistory.TabIndex = 0;
            this.rtbHistory.Text = "";
            // 
            // pbxCanvas
            // 
            this.pbxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbxCanvas.Name = "pbxCanvas";
            this.pbxCanvas.Size = new System.Drawing.Size(244, 247);
            this.pbxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCanvas.TabIndex = 2;
            this.pbxCanvas.TabStop = false;
            this.pbxCanvas.Click += new System.EventHandler(this.pbxCanvas_Click);
            this.pbxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCanvas_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 293);
            this.Controls.Add(this.splcMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splcMain.Panel1.ResumeLayout(false);
            this.splcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMain)).EndInit();
            this.splcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splcMain;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.ToolStripStatusLabel tlstrpStatus;
        private System.Windows.Forms.PictureBox pbxCanvas;

    }
}

