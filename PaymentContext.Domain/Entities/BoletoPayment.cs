using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            DateTime paidDate,
            DateTime expireDate,
            string payer,
            Document document,
            decimal total,
            decimal totalPaid,
            string address,
            Email email,
            string barcode,
            string boletoNumber) : base(
                paidDate,
                expireDate,
                payer,
                document,
                total,
                totalPaid,
                address,
                email)
        {
            Barcode = barcode;
            BoletoNumber = boletoNumber;
        }

        public string Barcode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

}