using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Model.ViewModels;
using Service.Contract.Base;
using Service.Services;
using System.Diagnostics;
using TecnicalTestProject.Models;

namespace TecnicalTestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IMapper _iMapper;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork iUnitOfWork, IMapper iMapper)
        {
            _logger = logger;
            _iUnitOfWork = iUnitOfWork;
            _iMapper = iMapper;
        }

        public async Task<IActionResult> Index()
        {
            var type = await _iUnitOfWork.CustomerType.GetAllAsync();
            var productService = await _iUnitOfWork.ProductsService.GetAllAsync();

            var model = new MeetingMinutesMasterVm
            {
                SelectedOption = "1",
                CustomerTypeList = type,
                ProductServiceList = productService.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }),
                MeetingMinutesDetails = new List<MeetingMinutesDetails> { new MeetingMinutesDetails() }

            };

            if (model.SelectedOption == "1")//set on enum
            {
                var corporateCustomers = await _iUnitOfWork.CorporateCustomer.GetAllAsync();
                ViewBag.SelectOptionValue = corporateCustomers.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                });
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("SelectOption")]
        public async Task<IActionResult> SelectOption(MeetingMinutesMasterVm model)
        {
            ViewBag.SelectOptionValue = new SelectListItem();
            var productService = await _iUnitOfWork.ProductsService.GetAllAsync();
            var type = await _iUnitOfWork.CustomerType.GetAllAsync();
            model.CustomerTypeList = type;
            model.SelectedOption = model.SelectedOption;
            model.MeetingMinutesDetails = new List<MeetingMinutesDetails> { new MeetingMinutesDetails() };
            if (int.Parse(model.SelectedOption) == 2)
            {
                var individual = await _iUnitOfWork.IndividualCustomer.GetAllAsync();
                ViewBag.SelectOptionValue = individual.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                });
            }
            else
            {
                var corporateCustomers = await _iUnitOfWork.CorporateCustomer.GetAllAsync();
                ViewBag.SelectOptionValue = corporateCustomers.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                });
            }
            model.ProductServiceList = productService.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            });
            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MeetingMinutesMasterVm model)
        {
            if (ModelState.IsValid)
            {
                model.CustomerTypeId = model.SelectedOption == "1" ? 1 : 2;
               
                var meetingMinutesMaster = _iMapper.Map<MeetingMinutesMaster>(model);
                var result = await _iUnitOfWork.MeetingMinutesMaster.AddAsync(meetingMinutesMaster);
                TempData["success"] = "Save Successfully.";
                return RedirectToAction("index");
            }
            return RedirectToAction("index", model);
        }


        [HttpGet]
        public async Task<IActionResult> GetProductServiceUnit(int id)
        {
            var productServices = await _iUnitOfWork.ProductsService.GetAllAsync();
            var result = productServices.FirstOrDefault(c => c.Id == id);
            if (result != null)
            {
                return Ok(result.Unit);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetMasterDetails()
        {
            var result = await _iUnitOfWork.MeetingMinutesDetails.GetAllMasterDetailsAsync();
            var modfiedValue = result.Select((masterDetailsRetrunModel, index) => new MasterDetailsRetrunModel
            {
                Sl = index + 1,
                Id = masterDetailsRetrunModel.Id,
                Name = masterDetailsRetrunModel.Name,
                Unit = masterDetailsRetrunModel.Unit,
                Quantity = masterDetailsRetrunModel.Quantity,
                MeetingMinutesMasterId = masterDetailsRetrunModel.MeetingMinutesMasterId
            }) ;
            return Json(new { data = modfiedValue });
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
