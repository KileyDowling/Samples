using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;


namespace SGFlooringCorp.BLL
{
    public class TaxOperations
    {
        private IStateTaxRepository _taxRepository;

        public TaxOperations(IStateTaxRepository myRepo)
        {
            _taxRepository = myRepo;
        }

        public List<StateTax> ListAll()
        {
            return _taxRepository.ListAll();
        }

        public decimal GetRate(string stateAbbreviation)
        {
            var allStates = _taxRepository.ListAll();
            var state = allStates.First(s => s.StateAbbreviation == stateAbbreviation);

            return state.TaxRate;
        }

        public bool IsValidState(string stateAbbreviation)
        {
            var allStates = _taxRepository.ListAll();
            return allStates.Any(s => s.StateAbbreviation == stateAbbreviation);
        }

        public Response<Order> GetTax(OrderRequest orderRequest)
        {
            var response = new Response<Order>();
            
            bool validState = IsValidState(orderRequest.Order.StateAbbreviation);
            try
            {

                if (validState)
                {
                    orderRequest.Order.TaxRate = GetRate(orderRequest.Order.StateAbbreviation);
                    response.Success = true;
                    response.Data = orderRequest.Order;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Invalid state entered";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
