namespace MoodArt.Shared.Enums;

/// <summary>
/// 绘画任务状态
/// </summary>
public enum ArtTaskStatus
{
    /// <summary>
    /// 等待处理
    /// </summary>
    Pending = 0,
    
    /// <summary>
    /// 处理中
    /// </summary>
    Processing = 1,
    
    /// <summary>
    /// 已完成
    /// </summary>
    Completed = 2,
    
    /// <summary>
    /// 失败
    /// </summary>
    Failed = 3,
    
    /// <summary>
    /// 已取消
    /// </summary>
    Cancelled = 4
}