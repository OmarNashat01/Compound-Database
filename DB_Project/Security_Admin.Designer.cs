
namespace DB_Project
{
    partial class Security_Admin
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
            this.Visitors_datagrid = new System.Windows.Forms.DataGridView();
            this.Residence_ID_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mark_As_Left_btn = new System.Windows.Forms.Button();
            this.Show_Visitors_btn = new System.Windows.Forms.Button();
            this.Show_Emergency_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Visitors_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = " Security Admin";
            // 
            // Visitors_datagrid
            // 
            this.Visitors_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visitors_datagrid.Location = new System.Drawing.Point(116, 92);
            this.Visitors_datagrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Visitors_datagrid.Name = "Visitors_datagrid";
            this.Visitors_datagrid.RowHeadersWidth = 51;
            this.Visitors_datagrid.Size = new System.Drawing.Size(819, 322);
            this.Visitors_datagrid.TabIndex = 5;
            // 
            // Residence_ID_textbox
            // 
            this.Residence_ID_textbox.Location = new System.Drawing.Point(265, 473);
            this.Residence_ID_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Residence_ID_textbox.Name = "Residence_ID_textbox";
            this.Residence_ID_textbox.Size = new System.Drawing.Size(177, 22);
            this.Residence_ID_textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 476);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Residence ID";
            // 
            // Mark_As_Left_btn
            // 
            this.Mark_As_Left_btn.Location = new System.Drawing.Point(519, 463);
            this.Mark_As_Left_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mark_As_Left_btn.Name = "Mark_As_Left_btn";
            this.Mark_As_Left_btn.Size = new System.Drawing.Size(161, 42);
            this.Mark_As_Left_btn.TabIndex = 8;
            this.Mark_As_Left_btn.Text = "Mark visitors as left";
            this.Mark_As_Left_btn.UseVisualStyleBackColor = true;
            this.Mark_As_Left_btn.Click += new System.EventHandler(this.Mark_As_Left_btn_Click);
            // 
            // Show_Visitors_btn
            // 
            this.Show_Visitors_btn.Location = new System.Drawing.Point(951, 116);
            this.Show_Visitors_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_Visitors_btn.Name = "Show_Visitors_btn";
            this.Show_Visitors_btn.Size = new System.Drawing.Size(100, 106);
            this.Show_Visitors_btn.TabIndex = 9;
            this.Show_Visitors_btn.Text = "Show Visitors";
            this.Show_Visitors_btn.UseVisualStyleBackColor = true;
            this.Show_Visitors_btn.Click += new System.EventHandler(this.Show_Visitors_btn_Click);
            // 
            // Show_Emergency_btn
            // 
            this.Show_Emergency_btn.Location = new System.Drawing.Point(951, 252);
            this.Show_Emergency_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_Emergency_btn.Name = "Show_Emergency_btn";
            this.Show_Emergency_btn.Size = new System.Drawing.Size(100, 106);
            this.Show_Emergency_btn.TabIndex = 10;
            this.Show_Emergency_btn.Text = "Show Emergency";
            this.Show_Emergency_btn.UseVisualStyleBackColor = true;
            this.Show_Emergency_btn.Click += new System.EventHandler(this.Show_Emergency_btn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Linen;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(919, 13);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 49);
            this.button6.TabIndex = 11;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Security_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Show_Emergency_btn);
            this.Controls.Add(this.Show_Visitors_btn);
            this.Controls.Add(this.Mark_As_Left_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Residence_ID_textbox);
            this.Controls.Add(this.Visitors_datagrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Security_Admin";
            this.Text = "Security_Admin";
            this.Load += new System.EventHandler(this.Security_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Visitors_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Visitors_datagrid;
        private System.Windows.Forms.TextBox Residence_ID_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mark_As_Left_btn;
        private System.Windows.Forms.Button Show_Visitors_btn;
        private System.Windows.Forms.Button Show_Emergency_btn;
        private System.Windows.Forms.Button button6;
    }
}