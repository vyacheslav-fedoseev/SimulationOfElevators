
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
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.MaxAccelerationTextBox = new System.Windows.Forms.TextBox();
            this.TamplateCheckBox = new System.Windows.Forms.CheckBox();
            this.EndLiftsConfigurationButton = new System.Windows.Forms.Button();
            this.MaxSpeedLable = new System.Windows.Forms.Label();
            this.MaxAccelerationLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.AddElevatorButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(217, 37);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxSpeedTextBox.TabIndex = 0;
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(217, 113);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CapacityTextBox.TabIndex = 1;
            // 
            // MaxAccelerationTextBox
            // 
            this.MaxAccelerationTextBox.Location = new System.Drawing.Point(217, 75);
            this.MaxAccelerationTextBox.Name = "MaxAccelerationTextBox";
            this.MaxAccelerationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxAccelerationTextBox.TabIndex = 2;
            // 
            // TamplateCheckBox
            // 
            this.TamplateCheckBox.AutoSize = true;
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
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(54, 113);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(76, 13);
            this.CapacityLabel.TabIndex = 7;
            this.CapacityLabel.Text = "Вместимость";
            // 
            // AddElevatorButton
            // 
            this.AddElevatorButton.Location = new System.Drawing.Point(149, 244);
            this.AddElevatorButton.Name = "AddElevatorButton";
            this.AddElevatorButton.Size = new System.Drawing.Size(75, 23);
            this.AddElevatorButton.TabIndex = 8;
            this.AddElevatorButton.Text = "Добавить лифт";
            this.AddElevatorButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(146, 197);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 9;
            // 
            // SetElevatorsConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 295);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AddElevatorButton);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.MaxAccelerationLabel);
            this.Controls.Add(this.MaxSpeedLable);
            this.Controls.Add(this.EndLiftsConfigurationButton);
            this.Controls.Add(this.TamplateCheckBox);
            this.Controls.Add(this.MaxAccelerationTextBox);
            this.Controls.Add(this.CapacityTextBox);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Name = "SetElevatorsConfigurationForm";
            this.Text = "Ы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox MaxAccelerationTextBox;
        private System.Windows.Forms.CheckBox TamplateCheckBox;
        private System.Windows.Forms.Button EndLiftsConfigurationButton;
        private System.Windows.Forms.Label MaxSpeedLable;
        private System.Windows.Forms.Label MaxAccelerationLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Button AddElevatorButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}