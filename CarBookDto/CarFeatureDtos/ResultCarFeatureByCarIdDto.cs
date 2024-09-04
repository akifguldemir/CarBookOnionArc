namespace CarBookDto.CarFeatureDtos
{
	public class ResultCarFeatureByCarIdDto
    {
        public int CarFeatureID { get; set; }
        public string FeatureName { get; set; }
        public int FeatureID { get; set; }
        public bool Available { get; set; }
    }
}
