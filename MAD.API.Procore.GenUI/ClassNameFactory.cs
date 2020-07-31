﻿using Humanizer;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Gen
{
    internal static class ClassNameFactory
    {
        public static string Create(Schema schemaModel)
        {
            string name;

            if (!string.IsNullOrEmpty(schemaModel.Title))
                name = schemaModel.Title;
            else if (!string.IsNullOrEmpty(schemaModel.Field))
                name = schemaModel.Field;
            else if (!string.IsNullOrEmpty(schemaModel.Description))
                name = schemaModel.Description;
            else
                return null;

            return name.CleanForCode();
        }
    }
}
