using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Migration.Tool.KXP.Models;

[Table("EmailLibrary_EmailBounce")]
[Index("EmailBounceEmailAddress", Name = "IX_EmailLibrary_EmailBounce_EmailBounceEmailAddress", IsUnique = true)]
public class EmailLibraryEmailBounce
{
    [Key]
    [Column("EmailBounceID")]
    public int EmailBounceId { get; set; }

    [StringLength(256)]
    public string EmailBounceEmailAddress { get; set; } = null!;

    public bool EmailBounceIsHardBounce { get; set; }

    public int EmailBounceSoftBounceCount { get; set; }
}
