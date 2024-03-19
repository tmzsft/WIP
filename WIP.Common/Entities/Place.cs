public class Place
{
    public string PlaceName { get; set; }
    public string PlaceMotto { get; set; }
    public string? PlaceBranchName { get; set; }
    public PlaceType PlaceType { get; set; }
    public PlacePrevalence PlacePrevalence { get; set; }
    public int PlaceCountry { get; set; }
    public int PlaceCity { get; set; }
    public string PlaceLocation { get; set; }
    public PlaceSizeScoreEnum PlaceSize { get; set; } //fiziksel
    public PlaceTest PlaceTest { get; set; }
    public bool PlaceRegistered { get; set; }
    public PlaceParking PlaceParking { get; set; }   //fiziksel
    public PlaceQualityScoreEnum PlaceAudience { get; set; }
    public PlaceQualityScoreEnum PlaceQuietness { get; set; }
    public bool PlaceHasSeperatedWorkingArea { get; set; }
    public PlaceSizeScoreEnum PlaceWoringAreaSize { get; set; }
    public PlaceQualityScoreEnum PlaceLighting { get; set; }
    public PlaceQualityScoreEnum PlaceAirContdition { get; set; }
    public PlaceBuilding PlaceBuilding { get; set; }
    public PlacePowerline PlacePowerline { get; set; }
    
}