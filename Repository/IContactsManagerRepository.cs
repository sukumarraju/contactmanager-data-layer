// -----------------------------------------------------------------------
// <copyright file="IContactsMangerRepository.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contacts.Data.SqlServer.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using Contacts.Data.SqlServer.Entities;
    
    

    /// <summary>
    ///  Contains method signatures for ContactsManager repository
    /// </summary>
    public interface IContactsManagerRepository
    {
        /// <summary>
        /// Gets all the contact reocrds from database
        /// </summary>
        /// <returns>list of case study objects</returns>
        List<Contact> GetAllContacts();

        /// <summary>
        /// Gets the contact record that matches with the id 
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>single contact record</returns>
        Contact  GetContactById(int id);

        /// <summary>
        /// Inserts a new Contact record
        /// </summary>
        /// <param name="entity">Contact entity type that has to be inserted into the database</param>
        Contact Insert(Contact entity);

        /// <summary>
        /// Updates a single Contact record
        /// </summary>
        /// <param name="entity">Contact entity type that has to be updated in the database</param>
        bool Update(Contact entity);

        /// <summary>
        /// Delete a single record from the table
        /// </summary>
        /// <param name="entity">ID of the row that has to be deleted from department table</param>
        void Delete(int id);
    }
}
