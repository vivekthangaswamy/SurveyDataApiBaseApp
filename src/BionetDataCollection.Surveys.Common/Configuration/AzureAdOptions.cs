﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace BionetDataCollection.Surveys.Common.Configuration
{
    public class AzureAdOptions
    {
        public AzureAdOptions()
        {
            Asymmetric = new AsymmetricEncryptionOptions();
        }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string PostLogoutRedirectUri { get; set; }
        public string WebApiResourceId { get; set; }

        public AsymmetricEncryptionOptions Asymmetric { get; set; }

    }
}
