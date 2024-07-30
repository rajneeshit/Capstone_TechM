namespace API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        public UserType UserType { get; set; } = UserType.NONE;
        public AccountStatus AccountStatus { get; set; } = AccountStatus.UNAPROOVED;
    }

    public enum UserType
    {
        NONE, ADMIN, SERVICE_ADVISER
    }

    public enum AccountStatus
    {
        UNAPROOVED, ACTIVE, BLOCKED
    }

    public class CarCategory
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public float Price { get; set; }
        public bool Ordered { get; set; }
        public int CarCategoryId { get; set; }

        public CarCategory? CarCategory { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Returned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int AmountPaid { get; set; }

        public User? User { get; set; }
        public Car? Car { get; set; }
    }
    public class AfterServiceDb
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int AmountPaid { get; set; }
        public bool Returned { get; set; }
        public string Material { get; set; }


    }
}
