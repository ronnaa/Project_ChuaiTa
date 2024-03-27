namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class id_log
    {
        public string? Id { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }
        public string? tel { get; set; }
    }

    public class menu
    {
        public string? men { get; set; }
        public string? name { get; set; }
        public int? amount { get; set; }
        public int? price { get; set; }
        public string? note { get; set; }
    }

    public class Team
    {
        public int Position { get; set; }
        public string HomeGround { get; set; }
        public string NickName { get; set; }
        public int Founded { get; set; }
        public string Name { get; set; }
    }
}