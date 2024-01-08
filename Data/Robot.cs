using System.ComponentModel.DataAnnotations;

namespace BlazorAppAzure.Data
{
    public class Robot
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
    }
}
