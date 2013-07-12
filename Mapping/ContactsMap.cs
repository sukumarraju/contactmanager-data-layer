// -----------------------------------------------------------------------
// <copyright file="ContactsMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contacts.Data.SqlServer.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contacts.Data.SqlServer.Entities;
    using Contacts.Data.SqlServer.Model;
    using AutoMapper;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContactsMap
    {
        public static ContactBO Map(Contact entity)
        {
            return Mapper.Map<Contact, ContactBO>(entity);
        }

        public static List<ContactBO> Map(List<Contact> entities)
        {
            return Mapper.Map<List<Contact>, List<ContactBO>>(entities);
        }

        public static Contact Map(ContactBO entity)
        {
            return Mapper.Map<ContactBO, Contact>(entity);
        }
    }
}
