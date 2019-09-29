namespace Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        /// <summary>
        /// Path/Link to Image file
        /// </summary>
        public string Image { get; set; }
    }
}
