using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
	public class _Testimonial:ViewComponent
	{
		TestimonialManager testimonialManager=new TestimonialManager(new EfTestimonial());
		public IViewComponentResult Invoke()
		{
			var values = testimonialManager.GetList();
			return View(values);
		}
	}
}
