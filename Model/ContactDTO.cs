// -----------------------------------------------------------------------
// <copyright file="ContactDTO.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contacts.Data.SqlServer.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContactBO
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Email { get; set; }
            //public string Twitter { get; set; }

        
    }
}
