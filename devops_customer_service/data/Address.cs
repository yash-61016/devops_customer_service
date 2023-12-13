using System;

namespace devops_customer_service.data
{
    public class Address
    {
        public int Id { get; set; }
        public required int CustomerId { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }
        public required string CreatedAt { get; set; }
        public required string UpdatedAt { get; set; }
    }
}