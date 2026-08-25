namespace PrincipiosPOO.Constructores
{
    public class BankAccount
    {
        public string Owner { get; set; }

        public BankAccount(string name)
        {
            Owner = name;
        }

        public BankAccount()
        {
            Owner = "Francisco Perez";
        }
    }
}