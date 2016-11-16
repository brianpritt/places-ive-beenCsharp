using Nancy;
using System.Collections.Generic;
using OurPlaces.Objects;

namespace OurPlaces
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/places"] = _ =>{
        List<Place> allPlaces = Place.GetAll();
        return View["/places.cshtml", allPlaces];
      };
      Get["/place/new"] = _ =>{
        return View["/place_form.cshtml"];
      };
      Get["/place/{id}"] = parameters =>
      {
        Place place = Place.Find(parameters.id);
        return View["place.cshtml", place];
      };
      Post["/places"] =_=> {
        string picture = Request.Form["picture"];
        string notes = Request.Form["notes"];
        string place = Request.Form["new-place"];
        Place newPlace = new Place(place, notes , picture);

        List<Place> allPlaces = Place.GetAll();
        return View["/places", allPlaces];
      };
    }
  }
}
