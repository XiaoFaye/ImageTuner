namespace ImageTuner;

public static class TaskExtensions
{
    public static async Task RunParallelAsync(this IEnumerable<Task> tasks, int maxParallel)
    {
        while (tasks.Any(t => !t.IsCompleted))
        {
            var queued = tasks.Where(t => !t.IsCompleted).Take(maxParallel).ToList();
            queued.ForEach(x => x.Start());
            await Task.WhenAll(queued);
        }
    }
}
