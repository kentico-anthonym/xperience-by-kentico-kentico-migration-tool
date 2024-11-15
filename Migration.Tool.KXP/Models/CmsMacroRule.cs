using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration.Tool.KXP.Models;

[Table("CMS_MacroRule")]
public class CmsMacroRule
{
    [Key]
    [Column("MacroRuleID")]
    public int MacroRuleId { get; set; }

    [StringLength(200)]
    public string MacroRuleName { get; set; } = null!;

    [StringLength(1000)]
    public string MacroRuleText { get; set; } = null!;

    public string? MacroRuleParameters { get; set; }

    public DateTime MacroRuleLastModified { get; set; }

    [Column("MacroRuleGUID")]
    public Guid MacroRuleGuid { get; set; }

    public string MacroRuleCondition { get; set; } = null!;

    [StringLength(500)]
    public string MacroRuleDisplayName { get; set; } = null!;

    public bool? MacroRuleIsCustom { get; set; }

    [StringLength(450)]
    public string? MacroRuleDescription { get; set; }

    public bool? MacroRuleEnabled { get; set; }

    [InverseProperty("MacroRule")]
    public virtual ICollection<CmsMacroRuleMacroRuleCategory> CmsMacroRuleMacroRuleCategories { get; set; } = new List<CmsMacroRuleMacroRuleCategory>();
}
