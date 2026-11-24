namespace DemoAssign2.Enteties
{
    public class Member:GymUser
    {
        public string? photo { get; set; } 
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
