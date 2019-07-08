﻿using DocuDataManager.Library.DataAccess;
using DocuDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocuDataManager.Controllers
{
    [Authorize]
    public class SaleController : ApiController
    {
        //public List<ProductModel> Get()
        //{
        //    ProductData data = new ProductData();

        //    return data.Getproducts();
        //}
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();
            string userId = RequestContext.Principal.Identity.GetUserId();

            data.SaveSale(sale, userId);
            
        }
    }
}
