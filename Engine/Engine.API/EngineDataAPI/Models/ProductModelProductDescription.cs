﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Engine.API.Models;
using Newtonsoft.Json.Linq;

namespace Engine.API.Models
{
    public partial class ProductModelProductDescription
    {
        private string _culture;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Culture
        {
            get { return this._culture; }
            set { this._culture = value; }
        }
        
        private DateTimeOffset? _modifiedDate;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? ModifiedDate
        {
            get { return this._modifiedDate; }
            set { this._modifiedDate = value; }
        }
        
        private ProductDescription _productDescription;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ProductDescription ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }
        
        private int? _productDescriptionID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ProductDescriptionID
        {
            get { return this._productDescriptionID; }
            set { this._productDescriptionID = value; }
        }
        
        private ProductModel _productModel;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ProductModel ProductModel
        {
            get { return this._productModel; }
            set { this._productModel = value; }
        }
        
        private int? _productModelID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ProductModelID
        {
            get { return this._productModelID; }
            set { this._productModelID = value; }
        }
        
        private string _rowguid;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Rowguid
        {
            get { return this._rowguid; }
            set { this._rowguid = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductModelProductDescription
        /// class.
        /// </summary>
        public ProductModelProductDescription()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken cultureValue = inputObject["Culture"];
                if (cultureValue != null && cultureValue.Type != JTokenType.Null)
                {
                    this.Culture = ((string)cultureValue);
                }
                JToken modifiedDateValue = inputObject["ModifiedDate"];
                if (modifiedDateValue != null && modifiedDateValue.Type != JTokenType.Null)
                {
                    this.ModifiedDate = ((DateTimeOffset)modifiedDateValue);
                }
                JToken productDescriptionValue = inputObject["ProductDescription"];
                if (productDescriptionValue != null && productDescriptionValue.Type != JTokenType.Null)
                {
                    ProductDescription productDescription = new ProductDescription();
                    productDescription.DeserializeJson(productDescriptionValue);
                    this.ProductDescription = productDescription;
                }
                JToken productDescriptionIDValue = inputObject["ProductDescriptionID"];
                if (productDescriptionIDValue != null && productDescriptionIDValue.Type != JTokenType.Null)
                {
                    this.ProductDescriptionID = ((int)productDescriptionIDValue);
                }
                JToken productModelValue = inputObject["ProductModel"];
                if (productModelValue != null && productModelValue.Type != JTokenType.Null)
                {
                    ProductModel productModel = new ProductModel();
                    productModel.DeserializeJson(productModelValue);
                    this.ProductModel = productModel;
                }
                JToken productModelIDValue = inputObject["ProductModelID"];
                if (productModelIDValue != null && productModelIDValue.Type != JTokenType.Null)
                {
                    this.ProductModelID = ((int)productModelIDValue);
                }
                JToken rowguidValue = inputObject["rowguid"];
                if (rowguidValue != null && rowguidValue.Type != JTokenType.Null)
                {
                    this.Rowguid = ((string)rowguidValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type ProductModelProductDescription
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Culture != null)
            {
                outputObject["Culture"] = this.Culture;
            }
            if (this.ModifiedDate != null)
            {
                outputObject["ModifiedDate"] = this.ModifiedDate.Value;
            }
            if (this.ProductDescription != null)
            {
                outputObject["ProductDescription"] = this.ProductDescription.SerializeJson(null);
            }
            if (this.ProductDescriptionID != null)
            {
                outputObject["ProductDescriptionID"] = this.ProductDescriptionID.Value;
            }
            if (this.ProductModel != null)
            {
                outputObject["ProductModel"] = this.ProductModel.SerializeJson(null);
            }
            if (this.ProductModelID != null)
            {
                outputObject["ProductModelID"] = this.ProductModelID.Value;
            }
            if (this.Rowguid != null)
            {
                outputObject["rowguid"] = this.Rowguid;
            }
            return outputObject;
        }
    }
}
