using System.Text.Json.Serialization;

namespace Ecommerce.Shared;

public class Category:BaseSettingEntity
{

    public ICollection<SubCategory>? SubCategories { get; set; }

}
