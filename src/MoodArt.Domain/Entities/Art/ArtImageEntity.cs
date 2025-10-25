using MoodArt.Domain.Entities.Base;

namespace MoodArt.Domain.Entities.Art;

/// <summary>
/// 艺术作品实体
/// </summary>
/// <remarks>
/// 存储AI生成的艺术图片信息
/// </remarks>
public class ArtImageEntity : BaseEntity
{
    /// <summary>
    /// 艺术任务ID（关联到ArtTask表）
    /// </summary>
    public Guid ArtTaskId { get; set; }
    
    /// <summary>
    /// 图片URL地址
    /// </summary>
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// 艺术风格
    /// </summary>
    /// <example>印象派、超现实主义、极简主义</example>
    public string Style { get; set; } = string.Empty;
    
    /// <summary>
    /// 对应的情绪类型
    /// </summary>
    /// <example>快乐、悲伤、平静</example>
    public string Emotion { get; set; } = string.Empty;
    
    /// <summary>
    /// 作品描述（可选）
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// 图片宽度（像素）
    /// </summary>
    /// <example>1024</example>
    public int Width { get; set; }
    
    /// <summary>
    /// 图片高度（像素）
    /// </summary>
    /// <example>1024</example>
    public int Height { get; set; }
    
    /// <summary>
    /// 文件大小（字节）
    /// </summary>
    /// <example>2048576</example>
    public long FileSize { get; set; }
    
    /// <summary>
    /// 是否公开展示
    /// </summary>
    /// <remarks>
    /// true: 在公共画廊展示
    /// false: 仅用户自己可见
    /// </remarks>
    public bool IsPublic { get; set; } = true;
}