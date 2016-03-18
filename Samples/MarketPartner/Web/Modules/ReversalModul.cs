using System;
using System.Net;
using System.Net.Http;
using FP.Spartakiade2016.ProcessChain.MarketPartner.Models;
using Nancy;
using Nancy.ModelBinding;
using Newtonsoft.Json;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class ReversalModul : NancyModule
    {
        public ReversalModul()
        {
            Get["/reversal"] = _ =>
            {
                var model = new Reversal
                {
                    Number = string.Format("SR-{0}", DateTime.Now.Ticks),
                    DocumentDate = DateTime.UtcNow.Date
                };

                return View["reversal", model];
            };

            Post["/reversal", true] = async (x, ct) =>
            {
                Reversal model = this.Bind<Reversal>();

                var json = MapModelToJson(model);

                using (var handler = new HttpClientHandler { Credentials = new NetworkCredential(model.UserName, model.Password) })
                {
                    using (HttpClient client = new HttpClient(handler))
                    {
                        var content = new StringContent(json);
                        var result = await client.PostAsync("http://processServer:9090/service/", content);

                        Confirm confirm = new Confirm { Successful = true };
                        if (!result.IsSuccessStatusCode)
                        {
                            confirm.Successful = false;
                            confirm.ErrorText = string.Format("{0} - {1}", result.StatusCode, result.ReasonPhrase);
                        }
                        return View["confirm", confirm];
                    }
                }
            };
        }

        private static string MapModelToJson(Reversal model)
        {
            var reversal = new Contracts.Invoic.Reversal
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTime.UtcNow,
                Number = model.Number,
                ReferenceBillNumber = model.ReferenceBillNumber,
                DocumentDate = model.DocumentDate,
                ReferenceDate = model.ReferenceDate
            };

            return JsonConvert.SerializeObject(reversal, Formatting.Indented);
        }
    }
}
