using System.ComponentModel.DataAnnotations;

namespace todo_list_winforms.DAL.Models.Base;
public class BaseEntity : IBaseEntity
{
    /// <summary>
    /// Base identity
    /// </summary>
    [Key]
    public int Id { get; set; }
}