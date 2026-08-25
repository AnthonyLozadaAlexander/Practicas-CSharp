namespace PrincipiosPOO.Constructores
{
    public class BankAccount
    {
        public int accountNumber => AccountNumber; // el atributo accountNumber toma la referencia de AccountNumber, que es privado y solo puede ser modificado por el constructor

        public string Owner => _owner; // el atributo Owner toma la referencia de _owner, que es privado y solo puede ser modificado por el constructor

        private string _owner;

        public decimal Amount { get; set; } // monto

        public bool isActive { get; set; }

        private int AccountNumber;

        public BankAccount(string name)
        {
            isActive = true;
            var random = new Random();
            AccountNumber = random.Next(); // genera un numero de cuenta aleatorio
            _owner = name;
        }

        public BankAccount()
        {
            _owner = "Francisco Perez";
            isActive = true;
        }


    }
}