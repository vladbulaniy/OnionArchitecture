using System;

namespace Core
{
    public class BloodDonor
    {
        public string BloodDonorID { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string BloodGroup { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PinCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsVerified { get; set; }
    }
}
