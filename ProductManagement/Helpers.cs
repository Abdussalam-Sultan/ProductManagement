using ProductManagement.Enums;
namespace ProductManagement
{
    public class Helpers
    {
        public static string ToCssClass(Status status)
        {
            return status switch
            {
                Status.InStock => "status in-stock",
                Status.LowStock => "status low-stock",
                Status.OutOfStock => "status out-stock",
                _ => "badge bg-secondary"
            };
        }

        public static string ToDisplayName(Status status)
        {
            return status switch
            {
                Status.InStock => "In Stock",
                Status.LowStock => "Low Stock",
                Status.OutOfStock => "Out of Stock",
                _ => "Unknown"
            };
        }
    }
}
