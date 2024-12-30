namespace BookAPI.DataAccessLayer.Dtos
{
    public class ResultBookDto
    {
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        
        public string? Description { get; set; }
    }
} 