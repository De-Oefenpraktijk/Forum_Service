namespace Forum.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Text { get; set; } = null!;
        public FormPost FormPost { get; set; } = null!;
    }
}