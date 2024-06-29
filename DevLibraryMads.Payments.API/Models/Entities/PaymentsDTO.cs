using DevLibraryMads.Payments.API.Models.Enums;

namespace DevLibraryMads.Payments.API.Models.Entities
{
    public class PaymentsDTO
    {
        public int IdOrder { get; set; }
        public string CardNumber { get; set; }
        public string DtExpired { get; set; }
        public string FullName { get; set; }
        public decimal Account { get; set; }
        public StatusPaymentsEnum StatusPayments { get; set; }

        public void UpdateStatusPayments(string msgRetorno)
        {
            if (msgRetorno == "Autorizado")
                StatusPayments = StatusPaymentsEnum.Success;
            else
                StatusPayments = StatusPaymentsEnum.Failed;
        }
    }
}
