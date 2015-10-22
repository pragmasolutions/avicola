using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Services.Dtos
{
    public class BatchBarnDetailDto
    {
        public string StageDetails { get; set; }

        public IList<BatchBarnDto> BatchBarns { get; set; }
    }
}
