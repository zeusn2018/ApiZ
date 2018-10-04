
using EnterprisePatterns.Api.BankAccounts.Domain.Entity;

namespace EnterprisePatterns.Api.BankAccounts.Domain.Repository
{
    public interface UserAccountRepository
    {
        void Create(UserAccount userAccount);
        void Delete(UserAccount bankAccount);
        UserAccount Read(long id);
    }
}
