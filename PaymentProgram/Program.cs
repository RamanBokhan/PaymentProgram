namespace PaymentProgram
{
    internal class Program
    {   

        static bool PrintCards(PaymentCard[] paymentCards) 
        {
        foreach (PaymentCard card in paymentCards) 
            {
            
            Console.WriteLine(card.GetFullInformation());
            
            }
            return true;

        }

        static void Main(string[] args)
         {
            PaymentCard Card1 = new PaymentCard("1234 1235 1245 1254", "02/25", "Vasia Pupkin", 666);
            PaymentCard Card2 = new PaymentCard("6666 1225 4569 1545", "05/24", "Levy Shtraus", 345);
            PaymentCard Card3 = new PaymentCard("1518 1551 1515 4844", "06/27", "Andrew Warhola", 564);
            PaymentCard Card4 = new PaymentCard("1515 4484 1544 3323", "04/25", "Pablo Picasso", 456);
            PaymentCard Card5 = new PaymentCard("5155 8875 4848 4848", "08/25", "Vincent van Gogh", 358);

            PaymentCard[] paymentCards = new PaymentCard[] { Card1, Card2, Card3, Card4, Card5 };

            PrintCards(paymentCards);
        }
    }
}