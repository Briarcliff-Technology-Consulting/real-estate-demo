

using RealEstateDemo.DataAccess.Enums;

namespace RealEstateDemo.DataAccess
{
    public class Property
    {
        public Property(string streetAddress1,
            string? streetAddress2,
            decimal price,
            int cityFK,
            string zipCode,
            string mlsNum,
            int agentFK,
            DateTime dateListed,
            PropertyState propertyState)
        {
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            Price = price;
            CityFK = cityFK;
            ZipCode = zipCode;
            MlsNum = mlsNum;
            AgentFK = agentFK;
            DateListed = dateListed;
            PropertyState = propertyState;
        }

        public int PropertyPK { get; set; }
        public string StreetAddress1 { get; set; }
        public string? StreetAddress2 { get; set; } = null;
        public decimal Price { get; set; }
        public int CityFK { get; set; }
        public int StateFK { get; set; }
        public string ZipCode { get; set; }
        public string MlsNum { get; set; }
        public int AgentFK { get; set; }
        public DateTime DateListed { get; set; }
        public PropertyState PropertyState { get; set; }
        public string DisplayAddress
        {
            get => $"{StreetAddress1}, Macon, GA";
        }
        public string DisplayPrice
        {
            get => $"{Price.ToString("C")}";
        }

        #region Data access

        public static Property? GetPropertyByMlsNum(string mlsNum)
        {
            return new Property("100 Derby Lane", null, 500000, 10, "31210", mlsNum, 1, DateTime.Now, PropertyState.Active);
        }

        public static Property? GetPropertyByPropertyPK(int propertyPK)
        {
            return new Property("100 Derby Lane", null, 650000, 10, "31210", "1180", 1, DateTime.Now, PropertyState.Active);
        }

        public static IReadOnlyCollection<Property> GetPropertiesByCityFK(int cityFK)
        {
            return new List<Property>()
            {
                new Property("100 Derby Lane", null, 70000, 10, "31210", "1180", 1, DateTime.Now, PropertyState.Active),
                new Property("100 Derby Lane", null, 120000, 10, "31210", "1181", 1, DateTime.Now, PropertyState.Active)
            };
        }

        #endregion
    }
}
