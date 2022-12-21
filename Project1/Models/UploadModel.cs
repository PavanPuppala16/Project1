namespace Project1.Models
{
    public class UploadModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
