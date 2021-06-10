using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MovieRatingSystem.Client.Helpers;
using MovieRatingSystem.Client.Shared;
using MovieRatingSystem.Services.Contracts;
using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingSystem.Client.Pages
{
    public partial class RatingOverview : ComponentBase
    {        
        [Parameter]
        public int TypeID { get; set; }

        [CascadingParameter]
        public Error Error { get; set; }

        public string User { get; set; }

        public IEnumerable<RatingViewModel> Content { get; set; }

        [Inject]
        public IContentDataService ContentDataService { get; set; }

        [Inject]
        public AuthenticationStateProvider AuthProvider { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                User = (await AuthProvider.GetAuthenticationStateAsync()).User.Identity.Name;
                Content = (await ContentDataService.GetRatings(TypeID, User)).ToList();
            }
            catch(Exception exception)
            {
                Error.ProcessError(exception);
            }
        }

        public async Task OnSaveRatingButtonClicked(int contentID)
        {
            try
            {
                var contentModel = Content.FirstOrDefault(el => el.ID == contentID);
                if (contentModel == null)
                {
                    throw new Exception(ErrorMessages.WRONG_PARAMETER);
                }
                if(contentModel.MyRating == 0)
                {
                    throw new Exception(ErrorMessages.RATING_ZERO);
                }

                contentModel.Username = User;

                bool success = await ContentDataService.UpdateRating(contentModel);
                if(!success)
                {
                    throw new Exception(ErrorMessages.RATING_NOT_UPDATED);
                }
                Content = (await ContentDataService.GetRatings(TypeID, User)).ToList();
                StateHasChanged();
            }
            catch(Exception exception)
            {
                Error.ProcessError(exception);
            }
        }

    }
}
