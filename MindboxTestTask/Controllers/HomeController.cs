using Microsoft.AspNetCore.Mvc;
using MindboxTestTask.Interfaces;
using MindboxTestTask.Models;
using System.Collections.Generic;

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
        public JsonResult CalculateCircleArea(Circle circle)
        {
            var area = circle.GetArea();
            return Json(area);
        }

        [HttpPost]
        public JsonResult CalculateTriangleArea(Triangle triangle)
        {
            var area = triangle.GetArea();
            var isRight = triangle.IsRightTriangle();
            return Json(new { area, isRight });
        }

        [HttpPost]
        public JsonResult CalculateArea(string type, double[] parameters)
        {
            var shape = _shapeFactory.CreateShape(type, parameters);
            var area = shape.GetArea();
            return Json(area);
        }
    }
}
