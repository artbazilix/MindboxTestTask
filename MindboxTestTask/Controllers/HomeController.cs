using Microsoft.AspNetCore.Mvc;
using MindboxTestTask.Interfaces;
using MindboxTestTask.Models;
using MindboxTestTask.ViewModels;

namespace MindboxTestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShapeFactory _shapeFactory;

        public HomeController(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CalculateCircleArea(CircleViewModel circle)
        {
            var area = circle.GetArea();
            return Json(area);
        }

        [HttpPost]
        public JsonResult CalculateTriangleArea(TriangleViewModel triangle)
        {
            var area = triangle.GetArea();
            var isRight = triangle.IsRightTriangle();
            return Json(new { area, isRight });
        }

        [HttpPost]
        public JsonResult CalculateArea(ShapeViewModel shapeViewModel)
        {
            var shape = _shapeFactory.CreateShape(shapeViewModel.Type, shapeViewModel.Parameters);
            var area = shape.GetArea();
            var isRight = shape is Triangle triangle ? triangle.IsRightTriangle() : (bool?)null;
            return Json(new { area, isRight });
        }
    }
}
