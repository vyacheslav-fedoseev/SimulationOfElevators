
namespace WinFormsAppSimulation
{
    partial class SetElevatorsConfigurationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TamplateCheckBox = new System.Windows.Forms.CheckBox();
            this.EndLiftsConfigurationButton = new System.Windows.Forms.Button();
            this.MaxSpeedLable = new System.Windows.Forms.Label();
            this.MaxAccelerationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLiftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // TamplateCheckBox
            // 
            this.TamplateCheckBox.AutoSize = true;
            this.TamplateCheckBox.Enabled = false;
            this.TamplateCheckBox.Location = new System.Drawing.Point(171, 151);
            this.TamplateCheckBox.Name = "TamplateCheckBox";
            this.TamplateCheckBox.Size = new System.Drawing.Size(161, 17);
            this.TamplateCheckBox.TabIndex = 3;
            this.TamplateCheckBox.Text = "Использовать как шаблон";
            this.TamplateCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndLiftsConfigurationButton
            // 
            this.EndLiftsConfigurationButton.Location = new System.Drawing.Point(242, 244);
            this.EndLiftsConfigurationButton.Name = "EndLiftsConfigurationButton";
            this.EndLiftsConfigurationButton.Size = new System.Drawing.Size(75, 23);
            this.EndLiftsConfigurationButton.TabIndex = 4;
            this.EndLiftsConfigurationButton.Text = "Завершить конфигурацию";
            this.EndLiftsConfigurationButton.UseVisualStyleBackColor = true;
            // this.EndLiftsConfigurationButton.Click += new System.EventHandler(this.EndLiftsConfigurationButton_Click);
            // 
            // MaxSpeedLable
            // 
            this.MaxSpeedLable.AutoSize = true;
            this.MaxSpeedLable.Location = new System.Drawing.Point(54, 37);
            this.MaxSpeedLable.Name = "MaxSpeedLable";
            this.MaxSpeedLable.Size = new System.Drawing.Size(134, 13);
            this.MaxSpeedLable.TabIndex = 5;
            this.MaxSpeedLable.Text = "Максимальная скорость";
            // 
            // MaxAccelerationLabel
            // 
            this.MaxAccelerationLabel.AutoSize = true;
            this.MaxAccelerationLabel.Location = new System.Drawing.Point(54, 75);
            this.MaxAccelerationLabel.Name = "MaxAccelerationLabel";
            this.MaxAccelerationLabel.Size = new System.Drawing.Size(140, 13);
            this.MaxAccelerationLabel.TabIndex = 6;
            this.MaxAccelerationLabel.Text = "Максимальное ускорение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вместимость";
            // 
            // AddLiftButton
            // 
            this.AddLiftButton.Location = new System.Drawing.Point(149, 244);
            this.AddLiftButton.Name = "AddLiftButton";
            this.AddLiftButton.Size = new System.Drawing.Size(75, 23);
            this.AddLiftButton.TabIndex = 8;
            this.AddLiftButton.Text = "Добавить лифт";
            this.AddLiftButton.UseVisualStyleBackColor = true;
            // 
            // SetElevatorsConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 295);
            this.Controls.Add(this.AddLiftButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxAccelerationLabel);
            this.Controls.Add(this.MaxSpeedLable);
            this.Controls.Add(this.EndLiftsConfigurationButton);
            this.Controls.Add(this.TamplateCheckBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SetElevatorsConfigurationForm";
            this.Text = "Ввод параметров лифтов";
            // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetElevatorsConfigurationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox TamplateCheckBox;
        private System.Windows.Forms.Button EndLiftsConfigurationButton;
        private System.Windows.Forms.Label MaxSpeedLable;
        private System.Windows.Forms.Label MaxAccelerationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddLiftButton;
    }
}