using Microsoft.ML.Data;

namespace RecomendacionDePortafolio.Models
{
    public class ProductEntry
    {
        [KeyType(count: 262111)]
        public uint ProductID { get; set; }

        [KeyType(count: 262111)]
        public uint CoPurchaseProductID { get; set; }
    }
}
