using System;
using System.Collections.Generic;
using System.Linq;
using FP.Spartakiade2016.ProcessChain.Data.Objects;

namespace FP.Spartakiade2016.ProcessChain.Data
{
    public class MarktpartnerRepository
    {
        private static readonly List<boMarktpartner> _marktpartners = new List<boMarktpartner>
        {
            new boMarktpartner
            {
                Id = new Guid("3407F0AB-D408-48D5-9AFD-E442E614E9C0"),
                UserName = "Spartakiade",
                Password = "SportF3#",
                ServiceUrl = "http://marketpartner:12088/service/"
            },
            new boMarktpartner
            {
                Id = new Guid("0BF93D28-BAA4-40EE-8562-6706491C5E1E"),
                UserName = "processChain",
                Password = "topsecret",
                ServiceUrl = "http://processServer:9090/Service/"
            }
        };

        public boMarktpartner GetMarktpartnerByUserName(string userName)
        {
            return _marktpartners.FirstOrDefault(x => x.UserName == userName);
        }

        public boMarktpartner GetMarktpartnerById(Guid id)
        {
            return _marktpartners.FirstOrDefault(x => x.Id == id);
        }

        public boMarktpartner GetSystemMarktpartner()
        {
            return _marktpartners.First(x => x.Id == new Guid("0BF93D28-BAA4-40EE-8562-6706491C5E1E"));
        }
    }
}
