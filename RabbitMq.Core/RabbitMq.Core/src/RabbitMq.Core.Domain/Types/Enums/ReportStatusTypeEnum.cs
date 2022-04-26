using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RabbitMq.Core.Domain.Types.Enums
{
    public enum ReportStatusTypeEnum
    {
        [Display(Name = "Devam Ediyor")]
        Ongoing = 1,

        [Display(Name = "Tamamlandı")]
        Complete = 2
    }
}
