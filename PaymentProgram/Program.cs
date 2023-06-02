using PaymentProgram.Comparers;
using PaymentProgram.PaymentMeans;

namespace PaymentProgram
{
    internal class Program
    {   

        static void Main(string[] args)
         {
            Address address1 = new Address("Minsk", "Chapaeva", "8A", "44");
            Address address2 = new Address("Grodno", "Sovetskaya", "10", "2");
            Address address3 = new Address("Brest", "Lenina", "5", "78");
            Address address4 = new Address("Vitebsk", "Pobedy", "20", "13");
            Address address5 = new Address("Vitebsk", "Kosmonavtov", "3", "34");

            BankClient bankClient1 = new BankClient("Vasia", "Pupkin", address1);
            BankClient bankClient2 = new BankClient("Petr", "Ivanov", address2);
            BankClient bankClient3 = new BankClient("Ivan", "Petrov", address3);
            BankClient bankClient4 = new BankClient("Svetlana", "Sidorova", address4);
            BankClient bankClient5 = new BankClient("Olga", "Nikitina", address5);

            CardExpDate cardExpDate1 = new CardExpDate(10, 23);
            CardExpDate cardExpDate2 = new CardExpDate(04, 25);
            CardExpDate cardExpDate3 = new CardExpDate(12, 25);
            CardExpDate cardExpDate4 = new CardExpDate(06, 24);
            CardExpDate cardExpDate5 = new CardExpDate(08, 26);

            bankClient1.AddPaymentMean(new DebetCard("1234 1235 1245 1254", cardExpDate1, 325, 1000f, 0.05f));
            bankClient1.AddPaymentMean(new BitCoin(2000f));
            bankClient1.AddPaymentMean(new Cash(250f));
            bankClient1.AddPaymentMean(new CashBackCard("6666 1225 4569 1545", cardExpDate2, 924, 666f, 0.02f));
            bankClient1.AddPaymentMean(new CreditCard("1518 1551 1515 4844", cardExpDate3, 854, 500f, 0.05f, 3000));

            // Task 02:
            bankClient2.AddPaymentMean(new DebetCard("1515 4544 8787 1545", cardExpDate2, 999, 2500f, 0.05f));
            bankClient2.AddPaymentMean(new BitCoin(600f));
            bankClient3.AddPaymentMean(new Cash(500f));
            bankClient3.AddPaymentMean(new CashBackCard("1515 4544 5454 8787", cardExpDate3, 565, 700f, 0.02f));
            bankClient3.AddPaymentMean(new CreditCard("4545 4548 4877 5151", cardExpDate4, 888, 999f, 0.05f, 200f));

            List<BankClient> clients = new List<BankClient> { bankClient1, bankClient2, bankClient3 };

            clients.Sort(new ClientNameComparer());
            clients.Sort(new AddressComparer());
            clients.Sort(new CountCardComparer());
            clients.Sort(new AmountOfMoney());
            clients.Sort(new MaxOfMoneyComparer());


            bankClient1.Pay(125f);
            bankClient1.Pay(500f);
            bankClient1.Pay(1050f);
            bankClient1.Pay(1800f);
            bankClient1.Pay(700f);




            Console.WriteLine(bankClient1 + " \n" + bankClient1.GetPaymentMean());
        }
    }
}