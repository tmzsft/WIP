public class Place
{
    public Guid PlaceID { get; set; }
    public Guid? PlaceCenterID { get; set; }
    public PlaceBranching PlaceBranching { get; set; }
    public string? PlaceBranchName { get; set; }
    public required string PlaceName { get; set; }
    public required string PlaceMotto { get; set; }
    public PlaceType PlaceType { get; set; }
    public PlacePrevalence PlacePrevalence { get; set; }
    public int PlaceCountry { get; set; }
    public int PlaceCity { get; set; }
    public required string PlaceLocation { get; set; }
    public PlaceTest PlaceTest { get; set; }
    public bool PlaceRegistered { get; set; }
    public bool PlaceHasSeperatedWorkingArea { get; set; }


    public required PlaceCleanlinessScore PlaceCleanlinessScore { get; set; }
    public required WorkPlaceComfortScore PlaceComfortScore { get; set; }
    public required PlacePhysicalProperties PlacePhysicalProperties { get; set; }
    public required PlaceServiceScore PlaceServiceScore { get; set; }
    public required WorkPlaceProperties PlaceWorkingAreaProperties { get; set; }

}