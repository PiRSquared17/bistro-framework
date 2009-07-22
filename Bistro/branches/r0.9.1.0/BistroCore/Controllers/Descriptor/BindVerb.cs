﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bistro.Controllers.Descriptor
{
    /// <summary>
    /// Enum of valid bind terms
    /// </summary>
    public enum BindVerb
    {
        // TODO: AP 07/08/09 this is setup to be a Flags attribute, but we don't currently support multiple verbs per binding
        GET = 1,
        POST = 2,
        PUT = 4,
        HEAD = 8,
        DELETE = 16
    }
}
