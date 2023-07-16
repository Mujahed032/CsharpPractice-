using LearningClassRelations;
using Microsoft.EntityFrameworkCore;

var _context = new DataContext();
//GetPhones("Ahmad");
//GetUsers("Samsung S20");
//GetAllPhonesByCategory("Android");
//GetAllUsersByCategory("IOS");
//GetAllUsersWhoHaveMoreThanOnePhone();
//GetAllPhonesWhoHaveMoreThanOneUser();

//InsertUser();

void InsertUser()
{
   

    var categories = _context.categories.ToList();

     
    var phone = new Phone();
    phone.Name = "OnePlus 9R";
    phone.Category = categories.Where(c => c.PhoneType == "Android").FirstOrDefault();

    var phoneSamsungS20 = _context.phones.Where(p => p.Name == "Samsung S20").FirstOrDefault();

    var user = new User();
    user.Name = "Ahsan";
    user.phones = new List<Phone>();
    user.phones.Add(phone);
    user.phones.Add(phoneSamsungS20);

    _context.Add(user);

    _context.SaveChanges();

}

UpdateUser();

void UpdateUser()
{
    var userAhsan = _context.users.Where(u => u.Name == "Ahsan").FirstOrDefault();
    if(userAhsan != null)
    {
        userAhsan.Name = "Ahsan Malik";
    }

    _context.SaveChanges();
}

DeleteUser();

void DeleteUser()
{
    var user = _context.users.Where(u => u.Name == "Azeem").FirstOrDefault();
    if(user != null )
    {
        _context.Remove(user);
        _context.SaveChanges();
    }
}

//InsertPhone();
//UpdatePhone();
//DeletePhone();

//CRUD = Create Read     Update Delete
//     HttpPost HttpGet HttpPut HttpDelete
void GetPhones(string userName)
{ 
   
    var users = _context.users.Include(p => p.phones).ToList();
    foreach (var user in users)
    {
        if (user.Name == userName)
        {
            foreach (var phone in user.phones)
            {
                Console.WriteLine(phone.Name);
            }
        }

      
    }
}




void GetUsers(string phoneName)
{
    var phones = _context.phones.Include(p => p.Users).ToList();
    foreach (var phone in phones)
    {
        if(phone.Name == phoneName)
        {
            foreach (var item in phone.Users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    
}




void GetAllPhonesByCategory(string categoryName)
{
  //var phones = _context.phones.Where(p => p.Category.PhoneType == categoryName).Include(ph => ph.Category).ToList();

    var phones = _context.phones.Include(ph => ph.Category).ToList();

    foreach(var phone in phones)
    {
        if(phone.Category.PhoneType == categoryName)
        {
            Console.WriteLine(phone.Name);
        }
    }
}




void GetAllUsersByCategory(string categoryName)
{
    var phones = _context.phones.Include(p => p.Category).Include(p => p.Users).ToList();
    foreach (var phone in phones)
    {
        if(phone.Category.PhoneType == categoryName)
        {
            foreach(var item in phone.Users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
   
}




void GetAllUsersWhoHaveMoreThanOnePhone()
{
    var users = _context.users.Include(u => u.phones).ToList();
    foreach (var user in users)
    {
        if (user.phones.Count > 1)
        {
            Console.WriteLine(user.Name);
        }
    } 
}




void GetAllPhonesWhoHaveMoreThanOneUser()
{
    var phones = _context.phones.Include(p => p.Users).ToList();
    foreach (var phone in phones)
    {
        if (phone.Users.Count > 1)
        {
            Console.WriteLine(phone.Name);
        }
    }
   
}

