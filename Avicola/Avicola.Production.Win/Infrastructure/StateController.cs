using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;

namespace Avicola.Production.Win.Infrastructure
{
    public class StateController : IStateController
    {
        private Office.Services.Dtos.BatchDto _currentSelectedBatch;

        public Office.Services.Dtos.BatchDto CurrentSelectedBatch
        {
            get { return _currentSelectedBatch; }
            set
            {
                if (_currentSelectedBatch == value)
                {
                    return;
                }

                _currentSelectedBatch = value;
            }
        }


        private Standard _currentSelectedStandard;

        public Standard CurrentSelectedStandard
        {
            get { return _currentSelectedStandard; }
            set
            {
                if (_currentSelectedStandard == value)
                {
                    return;
                }

                _currentSelectedStandard = value;
            }
        }
    }
}
