using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables(int.Parse(Request.Query["width"]), int.Parse(Request.Query["height"]), int.Parse(Request.Query["height"]), int.Parse(Request.Query["weight"]));

        return View["index.cshtml", myParcelVariables];
      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
