using Knights_of_Columbus_Website.Data;

namespace Knights_of_Columbus_Website.Models
{
    public static class SeedData
    {


        public static void SeedDatabase(KOCDbContext myDbContext)
        {
            List<Knights> KnightsList = new List<Knights>();
            {
                if (myDbContext.SignUp.Count() == 0)
                {
                    KnightsList.Add(new Knights()
                    {

                        MemberId = 1,
                        FirstName = "William",
                        MiddleIntial = "M",
                        SirName1 = "Flores",
                        SirName2 = "",
                        UserName = "Wflores",
                        Password = "Password",
                        IsAccepted = true,
                        StreetAddress = "806 Lacey Street SE",
                        City = "Lacey",
                        State = "Washington",
                        PostalCode = "98503",
                        PhoneNum = "360-480-3111",
                        EmailAddress = "william.m.flores@yahoo.com",
                        Ismarried = true,
                        WFirstName = "Lousie",
                        WMiddleIntial = "M",
                        WSirName = "Flores"
                    });

                    KnightsList.Add(new Knights()
                    {

                        MemberId = 2,
                        FirstName = "William",
                        MiddleIntial = "M",
                        SirName1 = "Flores",
                        SirName2 = "",
                        UserName = "Wflores",
                        Password = "Password",
                        IsAccepted = true,
                        StreetAddress = "806 Lacey Street SE",
                        City = "Lacey",
                        State = "Washington",
                        PostalCode = "98503",
                        PhoneNum = "360-480-3111",
                        EmailAddress = "william.m.flores@yahoo.com",
                        Ismarried = true,
                        WFirstName = "Lousie",
                        WMiddleIntial = "M",
                        WSirName = "Flores"
                    });

                    KnightsList.Add(new Knights()
                    {

                        MemberId = 3,
                        FirstName = "William",
                        MiddleIntial = "M",
                        SirName1 = "Flores",
                        SirName2 = "",
                        UserName = "Wflores",
                        Password = "Password",
                        IsAccepted = true,
                        StreetAddress = "806 Lacey Street SE",
                        City = "Lacey",
                        State = "Washington",
                        PostalCode = "98503",
                        PhoneNum = "360-480-3111",
                        EmailAddress = "william.m.flores@yahoo.com",
                        Ismarried = true,
                        WFirstName = "Lousie",
                        WMiddleIntial = "M",
                        WSirName = "Flores"
                    });

                    KnightsList.Add(new Knights()
                    {

                        MemberId = 4,
                        FirstName = "William",
                        MiddleIntial = "M",
                        SirName1 = "Flores",
                        SirName2 = "",
                        UserName = "Wflores",
                        Password = "Password",
                        IsAccepted = true,
                        StreetAddress = "806 Lacey Street SE",
                        City = "Lacey",
                        State = "Washington",
                        PostalCode = "98503",
                        PhoneNum = "360-480-3111",
                        EmailAddress = "william.m.flores@yahoo.com",
                        Ismarried = true,
                        WFirstName = "Lousie",
                        WMiddleIntial = "M",
                        WSirName = "Flores"
                    });

                    myDbContext.AddRange(KnightsList);
                    myDbContext.SaveChanges();

                }

            };



        }

    }
}
