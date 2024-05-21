using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class CorporateCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CustomerTypeId")]
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
