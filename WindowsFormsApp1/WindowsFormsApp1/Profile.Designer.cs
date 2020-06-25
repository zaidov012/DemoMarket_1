namespace WindowsFormsApp1
{
    partial class Profile
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAddBalance.FlatAppearance.BorderSize = 0;
            this.buttonAddBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBalance.Location = new System.Drawing.Point(24, 134);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(146, 42);
            this.buttonAddBalance.TabIndex = 0;
            this.buttonAddBalance.Text = "Add To Balance";
            this.buttonAddBalance.UseVisualStyleBackColor = false;
            this.buttonAddBalance.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add";
            // 
            // textBoxAddBalance
            // 
            this.textBoxAddBalance.Location = new System.Drawing.Point(44, 98);
            this.textBoxAddBalance.Name = "textBoxAddBalance";
            this.textBoxAddBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddBalance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AZN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balance:";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(89, 65);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(31, 13);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "AZN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(24, 370);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 42);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartButton.Location = new System.Drawing.Point(330, 370);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(146, 42);
            this.cartButton.TabIndex = 0;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(642, 192);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(146, 42);
            this.buttonBuy.TabIndex = 0;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxAddBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonAddBalance);
            this.Name = "Profile";
            this.Text = "Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button buttonBuy;
    }
}

