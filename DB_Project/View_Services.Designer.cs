
namespace DB_Project
{
    partial class View_Services
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
            this.Services_Grid = new System.Windows.Forms.DataGridView();
            this.Dep_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Services_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Services_Grid
            // 
            this.Services_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_Grid.Location = new System.Drawing.Point(413, 126);
            this.Services_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Services_Grid.Name = "Services_Grid";
            this.Services_Grid.RowHeadersWidth = 51;
            this.Services_Grid.RowTemplate.Height = 24;
            this.Services_Grid.Size = new System.Drawing.Size(372, 298);
            this.Services_Grid.TabIndex = 0;
            // 
            // Dep_combobox
            // 
            this.Dep_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep_combobox.FormattingEnabled = true;
            this.Dep_combobox.Location = new System.Drawing.Point(16, 197);
            this.Dep_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.Dep_combobox.Name = "Dep_combobox";
            this.Dep_combobox.Size = new System.Drawing.Size(213, 24);
            this.Dep_combobox.TabIndex = 1;
            this.Dep_combobox.SelectionChangeCommitted += new System.EventHandler(this.Dep_combobox_SelectionChangeCommitted);
            this.Dep_combobox.SelectedValueChanged += new System.EventHandler(this.Dep_combobox_SelectedValueChanged);
            this.Dep_combobox.Leave += new System.EventHandler(this.Dep_combobox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a department to \r\ndisplay its services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Services we offer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Linen;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(13, 13);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 49);
            this.button6.TabIndex = 13;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // View_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dep_combobox);
            this.Controls.Add(this.Services_Grid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_Services";
            this.Text = "View_Services";
            this.Load += new System.EventHandler(this.View_Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Services_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Services_Grid;
        private System.Windows.Forms.ComboBox Dep_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}