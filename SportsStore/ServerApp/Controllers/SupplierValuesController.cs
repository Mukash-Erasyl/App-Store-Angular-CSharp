using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using ServerApp.Models.BindingTargets;
using System.Collections.Generic;

namespace ServerApp.Controllers {
    [Route("api/suppliers")]
    public class SupplierValuesController : Controller {
        private DataContext context;
        public SupplierValuesController(DataContext ctx) {
            context = ctx;
}
        [HttpGet]
        public IEnumerable<Supplier> GetSuppliers() {
            return context.Suppliers;
        }
        [HttpPost]
        public IActionResult CreateSupplier([FromBody]SupplierData sdata) {
            if (ModelState.IsValid) {
                Supplier s = sdata.Supplier;
                context.Add(s);
                context.SaveChanges();
                return Ok(s.Id);
            } else {
                return BadRequest(ModelState);
} }
} }