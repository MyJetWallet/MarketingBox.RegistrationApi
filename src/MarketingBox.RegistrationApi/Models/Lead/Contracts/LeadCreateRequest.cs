using Destructurama.Attributed;

namespace MarketingBox.RegistrationApi.Models.Lead.Contracts
{
    public class LeadCreateRequest
    {
        #region Personal info
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string FirstName { get; set; }
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string LastName { get; set; }
        [LogMasked(PreserveLength = true)]
        public string Password { get; set; }
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Email { get; set; }
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Phone { get; set; }
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Ip { get; set; }
        public string Country { get; set; }
        public long OfferId { get; set; }
        #endregion

        #region Additional parameters
        public string So { get; set; }
        public string Sub { get; set; }
        public string Sub1 { get; set; }
        public string Sub2 { get; set; }
        public string Sub3 { get; set; }
        public string Sub4 { get; set; }
        public string Sub5 { get; set; }
        public string Sub6 { get; set; }
        public string Sub7 { get; set; }
        public string Sub8 { get; set; }
        public string Sub9 { get; set; }
        public string Sub10 { get; set; }
        #endregion  
    }
}
