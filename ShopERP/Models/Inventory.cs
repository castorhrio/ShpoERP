//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopERP.Models
{
    /// <summary>
    /// Defines the <see cref="Inventory" />.
    /// </summary>
    public partial class Inventory
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the product_id.
        /// </summary>
        public int product_id { get; set; }

        /// <summary>
        /// Gets or sets the stock_count.
        /// </summary>
        public int stock_count { get; set; }

        /// <summary>
        /// Gets or sets the in_stock_count.
        /// </summary>
        public int in_stock_count { get; set; }

        /// <summary>
        /// Gets or sets the create_time.
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// Gets or sets the update_time.
        /// </summary>
        public System.DateTime update_time { get; set; }
    }
}