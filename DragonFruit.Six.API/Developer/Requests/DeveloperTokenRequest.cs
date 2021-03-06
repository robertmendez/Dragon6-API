﻿// Dragon6 API Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under Apache-2. Please refer to the LICENSE file for more info

namespace DragonFruit.Six.API.Developer.Requests
{
    public class DeveloperTokenRequest : DeveloperApiRequest
    {
        public override string Path => "https://dragon6.dragonfruit.network/api/token/dev";

        protected override bool RequireAuth => true;
    }
}
