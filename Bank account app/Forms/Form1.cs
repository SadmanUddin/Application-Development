using MySql.Data.MySqlClient;
using Bank_account_app.Models;
using Bank_account_app.Data;

namespace Bank_account_app.Forms
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
            //BankAccount bankAccount = new BankAccount("Sadman Uddin");
            //BankAccount bankAccount2 = new BankAccount("Irfan tahmid");
            //BankAccount bankAccount3 = new BankAccount("Sahal");
            //BankAccount bankAccount4 = new BankAccount("Fardin ahmed");
            //BankAccount bankAccount5 = new BankAccount("Milton");

            //bankAccounts.Add(bankAccount);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);
            //bankAccounts.Add(bankAccount4);

            //bankAccountGrid.DataSource=bankAccounts;


        }

        private void RefreshGrid()
        {
            bankAccountGrid.DataSource = null;
            bankAccountGrid.DataSource=bankAccounts;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void CreateAccountbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Ownertxt.Text))
            {
                return;
            }

            if (InteretRateNum.Value>0)
            {
                savingsaccount sc = new savingsaccount(Ownertxt.Text, InteretRateNum.Value);
                bankAccounts.Add(sc);

                SaveAccountToDatabase(sc);
            }
            else
            {
               BankAccount bankAccount = new BankAccount(Ownertxt.Text);
               bankAccounts.Add(bankAccount);
                SaveAccountToDatabase(bankAccount);
            }
            RefreshGrid();
            Ownertxt.Text = "";
            InteretRateNum.Value=0;

        }

        private void UpdateBalance(BankAccount acc)
        {
            using(var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE accounts SET Balance=@balance WHERE AccountNumber=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@balance", acc.Balance);
                    cmd.Parameters.AddWithValue("@id", acc.AccountNumber.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (bankAccountGrid.SelectedRows.Count==1 && Amountnum.Value>0)
            {
                BankAccount selectedBankAccount = bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string X = selectedBankAccount.deposit(Amountnum.Value);
                UpdateBalance(selectedBankAccount);
                RefreshGrid();
                Amountnum.Value = 0;
                MessageBox.Show(X);
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            BankAccount selectedBankAccount = bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
            string X = selectedBankAccount.withdraw(Amountnum.Value);
            UpdateBalance(selectedBankAccount);
            RefreshGrid();
            Amountnum.Value = 0;
            MessageBox.Show(X);

        }

        private void SaveAccountToDatabase(BankAccount acc)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO  accounts(AccountNumber,Owner,Balance,InterestRate) Values(@id,@owner,@balance,@rate)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", acc.AccountNumber.ToString());
                    cmd.Parameters.AddWithValue("@owner", acc.owner);
                    cmd.Parameters.AddWithValue("@balance", acc.Balance);

                    decimal rate = 0;
                    if (acc is savingsaccount s)
                    {
                        rate=s.interestrate;
                    }
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void LoadAccounts()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * From accounts";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string owner = reader.GetString("Owner");
                        decimal balance = reader.GetDecimal("Balance");
                        decimal rate = reader.GetDecimal("InterestRate");
                        BankAccount acc;

                        if (rate>0)
                        {
                            acc = new savingsaccount(owner, rate, balance);
                        }
                        else
                        {
                            acc=new BankAccount(owner, balance);
                        }
                        acc.AccountNumber=Guid.Parse(reader.GetString("AccountNumber"));
                        bankAccounts.Add(acc);
                    }
                }
            }
            RefreshGrid();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            LoadAccounts();
        }
        private void label4_Click(object sender, EventArgs e) { }
        

        private void InteretRateNum_ValueChanged(object sender, EventArgs e){}
    }
}
