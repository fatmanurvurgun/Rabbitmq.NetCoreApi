using RabbitMq.Core.Common.Entity;
using RabbitMq.Core.Domain.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Domain.Entities
{
    public class Report : BaseEntity
    {
        public DateTime RequestedDate { get; set; }
        public DateTime CompletedTime { get; set; }
        public string FilePath { get; set; }
        public ReportStatusTypeEnum ReportStatus { get; set; }
    }
}
