namespace BullsAndCows
{
    partial class Form1
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.Compare_button = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.N_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.genNewNumber = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(12, 165);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(75, 20);
            this.inputTextbox.TabIndex = 0;
            // 
            // Compare_button
            // 
            this.Compare_button.Location = new System.Drawing.Point(12, 191);
            this.Compare_button.Name = "Compare_button";
            this.Compare_button.Size = new System.Drawing.Size(75, 23);
            this.Compare_button.TabIndex = 1;
            this.Compare_button.Text = "Сравнить";
            this.Compare_button.UseVisualStyleBackColor = true;
            this.Compare_button.Click += new System.EventHandler(this.Compare_button_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(93, 12);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(217, 231);
            this.logTextbox.TabIndex = 2;
            // 
            // N_textbox
            // 
            this.N_textbox.Location = new System.Drawing.Point(12, 29);
            this.N_textbox.Name = "N_textbox";
            this.N_textbox.Size = new System.Drawing.Size(75, 20);
            this.N_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол-во цифр";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(12, 220);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 5;
            this.Clear_button.Text = "Сброс";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // genNewNumber
            // 
            this.genNewNumber.Location = new System.Drawing.Point(12, 55);
            this.genNewNumber.Name = "genNewNumber";
            this.genNewNumber.Size = new System.Drawing.Size(75, 34);
            this.genNewNumber.TabIndex = 6;
            this.genNewNumber.Text = "Загадать число";
            this.genNewNumber.UseVisualStyleBackColor = true;
            this.genNewNumber.Click += new System.EventHandler(this.genNewNumber_Click);
            // 
            // status_label
            // 
            this.status_label.Location = new System.Drawing.Point(12, 96);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(75, 33);
            this.status_label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 257);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.genNewNumber);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N_textbox);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.Compare_button);
            this.Controls.Add(this.inputTextbox);
            this.Name = "Form1";
            this.Text = "BullsAndCows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button Compare_button;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.TextBox N_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button genNewNumber;
        private System.Windows.Forms.Label status_label;
    }
}

