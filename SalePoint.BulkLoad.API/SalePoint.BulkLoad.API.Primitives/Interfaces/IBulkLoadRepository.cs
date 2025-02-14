﻿using Microsoft.AspNetCore.Http;

namespace SalePoint.BulkLoad.API.Primitives.Interfaces
{
    public interface IBulkLoadRepository
    {
        Task<bool> BulkLoadProducts(IFormFile formFile, int userId);

        Task<List<BulkUpgradeErrors>> UpgradeBulkLoadProducts(IFormFile formFile, int userId);
    }
}