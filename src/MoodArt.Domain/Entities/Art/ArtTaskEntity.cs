using MoodArt.Domain.Entities.Base;
using MoodArt.Shared.Enums;

namespace MoodArt.Domain.Entities.Art;

/// <summary>
/// 艺术任务实体
/// </summary>
/// <remarks>
/// 记录AI绘画任务的状态和进度
/// </remarks>
public class ArtTask : BaseEntity
{
    /// <summary>
    /// 情绪记录ID（关联到EmotionRecord表）
    /// </summary>
    public Guid EmotionRecordId { get; set; }
    
    /// <summary>
    /// 任务唯一标识符（用于查询任务状态）
    /// </summary>
    /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
    public string JobId { get; set; } = string.Empty;
    
    /// <summary>
    /// 任务状态（等待/处理中/完成/失败/取消）
    /// </summary>
    public ArtTaskStatus Status { get; set; }
    
    /// <summary>
    /// 任务进度（0-100）
    /// </summary>
    /// <example>85</example>
    public int Progress { get; set; }
    
    /// <summary>
    /// AI绘画提示词（发送给AI的文本）
    /// </summary>
    /// <example>joyful painting, impressionism style, warm colors, high quality</example>
    public string? Prompt { get; set; }
    
    /// <summary>
    /// 生成结果的图片URL
    /// </summary>
    public string? ResultUrl { get; set; }
    
    /// <summary>
    /// 错误信息（任务失败时记录）
    /// </summary>
    public string? ErrorMessage { get; set; }
    
    /// <summary>
    /// 任务开始处理的时间
    /// </summary>
    public DateTime? StartedAt { get; set; }
    
    /// <summary>
    /// 任务完成的时间（成功或失败）
    /// </summary>
    public DateTime? CompletedAt { get; set; }
}