// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using eppeta.webapi.Identity.Models;
using System.ComponentModel.DataAnnotations;

namespace eppeta.webapi.DTO
{
    public class UserAccountResponse : UserAccount
    {
        public string Id { get; set; } = string.Empty;

        public bool RequirePasswordChange { get; set; }

        public static UserAccountResponse From(ApplicationUser user)
        {
            return new UserAccountResponse
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                RequirePasswordChange = user.RequirePasswordChange
            };
        }
    }
}
