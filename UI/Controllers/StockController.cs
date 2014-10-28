using System;
using System.Web.Mvc;
using Common.StockLogs;
using UI.ViewModels.ViewModelBuilders;

namespace UI.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockLogService _stockLogService;
        private readonly StockLogViewModelBuilder _viewModelBuilder;

        public StockController(IStockLogService stockLogService)
        {
            _stockLogService = stockLogService;
            _viewModelBuilder = new StockLogViewModelBuilder(_stockLogService);
        }

        public ActionResult Index()
        {
            var model = _viewModelBuilder.BuildIndexViewModel();
            return PartialView("IndexPartial", model);
        }

        public ActionResult Create()
        {
            throw new NotImplementedException();
        }
	}
}