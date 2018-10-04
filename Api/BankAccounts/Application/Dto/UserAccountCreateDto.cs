
using EnterprisePatterns.Api.Common.Application.Enum;
using System;

namespace EnterprisePatterns.Api.BankAccounts.Application.Dto
{
    public class UserAccountCreateDto
    {
        public string Number { get; set; }
        public Decimal Balance { get; set; }
        public Currency Currency { get; set; }
        public bool Locked { get; set; }
        public long CustomerId { get; set; }

        public UserAccountCreateDto()
        {
            Locked = false;
        }
    }
}
