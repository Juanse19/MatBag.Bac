using System;
using System.Collections.Generic;

namespace IoT.Entities.Models
{
    public partial class Users
    {
        public Users()
        {
            DeviceParametersCreatedByUser = new HashSet<DeviceParameters>();
            DeviceParametersUpdatedByUser = new HashSet<DeviceParameters>();
            DevicesCreatedByUser = new HashSet<Devices>();
            DevicesUpdatedByUser = new HashSet<Devices>();
            UserClaims = new HashSet<UserClaims>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public string Discriminator { get; set; }

        public virtual Settings Settings { get; set; }
        public virtual UserPhotos UserPhotos { get; set; }
        public virtual ICollection<DeviceParameters> DeviceParametersCreatedByUser { get; set; }
        public virtual ICollection<DeviceParameters> DeviceParametersUpdatedByUser { get; set; }
        public virtual ICollection<Devices> DevicesCreatedByUser { get; set; }
        public virtual ICollection<Devices> DevicesUpdatedByUser { get; set; }
        public virtual ICollection<UserClaims> UserClaims { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
