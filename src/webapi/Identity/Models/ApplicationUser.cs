// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.AspNetCore.Identity;

namespace eppeta.webapi.Identity.Models;

public class ApplicationUser : IdentityUser
{
    public ApplicationUser() : base()
    {
    }

    public ApplicationUser(string userName) : base(userName)
    {
    }

    public bool RequirePasswordChange { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateTime? DeletedAt { get; set; }

}
