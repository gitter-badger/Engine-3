﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Engine.API.Models;
using Microsoft.Rest;

namespace Engine.API
{
    public partial interface IProductCategories
    {
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<ProductCategory>> DeleteProductCategoryByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ProductCategoryDTO>>> GetProductCategoriesWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<ProductCategory>> GetProductCategoryByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ProductCategoryDTO>>> GetProductChildCategoriesByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='productCategory'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<ProductCategory>> PostProductCategoryByProductcategoryWithOperationResponseAsync(ProductCategory productCategory, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='productCategory'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutProductCategoryByIdAndProductcategoryWithOperationResponseAsync(int id, ProductCategory productCategory, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}