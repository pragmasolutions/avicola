using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Deposit.Dashboard.UserControls
{
    public partial class UcOrderBlock : UserControl
    {
        #region Properties

        public DateTime? CreatedDate
        {
            get
            {
                if (lblCreatedDateValue == null)
                    return null;
                return Convert.ToDateTime(lblCreatedDateValue.Text);
            }
            set
            {
                lblCreatedDateValue.Text = value.GetValueOrDefault().ToShortDateString();
            }
        }

        public string Status
        {
            get
            {
                if (lblStatusValue == null)
                    return null;
                return lblStatusValue.Text;
            }
            set
            {
                lblStatusValue.Text = value;
            }
        }

        public string ClientName
        {
            get
            {
                if (lblClientNameValue == null)
                    return null;
                return lblClientNameValue.Text;
            }
            set
            {
                lblClientNameValue.Text = value;
            }
        }

        public string Address
        {
            get
            {
                if (lblAddressValue == null)
                    return null;
                return lblAddressValue.Text;
            }
            set
            {
                lblAddressValue.Text = value;
            }
        }

        public List<OrderEggClassDto> EggClasses { get; set; }

        public List<EggClassStock> CurrentStocks { get; set; }

        #endregion
        

        public UcOrderBlock()
        {
            InitializeComponent();
        }

        private void UcOrderBlock_Load(object sender, EventArgs e)
        {
            LoadEggClasses();
        }

        private void LoadEggClasses()
        {
            foreach (var dto in EggClasses)
            {
                flpOrderEggClasses.Controls.Add(new UcEggClassOrder()
                {
                    EggClassName = dto.EggClassName,
                    Amount = dto.Dozens,
                    CurrentStock = CurrentStocks.FirstOrDefault(x => x.Id == dto.EggClassId).EggsCount.GetValueOrDefault()
                });
            }
        }

        
    }
}
