using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;
        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() { id = 1,Name="Homer Simpson",Email ="homer@aol,com",Gender="Male",Phone=123456,Address="44 Evergreen Terrace",Postcode="TWFSFSD",Biography="Hoping to improve shooting ability",Skills=Skills.Low},
                new User() { id = 2,Name="Marge Flanders",Email ="marge@aol,com",Gender="Female",Phone=345623,Address="100 Blue Terrace",Postcode="TXDKSS",Biography="Great Tackling ability",Skills=Skills.Medium},
                new User() { id = 3,Name="Bart Jones",Email ="bart@aol,com",Gender="Male",Phone=3564243,Address="99 Slow Road",Postcode="TFYSFS",Biography="Lacks ability",Skills=Skills.High,}
            };

        }

        public User Add(User user)
        {
            user.id = _userList.Max(e => e.id) + 1;
            _userList.Add(user);
            return user;
        }

        public User Delete(int id)
        {
           User user = _userList.FirstOrDefault(e => e.id == id);
            if(user != null)
            {
                _userList.Remove(user);
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int id)
        {
            return _userList.FirstOrDefault(e => e.id == id);
        }

        public User Update(User userChanges)
        {
            User user = _userList.FirstOrDefault(e => e.id == userChanges.id);
            if (user != null)
            {
                user.Name = userChanges.Name;
                user.Address = userChanges.Address;
                user.Email = userChanges.Email;
                user.Postcode = userChanges.Postcode;
                user.Phone = userChanges.Phone;
                user.Biography = userChanges.Biography;
                user.Skills = userChanges.Skills;
                user.Gender = userChanges.Gender;
                user.Sport = userChanges.Sport;

            }
            return user;
        }
    }
}
