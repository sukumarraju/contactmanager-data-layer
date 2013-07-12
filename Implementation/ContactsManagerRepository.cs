// -----------------------------------------------------------------------
// <copyright file="ContactsManagerRepository.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contacts.Data.SqlServer.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    
    using Contacts.Data.SqlServer.Repository;
    using Contacts.Data.SqlServer.Entities;
    

    /// <summary>
    /// contains implementation of IContactManagerRepository
    /// </summary>
    public class ContactsManagerRepository : IContactsManagerRepository
    {
        /// <summary>
        /// Returns a list of all Contacts in database
        /// </summary>
        /// <returns>List of contact record</returns>
        public List<Contact> GetAllContacts()
        {
            using(var context = ContactsManagerFactory.CreateContext())
            {
                var contactslist = (from contact in context.Contacts orderby contact.ID descending select contact).ToList();
                return contactslist;
            }
            
        }
        /// <summary>
        /// Returns a contact record that matches with the id passed in
        /// </summary>
        /// <param name="id">single contact record</param>
        /// <returns></returns>
        public Contact GetContactById(int id)
        {
            using(var context = ContactsManagerFactory.CreateContext())
            {
                var contactrecord = (from contact in context.Contacts where contact.ID == id select contact).SingleOrDefault();
                return contactrecord;
            }
        }

        /// <summary>
        /// Inserts contact record into database
        /// </summary>
        /// <param name="entity">contact</param>
        public Contact Insert(Contact entity)
        {
            using(var context = ContactsManagerFactory.CreateContext())
            {
                context.Contacts.AddObject(entity);
                context.SaveChanges();

                return entity;
            }
        }

        /// <summary>
        /// Updates the contact record in database
        /// </summary>
        /// <param name="entity">contact record passed</param>
        public bool Update(Contact entity)
        {
            using(var context = ContactsManagerFactory.CreateContext())
            {

                context.Contacts.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                context.SaveChanges();

                return true;

            }
        }

        /// <summary>
        /// Deletes the contact record from database that matches the id passed
        /// </summary>
        /// <param name="id">ID</param>
        public void Delete(int id)
        {
            using(var context = ContactsManagerFactory.CreateContext())
            {
                var contact = context.Contacts.Single(x => x.ID == id);

                context.DeleteObject(contact);
                context.SaveChanges();
            }
            
        }
    }
}
