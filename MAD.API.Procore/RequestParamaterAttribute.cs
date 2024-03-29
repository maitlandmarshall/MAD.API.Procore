﻿using System;

namespace MAD.API.Procore
{
    public class RequestParameterAttribute : Attribute
    {
        public RequestParameterAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}
