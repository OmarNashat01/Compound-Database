
namespace DB_Project
{
    partial class Subscribe_in_a_Service
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
            this.Res_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dep_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Service_combobox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Res_id
            // 
            this.Res_id.Location = new System.Drawing.Point(117, 96);
            this.Res_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Res_id.Name = "Res_id";
            this.Res_id.Size = new System.Drawing.Size(121, 22);
            this.Res_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Residence_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Request Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dep_combobox
            // 
            this.Dep_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep_combobox.FormattingEnabled = true;
            this.Dep_combobox.Location = new System.Drawing.Point(117, 138);
            this.Dep_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dep_combobox.Name = "Dep_combobox";
            this.Dep_combobox.Size = new System.Drawing.Size(121, 24);
            this.Dep_combobox.TabIndex = 5;
            this.Dep_combobox.SelectedIndexChanged += new System.EventHandler(this.Dep_combobox_SelectedIndexChanged);
            this.Dep_combobox.Leave += new System.EventHandler(this.Dep_combobox_Leave);
            this.Dep_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dep_combobox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service";
            // 
            // Service_combobox
            // 
            this.Service_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Service_combobox.FormattingEnabled = true;
            this.Service_combobox.Location = new System.Drawing.Point(117, 190);
            this.Service_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Service_combobox.Name = "Service_combobox";
            this.Service_combobox.Size = new System.Drawing.Size(121, 24);
            this.Service_combobox.TabIndex = 7;
            this.Service_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Service_combobox_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Subscribe_in_a_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Service_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dep_combobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Res_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Subscribe_in_a_Service";
            this.Text = "Subscribe_in_a_Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Res_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Dep_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Service_combobox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}