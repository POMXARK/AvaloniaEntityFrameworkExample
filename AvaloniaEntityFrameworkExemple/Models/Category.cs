using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaEntityFrameworkExemple.Models
{
    public class Category
    {
        public uint CategoryId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Product>
            Products
        { get; private set; } =
            new ObservableCollection<Product>();
    }
}
