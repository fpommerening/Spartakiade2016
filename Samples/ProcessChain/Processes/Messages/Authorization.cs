using FP.Spartakiade2016.ProcessChain.Data;


namespace FP.Spartakiade2016.ProcessChain.Processes.Messages
{
    public class Authorization
    {
        private MarktpartnerRepository _marktpartnerRepository;

        public Authorization(MarktpartnerRepository marktpartnerRepository)
        {
            _marktpartnerRepository = marktpartnerRepository;
        }

       
    }
}
