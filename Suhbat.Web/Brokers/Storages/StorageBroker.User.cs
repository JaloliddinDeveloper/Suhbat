//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Suhbat.Web.Models.Foundations.Users;

namespace Suhbat.Web.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }
    }
}
