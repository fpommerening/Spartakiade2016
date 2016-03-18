using System;
using System.Net;
using System.Net.Http;
using FP.Spartakiade2016.ProcessChain.MarketPartner.Models;
using Nancy;
using Nancy.ModelBinding;
using Newtonsoft.Json;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class RegistrationModule : NancyModule
    {
        public RegistrationModule()
        {
            Get["/registration"] = x =>
            {
                var model = new Registration();
                return View["registration", model];
            };

            Post["/registration", true] = async (x, ct) =>
            {
                Registration model = this.Bind<Registration>();

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

        private static string MapModelToJson(Registration model)
        {
            var registration = new Contracts.Customer.Registration
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTime.UtcNow,
                Name = model.Name,
                FirstName = model.FirstName,
                Title = model.Title,
                Birthday = model.Birthday,
                Email = model.Email,
                BillingAddress = new Contracts.Common.Address
                {
                    Street = model.BillingAddressStreet,
                    Number = model.BillingAddressNumber,
                    City = model.BillingAddressCity,
                    ZipCode = model.BillingAddressZipCode,
                    Country = model.BillingAddressCountry
                },
                DeliveryAddress = new Contracts.Common.Address
                {
                    Street = model.DeliveryAddressStreet,
                    Number = model.DeliveryAddressNumber,
                    City = model.DeliveryAddressCity,
                    ZipCode = model.DeliveryAddressZipCode,
                    Country = model.DeliveryAddressCountry
                }
            };

            return JsonConvert.SerializeObject(registration, Formatting.Indented);
        }
    }
}
