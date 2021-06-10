using Microsoft.AspNetCore.Components;
using MovieRatingSystem.Client.Shared;
using MovieRatingSystem.Services.Contracts;
using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Client.Pages
{
    public partial class ContentOverview : ComponentBase
    {
        [Parameter]
        public string SearchTerm { get; set; } = string.Empty;

        [Parameter]
        public int TypeID { get; set; }

        public IEnumerable<ContentViewModel> Content { get; set; }

        [Inject]
        public IContentDataService ContentDataService { get; set; }

        [CascadingParameter]
        public Error Error { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                Content = (await ContentDataService.GetContent(string.Empty, TypeID)).ToList();
            }
            catch (Exception exception)
            {
                Error.ProcessError(exception);
            }            
        }

        public async Task OnTextChanged(ChangeEventArgs args)
        {
            try
            {
                IEnumerable<ContentViewModel> contentResults;
                if (string.IsNullOrWhiteSpace(SearchTerm))
                {
                    contentResults = await ContentDataService.GetContent(string.Empty, TypeID);
                    Content = contentResults.ToList();
                }

                if (SearchTerm.Length < 2)
                {
                    return;
                }

                var searchTermLowerCase = SearchTerm.ToLower();
                contentResults = await ContentDataService.GetContent(searchTermLowerCase, TypeID);
                Content = contentResults.ToList();
                StateHasChanged();
            }
            catch(Exception exception)
            {
                Error.ProcessError(exception);
            }
        }

    }
}
