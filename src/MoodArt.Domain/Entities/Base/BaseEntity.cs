namespace MoodArt.Domain.Entities.Base;

/// <summary>
/// 实体基类
/// </summary>
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// 创建人ID
    /// </summary>
    public Guid CreatorUserId  { get; set; }
    
    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreationTime { get; set; }
    
    /// <summary>
    /// 最后修改人ID
    /// </summary>
    public Guid? LastModifierUserId { get; set; }
    
    /// <summary>
    /// 最后修改时间
    /// </summary>
    public DateTime? LastModificationTime{ get; set; }
    
    /// <summary>
    ///  是否删除
    /// </summary>
    public bool IsDeleted { get; set; }
    
    /// <summary>
    /// 删除人ID
    /// </summary>
    public Guid? DeleterUserId { get; set; }
    
    /// <summary>
    /// 删除时间
    /// </summary>
    public DateTime? DeletionTime { get; set; }
}