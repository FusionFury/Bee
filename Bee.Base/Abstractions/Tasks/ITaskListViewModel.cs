using Avalonia.Platform.Storage;
using Bee.Base.Models.Tasks;

namespace Bee.Base.Abstractions.Tasks;

/// <summary>
/// 任务列表视图模型协变接口，允许派生类型的实例赋值给基类型的变量
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ITaskListViewModel<out T> where T : TaskArgumentBase
{
    /// <summary>
    /// 执行任务参数配置对象
    /// </summary>
    T? TaskArguments { get; }
    /// <summary>
    /// 拖放文件处理
    /// </summary>
    /// <param name="storageItems"></param>
    /// <returns></returns>
    Task OnDragOver(IEnumerable<IStorageItem>? storageItems);
    /// <summary>
    /// 移除任务项
    /// </summary>
    /// <param name="item"></param>
    void RemoveTaskItem(TaskItem item);
    /// <summary>
    /// 初始化任务参数对象
    /// </summary>
    /// <param name="outputPath">输出路径（相对于全局输出目录下的路径）</param>
    void InitialArguments(string outputPath);
    /// <summary>
    /// 设置输入扩展
    /// </summary>
    /// <param name="inputExtensions"></param>
    void SetInputExtensions(IEnumerable<string> inputExtensions);
}