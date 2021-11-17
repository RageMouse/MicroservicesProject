namespace PaymentAPI.Common
{
    public class BaseObject
    {
        public BaseObject()
        {
        }

        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as BaseObject;
            if (other == null || string.IsNullOrEmpty(other.Id))
                return false;

            return other.Id.Equals(Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
