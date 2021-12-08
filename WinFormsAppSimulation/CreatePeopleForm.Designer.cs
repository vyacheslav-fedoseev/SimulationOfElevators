
namespace WinFormsAppSimulation
{
    partial class CreatePeopleForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PeopleCountTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFloorTextBox = new System.Windows.Forms.TextBox();
            this.CurrentFloorTextBox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(100, 171);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество человек :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "На каком этаже:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Этаж назначения :";
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(191, 42);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.Size = new System.Drawing.Size(41, 20);
            this.PeopleCountTextBox.TabIndex = 4;
            // 
            // DestinationFloorTextBox
            // 
            this.DestinationFloorTextBox.Location = new System.Drawing.Point(191, 100);
            this.DestinationFloorTextBox.Name = "DestinationFloorTextBox";
            this.DestinationFloorTextBox.Size = new System.Drawing.Size(41, 20);
            this.DestinationFloorTextBox.TabIndex = 5;
            // 
            // CurrentFloorTextBox
            // 
            this.CurrentFloorTextBox.Location = new System.Drawing.Point(191, 74);
            this.CurrentFloorTextBox.Name = "CurrentFloorTextBox";
            this.CurrentFloorTextBox.Size = new System.Drawing.Size(41, 20);
            this.CurrentFloorTextBox.TabIndex = 6;
            // 
            // ErrorMessageLebel
            // 
            this.ErrorMessageLebel.AutoSize = true;
            this.ErrorMessageLebel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLebel.Location = new System.Drawing.Point(62, 137);
            this.ErrorMessageLebel.Name = "ErrorMessageLebel";
            this.ErrorMessageLebel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLebel.TabIndex = 7;
            // 
            // CreatePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 219);
            this.Controls.Add(this.ErrorMessageLebel);
            this.Controls.Add(this.CurrentFloorTextBox);
            this.Controls.Add(this.DestinationFloorTextBox);
            this.Controls.Add(this.PeopleCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Name = "CreatePeopleForm";
            this.Text = "Создание группы людей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PeopleCountTextBox;
        private System.Windows.Forms.TextBox DestinationFloorTextBox;
        private System.Windows.Forms.TextBox CurrentFloorTextBox;
        private System.Windows.Forms.Label ErrorMessageLebel;
    }
}