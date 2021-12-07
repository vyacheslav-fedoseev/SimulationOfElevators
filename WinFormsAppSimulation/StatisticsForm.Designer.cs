
namespace WinFormsAppSimulation
{
    partial class StatisticsForm
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
            this.StatisticsLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatisticsLabel
            // 
            this.StatisticsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatisticsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatisticsLabel.Location = new System.Drawing.Point(12, 22);
            this.StatisticsLabel.MaximumSize = new System.Drawing.Size(366, 195);
            this.StatisticsLabel.Name = "StatisticsLabel";
            this.StatisticsLabel.Size = new System.Drawing.Size(366, 195);
            this.StatisticsLabel.TabIndex = 0;
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(274, 238);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(104, 25);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(274, 269);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "В главное меню";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 306);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.StatisticsLabel);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            // this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StatisticsLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExitButton;
    }
}