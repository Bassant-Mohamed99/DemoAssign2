namespace DemoAssign2.Enteties
{
    public class MemberShip:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default;
        public int PlanId { get; set; }
        public Plans Plan { get; set; } = default;
        public string status { get => StartDate > DateTime.Now ? "UpComing" : EndDate > StartDate ? "Active" : "Expired";}
    }
}
