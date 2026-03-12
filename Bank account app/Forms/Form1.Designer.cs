namespace Bank_account_app.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Ownertxt = new TextBox();
            Amountnum = new NumericUpDown();
            bankAccountGrid = new DataGridView();
            DepositButton = new Button();
            WithdrawButton = new Button();
            CreateAccountbtn = new Button();
            label3 = new Label();
            label4 = new Label();
            InteretRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Amountnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InteretRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 367);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // Ownertxt
            // 
            Ownertxt.Location = new Point(152, 71);
            Ownertxt.Name = "Ownertxt";
            Ownertxt.Size = new Size(156, 23);
            Ownertxt.TabIndex = 2;
            Ownertxt.TextChanged += textBox1_TextChanged;
            // 
            // Amountnum
            // 
            Amountnum.Location = new Point(166, 374);
            Amountnum.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            Amountnum.Minimum = new decimal(new int[] { -727379969, 232, 0, int.MinValue });
            Amountnum.Name = "Amountnum";
            Amountnum.Size = new Size(153, 23);
            Amountnum.TabIndex = 3;
            // 
            // bankAccountGrid
            // 
            bankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankAccountGrid.Location = new Point(329, 71);
            bankAccountGrid.Name = "bankAccountGrid";
            bankAccountGrid.Size = new Size(459, 244);
            bankAccountGrid.TabIndex = 4;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(329, 321);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(224, 30);
            DepositButton.TabIndex = 5;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(559, 321);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(229, 30);
            WithdrawButton.TabIndex = 6;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // CreateAccountbtn
            // 
            CreateAccountbtn.Location = new Point(152, 158);
            CreateAccountbtn.Name = "CreateAccountbtn";
            CreateAccountbtn.Size = new Size(156, 30);
            CreateAccountbtn.TabIndex = 7;
            CreateAccountbtn.Text = "Create account";
            CreateAccountbtn.UseVisualStyleBackColor = true;
            CreateAccountbtn.Click += CreateAccountbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 109);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(130, 30);
            label4.TabIndex = 9;
            label4.Text = "Interest rate:";
            label4.Click += label4_Click;
            // 
            // InteretRateNum
            // 
            InteretRateNum.Location = new Point(152, 119);
            InteretRateNum.Name = "InteretRateNum";
            InteretRateNum.Size = new Size(120, 23);
            InteretRateNum.TabIndex = 11;
            InteretRateNum.ValueChanged += InteretRateNum_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(InteretRateNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CreateAccountbtn);
            Controls.Add(WithdrawButton);
            Controls.Add(DepositButton);
            Controls.Add(bankAccountGrid);
            Controls.Add(Amountnum);
            Controls.Add(Ownertxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Amountnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InteretRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Ownertxt;
        private NumericUpDown Amountnum;
        private DataGridView bankAccountGrid;
        private Button DepositButton;
        private Button WithdrawButton;
        private Button CreateAccountbtn;
        private Label label3;
        private Label label4;
        private NumericUpDown InteretRateNum;
    }
}
