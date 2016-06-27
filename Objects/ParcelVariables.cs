namespace Parcel.Objects
{
  public class ParcelVariables
  {
    public int Length { get; set; };
    public int Width { get; set; };
    public int Height { get; set; };
    public int Weight { get; set; };

    public ParcelVariables(int parcelLength, int parcelWidth, int parcelHeight, int parcelWeight)
    {
      Length = parcelLength;
      Width = parcelWidth;
      Height = parcelHeight;
      Weight = parcelWeight;
    }
  }
}
