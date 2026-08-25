namespace PrincipiosPOO.Constructores
{
    public class BankAccount
    {
        public int accountNumber { get; set; } // numero de cuenta

        public string Owner => _owner;

        private string _owner;

        public decimal Amount { get; set; } // monto

        public bool isActive { get; set; }

        public BankAccount(string name)
        {
            _owner = name;
        }

        public BankAccount()
        {
            _owner = "Francisco Perez";
        }


    }
}