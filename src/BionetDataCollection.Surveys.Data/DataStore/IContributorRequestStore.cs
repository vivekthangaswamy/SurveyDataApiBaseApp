// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using BionetDataCollection.Surveys.Data.DataModels;

namespace BionetDataCollection.Surveys.Data.DataStore
{
    public interface IContributorRequestStore
    {
        Task AddRequestAsync(ContributorRequest contributorRequest);
        Task<ICollection<ContributorRequest>> GetRequestForSurveyAsync(int surveyId);
        Task<ICollection<ContributorRequest>> GetRequestsForUserAsync(string emailAddress);
        Task RemoveRequestAsync(ContributorRequest contributorRequest);
    }
}
