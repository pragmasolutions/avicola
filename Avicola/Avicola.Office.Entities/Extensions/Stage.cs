using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class Stage : IEntity
    {
        public static readonly Guid BREEDING = new Guid("096DEBD6-C537-4569-8B97-53A3C3E82A39");
        public static readonly Guid REBREEDING = new Guid("50F38EC7-4A04-4A9E-B2E4-6B9BC59D57DA");
        public static readonly Guid POSTURE = new Guid("0FB44F39-CDB4-4564-AA3D-DF5E30D3BD0F");

        public static string NextStage(Guid stageId)
        {

            if (stageId == BREEDING)
            {
                return "Re Cría";
            }
            else if (stageId == BREEDING)
            {
                return "Posture";
            }

            return String.Empty;
        }

        public static Guid NextStageId(Guid stageId)
        {

            if (stageId == BREEDING)
            {
                return REBREEDING;
            }
            else if (stageId == BREEDING)
            {
                return POSTURE;
            }

            return Guid.Empty;
        }
    }
}
