namespace Alberts_Dewan_Personal_Project.Models
{
    public class RecommendationInputModel

    {
        public string Province { get; set; }
        public int EnergyBill { get; set; }
        public int PeopleCount { get; set; }
        public int HomeSize { get; set; }
        public int WaterPumps { get; set; }
        public int Aircons { get; set; }
        public string StoveType { get; set; }
        public int DryerCount { get; set; }
        public int DishwasherCount { get; set; }
        public int GeyserCount { get; set; }
    }
}