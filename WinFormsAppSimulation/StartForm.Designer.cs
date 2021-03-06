
namespace WinFormsAppSimulation
{
    partial class StartForm
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
            this.StartConfigurationButton = new System.Windows.Forms.Button();
            this.StrategyChoosingButton = new System.Windows.Forms.Button();
            this.StartSimulationButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateEventsListButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartConfigurationButton
            // 
            this.StartConfigurationButton.Location = new System.Drawing.Point(169, 27);
            this.StartConfigurationButton.Name = "StartConfigurationButton";
            this.StartConfigurationButton.Size = new System.Drawing.Size(150, 50);
            this.StartConfigurationButton.TabIndex = 0;
            this.StartConfigurationButton.Text = "Задать конфигурацию";
            this.StartConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // StrategyChoosingButton
            // 
            this.StrategyChoosingButton.Location = new System.Drawing.Point(169, 83);
            this.StrategyChoosingButton.Name = "StrategyChoosingButton";
            this.StrategyChoosingButton.Size = new System.Drawing.Size(150, 50);
            this.StrategyChoosingButton.TabIndex = 1;
            this.StrategyChoosingButton.Text = "Выбрать стратегию";
            this.StrategyChoosingButton.UseVisualStyleBackColor = true;
            // 
            // StartSimulationButton
            // 
            this.StartSimulationButton.Location = new System.Drawing.Point(191, 279);
            this.StartSimulationButton.Name = "StartSimulationButton";
            this.StartSimulationButton.Size = new System.Drawing.Size(105, 46);
            this.StartSimulationButton.TabIndex = 2;
            this.StartSimulationButton.Text = "Запустить симуляцию";
            this.StartSimulationButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(191, 335);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CreateEventsListButton
            // 
            this.CreateEventsListButton.Location = new System.Drawing.Point(169, 139);
            this.CreateEventsListButton.Name = "CreateEventsListButton";
            this.CreateEventsListButton.Size = new System.Drawing.Size(150, 50);
            this.CreateEventsListButton.TabIndex = 4;
            this.CreateEventsListButton.Text = "Список событий";
            this.CreateEventsListButton.UseVisualStyleBackColor = true;
            // this.CreateEventsListButton.Click += new System.EventHandler(this.CreateEventsListButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(118, 239);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLabel.TabIndex = 5;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.CreateEventsListButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartSimulationButton);
            this.Controls.Add(this.StrategyChoosingButton);
            this.Controls.Add(this.StartConfigurationButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartConfigurationButton;
        private System.Windows.Forms.Button StrategyChoosingButton;
        private System.Windows.Forms.Button StartSimulationButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateEventsListButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}