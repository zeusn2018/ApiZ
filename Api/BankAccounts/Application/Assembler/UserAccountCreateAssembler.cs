
using AutoMapper;
using EnterprisePatterns.Api.BankAccounts.Application.Dto;
using EnterprisePatterns.Api.BankAccounts.Domain.Entity;


namespace EnterprisePatterns.Api.BankAccounts.Application.Assembler
{
    public class UserAccountCreateAssembler
    {
        private readonly IMapper _mapper;

        public UserAccountCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserAccount toEntity(UserAccountCreateDto userAccountCreateDto)
        {
            return _mapper.Map<UserAccount>(userAccountCreateDto);
        }
    }
}
