﻿
namespace Larab5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Mainframe = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textlog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mainframe)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainframe
            // 
            this.Mainframe.Location = new System.Drawing.Point(9, 11);
            this.Mainframe.Name = "Mainframe";
            this.Mainframe.Size = new System.Drawing.Size(569, 468);
            this.Mainframe.TabIndex = 0;
            this.Mainframe.TabStop = false;
            this.Mainframe.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainframe_Paint);
            this.Mainframe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mainframe_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(584, 11);
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(219, 468);
            this.textlog.TabIndex = 1;
            this.textlog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 491);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.Mainframe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mainframe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mainframe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox textlog;
    }
}

