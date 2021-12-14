
namespace WinFormsAppSimulation
{
    partial class CheckPeopleStatusForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.peopleStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(271, 225);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Завершить";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // peopleStatusLabel
            // 
            this.peopleStatusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.peopleStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peopleStatusLabel.Location = new System.Drawing.Point(12, 23);
            this.peopleStatusLabel.MaximumSize = new System.Drawing.Size(335, 180);
            this.peopleStatusLabel.Name = "peopleStatusLabel";
            this.peopleStatusLabel.Size = new System.Drawing.Size(334, 180);
            this.peopleStatusLabel.TabIndex = 1;
            // 
            // CheckPeopleStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 260);
            this.Controls.Add(this.peopleStatusLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "CheckPeopleStatusForm";
            this.Text = "Просмотр статуса людей ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label peopleStatusLabel;
    }
}