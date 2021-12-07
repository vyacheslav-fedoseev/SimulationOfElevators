
namespace WinFormsAppSimulation
{
    partial class SetConfigurationForm
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
            this.FloorsCountLabel = new System.Windows.Forms.Label();
            this.LiftsCountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FloorsCountLabel
            // 
            this.FloorsCountLabel.AutoSize = true;
            this.FloorsCountLabel.Location = new System.Drawing.Point(45, 58);
            this.FloorsCountLabel.Name = "FloorsCountLabel";
            this.FloorsCountLabel.Size = new System.Drawing.Size(106, 13);
            this.FloorsCountLabel.TabIndex = 0;
            this.FloorsCountLabel.Text = "Количество этажей";
            // 
            // LiftsCountLabel
            // 
            this.LiftsCountLabel.AutoSize = true;
            this.LiftsCountLabel.Location = new System.Drawing.Point(45, 93);
            this.LiftsCountLabel.Name = "LiftsCountLabel";
            this.LiftsCountLabel.Size = new System.Drawing.Size(108, 13);
            this.LiftsCountLabel.TabIndex = 1;
            this.LiftsCountLabel.Text = "Количество Лифтов";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(277, 163);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            // this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SetConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 198);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LiftsCountLabel);
            this.Controls.Add(this.FloorsCountLabel);
            this.Name = "SetConfigurationForm";
            this.Text = "Ввод параметров конфигурации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FloorsCountLabel;
        private System.Windows.Forms.Label LiftsCountLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NextButton;
    }
}