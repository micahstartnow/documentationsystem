﻿using DocuDataManager.Library.DataAccess;
using DocuDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocuDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET api/values
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.Getproducts();
        }
    }
}
