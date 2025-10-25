using MoodArt.Domain.Entities.Base;

namespace MoodArt.Domain.Entities.Identity;

/// <summary>
/// 用户
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// 用户名称
    /// </summary>
    public string Username { get; set; } = string.Empty;
    
    /// <summary>
    /// 用户密码
    /// </summary>
    public string Password { get; set; } = string.Empty;
    
    /// <summary>
    /// 是否启用
    /// </summary>
    public bool IsActive { get; set; } = true;
}