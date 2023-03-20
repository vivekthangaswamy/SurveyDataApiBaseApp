// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using BionetDataCollection.Surveys.Data.DataModels;

namespace BionetDataCollection.Surveys.Data.DTOs
{
    public class ContributorsDTO
    {
        public int SurveyId { get; set; }
        public ICollection<UserDTO> Contributors { get; set; }
        public ICollection<ContributorRequest> Requests { get; set; }
    }
}
