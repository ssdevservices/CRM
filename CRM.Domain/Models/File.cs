using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Domain.Models
{
    [Table("Files", Schema = "dbo")]
    public class File
    {
        [Key]
        public int FileId { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public byte[] FileData { get; set; }
    }
}
