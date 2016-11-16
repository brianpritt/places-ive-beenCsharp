using System.Collections.Generic;

namespace OurPlaces.Objects
{
  public class Place
  {
    private string _description;
    private int _id;
    private string _notes;
    private string _picture;
    private static List<Place> _instances =  new List<Place> {};

    public Place(string description, string notes, string picture)
    {
      _description = description;
      _notes = notes;
      _picture = picture;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
        _description = newDescription;
    }
    public string GetNotes()
    {
      return _notes;
    }
    public void SetNotes(string newNotes)
    {
      _notes = newNotes;
    }
    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string newPicture)
    {
        _picture = newPicture;
    }
    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
