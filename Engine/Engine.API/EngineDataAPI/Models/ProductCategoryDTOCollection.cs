﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Engine.API.Models;
using Newtonsoft.Json.Linq;

namespace Engine.API.Models
{
    public static partial class ProductCategoryDTOCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<ProductCategoryDTO> DeserializeJson(JToken inputObject)
        {
            IList<ProductCategoryDTO> deserializedObject = new List<ProductCategoryDTO>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                ProductCategoryDTO productCategoryDTO = new ProductCategoryDTO();
                productCategoryDTO.DeserializeJson(iListValue);
                deserializedObject.Add(productCategoryDTO);
            }
            return deserializedObject;
        }
    }
}
