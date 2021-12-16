
namespace WinFormsAppSimulation
{
    partial class CreateEventsListForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.DestinationFloorTextBox = new System.Windows.Forms.TextBox();
            this.CreatePeopleTimeTextBox = new System.Windows.Forms.TextBox();
            this.CurrentFloorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PeopleCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatePeopleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorCreatePeopleMessageLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TurnOnFireAlarmTimeTextBox = new System.Windows.Forms.TextBox();
            this.DurationTimeFireAlarmTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ErrorFireAlarmMessageLabel = new System.Windows.Forms.Label();
            this.CreateFireAlarmButton = new System.Windows.Forms.Button();
            this.EventsListLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "этаж на";
            // 
            // DestinationFloorTextBox
            // 
            this.DestinationFloorTextBox.Location = new System.Drawing.Point(68, 85);
            this.DestinationFloorTextBox.Name = "DestinationFloorTextBox";
            this.DestinationFloorTextBox.Size = new System.Drawing.Size(37, 20);
            this.DestinationFloorTextBox.TabIndex = 4;
            // 
            // CreatePeopleTimeTextBox
            // 
            this.CreatePeopleTimeTextBox.Location = new System.Drawing.Point(167, 85);
            this.CreatePeopleTimeTextBox.Name = "CreatePeopleTimeTextBox";
            this.CreatePeopleTimeTextBox.Size = new System.Drawing.Size(37, 20);
            this.CreatePeopleTimeTextBox.TabIndex = 6;
            // 
            // CurrentFloorTextBox
            // 
            this.CurrentFloorTextBox.Location = new System.Drawing.Point(219, 48);
            this.CurrentFloorTextBox.Name = "CurrentFloorTextBox";
            this.CurrentFloorTextBox.Size = new System.Drawing.Size(37, 20);
            this.CurrentFloorTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "секунде.";
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(46, 48);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.Size = new System.Drawing.Size(41, 20);
            this.PeopleCountTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "человек, следующих с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "на";
            // 
            // CreatePeopleButton
            // 
            this.CreatePeopleButton.Location = new System.Drawing.Point(119, 127);
            this.CreatePeopleButton.Name = "CreatePeopleButton";
            this.CreatePeopleButton.Size = new System.Drawing.Size(75, 23);
            this.CreatePeopleButton.TabIndex = 9;
            this.CreatePeopleButton.Text = "Добавить";
            this.CreatePeopleButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ErrorCreatePeopleMessageLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CreatePeopleButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DestinationFloorTextBox);
            this.panel1.Controls.Add(this.PeopleCountTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CreatePeopleTimeTextBox);
            this.panel1.Controls.Add(this.CurrentFloorTextBox);
            this.panel1.Location = new System.Drawing.Point(23, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 167);
            this.panel1.TabIndex = 10;
            // 
            // ErrorCreatePeopleMessageLabel
            // 
            this.ErrorCreatePeopleMessageLabel.AutoSize = true;
            this.ErrorCreatePeopleMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorCreatePeopleMessageLabel.Location = new System.Drawing.Point(207, 132);
            this.ErrorCreatePeopleMessageLabel.Name = "ErrorCreatePeopleMessageLabel";
            this.ErrorCreatePeopleMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorCreatePeopleMessageLabel.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "СОЗДАНИЕ ЛЮДЕЙ";
            // 
            // TurnOnFireAlarmTimeTextBox
            // 
            this.TurnOnFireAlarmTimeTextBox.Location = new System.Drawing.Point(143, 43);
            this.TurnOnFireAlarmTimeTextBox.Name = "TurnOnFireAlarmTimeTextBox";
            this.TurnOnFireAlarmTimeTextBox.Size = new System.Drawing.Size(49, 20);
            this.TurnOnFireAlarmTimeTextBox.TabIndex = 11;
            // 
            // DurationTimeFireAlarmTextBox
            // 
            this.DurationTimeFireAlarmTextBox.Location = new System.Drawing.Point(143, 76);
            this.DurationTimeFireAlarmTextBox.Name = "DurationTimeFireAlarmTextBox";
            this.DurationTimeFireAlarmTextBox.Size = new System.Drawing.Size(49, 20);
            this.DurationTimeFireAlarmTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Включить на";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "секунде.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Длительность:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "секунд.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "ПОЖАРНАЯ ТРЕВОГА";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ErrorFireAlarmMessageLabel);
            this.panel2.Controls.Add(this.CreateFireAlarmButton);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.DurationTimeFireAlarmTextBox);
            this.panel2.Controls.Add(this.TurnOnFireAlarmTimeTextBox);
            this.panel2.Location = new System.Drawing.Point(23, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 150);
            this.panel2.TabIndex = 17;
            // 
            // ErrorFireAlarmMessageLabel
            // 
            this.ErrorFireAlarmMessageLabel.AutoSize = true;
            this.ErrorFireAlarmMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorFireAlarmMessageLabel.Location = new System.Drawing.Point(204, 119);
            this.ErrorFireAlarmMessageLabel.Name = "ErrorFireAlarmMessageLabel";
            this.ErrorFireAlarmMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorFireAlarmMessageLabel.TabIndex = 15;
            // 
            // CreateFireAlarmButton
            // 
            this.CreateFireAlarmButton.Location = new System.Drawing.Point(119, 114);
            this.CreateFireAlarmButton.Name = "CreateFireAlarmButton";
            this.CreateFireAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.CreateFireAlarmButton.TabIndex = 14;
            this.CreateFireAlarmButton.Text = "Добавить";
            this.CreateFireAlarmButton.UseVisualStyleBackColor = true;
            // 
            // EventsListLabel
            // 
            this.EventsListLabel.AutoSize = true;
            this.EventsListLabel.Location = new System.Drawing.Point(12, 47);
            this.EventsListLabel.Name = "EventsListLabel";
            this.EventsListLabel.Size = new System.Drawing.Size(0, 13);
            this.EventsListLabel.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.EventsListLabel);
            this.panel3.Location = new System.Drawing.Point(376, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 335);
            this.panel3.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "СПИСОК ДОБАВЛЕННЫХ СОБЫТИЙ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.ExportToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ImportToolStripMenuItem.Text = "Импорт";
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ExportToolStripMenuItem.Text = "Экспорт";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(758, 381);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(55, 33);
            this.Ok.TabIndex = 21;
            this.Ok.Text = "ОК";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // CreateEventsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(854, 438);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateEventsListForm";
            this.Text = "CreateEventsListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DestinationFloorTextBox;
        private System.Windows.Forms.TextBox CreatePeopleTimeTextBox;
        private System.Windows.Forms.TextBox CurrentFloorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PeopleCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreatePeopleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TurnOnFireAlarmTimeTextBox;
        private System.Windows.Forms.TextBox DurationTimeFireAlarmTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateFireAlarmButton;
        private System.Windows.Forms.Label EventsListLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label ErrorCreatePeopleMessageLabel;
        private System.Windows.Forms.Label ErrorFireAlarmMessageLabel;
    }
}