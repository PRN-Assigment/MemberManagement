namespace BusinessObject
{
    public class MemberObject : IComparable<MemberObject>
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public int CompareTo(MemberObject? other)
        {
            return this.MemberName.CompareTo(other.MemberName);
        }
    }
}