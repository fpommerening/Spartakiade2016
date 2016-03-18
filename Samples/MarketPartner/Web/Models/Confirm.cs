namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Models
{
    public class Confirm
    {
        public bool Successful { get; set; }

        public string DisplayText
        {
            get { return Successful ? "Erfolgreich gesendet" : "Versand fehlgeschlagen"; }
        }

        public string ErrorText { get; set; }

    }
}
