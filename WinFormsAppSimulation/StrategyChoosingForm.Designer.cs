
namespace WinFormsAppSimulation
{
    partial class StrategyChoosingForm
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
            this.StrategyComboBox = new System.Windows.Forms.ComboBox();
            this.StrategyLabel = new System.Windows.Forms.Label();
            this.ОкButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrategyComboBox
            // 
            this.StrategyComboBox.FormattingEnabled = true;
            this.StrategyComboBox.Items.AddRange(new object[] {
            "Минимальное время ожидания",
            "Минимум холостых ходов"});
            this.StrategyComboBox.Location = new System.Drawing.Point(89, 32);
            this.StrategyComboBox.Name = "StrategyComboBox";
            this.StrategyComboBox.Size = new System.Drawing.Size(218, 21);
            this.StrategyComboBox.TabIndex = 0;
            // 
            // StrategyLabel
            // 
            this.StrategyLabel.AutoSize = true;
            this.StrategyLabel.Location = new System.Drawing.Point(24, 35);
            this.StrategyLabel.Name = "StrategyLabel";
            this.StrategyLabel.Size = new System.Drawing.Size(59, 13);
            this.StrategyLabel.TabIndex = 1;
            this.StrategyLabel.Text = "Стратегия";
            // 
            // ОкButton
            // 
            this.ОкButton.Location = new System.Drawing.Point(222, 145);
            this.ОкButton.Name = "ОкButton";
            this.ОкButton.Size = new System.Drawing.Size(75, 23);
            this.ОкButton.TabIndex = 2;
            this.ОкButton.Text = "ОК";
            this.ОкButton.UseVisualStyleBackColor = true;
            this.ОкButton.Click += new System.EventHandler(this.ОкButton_Click);
            // 
            // StrategyChoosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 180);
            this.Controls.Add(this.ОкButton);
            this.Controls.Add(this.StrategyLabel);
            this.Controls.Add(this.StrategyComboBox);
            this.Name = "StrategyChoosingForm";
            this.Text = "Выбор стратегии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StrategyComboBox;
        private System.Windows.Forms.Label StrategyLabel;
        private System.Windows.Forms.Button ОкButton;
    }
}