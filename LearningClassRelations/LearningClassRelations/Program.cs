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
            foreach (var item in user.phones)
            {
                Console.WriteLine(item.Name);
            }
        }

      
    }
}

//GetUsers("Samsung S20");

void GetUsers(string phoneName)
{
    
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

void GetAllUsersByCategory(string v)
{
    throw new NotImplementedException();
}

