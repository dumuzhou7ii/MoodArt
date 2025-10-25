using MoodArt.Domain.Entities.Base;
using MoodArt.Shared.Enums;

namespace MoodArt.Domain.Entities.Emotion;

/// <summary>
/// 情绪记录实体
/// </summary>
public class EmotionRecord : BaseEntity
{
    /// <summary>
    /// 用户输入的情绪文本
    /// </summary>
    public string Text { get; set; } = string.Empty;
    
    /// <summary>
    /// 情绪标签（中文）
    /// </summary>
    /// <example>快乐</example>
    public string EmotionLabel { get; set; } = string.Empty;
    
    /// <summary>
    /// 情绪类型（枚举）
    /// </summary>
    public EmotionType EmotionType { get; set; }
    
    /// <summary>
    /// 情绪识别置信度（0-1之间）
    /// </summary>
    /// <example>0.85</example>
    public float Confidence { get; set; }
}