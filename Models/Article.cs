using System;
using LinqToDB.Mapping;

namespace ShopBridgeAPI.Models
{
    [Table(Name = "article")]
    public class Article
    {
        [PrimaryKey, Identity]
        [Column(Name = "id"), NotNull]
        public long Id { get; set; }

        [Column(Name = "code"), NotNull]
        public string Code { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }

        [Column(Name = "description"), NotNull]
        public string Description { get; set; }

        [Column(Name = "price"), NotNull]
        public decimal Price { get; set; }

        [Column(Name = "count"), NotNull]
        public long Count { get; set; }

        [Column(Name = "created_date")]
        public DateTime CreateddDate { get; set; }

        [Column(Name = "updated_date")]
        public DateTime UpdatedDate { get; set; }
    }
}
