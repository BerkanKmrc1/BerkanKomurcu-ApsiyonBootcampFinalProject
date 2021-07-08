
using ApartmentManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Interfaces
{
    public interface ICreditCardService
    {
        Task<bool> WithdrawMoney(CreditCardDto creditCard);
    }
}
