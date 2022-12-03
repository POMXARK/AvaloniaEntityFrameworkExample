

namespace AvaloniaEntityFrameworkExemple.Models
{
    public class Product
    {
        public uint ProductId { get; set; }
        public string? Name { get; set; }

        public uint CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
