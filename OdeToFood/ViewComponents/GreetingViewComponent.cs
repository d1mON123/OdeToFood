using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class GreetingViewComponent : ViewComponent
    {
        private readonly IGreeter _greeter;

        public GreetingViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _greeter.GetGreeting();
            return await Task.FromResult<IViewComponentResult>(View("Default", model));
        }
    }
}
