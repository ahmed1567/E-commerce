using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared;

public class SubCategory:BaseSettingEntity
{
    public Guid CategoryId { get; set; }

    public Category? Category { get; set; }

    public ICollection<Product>? Products { get; set; }
}
