﻿using Magelia.WebStore.Models.Records;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace Magelia.WebStore.Handlers
{
    public class UserAddressPartHandler : ContentHandler
    {
        public UserAddressPartHandler(IRepository<UserAddressesPartRecord> repository)
        {
            this.Filters.Add(StorageFilter.For(repository));
        }
    }
}