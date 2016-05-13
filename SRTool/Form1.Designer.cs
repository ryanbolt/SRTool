namespace SRTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nstTimePicker = new System.Windows.Forms.DateTimePicker();
            this.utcTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pstTimePicker = new System.Windows.Forms.DateTimePicker();
            this.convert = new System.Windows.Forms.Button();
            this.nstRadioButton = new System.Windows.Forms.RadioButton();
            this.utcRadioButton = new System.Windows.Forms.RadioButton();
            this.pstRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UTC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PST";
            // 
            // nstTimePicker
            // 
            this.nstTimePicker.Enabled = false;
            this.nstTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.nstTimePicker.Location = new System.Drawing.Point(153, 101);
            this.nstTimePicker.Name = "nstTimePicker";
            this.nstTimePicker.ShowUpDown = true;
            this.nstTimePicker.Size = new System.Drawing.Size(109, 22);
            this.nstTimePicker.TabIndex = 3;
            // 
            // utcTimePicker
            // 
            this.utcTimePicker.Enabled = false;
            this.utcTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.utcTimePicker.Location = new System.Drawing.Point(153, 216);
            this.utcTimePicker.Name = "utcTimePicker";
            this.utcTimePicker.ShowUpDown = true;
            this.utcTimePicker.Size = new System.Drawing.Size(109, 22);
            this.utcTimePicker.TabIndex = 4;
            // 
            // pstTimePicker
            // 
            this.pstTimePicker.Enabled = false;
            this.pstTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pstTimePicker.Location = new System.Drawing.Point(153, 161);
            this.pstTimePicker.Name = "pstTimePicker";
            this.pstTimePicker.ShowUpDown = true;
            this.pstTimePicker.Size = new System.Drawing.Size(109, 22);
            this.pstTimePicker.TabIndex = 5;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(153, 279);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 6;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // nstRadioButton
            // 
            this.nstRadioButton.AutoSize = true;
            this.nstRadioButton.Location = new System.Drawing.Point(58, 101);
            this.nstRadioButton.Name = "nstRadioButton";
            this.nstRadioButton.Size = new System.Drawing.Size(17, 16);
            this.nstRadioButton.TabIndex = 13;
            this.nstRadioButton.TabStop = true;
            this.nstRadioButton.UseVisualStyleBackColor = true;
            this.nstRadioButton.Click += new System.EventHandler(this.Enable_Boxes);
            // 
            // utcRadioButton
            // 
            this.utcRadioButton.AutoSize = true;
            this.utcRadioButton.Location = new System.Drawing.Point(58, 216);
            this.utcRadioButton.Name = "utcRadioButton";
            this.utcRadioButton.Size = new System.Drawing.Size(17, 16);
            this.utcRadioButton.TabIndex = 12;
            this.utcRadioButton.TabStop = true;
            this.utcRadioButton.UseVisualStyleBackColor = true;
            this.utcRadioButton.Click += new System.EventHandler(this.Enable_Boxes);
            // 
            // pstRadioButton
            // 
            this.pstRadioButton.AutoSize = true;
            this.pstRadioButton.Location = new System.Drawing.Point(58, 161);
            this.pstRadioButton.Name = "pstRadioButton";
            this.pstRadioButton.Size = new System.Drawing.Size(17, 16);
            this.pstRadioButton.TabIndex = 11;
            this.pstRadioButton.TabStop = true;
            this.pstRadioButton.UseVisualStyleBackColor = true;
            this.pstRadioButton.Click += new System.EventHandler(this.Enable_Boxes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 576);
            this.Controls.Add(this.pstRadioButton);
            this.Controls.Add(this.utcRadioButton);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.nstRadioButton);
            this.Controls.Add(this.pstTimePicker);
            this.Controls.Add(this.utcTimePicker);
            this.Controls.Add(this.nstTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker nstTimePicker;
        private System.Windows.Forms.DateTimePicker utcTimePicker;
        private System.Windows.Forms.DateTimePicker pstTimePicker;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.RadioButton nstRadioButton;
        private System.Windows.Forms.RadioButton utcRadioButton;
        private System.Windows.Forms.RadioButton pstRadioButton;
    }
}

