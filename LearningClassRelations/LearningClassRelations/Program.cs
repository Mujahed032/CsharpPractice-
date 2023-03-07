using LearningClassRelations;
using Microsoft.EntityFrameworkCore;

var _context = new DataContext();
//GetPhones("Ahmad");

void GetPhones(string userName)
{ 
   
    var users = _context.users.Include(p => p.phones).ToList();
    foreach (var user in users)
    {
        if (user.Name == "Khizar")
        {
            foreach (var phone in user.phones)
            {
                Console.WriteLine(phone.Name);
            }
        }

      
    }
}


//GetUsers("Samsung S20");

void GetUsers(string phoneName)
{
    var phones = _context.phones.Include(p => p.Users).ToList();
    foreach (var phone in phones)
    {
        if(phone.Name == "S20")
        {
            foreach (var item in phone.Users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    
}


GetAllPhonesByCategory("Android");

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


GetAllUsersByCategory("IOS");

void GetAllUsersByCategory(string categoryName)
{
    var phones = _context.phones.Include(p => p.Users).ToList();
    foreach (var phone in phones)
    {
        if (phone.Category.PhoneType == categoryName)
        {
            foreach (var item in phone.Users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}


GetAllUsersWhoHaveMoreThanOnePhone();

void GetAllUsersWhoHaveMoreThanOnePhone()
{
    var users = _context.users.OrderBy(u => u.Id).ToList();
    foreach (var user in users)
    {
        Console.WriteLine(user);
    } 
}


GetAllPhonesWhoHaveMoreThanOneUser();

void GetAllPhonesWhoHaveMoreThanOneUser()
{
    var phones = _context.phones.OrderBy(p => p.Id).ToList();
    foreach (var phone in phones)
    {
        Console.WriteLine(phone);
    }
   
}

