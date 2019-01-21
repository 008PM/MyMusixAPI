using System;
using System.Collections.Generic;
using System.Text;
using MyMusixApi.Service.Domain.Models;
using System.Linq;
using MyMusixAPI.Service.Api.DTO;

namespace MyMusixApi.Service.Domain.DTO
{
    using Microsoft.EntityFrameworkCore;

    using MyMusixAPI.Service.Domain.Models;

    using Remotion.Linq.Clauses;

    public class AccountManagement
    {
        public bool UserRegistration(RegisterRequest TobeegistereData)
        {
            MyMusiXContext context = new MyMusiXContext();

            context.UserAccount.Add(
                new UserAccount
                    {
                        Id = null,
                        FirstName = TobeegistereData.FirstName,
                        LastName = TobeegistereData.LastName,
                        Email = TobeegistereData.Email,
                        Password = TobeegistereData.Password
                    });
            int result = context.SaveChanges();
            if (result != 0)
            {
                return true;
            }

            return false;

        }

        public bool UserLogging(LoginRequest LoginDetailToBeChecked)
        {
            MyMusiXContext context = new MyMusiXContext();


            String EmailTobeChecked = LoginDetailToBeChecked.Email;
            String PasswordTobeChecked = LoginDetailToBeChecked.Password;

            UserAccount userLogin=context.UserAccount.FirstOrDefault(e => e.Email == EmailTobeChecked);
           // UserAccount userPasswd = context.UserAccount.FirstOrDefault(p=>p.Password == PasswordTobeChecked);


           if (userLogin.Email == EmailTobeChecked && userLogin.Password == PasswordTobeChecked)
            //if ((userMail.ToString() == EmailTobeChecked)&&(userPasswd.ToString()==PasswordTobeChecked))
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        public UserAccount GetuserDetails(string email)
        {
            MyMusiXContext context = new MyMusiXContext();

            var UserDataFromDb = context.UserAccount.FirstOrDefault(user => user.Email == email);

            return UserDataFromDb;
        }

        public bool UpdateUser(UserAccount userobj)
        {
            MyMusiXContext context = new MyMusiXContext();

            var updatedUser = context.UserAccount.Update(userobj);
            int result = context.SaveChanges();
            if (context.UserAccount.AsNoTracking().Contains(userobj))
            {
                return true;
            }

            return false;

            
        }
    }
}
//(from p in Context.person_account_portfolio
//where p.person_id == personId select p).ToList()
//.ForEach(x => x.is_default = false);

//Context.SaveChanges();




//Person result = (from p in Context.Persons
//where p.person_id == 5
//select p).SingleOrDefault();

//result.is_default = false;
//Context.SaveChanges();