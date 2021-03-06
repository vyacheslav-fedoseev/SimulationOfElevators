
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
            this.FireButton = new System.Windows.Forms.Button();
            this.SpeedUpButton = new System.Windows.Forms.Button();
            this.SlowDownButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ElevatorsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PeopleCountTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFloorTextBox = new System.Windows.Forms.TextBox();
            this.CurrentFloorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorMessageLebel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(449, 537);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(36, 32);
            this.FireButton.TabIndex = 1;
            this.FireButton.Text = "🔥";
            this.FireButton.UseVisualStyleBackColor = true;
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.Location = new System.Drawing.Point(533, 537);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(36, 32);
            this.SpeedUpButton.TabIndex = 2;
            this.SpeedUpButton.Text = ">>";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            // 
            // SlowDownButton
            // 
            this.SlowDownButton.Location = new System.Drawing.Point(491, 537);
            this.SlowDownButton.Name = "SlowDownButton";
            this.SlowDownButton.Size = new System.Drawing.Size(36, 32);
            this.SlowDownButton.TabIndex = 3;
            this.SlowDownButton.Text = "<<";
            this.SlowDownButton.UseVisualStyleBackColor = true;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Location = new System.Drawing.Point(575, 537);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(36, 32);
            this.PlayPauseButton.TabIndex = 4;
            this.PlayPauseButton.Text = "▶|";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(617, 537);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(36, 32);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "█";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ElevatorsGrid
            // 
            this.ElevatorsGrid.AllowUserToAddRows = false;
            this.ElevatorsGrid.AllowUserToDeleteRows = false;
            this.ElevatorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElevatorsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ElevatorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElevatorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ElevatorsGrid.Location = new System.Drawing.Point(415, 27);
            this.ElevatorsGrid.Name = "ElevatorsGrid";
            this.ElevatorsGrid.ReadOnly = true;
            this.ElevatorsGrid.Size = new System.Drawing.Size(613, 504);
            this.ElevatorsGrid.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // PeopleStatusLabel
            // 
            this.PeopleStatusLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PeopleStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeopleStatusLabel.Location = new System.Drawing.Point(25, 66);
            this.PeopleStatusLabel.Name = "PeopleStatusLabel";
            this.PeopleStatusLabel.Size = new System.Drawing.Size(323, 241);
            this.PeopleStatusLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество человек :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "На каком этаже :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Этаж назначения :";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(131, 508);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(189, 367);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeopleCountTextBox.TabIndex = 12;
            // 
            // DestinationFloorTextBox
            // 
            this.DestinationFloorTextBox.Location = new System.Drawing.Point(189, 450);
            this.DestinationFloorTextBox.Name = "DestinationFloorTextBox";
            this.DestinationFloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.DestinationFloorTextBox.TabIndex = 13;
            // 
            // CurrentFloorTextBox
            // 
            this.CurrentFloorTextBox.Location = new System.Drawing.Point(189, 409);
            this.CurrentFloorTextBox.Name = "CurrentFloorTextBox";
            this.CurrentFloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentFloorTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Создание группы людей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Статус людей";
            // 
            // ErrorMessageLebel
            // 
            this.ErrorMessageLebel.AutoSize = true;
            this.ErrorMessageLebel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLebel.Location = new System.Drawing.Point(119, 483);
            this.ErrorMessageLebel.Name = "ErrorMessageLebel";
            this.ErrorMessageLebel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLebel.TabIndex = 17;
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesLabel.Location = new System.Drawing.Point(815, 547);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(19, 22);
            this.MinutesLabel.TabIndex = 18;
            this.MinutesLabel.Text = "x";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLabel.Location = new System.Drawing.Point(841, 547);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(19, 22);
            this.SecondsLabel.TabIndex = 19;
            this.SecondsLabel.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(830, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.ErrorMessageLebel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentFloorTextBox);
            this.Controls.Add(this.DestinationFloorTextBox);
            this.Controls.Add(this.PeopleCountTextBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeopleStatusLabel);
            this.Controls.Add(this.ElevatorsGrid);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.SlowDownButton);
            this.Controls.Add(this.SpeedUpButton);
            this.Controls.Add(this.FireButton);
            this.Name = "SimulationForm";
            this.Text = "Симуляция";
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button SpeedUpButton;
        private System.Windows.Forms.Button SlowDownButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.DataGridView ElevatorsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label PeopleStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox PeopleCountTextBox;
        private System.Windows.Forms.TextBox DestinationFloorTextBox;
        private System.Windows.Forms.TextBox CurrentFloorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorMessageLebel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label label7;
    }
}