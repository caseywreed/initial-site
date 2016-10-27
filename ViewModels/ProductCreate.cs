using System.Collections.Generic;
using System.Linq;
using Bangazon.Models;
using BangazonWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BangazonWeb.ViewModels
{
  public class ProductCreate : BaseViewModel
  {
    public IEnumerable<SelectListItem> ProductTypes { get; set; }
    public Product NewProduct { get; set; }
    public ProductCreate(BangazonContext ctx) : base(ctx)
    {
      ProductTypes = context.ProductType
                .OrderBy(l => l.Label)
                .AsEnumerable()
                .Select(li => new SelectListItem { 
                    Text = li.Label,
                    Value = li.ProductTypeId.ToString()
                    });
    }
    public ProductCreate() { }
  }
}