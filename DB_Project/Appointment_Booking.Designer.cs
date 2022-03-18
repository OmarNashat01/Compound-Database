
namespace DB_Project
{
    partial class Appointment_Booking
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Residence_ID_textbox = new System.Windows.Forms.TextBox();
            this.Department_combobox = new System.Windows.Forms.ComboBox();
            this.Service_combobox = new System.Windows.Forms.ComboBox();
            this.Appointment_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.Appointment_Time_Picker = new System.Windows.Forms.DateTimePicker();
            this.Submit_Appointment_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Residence ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Appointment Time";
            // 
            // Residence_ID_textbox
            // 
            this.Residence_ID_textbox.Location = new System.Drawing.Point(225, 103);
            this.Residence_ID_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Residence_ID_textbox.Name = "Residence_ID_textbox";
            this.Residence_ID_textbox.Size = new System.Drawing.Size(180, 22);
            this.Residence_ID_textbox.TabIndex = 5;
            this.Residence_ID_textbox.TextChanged += new System.EventHandler(this.Residence_ID_textbox_TextChanged);
            this.Residence_ID_textbox.Leave += new System.EventHandler(this.Residence_ID_textbox_Leave);
            // 
            // Department_combobox
            // 
            this.Department_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_combobox.FormattingEnabled = true;
            this.Department_combobox.Location = new System.Drawing.Point(225, 153);
            this.Department_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Department_combobox.Name = "Department_combobox";
            this.Department_combobox.Size = new System.Drawing.Size(160, 24);
            this.Department_combobox.TabIndex = 6;
            this.Department_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Department_combobox_MouseClick);
            // 
            // Service_combobox
            // 
            this.Service_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Service_combobox.FormattingEnabled = true;
            this.Service_combobox.Location = new System.Drawing.Point(225, 191);
            this.Service_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Service_combobox.Name = "Service_combobox";
            this.Service_combobox.Size = new System.Drawing.Size(160, 24);
            this.Service_combobox.TabIndex = 7;
            this.Service_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Service_combobox_MouseClick);
            // 
            // Appointment_Date_Picker
            // 
            this.Appointment_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Appointment_Date_Picker.Location = new System.Drawing.Point(225, 238);
            this.Appointment_Date_Picker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Appointment_Date_Picker.Name = "Appointment_Date_Picker";
            this.Appointment_Date_Picker.Size = new System.Drawing.Size(141, 22);
            this.Appointment_Date_Picker.TabIndex = 8;
            // 
            // Appointment_Time_Picker
            // 
            this.Appointment_Time_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Appointment_Time_Picker.Location = new System.Drawing.Point(225, 284);
            this.Appointment_Time_Picker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Appointment_Time_Picker.Name = "Appointment_Time_Picker";
            this.Appointment_Time_Picker.Size = new System.Drawing.Size(141, 22);
            this.Appointment_Time_Picker.TabIndex = 9;
            // 
            // Submit_Appointment_Button
            // 
            this.Submit_Appointment_Button.Location = new System.Drawing.Point(57, 375);
            this.Submit_Appointment_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Submit_Appointment_Button.Name = "Submit_Appointment_Button";
            this.Submit_Appointment_Button.Size = new System.Drawing.Size(269, 85);
            this.Submit_Appointment_Button.TabIndex = 10;
            this.Submit_Appointment_Button.Text = "Book Appointment";
            this.Submit_Appointment_Button.UseVisualStyleBackColor = true;
            this.Submit_Appointment_Button.Click += new System.EventHandler(this.Submit_Appointment_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(27, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Appointment_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit_Appointment_Button);
            this.Controls.Add(this.Appointment_Time_Picker);
            this.Controls.Add(this.Appointment_Date_Picker);
            this.Controls.Add(this.Service_combobox);
            this.Controls.Add(this.Department_combobox);
            this.Controls.Add(this.Residence_ID_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Appointment_Booking";
            this.Text = "Appointment_Booking";
            this.Load += new System.EventHandler(this.Appointment_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Residence_ID_textbox;
        private System.Windows.Forms.ComboBox Department_combobox;
        private System.Windows.Forms.ComboBox Service_combobox;
        private System.Windows.Forms.DateTimePicker Appointment_Date_Picker;
        private System.Windows.Forms.DateTimePicker Appointment_Time_Picker;
        private System.Windows.Forms.Button Submit_Appointment_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}