using Nancy.Authentication.Basic;
using Nancy.Security;

namespace FP.Spartakiade2016.ProcessChain.Webbroker.Module
{
    public class UserValidator : IUserValidator
    {
        private readonly ProcessRepository _processRepository;
        public UserValidator(ProcessRepository processRepository)
        {
            _processRepository = processRepository;
        }

        public IUserIdentity Validate(string username, string password)
        {
            var result = _processRepository.Authorize(username, password);
            if (result.IsValid)
            {
                return new ProcessUserIdentity(username, result.Id);
            }
            return null;
        }
    }
}
