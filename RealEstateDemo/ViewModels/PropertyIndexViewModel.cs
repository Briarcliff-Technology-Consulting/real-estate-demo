using RealEstateDemo.DataAccess;

namespace RealEstateDemo.ViewModels
{
    public class PropertyIndexViewModel
    {
        public PropertyIndexViewModel(int propertyPK, string displayAddress, string displayPrice, string mlsNum)
        {
            PropertyPK = propertyPK;
            DisplayAddress = displayAddress;
            DisplayPrice = displayPrice;
            MlsNum = mlsNum;
        }

        public int PropertyPK { get; private init; }
        public string DisplayAddress { get; private init; }
        public string DisplayPrice { get; private init; }
        public string MlsNum { get; private init; }

        public static PropertyIndexViewModel ToViewModel(Property property)
        {
            return new PropertyIndexViewModel(property.PropertyPK, property.DisplayAddress, property.DisplayPrice, property.MlsNum);
        }
    }
}
