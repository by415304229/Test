using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZPMC_MES.Api.ViewModels
{
    public class ProductImportModel
    {
        public IList<ProductJsonModel> UploadData { get; set; }
    }
}
