using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace MovieRatingSystem.Client.Shared
{
    public partial class Error: ComponentBase
    {
        [Inject]
        ILogger<Error> Logger { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string UserMessage { get; set; }

        public void ProcessError(Exception ex)
        {
            UserMessage = ex.Message;

            Logger.LogError("Error:ProcessError - Type: {Type} Message: {Message}",
                ex.GetType(), ex.Message);
            StateHasChanged();
        }
    }
}
