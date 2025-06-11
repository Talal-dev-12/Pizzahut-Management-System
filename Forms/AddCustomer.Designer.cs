namespace Pizzahut_Management_System.Forms
{
    partial class AddCustomer
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
            PHONE = new Label();
            label3 = new Label();
            SALAD = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtName = new TextBox();
            TxtTax = new TextBox();
            TxtTotal = new TextBox();
            TxtDrink = new TextBox();
            TxtSalad = new TextBox();
            TxtPizza = new TextBox();
            TxtPhone = new TextBox();
            label8 = new Label();
            BtnBack = new Button();
            BtnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(265, 88);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "NAME :";
            // 
            // PHONE
            // 
            PHONE.AutoSize = true;
            PHONE.Font = new Font("Segoe UI", 9F);
            PHONE.Location = new Point(265, 137);
            PHONE.Name = "PHONE";
            PHONE.Size = new Size(65, 20);
            PHONE.TabIndex = 1;
            PHONE.Text = "PHONE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(265, 189);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "PIZZA :";
            // 
            // SALAD
            // 
            SALAD.AutoSize = true;
            SALAD.Font = new Font("Segoe UI", 9F);
            SALAD.Location = new Point(265, 244);
            SALAD.Name = "SALAD";
            SALAD.Size = new Size(62, 20);
            SALAD.TabIndex = 3;
            SALAD.Text = "SALAD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(265, 295);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "DRINK :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(265, 346);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "TAX :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(265, 402);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "TOTAL :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(332, 85);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(248, 27);
            TxtName.TabIndex = 7;
            // 
            // TxtTax
            // 
            TxtTax.Location = new Point(332, 343);
            TxtTax.Name = "TxtTax";
            TxtTax.Size = new Size(248, 27);
            TxtTax.TabIndex = 8;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(332, 399);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(248, 27);
            TxtTotal.TabIndex = 9;
            // 
            // TxtDrink
            // 
            TxtDrink.Location = new Point(332, 292);
            TxtDrink.Name = "TxtDrink";
            TxtDrink.Size = new Size(248, 27);
            TxtDrink.TabIndex = 10;
            // 
            // TxtSalad
            // 
            TxtSalad.Location = new Point(332, 241);
            TxtSalad.Name = "TxtSalad";
            TxtSalad.Size = new Size(248, 27);
            TxtSalad.TabIndex = 11;
            TxtSalad.TextChanged += textBox5_TextChanged;
            // 
            // TxtPizza
            // 
            TxtPizza.Location = new Point(332, 186);
            TxtPizza.Name = "TxtPizza";
            TxtPizza.Size = new Size(248, 27);
            TxtPizza.TabIndex = 12;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(332, 134);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(248, 27);
            TxtPhone.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(338, 32);
            label8.Name = "label8";
            label8.Size = new Size(188, 31);
            label8.TabIndex = 14;
            label8.Text = "ADD CUSTOMER";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(12, 402);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 15;
            BtnBack.Text = "BACK";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(694, 409);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 29);
            BtnAdd.TabIndex = 16;
            BtnAdd.Text = "ADD";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAdd);
            Controls.Add(BtnBack);
            Controls.Add(label8);
            Controls.Add(TxtPhone);
            Controls.Add(TxtPizza);
            Controls.Add(TxtSalad);
            Controls.Add(TxtDrink);
            Controls.Add(TxtTotal);
            Controls.Add(TxtTax);
            Controls.Add(TxtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SALAD);
            Controls.Add(label3);
            Controls.Add(PHONE);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label PHONE;
        private Label label3;
        private Label SALAD;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtName;
        private TextBox TxtTax;
        private TextBox TxtTotal;
        private TextBox TxtDrink;
        private TextBox TxtSalad;
        private TextBox TxtPizza;
        private TextBox TxtPhone;
        private Label label8;
        private Button BtnBack;
        private Button BtnAdd;
    }
}