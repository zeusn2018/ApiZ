




using Microsoft.AspNetCore.Mvc;
using EnterprisePatterns.Api.BankAccounts.Application.Dto;
using Microsoft.AspNetCore.Http;
using EnterprisePatterns.Api.BankAccounts.Application.Assembler;
using EnterprisePatterns.Api.BankAccounts.Domain.Entity;
using EnterprisePatterns.Api.BankAccounts.Domain.Repository;
using EnterprisePatterns.Api.Common.Application.Dto;
using System;
using EnterprisePatterns.Api.Common.Application;


namespace EnterprisePatterns.Api.Controllers
{
    [Route("v1/customers/{customerId}/bank-accounts")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly BankAccountCreateAssembler _bankAccountCreateAssembler;

        public UserAccountsController(
            IUnitOfWork unitOfWork,
            IBankAccountRepository bankAccountRepository,
            BankAccountCreateAssembler bankAccountCreateAssembler)
        {
            _unitOfWork = unitOfWork;
            _bankAccountRepository = bankAccountRepository;
            _bankAccountCreateAssembler = bankAccountCreateAssembler;
        }

        [HttpPost]
        public IActionResult Create(long customerId, [FromBody] UserAccountCreateDto userAccountCreateDto)
        {
            bool uowStatus = false;
            try
            {
                uowStatus = _unitOfWork.BeginTransaction();
                userAccountCreateDto.CustomerId = customerId;
                //TODO: Validations with Notification Pattern
                UserAccount userAccount = _userAccountCreateAssembler.toEntity(userAccountCreateDto);
                _bankAccountRepository.Create(bankAccount);
                _unitOfWork.Commit(uowStatus);
                return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("BankAccount Created!"));
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                Console.WriteLine(ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponseDto("Internal Server Error"));

            }
        }
    }
}
