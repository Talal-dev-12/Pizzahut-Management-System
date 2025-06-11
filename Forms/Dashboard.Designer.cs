namespace Pizzahut_Management_System.Forms
{
    partial class Dashboard
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
            label1 = new Label();
            BtnAddCustomer = new Button();
            BtnSearchCustomer = new Button();
            BtnUpdateCustomer = new Button();
            BtnDeleteCustomer = new Button();
            BtnDisplayData = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 35);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.Location = new Point(14, 77);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(155, 39);
            BtnAddCustomer.TabIndex = 1;
            BtnAddCustomer.Text = "Add Customer";
            BtnAddCustomer.UseVisualStyleBackColor = true;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // BtnSearchCustomer
            // 
            BtnSearchCustomer.Location = new Point(14, 132);
            BtnSearchCustomer.Name = "BtnSearchCustomer";
            BtnSearchCustomer.Size = new Size(155, 38);
            BtnSearchCustomer.TabIndex = 2;
            BtnSearchCustomer.Text = "Search Customer";
            BtnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateCustomer
            // 
            BtnUpdateCustomer.Location = new Point(14, 183);
            BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            BtnUpdateCustomer.Size = new Size(155, 38);
            BtnUpdateCustomer.TabIndex = 3;
            BtnUpdateCustomer.Text = "Update Customer";
            BtnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCustomer
            // 
            BtnDeleteCustomer.Location = new Point(14, 236);
            BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            BtnDeleteCustomer.Size = new Size(155, 38);
            BtnDeleteCustomer.TabIndex = 4;
            BtnDeleteCustomer.Text = "Delete Customer";
            BtnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnDisplayData
            // 
            BtnDisplayData.Location = new Point(14, 282);
            BtnDisplayData.Name = "BtnDisplayData";
            BtnDisplayData.Size = new Size(155, 38);
            BtnDisplayData.TabIndex = 5;
            BtnDisplayData.Text = "Display Customers";
            BtnDisplayData.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BtnDisplayData);
            panel1.Controls.Add(BtnDeleteCustomer);
            panel1.Controls.Add(BtnAddCustomer);
            panel1.Controls.Add(BtnUpdateCustomer);
            panel1.Controls.Add(BtnSearchCustomer);
            panel1.Location = new Point(-2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 452);
            panel1.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAddCustomer;
        private Button BtnSearchCustomer;
        private Button BtnUpdateCustomer;
        private Button BtnDeleteCustomer;
        private Button BtnDisplayData;
        private Panel panel1;
    }
}