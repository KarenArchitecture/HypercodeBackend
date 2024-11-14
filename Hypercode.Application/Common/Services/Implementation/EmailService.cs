using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Services.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly IUnitOfWork uow;
        public EmailService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Email GetEmail(int emailId)
        {
            return uow.Email.Get(u => u.Id == emailId);
        }
        public IEnumerable<Email> GetAllEmails()
        {
            return uow.Email.GetAll();
        }

        public bool AddEmail(Email email)
        {
            try
            {
                uow.Email.Add(email);
                uow.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
