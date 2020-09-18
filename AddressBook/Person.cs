using System;


namespace AddressBook
{
    class Person 
    {
        private String fname, lname, address, city, state, phone, zip;
        public Person(String fname, String lname, String address, String city, String state, String phone, String zip)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Phone = phone;
            this.Zip = zip;
        }

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Zip { get => zip; set => zip = value; }

          public String getFname()
         {
return fname;
}

public void setFname(String fname)
{
this.fname = fname;
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
}

        public String toString()
        {
            return "Person{" +
                    "First Name='" + Fname + '\'' +
                    ", Last Name='" + Lname + '\'' +
                    ", Address='" + Address + '\'' +
                    ", City='" + City + '\'' +
                    ", State='" + State + '\'' +
                    ", Phone Number='" + Phone + '\'' +
                    ", Zip Code='" + Zip + '\'' +
                    '}';
        }
    }
  
}

