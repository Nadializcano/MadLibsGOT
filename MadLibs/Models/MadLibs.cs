namespace MadLibs.Models
{
  public class LibsVariable
  {
    private string _nameone;
    private string _nametwo;
    private string _namethree;

    public string GetNameOne()
    {
      return _nameone;
    }
    public void SetNameOne(string newNameOne)
    {
      _nameone= newNameOne;
    }
    public string GetNameTwo()
    {
      return _nametwo;
    }
    public void SetNameTwo(string newNameTwo)
    {
      _nametwo = newNameTwo;
    }
    public string GetNameThree()
    {
      return _namethree;
    }
    public void SetNameThree(string newNameThree)
    {
      _namethree = newNameThree;
    }
  }
}
