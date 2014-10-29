using System;
using System.Web.Mvc;
using Common.StockLogs;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class StockLogController : Controller
    {
        private readonly IStockLogService _stockLogService;
        private readonly StockLogViewModelBuilder _viewModelBuilder;

        public StockLogController(IStockLogService stockLogService)
        {
            _stockLogService = stockLogService;
            _viewModelBuilder = new StockLogViewModelBuilder(_stockLogService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _viewModelBuilder.BuildIndexViewModel();
            return PartialView("IndexPartial", model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Update(object id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}