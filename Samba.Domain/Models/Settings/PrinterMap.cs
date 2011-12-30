﻿using Samba.Domain.Models.Menus;
using Samba.Domain.Models.Tickets;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Settings
{
    public class PrinterMap : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrintJobId { get; set; }
        public int DepartmentId { get; set; }
        public string MenuItemGroupCode { get; set; }
        public string TicketTag { get; set; }
        public int MenuItemId { get; set; }
        public int PrinterId { get; set; }
        public int PrinterTemplateId { get; set; }
    }
}
