using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProgramKicker
{
    partial class Kicker
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
            this.components = new System.ComponentModel.Container();
            this.FilePicker = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SecondPicker = new System.Windows.Forms.NumericUpDown();
            this.MinutePicker = new System.Windows.Forms.NumericUpDown();
            this.HourPicker = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExeKickerNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePicker
            // 
            this.FilePicker.Location = new System.Drawing.Point(279, 9);
            this.FilePicker.Name = "FilePicker";
            this.FilePicker.Size = new System.Drawing.Size(75, 23);
            this.FilePicker.TabIndex = 0;
            this.FilePicker.Text = "Choose...";
            this.FilePicker.UseVisualStyleBackColor = true;
            this.FilePicker.Click += new System.EventHandler(this.FilePicker_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(9, 35);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(33, 13);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "Timer";
            // 
            // SecondPicker
            // 
            this.SecondPicker.Location = new System.Drawing.Point(131, 33);
            this.SecondPicker.Name = "SecondPicker";
            this.SecondPicker.Size = new System.Drawing.Size(37, 20);
            this.SecondPicker.TabIndex = 3;
            // 
            // MinutePicker
            // 
            this.MinutePicker.Location = new System.Drawing.Point(90, 33);
            this.MinutePicker.Name = "MinutePicker";
            this.MinutePicker.Size = new System.Drawing.Size(35, 20);
            this.MinutePicker.TabIndex = 4;
            // 
            // HourPicker
            // 
            this.HourPicker.Location = new System.Drawing.Point(48, 33);
            this.HourPicker.Name = "HourPicker";
            this.HourPicker.Size = new System.Drawing.Size(36, 20);
            this.HourPicker.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ExeKickerNotifier
            // 
            this.ExeKickerNotifier.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExeKickerNotifier.BalloonTipText = "Program Kicker";
            this.ExeKickerNotifier.Text = "ExeKicker";
            this.ExeKickerNotifier.Visible = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(276, 51);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 47);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(183, 51);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 47);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "OO:OO:OO";
            // 
            // Kicker
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.HourPicker);
            this.Controls.Add(this.MinutePicker);
            this.Controls.Add(this.SecondPicker);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilePicker);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Kicker";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "The Kicker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SecondPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FilePicker;
        private TextBox textBox1;
        private Label TimerLabel;
        private NumericUpDown SecondPicker;
        private NumericUpDown MinutePicker;
        private NumericUpDown HourPicker;
        private OpenFileDialog openFileDialog1;
        private NotifyIcon ExeKickerNotifier;
        private Button StartButton;
        private Button StopButton;
        private Label label1;
    }
}

