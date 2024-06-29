using DevLibraryMads.Payments.API.Models.Entities;
using DevLibraryMads.Payments.API.Models.Enums;

namespace DevLibraryMads.Payments.API.Service
{
    public class PaymentsService : IPaymentsService
    {
        public Task<bool> Process(PaymentsDTO paymentsDTO)
        {
            bool statusPayment = false;
            var msgRetorno = "Autorizado";

            if(paymentsDTO != null)
            {

                paymentsDTO.UpdateStatusPayments(msgRetorno);

                if (paymentsDTO.StatusPayments == StatusPaymentsEnum.Success)
                    statusPayment = true;
                else
                    statusPayment = false;
            }


            return Task.FromResult(statusPayment);
        }
    }
}
