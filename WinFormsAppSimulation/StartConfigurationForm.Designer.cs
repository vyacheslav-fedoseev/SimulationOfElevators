
namespace WinFormsAppSimulation
{
    partial class StartConfigurationForm
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
            this.ImportButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SetConfigurationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Enabled = false;
            this.ImportButton.Location = new System.Drawing.Point(12, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(150, 50);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Импортировать конфигурацию";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(224, 215);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(66, 34);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(12, 68);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(150, 50);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Экспортировать конфигурацию";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // SetConfigurationButton
            // 
            this.SetConfigurationButton.Location = new System.Drawing.Point(12, 124);
            this.SetConfigurationButton.Name = "SetConfigurationButton";
            this.SetConfigurationButton.Size = new System.Drawing.Size(150, 50);
            this.SetConfigurationButton.TabIndex = 3;
            this.SetConfigurationButton.Text = "Задать Кофигурацию Вручную";
            this.SetConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // StartConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 261);
            this.Controls.Add(this.SetConfigurationButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ImportButton);
            this.Name = "StartConfigurationForm";
            this.Text = "Главное окно конфигурации";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button SetConfigurationButton;
    }
}