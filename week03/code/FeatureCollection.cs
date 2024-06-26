public class FeatureCollection
{
    public string type { get; set; }
    public List<Feature> features { get; set; }
}
public class Properties
{
    public float mag { get; set; }
    public string place { get; set; }
}

public class Geometry
{
    // Define geometry properties if needed, e.g., coordinates
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
    // Add other properties as needed based on the actual JSON structure
}
