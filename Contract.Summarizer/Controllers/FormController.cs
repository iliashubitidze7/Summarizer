using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Summarizer.DataAccess.Repository;
using Summarizer.DataAccess.Repository.IRepository;
using Summarizer.Utility;

namespace Contract.Summarizer.Controllers
{
    public class FormController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public FormController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Form> formdb = _unitOfWork.forms.GetAll().ToList();
            if (formdb != null)
            {
                return View(formdb);
            }
            return View(NotFound());
        }

        public IActionResult Create()
        {
            ViewBag.ContractTypes = new SelectList(SD.contractType);
            ViewBag.Currency = new SelectList(SD.currency);

            return View();
        }

        [HttpPost]
        public IActionResult Create(Form form)
        {
            if (form != null)
            {
                _unitOfWork.forms.Add(form);
                _unitOfWork.Save();

                return RedirectToAction("Index");
                
            }
            return View("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            Form form = _unitOfWork.forms.Get(x => x.FormId == id);

            ViewBag.ContractTypes = new SelectList(SD.contractType);
            ViewBag.Currency = new SelectList(SD.currency);

            if (form == null)
            {
                return NotFound();
            }

            return View(form);
        }

        [HttpPost]
        public IActionResult Edit(Form form)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.forms.Update(form);
                _unitOfWork.Save();
                
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id) {
            Form form = _unitOfWork.forms.Get(u => u.FormId == id);

            if(form != null)
            {
                _unitOfWork.forms.Remove(form);
                _unitOfWork.Save();

            }
            return RedirectToAction("Index");

        }

    
    }
}
