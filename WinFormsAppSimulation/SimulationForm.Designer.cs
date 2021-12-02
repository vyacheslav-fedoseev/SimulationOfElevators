
namespace WinFormsAppSimulation
{
    partial class SimulationForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckPeopleStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FireButton = new System.Windows.Forms.Button();
            this.SpeedUpButton = new System.Windows.Forms.Button();
            this.SlowDownButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(805, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePeopleToolStripMenuItem,
            this.CheckPeopleStatusToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // CreatePeopleToolStripMenuItem
            // 
            this.CreatePeopleToolStripMenuItem.Name = "CreatePeopleToolStripMenuItem";
            this.CreatePeopleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CreatePeopleToolStripMenuItem.Text = "Создать группу людей";
            this.CreatePeopleToolStripMenuItem.Click += new System.EventHandler(this.CreatePeopleToolStripMenuItem_Click);
            // 
            // CheckPeopleStatusToolStripMenuItem
            // 
            this.CheckPeopleStatusToolStripMenuItem.Name = "CheckPeopleStatusToolStripMenuItem";
            this.CheckPeopleStatusToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CheckPeopleStatusToolStripMenuItem.Text = "Посмотреть статус людей";
            this.CheckPeopleStatusToolStripMenuItem.Click += new System.EventHandler(this.CheckPeopleStatusToolStripMenuItem_Click);
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(305, 442);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(36, 32);
            this.FireButton.TabIndex = 1;
            this.FireButton.Text = "🔥";
            this.FireButton.UseVisualStyleBackColor = true;
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.Location = new System.Drawing.Point(389, 442);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(36, 32);
            this.SpeedUpButton.TabIndex = 2;
            this.SpeedUpButton.Text = ">>";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            // 
            // SlowDownButton
            // 
            this.SlowDownButton.Location = new System.Drawing.Point(347, 442);
            this.SlowDownButton.Name = "SlowDownButton";
            this.SlowDownButton.Size = new System.Drawing.Size(36, 32);
            this.SlowDownButton.TabIndex = 3;
            this.SlowDownButton.Text = "<<";
            this.SlowDownButton.UseVisualStyleBackColor = true;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Location = new System.Drawing.Point(431, 442);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(36, 32);
            this.PlayPauseButton.TabIndex = 4;
            this.PlayPauseButton.Text = "▶|";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(473, 442);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(36, 32);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "█";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 497);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.SlowDownButton);
            this.Controls.Add(this.SpeedUpButton);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SimulationForm";
            this.Text = "Симуляция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreatePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckPeopleStatusToolStripMenuItem;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button SpeedUpButton;
        private System.Windows.Forms.Button SlowDownButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button StopButton;
    }
}