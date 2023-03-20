// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using BionetDataCollection.Surveys.Data.DTOs;

namespace BionetDataCollection.Surveys.Web.Services
{
    /// <summary>
    /// This interface defines the CRUD operations for <see cref="BionetDataCollection.Surveys.Data.DataModels.Question"/>s
    /// </summary>
    public interface IQuestionService
    {
        Task<QuestionDTO> GetQuestionAsync(int id);
        Task<QuestionDTO> CreateQuestionAsync(QuestionDTO question);
        Task<QuestionDTO> UpdateQuestionAsync(QuestionDTO question);
        Task DeleteQuestionAsync(int id);
    }
}