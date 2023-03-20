﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using BionetDataCollection.Surveys.Data.DataModels;

namespace BionetDataCollection.Surveys.Data.DataStore
{
    public interface IQuestionStore
    {
        Task<Question> GetQuestionAsync(int id);
        Task<Question> AddQuestionAsync(Question question);
        Task<Question> UpdateQuestionAsync(Question question);
        Task<Question> DeleteQuestionAsync(Question question);
    }
}
