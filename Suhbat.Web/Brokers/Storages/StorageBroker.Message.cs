//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Suhbat.Web.Models.Foundations.Messages;

namespace Suhbat.Web.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Message> Messages { get; set; }    
    }
}
