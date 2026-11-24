namespace DemoAssign2.Enteties
{
    public class Plans:BaseEntity
    {
        public string PlanName { get; set; } = default;
        public string Description { get; set; } = default;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public Boolean IsActive { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
