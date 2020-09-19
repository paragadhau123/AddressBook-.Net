using System;


namespace AddressBook
{
    class Person 
    {
        private String lname, address, city, state, phone, zip;
        public Person(String fname, String lname, String address, String city, String state, String phone, String zip)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNo = phone;
            this.ZipCode = zip;
        }

        public string FirstName { get; set; }
        public string LastName { get => lname; set => lname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNo { get => phone; set => phone = value; }
        public string ZipCode { get => zip; set => zip = value; }
        public override string ToString()
        {
            return "[FirstName=" + FirstName + ", LastName=" + LastName + ", Address=" + Address + ", City=" + City
                 + ", State=" + State + ", ZipCode=" + ZipCode + ", PhoneNo=" + PhoneNo + "]" + "\n";
        }

        /*   public String getFname()
          {
 return Fname;
 }

 public void setFname(String fname)
 {
 this.Fname = fname;
 }

 public String getLname()
 {
 return lname;
 }

 public void setLname(String lname)
 {
 this.lname = lname;
 }

 public String getAddress()
 {
 return address;
 }

 public void setAddress(String address)
 {
 this.address = address;
 }

 public String getCity()
 {
 return city;
 }

 public void setCity(String city)
 {
 this.city = city;
 }

 public String getState()
 {
 return state;
 }

 public void setState(String state)
 {
 this.state = state;
 }

 public String getPhone()
 {
 return phone;
 }

 public void setPhone(String phone)
 {
 this.phone = phone;
 }

 public String getZip()
 {
 return zip;
 }

 public void setZip(String zip)
 {
 this.zip = zip;
 }*/


    }
  
}

