using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace GlobalError.Components.Layout
{
    public class CustomErrorBoundary : ErrorBoundary
    {
        [Inject]
        ILogger<CustomErrorBoundary> Logger { get; set; } = default!;

        protected override Task OnErrorAsync(Exception ex)
        {
            Logger.LogError(ex.Message, "Error message");
            return Task.CompletedTask;
        }
    }
}
