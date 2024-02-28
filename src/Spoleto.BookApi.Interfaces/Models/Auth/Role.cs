﻿using System;
using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The user role for database authentication.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the users belonging to this role.
        /// </summary>
        public List<User> Users { get; set; }
    }
}
