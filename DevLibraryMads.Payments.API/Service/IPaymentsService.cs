using DevLibraryMads.Payments.API.Models.Entities;

namespace DevLibraryMads.Payments.API.Service
{
    public interface IPaymentsService
    {
        public Task<bool> Process(PaymentsDTO paymentsDTO);
    }
}
