namespace Stopwatch
{
    partial class MainForm
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
            this.startStopButton = new System.Windows.Forms.Button();
            this.primaryTitleLabel = new System.Windows.Forms.Label();
            this.secondaryTitleLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.durationsListBox = new System.Windows.Forms.ListBox();
            this.intervalSecondRadioButton = new System.Windows.Forms.RadioButton();
            this.intervalTenthSecondRadioButton = new System.Windows.Forms.RadioButton();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.intervalHundredthSecondRadioButton = new System.Windows.Forms.RadioButton();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(104)))));
            this.startStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startStopButton.FlatAppearance.BorderSize = 0;
            this.startStopButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startStopButton.Location = new System.Drawing.Point(39, 362);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(229, 51);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = false;
            // 
            // primaryTitleLabel
            // 
            this.primaryTitleLabel.AutoSize = true;
            this.primaryTitleLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primaryTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.primaryTitleLabel.Location = new System.Drawing.Point(47, 25);
            this.primaryTitleLabel.Name = "primaryTitleLabel";
            this.primaryTitleLabel.Size = new System.Drawing.Size(240, 106);
            this.primaryTitleLabel.TabIndex = 1;
            this.primaryTitleLabel.Text = "Stop.";
            // 
            // secondaryTitleLabel
            // 
            this.secondaryTitleLabel.AutoSize = true;
            this.secondaryTitleLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondaryTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(188)))), ((int)(((byte)(104)))));
            this.secondaryTitleLabel.Location = new System.Drawing.Point(257, 25);
            this.secondaryTitleLabel.Name = "secondaryTitleLabel";
            this.secondaryTitleLabel.Size = new System.Drawing.Size(304, 106);
            this.secondaryTitleLabel.TabIndex = 1;
            this.secondaryTitleLabel.Text = "Watch.";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(309, 362);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(229, 51);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(39, 154);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(509, 159);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "00:00:00";
            // 
            // durationsListBox
            // 
            this.durationsListBox.BackColor = System.Drawing.SystemColors.Control;
            this.durationsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durationsListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationsListBox.FormattingEnabled = true;
            this.durationsListBox.ItemHeight = 30;
            this.durationsListBox.Location = new System.Drawing.Point(586, 173);
            this.durationsListBox.Name = "durationsListBox";
            this.durationsListBox.Size = new System.Drawing.Size(142, 240);
            this.durationsListBox.TabIndex = 4;
            // 
            // intervalSecondRadioButton
            // 
            this.intervalSecondRadioButton.AutoSize = true;
            this.intervalSecondRadioButton.Location = new System.Drawing.Point(15, 30);
            this.intervalSecondRadioButton.Name = "intervalSecondRadioButton";
            this.intervalSecondRadioButton.Size = new System.Drawing.Size(47, 29);
            this.intervalSecondRadioButton.TabIndex = 5;
            this.intervalSecondRadioButton.Text = "1";
            this.intervalSecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // intervalTenthSecondRadioButton
            // 
            this.intervalTenthSecondRadioButton.AutoSize = true;
            this.intervalTenthSecondRadioButton.Location = new System.Drawing.Point(15, 65);
            this.intervalTenthSecondRadioButton.Name = "intervalTenthSecondRadioButton";
            this.intervalTenthSecondRadioButton.Size = new System.Drawing.Size(61, 29);
            this.intervalTenthSecondRadioButton.TabIndex = 6;
            this.intervalTenthSecondRadioButton.Text = "0.1";
            this.intervalTenthSecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.intervalSecondRadioButton);
            this.settingsGroup.Controls.Add(this.intervalTenthSecondRadioButton);
            this.settingsGroup.Controls.Add(this.intervalHundredthSecondRadioButton);
            this.settingsGroup.Location = new System.Drawing.Point(559, 311);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(207, 127);
            this.settingsGroup.TabIndex = 7;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Interval / s";
            this.settingsGroup.Visible = false;
            // 
            // intervalHundredthSecondRadioButton
            // 
            this.intervalHundredthSecondRadioButton.AutoSize = true;
            this.intervalHundredthSecondRadioButton.Checked = true;
            this.intervalHundredthSecondRadioButton.Location = new System.Drawing.Point(15, 100);
            this.intervalHundredthSecondRadioButton.Name = "intervalHundredthSecondRadioButton";
            this.intervalHundredthSecondRadioButton.Size = new System.Drawing.Size(71, 29);
            this.intervalHundredthSecondRadioButton.TabIndex = 0;
            this.intervalHundredthSecondRadioButton.TabStop = true;
            this.intervalHundredthSecondRadioButton.Text = "0.01";
            this.intervalHundredthSecondRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.durationsListBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.secondaryTitleLabel);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.primaryTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Stopwatch";
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label primaryTitleLabel;
        private System.Windows.Forms.Label secondaryTitleLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ListBox durationsListBox;
        private System.Windows.Forms.RadioButton intervalSecondRadioButton;
        private System.Windows.Forms.RadioButton intervalTenthSecondRadioButton;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.RadioButton intervalHundredthSecondRadioButton;
    }
}