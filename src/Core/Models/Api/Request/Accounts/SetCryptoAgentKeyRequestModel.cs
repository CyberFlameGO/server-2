﻿using System.ComponentModel.DataAnnotations;
using Bit.Core.Enums;
using Bit.Core.Models.Table;

namespace Bit.Core.Models.Api.Request.Accounts
{
    public class SetCryptoAgentKeyRequestModel
    {
        [Required]
        public string Key { get; set; }
        [Required]
        public KeysRequestModel Keys { get; set; }
        [Required]
        public KdfType Kdf { get; set; }
        [Required]
        public int KdfIterations { get; set; }
        [Required]
        public string OrgIdentifier { get; set; }

        public User ToUser(User existingUser)
        {
            existingUser.Kdf = Kdf;
            existingUser.KdfIterations = KdfIterations;
            existingUser.Key = Key;
            Keys.ToUser(existingUser);
            return existingUser;
        }
    }
}
